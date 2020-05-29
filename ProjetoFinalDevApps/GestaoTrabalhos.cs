using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProjetoFinalDevApps
{
    public partial class GestaoTrabalhos : Form
    {
        private RetrosariaModelContainer retrosaria;
        private PedidoTabelado _pedido;

        public GestaoTrabalhos(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }
        public void ExportarPDF(DataGridView dgv, string filename)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdftable = new PdfPTable(dgv.Columns.Count);
                pdftable.DefaultCell.Padding = 3;
                pdftable.WidthPercentage = 100;
                pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftable.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

                foreach (DataGridViewColumn coluna in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(coluna.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(216, 216, 191);
                    pdftable.AddCell(cell);

                }

                foreach (DataGridViewRow linha in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in linha.Cells)
                    {
                        pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }

                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = filename;
                saveFileDialog.DefaultExt = ".pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int soma = 0;
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdftable);

                        for (int i = 0; i < dgvTrabalhos.Rows.Count; ++i)
                        {
                            soma += Convert.ToInt32(dgvTrabalhos.Rows[i].Cells[6].Value);
                        }
                        Paragraph p = new Paragraph("Valor total: " + soma + " €");
                        pdfdoc.Add(p);


                        pdfdoc.Close();
                        stream.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private bool EstaSelecionado()
        {
            if (dgvTrabalhos.SelectedRows != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CarregarTrabalhos()
        {
            bsTrabalhos.DataSource = retrosaria.TrabalhoSet.Where(u => u.PedidoTabeladoId == _pedido.Id).ToList();
        }

        private void btNovoPedidoTabelado_Click(object sender, EventArgs e)
        {
            NovoTrabalho form = new NovoTrabalho(_pedido);
            form.ShowDialog(this);
        }

        private void GestaoTrabalhos_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            

        }

        private void GestaoTrabalhos_Activated(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            CarregarTrabalhos();
        }

        private void btVerPedidoTabelado_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Trabalho selecionado = (Trabalho)dgvTrabalhos.CurrentRow.DataBoundItem;
                EditarTrabalho form = new EditarTrabalho(selecionado);
                form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um trabalho");
            }

        }

        private void btExportar_Click(object sender, EventArgs e)
        {
            ExportarPDF(dgvTrabalhos, "trabalhos");
        }
    }
}

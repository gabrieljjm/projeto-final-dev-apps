using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalDevApps
{
    public partial class NovoTrabalho : Form
    {
        private string _nomeCliente;
        private RetrosariaModelContainer retrosaria;
        GestaoPedidoTabelado form1 = new GestaoPedidoTabelado();
        public NovoTrabalho(string nomeCliente)
        {
            InitializeComponent();
            this._nomeCliente = nomeCliente;
        }


        private void carregarComboboxArranjo()
        {
            //Assign Entity as DataSource.
            cbPeca.DataSource = retrosaria.PecaSet.ToList();
            cbPeca.DisplayMember = "TipoPeca";
            cbPeca.ValueMember = "Id";

            cbPeca.SelectedIndex = -1;
        }

        

        private void NovoTrabalho_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            labelCliente.Text = _nomeCliente;
            carregarComboboxArranjo();
        }

        private void cbArranjo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbArranjo - " + cbArranjo.SelectedValue);
        }

        private void cbPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPeca.SelectedIndex != -1)
                {
                    int pecaid = Int32.Parse(cbPeca.SelectedValue.ToString());
                    Console.WriteLine("cbPeca - " + cbPeca.SelectedValue);
                    List<PecaArranjo> listaPecaArranjo = retrosaria.PecaArranjoSet.Where(u => u.PecaId == pecaid).ToList();
                    if (listaPecaArranjo.Count != 0)
                    {
                        List<Arranjo> listaArranjo = new List<Arranjo>();
                        foreach (PecaArranjo pecaarranjo in listaPecaArranjo)
                        {
                            foreach (Arranjo arranjo in retrosaria.ArranjoSet)
                            {
                                if (pecaarranjo.ArranjoId == arranjo.Id)
                                {
                                    listaArranjo.Add(arranjo);
                                }
                            }
                        }
                        cbArranjo.DataSource = listaArranjo.ToList();
                        cbArranjo.DisplayMember = "TipoArranjo";
                        cbArranjo.ValueMember = "Id";
                        cbArranjo.SelectedIndex = -1;
                        cbArranjo.Enabled = true;
                    }
                    else
                    {
                        cbArranjo.Enabled = false;
                        cbArranjo.DataSource = null;
                    }
                }
                else
                {
                    cbArranjo.Enabled = false;
                    cbArranjo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            Trabalho novoTrabalho = new Trabalho();

            novoTrabalho.DescricaoPeca = tbDescricaoPeca.Text;
            novoTrabalho.CorPeca = tbCorPeca.Text;
            novoTrabalho.ValorPago = Convert.ToInt32(nudValorPago.Value);
            novoTrabalho.DataLevantamento = dtpLevantamento.Value;
            novoTrabalho.Observacoes = tbObservacoes.Text;

            form1.a = novoTrabalho;
            this.Close();
            
            Console.WriteLine("Descricao", novoTrabalho.DescricaoPeca);
        }
    }
}

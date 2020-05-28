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
    public partial class GestaoMateriais : Form
    {
        public GestaoMateriais()
        {
            InitializeComponent();
        }

        private void GestaoMateriais_Activated(object sender, EventArgs e)
        {
            LerDadosMateriais();
        }

        /// <summary>
        /// Método <c>LerDadosMateriais</c> carrega os Materiais da base de dados para a <c>bsMateriais</c>
        /// </summary>
        public void LerDadosMateriais()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsMateriais.DataSource = null;
            bsMateriais.DataSource = retrosaria.StockMateriaisSet.ToList();
        }

        /// <summary>
        /// Método <c>EstaSelecionado</c> verifica se está alguma linha selecionada na <c>dgvMateriais</c>
        /// </summary>
        private bool EstaSelecionado()
        {
            if (dgvMateriais.SelectedRows != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Selecione um Material");
                return false;
            }
        }

        /// <summary>
        /// Método <c>btNovo_Click</c> chama o formulário <c>RegistarMaterial</c>
        /// </summary>
        private void btNovo_Click(object sender, EventArgs e)
        {
            RegistarMaterial form = new RegistarMaterial();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Método <c>btApagar_Click</c> apaga os dados do material da base de dados
        /// </summary>
        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o material?";
                string title = "Apagar material";
                int idmaterial = (int)dgvMateriais.CurrentRow.Cells[0].Value;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Console.WriteLine(idmaterial);
                    try
                    {
                        retrosaria.StockMateriaisSet.Remove(retrosaria.StockMateriaisSet.Single(a => a.Id == idmaterial));
                        retrosaria.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Este material já se encontra registado num fornecimento.");
                    }
                    
                    LerDadosMateriais();
                }
            }
        }

        /// <summary>
        /// Método <c>btAlterar_Click</c> chama o formulário <c>RegistarMaterial</c> e envia o material escolhido
        /// </summary>
        private void btEditar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                StockMateriais selecionado = (StockMateriais)dgvMateriais.CurrentRow.DataBoundItem;
                RegistarMaterial form = new RegistarMaterial(selecionado);
                form.ShowDialog(this);
            }
        }
    }
}

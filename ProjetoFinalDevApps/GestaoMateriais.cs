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
        /// Método <c>LimpaCampos</c> limpa os campos do formulário
        /// </summary>
        private void LimpaCampos()
        {
            tbDescricao.Text = "";
            nudConsMed.Value = 0;
            nudMinimo.Value = 0;
            nudQuant.Value = 0;
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
                return false;
            }
        }

        /// <summary>
        /// Método <c>EstaPreenchido</c> verifica se os campos do formulário estão corretamente preenhidos
        /// </summary>
        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (tbDescricao.Text == "")
            {
                tbDescricao.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbDescricao.BackColor = Color.White;
            }
            if (nudQuant.Text == "")
            {
                nudQuant.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudQuant.BackColor = Color.White;
            }
            if (nudMinimo.Text == "")
            {
                nudMinimo.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudMinimo.BackColor = Color.White;
            }
            if (nudConsMed.Text == "")
            {
                nudConsMed.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudConsMed.BackColor = Color.White;
            }

            return preenchido;
        }

        /// <summary>
        /// Método <c>btCriar_Click</c> cria um material na base de dados
        /// </summary>
        private void btCriar_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                //Obter informação nos campos e atribui esse valor ao novoMaterial
                StockMateriais novoMaterial = new StockMateriais();
                novoMaterial.Descricao = tbDescricao.Text;
                novoMaterial.ConsumoMedioDiario = (double)nudConsMed.Value;
                novoMaterial.StockMinimo = (double)nudMinimo.Value;
                novoMaterial.QuantAtual = (double)nudQuant.Value;

                //Adicionar material à base de dados
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                retrosaria.StockMateriaisSet.Add(novoMaterial);
                retrosaria.SaveChanges();

                LimpaCampos();
                LerDadosMateriais();
            }
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
                        MessageBox.Show("Este material já se encontra registado num fornecedor.");
                    }
                    
                    LerDadosMateriais();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Material");
            }
        }

        /// <summary>
        /// Método <c>btAlterar_Click</c> chama o formulário EditarMaterial e envia o Material escolhido
        /// </summary>
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                StockMateriais selecionado = (StockMateriais)dgvMateriais.CurrentRow.DataBoundItem;
                EditarMaterial editar = new EditarMaterial(selecionado);
                editar.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um material");
            }
        }
    }
}

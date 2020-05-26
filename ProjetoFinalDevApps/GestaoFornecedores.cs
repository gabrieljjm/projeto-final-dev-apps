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
    public partial class GestaoFornecedores : Form
    {
        public GestaoFornecedores()
        {
            InitializeComponent();
        }

        private void GestaoFornecedores_Activated(object sender, EventArgs e)
        {
            LerDadosFornecedores();
        }

        /// <summary>
        /// Método <c>LerDadosFornecedores</c> carrega os Fornecedores da base de dados para a <c>bsFornecedores</c>
        /// </summary>
        private void LerDadosFornecedores()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsFornecedores.DataSource = null;
            bsFornecedores.DataSource = retrosaria.FornecedorSet.ToList();
        }

        /// <summary>
        /// Método <c>LimpaCampos</c> limpa os campos do formulário
        /// </summary>
        private void LimpaCampos()
        {
            tbNome.Text = "";
            tbLocalidade.Text = "";
            tbMorada.Text = "";
            tbCodPostal.Text = "";
            tbNif.Text = "";
            tbTelefone.Text = "";
        }

        /// <summary>
        /// Método <c>EstaSelecionado</c> verifica se está alguma linha selecionada na <c>dgvFornecedores</c>
        /// </summary>
        private bool EstaSelecionado()
        {
            if (dgvFornecedores.SelectedRows != null)
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
            if (tbNome.Text == "")
            {
                tbNome.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbNome.BackColor = Color.White;
            }
            if (tbMorada.Text == "")
            {
                tbMorada.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbMorada.BackColor = Color.White;
            }
            if (tbLocalidade.Text == "")
            {
                tbLocalidade.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbLocalidade.BackColor = Color.White;
            }
            if (!tbCodPostal.MaskCompleted)
            {
                tbCodPostal.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbCodPostal.BackColor = Color.White;
            }
            if (!tbNif.MaskCompleted)
            {
                tbNif.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbNif.BackColor = Color.White;
            }
            if (!tbTelefone.MaskCompleted)
            {
                tbTelefone.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbTelefone.BackColor = Color.White;
            }

            return preenchido;
        }

        /// <summary>
        /// Método <c>btCriar_Click</c> cria um fornecedor na base de dados
        /// </summary>
        private void btCriar_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                //Obter informação nos campos e atribui esse valor ao novoFornecedor
                Fornecedor novoFornecedor = new Fornecedor();
                novoFornecedor.Nome = tbNome.Text;
                novoFornecedor.Localidade = tbLocalidade.Text;
                novoFornecedor.Morada = tbMorada.Text;
                novoFornecedor.CodigoPostal = tbCodPostal.Text;
                novoFornecedor.NIF = tbNif.Text;
                novoFornecedor.Telefone = tbTelefone.Text;

                //Adicionar fornecedor à base de dados
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                retrosaria.FornecedorSet.Add(novoFornecedor);
                retrosaria.SaveChanges();

                LimpaCampos();
                LerDadosFornecedores();
            }
        }

        /// <summary>
        /// Método <c>btApagar_Click</c> apaga os dados do fornecedor da base de dados
        /// </summary>
        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o fornecedor?";
                string title = "Apagar fornecedor";
                int idfornecedor = (int)dgvFornecedores.CurrentRow.Cells[0].Value;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Console.WriteLine(idfornecedor);
                    retrosaria.FornecedorSet.Remove(retrosaria.FornecedorSet.Single(a => a.Id == idfornecedor));
                    retrosaria.SaveChanges();
                    LerDadosFornecedores();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Fornecedor");
            }
        }

        /// <summary>
        /// Método <c>btAlterar_Click</c> chama o formulário EditarFornecedores e envia o Fonecedor escolhido
        /// </summary>
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Fornecedor selecionado = (Fornecedor)dgvFornecedores.CurrentRow.DataBoundItem;
                EditarFornecedores editar = new EditarFornecedores(selecionado);
                editar.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor");
            }
        }

        /// <summary>
        /// Método <c>tbNome_KeyPress</c> proíbe o utilizador de inserir símbolos e números na <c>tbNome</c>
        /// </summary>
        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}

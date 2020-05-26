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
    public partial class GestaoClientes : Form
    {
        public GestaoClientes()
        {
            InitializeComponent();
        }

        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            LerDadosClientes();
        }

        private void GestaoClientes_Activated(object sender, EventArgs e)
        {
            LerDadosClientes();
        }

        /// <summary>
        /// Método <c>LerDadosClientes</c> carrega os Clientes da base de dados para a <c>bsClientes</c>
        /// </summary>
        public void LerDadosClientes()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = retrosaria.ClienteSet.ToList();
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
        /// Método <c>EstaSelecionado</c> verifica se está alguma linha selecionada na <c>dgvClientes</c>
        /// </summary>
        private bool EstaSelecionado()
        {
            if (dgvClientes.SelectedRows != null)
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
        /// Método <c>btCriar_Click</c> cria um cliente na base de dados
        /// </summary>
        private void btCriar_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                //Obter informação nos campos e atribui esse valor ao novoCliente
                Cliente novoCliente = new Cliente();
                novoCliente.Nome = tbNome.Text;
                novoCliente.Localidade = tbLocalidade.Text;
                novoCliente.Morada = tbMorada.Text;
                novoCliente.Codigo_Postal = tbCodPostal.Text;
                novoCliente.NIF = tbNif.Text;
                novoCliente.Telefone_Contacto = tbTelefone.Text;

                //Adicionar cliente à base de dados
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                retrosaria.ClienteSet.Add(novoCliente);
                retrosaria.SaveChanges();

                LimpaCampos();
                LerDadosClientes();
            }
        }

        /// <summary>
        /// Método <c>btApagar_Click</c> apaga os dados do cliente da base de dados
        /// </summary>
        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o cliente ?";
                string title = "Apagar cliente";
                int idcliente = (int)dgvClientes.CurrentRow.Cells[0].Value;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Console.WriteLine(idcliente);
                    retrosaria.ClienteSet.Remove(retrosaria.ClienteSet.Single(a => a.Id == idcliente));
                    retrosaria.SaveChanges();
                    LerDadosClientes();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Cliente");
            }
        }

        /// <summary>
        /// Método <c>btAlterar_Click</c> chama o formulário EditarClientes e envia o Cliente escolhido
        /// </summary>
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Cliente selecionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                EditarCliente editar = new EditarCliente(selecionado);
                editar.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um cliente");
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

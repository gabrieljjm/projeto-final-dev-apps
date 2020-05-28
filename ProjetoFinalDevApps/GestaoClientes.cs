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
            bsClientes.DataSource = null;
            bsClientes.DataSource = retrosaria.ClienteSet.ToList();
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
                MessageBox.Show("Selecione um cliente");
                return false;
            }
        }

        /// <summary>
        /// Método <c>btCriar_Click</c> chama o formulário RegistarCliente
        /// </summary>
        private void btNovo_Click(object sender, EventArgs e)
        {
            RegistarCliente form = new RegistarCliente();
            form.ShowDialog(this);
        }

        /// <summary>
        /// Método <c>btApagar_Click</c> apaga os dados do cliente da base de dados
        /// </summary>
        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o cliente?";
                string title = "Apagar cliente";
                int idcliente = (int)dgvClientes.CurrentRow.Cells[0].Value;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Console.WriteLine(idcliente);

                    try
                    {
                        retrosaria.ClienteSet.Remove(retrosaria.ClienteSet.Single(a => a.Id == idcliente));
                        retrosaria.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("O cliente que pretende apagar já se encontra com pedido");
                    }

                    LerDadosClientes();
                }
            }
        }

        /// <summary>
        /// Método <c>btAlterar_Click</c> chama o formulário RegistarCliente e envia o Cliente escolhido
        /// </summary>
        private void btEditar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Cliente selecionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                RegistarCliente form = new RegistarCliente(selecionado);
                form.Text = "Editar Cliente";
                form.ShowDialog(this);
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

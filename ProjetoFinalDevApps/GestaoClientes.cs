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
        private RetrosariaModelContainer retrosaria;
        public GestaoClientes()
        {
            InitializeComponent();
        }
        private void lerDadosCliente()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = retrosaria.ClienteSet.ToList();
        }

        private void limpaCampos()
        {
            tbNome.Text = "";
            tbLocalidade.Text = "";
            tbMorada.Text = "";
            tbCodPostal.Text = "";
            tbNif.Text = "";
            tbTelefone.Text = "";
        }

        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            lerDadosCliente();
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            //Obter informação digitada e atribuir esse valor às variàveis
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = tbNome.Text;
            novoCliente.Localidade = tbLocalidade.Text;
            novoCliente.Morada = tbMorada.Text;
            novoCliente.Codigo_Postal = tbCodPostal.Text;
            novoCliente.NIF = tbNif.Text;
            novoCliente.Telefone_Contacto = tbTelefone.Text;

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

            if (preenchido)
            {
                //Adicionar cliente à base de dados
                retrosaria.ClienteSet.Add(novoCliente);
                retrosaria.SaveChanges();

                limpaCampos();

                //Atualizar DataGridView
                lerDadosCliente();
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows == null)
            {
                MessageBox.Show("Selecione um Cliente");
            }
            else
            {
                string message = "Tem a certeza que deseja remover o cliente ?";
                string title = "Apagar cliente";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Cliente selecionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    tbNome.Text = selecionado.Nome;
                    retrosaria.ClienteSet.Remove(selecionado);
                    retrosaria.SaveChanges();

                }

                lerDadosCliente();
            }
        }
    }
}

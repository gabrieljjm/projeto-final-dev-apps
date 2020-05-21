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
    public partial class EditarCliente : Form
    {
        private RetrosariaModelContainer retrosaria;

        private Cliente _cliente;

        public EditarCliente(Cliente cliente)
        {
            InitializeComponent();
            this._cliente = cliente;
        }

        //FUNÇÕES
        void lerDadosCliente() => (Owner as GestaoClientes).lerDadosCliente();
        void esconderColuna() => (Owner as GestaoClientes).esconderColuna();
        void mudaNomeColuna() => (Owner as GestaoClientes).mudaNomeColuna();
        void AtivarBotoes() =>(Owner as GestaoClientes).AtivarBotoes();
        void tirarSelecao() => (Owner as GestaoClientes).tirarSelecao();
        private void carregarCampos()
        {
            tbNome.Text = _cliente.Nome;
            tbMorada.Text = _cliente.Morada;
            tbLocalidade.Text = _cliente.Localidade;
            tbCodPostal.Text = _cliente.Codigo_Postal;
            tbNif.Text = _cliente.NIF;
            tbTelefone.Text = _cliente.Telefone_Contacto;
        }

        //FUNÇÕES

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarCampos();

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            _cliente.Nome = tbNome.Text;
            _cliente.Morada = tbMorada.Text;
            _cliente.Localidade = tbLocalidade.Text;
            _cliente.Codigo_Postal = tbCodPostal.Text;
            _cliente.NIF = tbNif.Text;
            _cliente.Telefone_Contacto = tbTelefone.Text;

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
                
                retrosaria.SaveChanges();
                lerDadosCliente();
                esconderColuna();
                mudaNomeColuna();
                AtivarBotoes();
                tirarSelecao();
                this.Close();
                
            }
            

        }

        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void tbNome_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}

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
    public partial class EditarFornecedores : Form
    {
        private RetrosariaModelContainer retrosaria;
        private Fornecedor _fornecedor;

        public EditarFornecedores(Fornecedor fornecedor)
        {
            InitializeComponent();
            _fornecedor = fornecedor;
        }

        private void EditarFornecedores_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarCampos();
        }

        private void carregarCampos()
        {
            tbNome.Text = _fornecedor.Nome;
            tbMorada.Text = _fornecedor.Morada;
            tbLocalidade.Text = _fornecedor.Localidade;
            tbCodPostal.Text = _fornecedor.CodigoPostal;
            tbNif.Text = _fornecedor.NIF;
            tbTelefone.Text = _fornecedor.Telefone;
        }

        private bool estaPreenchido()
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

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (estaPreenchido())
            {
                _fornecedor.Nome = tbNome.Text;
                _fornecedor.Morada = tbMorada.Text;
                _fornecedor.Localidade = tbLocalidade.Text;
                _fornecedor.CodigoPostal = tbCodPostal.Text;
                _fornecedor.NIF = tbNif.Text;
                _fornecedor.Telefone = tbTelefone.Text;

                retrosaria.SaveChanges();
                this.Close();
            }
        }
    }
}

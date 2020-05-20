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
        private RetrosariaModelContainer retrosaria;

        public GestaoFornecedores()
        {
            InitializeComponent();
        }
        private void GestaoFornecedores_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            lerDadosFornecedores();
        }
        private void lerDadosFornecedores()
        {
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = retrosaria.FornecedorSet.ToList();
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
        private void btCriar_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            //Obter informação digitada e atribuir esse valor às variàveis
            Fornecedor novoFornecedor = new Fornecedor();
            novoFornecedor.Nome = tbNome.Text;
            novoFornecedor.Localidade = tbLocalidade.Text;
            novoFornecedor.Morada = tbMorada.Text;
            novoFornecedor.CodigoPostal = tbCodPostal.Text;
            novoFornecedor.NIF = tbNif.Text;
            novoFornecedor.Telefone = tbTelefone.Text;

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
                retrosaria.FornecedorSet.Add(novoFornecedor);
                retrosaria.SaveChanges();

                limpaCampos();

                //Atualizar DataGridView
                lerDadosFornecedores();
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (dgvFornecedores.SelectedRows == null)
            {
                MessageBox.Show("Selecione um Fornecedor");
            }
            else
            {
                string message = "Tem a certeza que deseja remover o fornecedor?";
                string title = "Apagar cliente";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Fornecedor selecionado = (Fornecedor)dgvFornecedores.CurrentRow.DataBoundItem;
                    tbNome.Text = selecionado.Nome;
                    retrosaria.FornecedorSet.Remove(selecionado);
                    retrosaria.SaveChanges();

                }

                lerDadosFornecedores();
            }
        }
    }
}

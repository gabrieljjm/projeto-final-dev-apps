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

        private void lerDadosFornecedores()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsFornecedores.DataSource = retrosaria.SaveChanges();
            bsFornecedores.DataSource = null;
            bsFornecedores.DataSource = retrosaria.FornecedorSet.ToList();
        }

        private void GestaoFornecedores_Activated(object sender, EventArgs e)
        {
            lerDadosFornecedores();
        }

        private void GestaoFornecedores_Load(object sender, EventArgs e)
        {
            lerDadosFornecedores();
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
        private bool estaSelecionado()
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

        private void btCriar_Click(object sender, EventArgs e)
        {
            if (estaPreenchido())
            {
                //Obter informação digitada e atribuir esse valor às variàveis
                Fornecedor novoFornecedor = new Fornecedor();
                novoFornecedor.Nome = tbNome.Text;
                novoFornecedor.Localidade = tbLocalidade.Text;
                novoFornecedor.Morada = tbMorada.Text;
                novoFornecedor.CodigoPostal = tbCodPostal.Text;
                novoFornecedor.NIF = tbNif.Text;
                novoFornecedor.Telefone = tbTelefone.Text;

                //Adicionar cliente à base de dados
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                retrosaria.FornecedorSet.Add(novoFornecedor);
                retrosaria.SaveChanges();

                limpaCampos();

                //Atualizar DataGridView
                lerDadosFornecedores();
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (estaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o fornecedor?";
                string title = "Apagar cliente";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Fornecedor selecionado = (Fornecedor)dgvFornecedores.CurrentRow.DataBoundItem;
                    tbNome.Text = selecionado.Nome;
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    retrosaria.FornecedorSet.Remove(selecionado);
                    retrosaria.SaveChanges();
                    lerDadosFornecedores();
                    dgvFornecedores.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Fornecedor");
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (estaSelecionado())
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
    }
}

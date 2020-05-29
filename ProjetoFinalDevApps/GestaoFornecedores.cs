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
        /// Método <c>btCriar_Click</c> cria um fornecedor na base de dados
        /// </summary>
        private void btCriar_Click(object sender, EventArgs e)
        {
            RegistarFornecedor form = new RegistarFornecedor();
            form.ShowDialog();
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
                Fornecedor fornecedor = (Fornecedor)dgvFornecedores.CurrentRow.DataBoundItem;
                int idfornecedor = (int)dgvFornecedores.CurrentRow.Cells[0].Value;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Console.WriteLine(idfornecedor);
                    retrosaria.FornecedorSet.Remove(retrosaria.FornecedorSet.Single(a => a.Id == fornecedor.Id));
                    try
                    {
                        retrosaria.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("O fornecedor que deseja apagar já contém um fornecimento");
                    }
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
                RegistarFornecedor form = new RegistarFornecedor(selecionado);
                form.Text = "Editar Fornecedor";
                form.ShowDialog(this);
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

        /// <summary>
        /// Método <c>btFornecimentos_Click</c> chama o formulário GestaoFornecimentos e envia o Fonecedor escolhido
        /// </summary>
        private void btFornecimentos_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Fornecedor selecionado = (Fornecedor)dgvFornecedores.CurrentRow.DataBoundItem;
                GestaoFornecimentos fornecimentos = new GestaoFornecimentos(selecionado);
                fornecimentos.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um fornecedor");
            }
        }

        private void GestaoFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}

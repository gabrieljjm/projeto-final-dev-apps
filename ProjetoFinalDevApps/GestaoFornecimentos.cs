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
    public partial class GestaoFornecimentos : Form
    {
        private Fornecedor _fornecedor;

        public GestaoFornecimentos(Fornecedor fornecedor)
        {
            InitializeComponent();
            _fornecedor = fornecedor;
        }

        private void GestaoFornecimentos_Activated(object sender, EventArgs e)
        {
            LerDadosFornecimentos();
        }

        /// <summary>
        /// Método <c>CarregarMateriais</c> carrega os Materiais ainda não fornecidos por este fornecedor da base de dados para a <c>cbMateriais</c>
        /// </summary>
        

        /// <summary>
        /// Método <c>LerDadosFornecimentos</c> carrega os Fornecimentos da base de dados para a <c>bsFornecimentos</c>
        /// </summary>
        private void LerDadosFornecimentos()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsFornecimentos.DataSource = null;
            bsFornecimentos.DataSource = (from Fornece fornecimentos in retrosaria.ForneceSet
                                             where fornecimentos.FornecedorId == _fornecedor.Id
                                             select fornecimentos).ToList();
        }

        /// <summary>
        /// Método <c>LimpaCampos</c> limpa os campos do formulário
        /// </summary>
       

        /// <summary>
        /// Método <c>EstaSelecionado</c> verifica se está alguma linha selecionada na <c>dgvFornecedores</c>
        /// </summary>
        private bool EstaSelecionado()
        {
            if (dgvFornecimentos.SelectedRows.Count !=  0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Selecione um fornecimento");
                return false;
            }
        }
        /// <summary>
        /// Método <c>btCriar_Click</c> regista um Fornecimento na base de dados
        /// </summary>
        private void btCriar_Click(object sender, EventArgs e)
        {
            RegistarFornecimento form = new RegistarFornecimento(_fornecedor);
            form.ShowDialog();
        }

        /// <summary>
        /// Método <c>btApagar_Click</c> apaga o fornecimento da base de dados
        /// </summary>
        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o fornecimento?";
                string title = "Apagar fornecimento";
                int idmaterial = (int)dgvFornecimentos.CurrentRow.Cells[0].Value;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Console.WriteLine(idmaterial);
                    retrosaria.ForneceSet.Remove(retrosaria.ForneceSet.Single(a => a.StockMateriaisId == idmaterial & a.FornecedorId == _fornecedor.Id));
                    retrosaria.SaveChanges();
                    LerDadosFornecimentos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Fornecimento");
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Fornece selecionado = (Fornece)dgvFornecimentos.CurrentRow.DataBoundItem;
                RegistarFornecimento form = new RegistarFornecimento(selecionado);
                form.Text = "Editar fornecimento";
                form.ShowDialog(this);
            }
        }

        private void GestaoFornecimentos_Load(object sender, EventArgs e)
        {

        }
    }
}

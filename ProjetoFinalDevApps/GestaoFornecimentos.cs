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
            CarregarMateriais();
        }

        /// <summary>
        /// Método <c>CarregarMateriais</c> carrega os Materiais ainda não fornecidos por este fornecedor da base de dados para a <c>cbMateriais</c>
        /// </summary>
        private void CarregarMateriais()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();

            //List<StockMateriais> listaMateriais = retrosaria.StockMateriaisSet.Where(u => u.).ToList();
            cbMateriais.DataSource = retrosaria.StockMateriaisSet.ToList();
            cbMateriais.DisplayMember = "Descricao";
            cbMateriais.ValueMember = "Id";

            cbMateriais.SelectedIndex = -1;
        }

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
        private void LimpaCampos()
        {
            nudPreco.Value = 0;
            dtpPrazo.Value = DateTime.Now;
        }

        /// <summary>
        /// Método <c>EstaSelecionado</c> verifica se está alguma linha selecionada na <c>dgvFornecedores</c>
        /// </summary>
        private bool EstaSelecionado()
        {
            if (dgvFornecimentos.SelectedRows != null)
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
            if (nudPreco.Text == "" || nudPreco.Value == 0)
            {
                nudPreco.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudPreco.BackColor = Color.White;
            }
            if (cbMateriais.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um material.");
                preenchido = false;
            }

            return preenchido;
        }

        /// <summary>
        /// Método <c>btCriar_Click</c> regista um Fornecimento na base de dados
        /// </summary>
        private void btCriar_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                try
                {
                    //Obter informação nos campos e atribui esse valor ao novoFornecimento
                    Fornece novoFornecimento = new Fornece();
                    novoFornecimento.Preco = (double)nudPreco.Value;
                    novoFornecimento.PrazoEntrega = dtpPrazo.Value;
                    novoFornecimento.StockMateriaisId = Int32.Parse(cbMateriais.SelectedValue.ToString());
                    novoFornecimento.FornecedorId = _fornecedor.Id;
                    //Adicionar fornecimento à base de dados
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    retrosaria.ForneceSet.Add(novoFornecimento);
                    retrosaria.SaveChanges();
                    LimpaCampos();
                    CarregarMateriais();
                    LerDadosFornecimentos();
                }
                catch (Exception)
                {
                    MessageBox.Show("O fornecedor já fornece esse material");
                }
            }
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
                EditarFornecimentos editarFornecimentos = new EditarFornecimentos(selecionado);
                editarFornecimentos.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um fornecimento");
            }
        }

        private void GestaoFornecimentos_Load(object sender, EventArgs e)
        {

        }
    }
}

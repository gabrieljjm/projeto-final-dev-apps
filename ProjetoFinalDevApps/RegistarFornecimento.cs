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
    public partial class RegistarFornecimento : Form
    {

        private RetrosariaModelContainer retrosaria;
        private Fornece _fornece;
        private Fornecedor _fornecedor;
        private bool editar = false;
        public RegistarFornecimento(Fornecedor fornecedor)
        {
            InitializeComponent();
            this._fornecedor = fornecedor;
        }

        public RegistarFornecimento(Fornece fornece)
        {
            InitializeComponent();
            this._fornece = fornece;
            editar = true;
            btRegistar.Text = "Guardar";
            label3.Enabled = false;
            cbMateriais.Enabled = false;
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

        private void CarregarCampos()
        {
            nudPreco.Value = Convert.ToDecimal(_fornece.Preco);
            dtpPrazo.Value = _fornece.PrazoEntrega;
            cbMateriais.SelectedValue = _fornece.StockMateriaisId;
        }
        private void CarregarMateriais()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();

            //List<StockMateriais> listaMateriais = retrosaria.StockMateriaisSet.Where(u => u.).ToList();
            cbMateriais.DataSource = retrosaria.StockMateriaisSet.ToList();
            cbMateriais.DisplayMember = "Descricao";
            cbMateriais.ValueMember = "Id";

            cbMateriais.SelectedIndex = -1;
        }
        private void EditarFornecimentos_Load(object sender, EventArgs e)
        {
            //retrosaria = new RetrosariaModelContainer();
            CarregarMateriais();
            //CarregarCampos();
            if (editar)
            {
                CarregarCampos();
            }

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstaPreenchido())
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Fornece fornece;
                    if (!editar)
                    {
                        fornece = new Fornece();
                        fornece.FornecedorId = _fornecedor.Id;
                    }
                    else
                    {
                        fornece = retrosaria.ForneceSet.Single(a => a.FornecedorId == _fornece.FornecedorId && a.StockMateriaisId == _fornece.StockMateriaisId);
                    }

                    //Obter informação nos campos e atribui esse valor ao fornece
                    fornece.Preco = Convert.ToInt32(nudPreco.Value);
                    fornece.PrazoEntrega = dtpPrazo.Value;
                    fornece.StockMateriaisId = Int32.Parse(cbMateriais.SelectedValue.ToString());


                    if (!editar)
                    {
                        retrosaria.ForneceSet.Add(fornece);
                    }


                    retrosaria.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }
    }
}

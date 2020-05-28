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
    public partial class EditarFornecimentos : Form
    {

        private RetrosariaModelContainer retrosaria;
        private Fornece _fornece;
        public EditarFornecimentos(Fornece fornece)
        {
            InitializeComponent();
            this._fornece = fornece;
        }
        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            
            if (nudPreco.Value == 0)
            {
                nudPreco.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudPreco.BackColor = Color.White;
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
        }
        private void EditarFornecimentos_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            CarregarMateriais();
            CarregarCampos();
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                Fornece selecionado = (Fornece)retrosaria.ForneceSet.Single(a => a.FornecedorId == _fornece.FornecedorId);
                selecionado.PrazoEntrega = dtpPrazo.Value;
                selecionado.Preco = Convert.ToDouble(nudPreco.Value);
                selecionado.StockMateriaisId = Int32.Parse(cbMateriais.SelectedValue.ToString()); 
                retrosaria.SaveChanges();

                this.Close();
            }
        }
    }
}

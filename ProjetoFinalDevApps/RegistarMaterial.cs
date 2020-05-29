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
    public partial class RegistarMaterial : Form
    {
        private StockMateriais _material;
        private bool editar = false;

        public RegistarMaterial()
        {
            InitializeComponent();
        }

        public RegistarMaterial(StockMateriais material)
        {
            InitializeComponent();
            this._material = material;
            editar = true;
            btRegistar.Text = "Guardar";
        }

        private void EditarMaterial_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                CarregarCampos();
            }
        }

        /// <summary>
        /// Método <c>CarregarCampos</c> carrega os dados do material para os campos do formulário
        /// </summary>
        private void CarregarCampos()
        {
            tbDescricao.Text = _material.Descricao;
            nudConsMed.Value = (decimal)_material.ConsumoMedioDiario;
            nudMinimo.Value = (decimal)_material.StockMinimo;
            nudQuant.Value = (decimal)_material.QuantAtual;
        }

        /// <summary>
        /// Método <c>EstaPreenchido</c> verifica se os campos do formulário estão corretamente preenhidos
        /// </summary>
        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (tbDescricao.Text == "")
            {
                tbDescricao.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbDescricao.BackColor = Color.White;
            }
            if (nudQuant.Text == "")
            {
                nudQuant.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudQuant.BackColor = Color.White;
            }
            if (nudMinimo.Text == "")
            {
                nudMinimo.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudMinimo.BackColor = Color.White;
            }
            if (nudConsMed.Text == "")
            {
                nudConsMed.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudConsMed.BackColor = Color.White;
            }

            return preenchido;
        }

        /// <summary>
        /// Método <c>btAlterar_Click</c> altera os valores na base de dados
        /// </summary>
        private void btRegistar_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstaPreenchido())
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    StockMateriais material;
                    if (!editar)
                    {
                        material = new StockMateriais();
                    }
                    else
                    {
                        material = retrosaria.StockMateriaisSet.Single(a => a.Id == _material.Id);
                    }
                    material.Descricao = tbDescricao.Text;
                    material.ConsumoMedioDiario = (double)nudConsMed.Value;
                    material.StockMinimo = (double)nudMinimo.Value;
                    material.QuantAtual = (double)nudQuant.Value;
                    if (!editar)
                    {
                        retrosaria.StockMateriaisSet.Add(material);
                    }
                    retrosaria.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

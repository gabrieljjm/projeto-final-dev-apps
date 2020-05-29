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
    public partial class GestaoConsumos : Form
    {
        private Arranjo _arranjo;

        public GestaoConsumos(Arranjo arranjo)
        {
            InitializeComponent();
            this._arranjo = arranjo;
        }

        private void GestaoConsumos_Activated(object sender, EventArgs e)
        {
            LerDadosConsumos();
            CarregarMateriais();
        }

        /// <summary>
        /// Método <c>CarregarMateriais</c> carrega os Materiais da base de dados para a <c>cbMateriais</c>
        /// </summary>
        private void CarregarMateriais()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();

            cbMateriais.DataSource = retrosaria.StockMateriaisSet.ToList();
            cbMateriais.DisplayMember = "Descricao";
            cbMateriais.ValueMember = "Id";
            
            cbMateriais.SelectedIndex = -1;
        }

        /// <summary>
        /// Método <c>LerDadosConsumos</c> carrega os Consumos da base de dados para a <c>bsConsumos</c>
        /// </summary>
        private void LerDadosConsumos()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();

            bsConsumos.DataSource = null;
            bsConsumos.DataSource = (from Consumo consumos in retrosaria.ConsumoSet
                                          where consumos.ArranjoId == _arranjo.Id
                                          select consumos).ToList();
        }

        /// <summary>
        /// Método <c>LimpaCampos</c> limpa os campos do formulário
        /// </summary>
        private void LimpaCampos()
        {
            nudQuantMed.Value = 0;
            cbMateriais.SelectedIndex = -1;
        }

        /// <summary>
        /// Método <c>EstaSelecionado</c> verifica se está alguma linha selecionada na <c>dgvConsumos</c>
        /// </summary>
        private bool EstaSelecionado()
        {
            if (dgvConsumos.SelectedRows != null)
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
            if (nudQuantMed.Text == "" || nudQuantMed.Value == 0)
            {
                nudQuantMed.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudQuantMed.BackColor = Color.White;
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
                //Obter informação nos campos e atribui esse valor ao novoFornecimento
                int idMaterial = Int32.Parse(cbMateriais.SelectedValue.ToString());
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                Consumo novoConsumo = new Consumo();
                novoConsumo.QuantidadeMedia = (double)nudQuantMed.Value;
                novoConsumo.StockMateriais = retrosaria.StockMateriaisSet.Where(u => u.Id == idMaterial).SingleOrDefault();
                novoConsumo.ArranjoId = _arranjo.Id;
                //Adicionar fornecimento à base de dados
                retrosaria.ConsumoSet.Add(novoConsumo);
                retrosaria.SaveChanges();
                LimpaCampos();
                CarregarMateriais();
                LerDadosConsumos();
            }
        }

        /// <summary>
        /// Método <c>btApagar_Click</c> apaga o consumo da base de dados
        /// </summary>
        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o consumo?";
                string title = "Apagar consumo";
                int idconsumo = (int)dgvConsumos.CurrentRow.Cells[0].Value;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Console.WriteLine(idconsumo);
                    retrosaria.ConsumoSet.Remove(retrosaria.ConsumoSet.Single(a => a.Id == idconsumo));
                    retrosaria.SaveChanges();
                    LerDadosConsumos();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Consumo");
            }
        }
    }
}

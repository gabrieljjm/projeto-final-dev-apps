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
    public partial class GestaoPecaArranjo : Form
    {
        private RetrosariaModelContainer retrosaria;
        public GestaoPecaArranjo()
        {
            InitializeComponent();
        }

        public void CarregarPecas()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsPeca.DataSource = null;
            bsPeca.DataSource = retrosaria.PecaSet.ToList();
        }

        public void CarregarArranjos()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsArranjo.DataSource = null;
            bsArranjo.DataSource = retrosaria.ArranjoSet.ToList();
        }

        private void carregarComboboxes()
        {
            //Assign Entity as DataSource.
            cbPeca.DataSource = retrosaria.PecaSet.ToList();
            cbPeca.DisplayMember = "TipoPeca";
            cbPeca.ValueMember = "Id";

            cbPeca.SelectedIndex = -1;

            cbArranjo.DataSource = retrosaria.ArranjoSet.ToList();
            cbArranjo.DisplayMember = "TipoArranjo";
            cbArranjo.ValueMember = "Id";

            cbArranjo.SelectedIndex = -1;
        }

        /// <summary>
        /// Método <c>EstaSelecionado</c> verifica se os campos do formulário estão corretamente preenchidos
        /// </summary>
        private bool EstaSelecionado()
        {
            bool selecionado = true;

            //Verificar se todos os campos estão preenchidos
            if (cbPeca.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma peça");
                selecionado = false;
            }
            else
            {
                cbPeca.BackColor = Color.White;
            }
            if (cbArranjo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um arranjo");
                selecionado = false;
            }
            else
            {
                cbArranjo.BackColor = Color.White;
            }
            if (nudPreco.Value == 0)
            {
                MessageBox.Show("Digite um preço para a combinação");
                selecionado = false;
            }
            else
            {
                cbArranjo.BackColor = Color.White;
            }
            return selecionado;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado()) { 


                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                int pecaid = Int32.Parse(cbPeca.SelectedValue.ToString());
                int arranjoid = Int32.Parse(cbArranjo.SelectedValue.ToString());

                PecaArranjo novoPecaArranjo = new PecaArranjo();
                novoPecaArranjo.PecaId = pecaid;
                novoPecaArranjo.ArranjoId = arranjoid;
                novoPecaArranjo.Preco = Convert.ToDouble(nudPreco.Value);

                retrosaria.PecaArranjoSet.Add(novoPecaArranjo);
                retrosaria.SaveChanges();

                cbPeca.SelectedIndex = -1;
                cbArranjo.SelectedIndex = -1;
                nudPreco.Value = 0;

                MessageBox.Show("Combinação de peça com arranjo registada com sucesso");
            }
        }

        private void GestaoPecaArranjo_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarComboboxes();
            CarregarPecas();
            CarregarArranjos();
        }

        private void btAdicionarPecaArranjo_Click(object sender, EventArgs e)
        {
            if (tbPeca.Text != "")
            {
                tbPeca.BackColor = Color.White;

                //Obter informação nos campos e atribui esse valor ao novaPeca
                Peca novaPeca = new Peca();
                novaPeca.TipoPeca = tbPeca.Text;

                //Adicionar peça à base de dados
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                retrosaria.PecaSet.Add(novaPeca);
                retrosaria.SaveChanges();

                carregarComboboxes();
                tbPeca.Text = "";
                MessageBox.Show("Peça adicionada com sucesso.");
            }
            else
            {
                tbPeca.BackColor = Color.Aqua;
            }
        }

        private void btAdicionarArranjo_Click(object sender, EventArgs e)
        {
            //Obter informação nos campos e atribui esse valor ao novoArranjo
            if(tbArranjo.Text != "") {

                tbArranjo.BackColor = Color.White;

                Arranjo novoArranjo = new Arranjo();
                novoArranjo.TipoArranjo = tbArranjo.Text;

                //Adicionar arranjo à base de dados
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                retrosaria.ArranjoSet.Add(novoArranjo);
                retrosaria.SaveChanges();

                carregarComboboxes();
                tbArranjo.Text = "";

                MessageBox.Show("Arranjo adicionado com sucesso.");
            }
            else
            {
                tbArranjo.BackColor = Color.Aqua;
            }
        }

        private void cbPeca_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void GestaoPecaArranjo_Activated(object sender, EventArgs e)
        {
            CarregarPecas();
            CarregarArranjos();
        }
    }
}

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
        /// Método <c>EstaPreenchido</c> verifica se os campos do formulário estão corretamente preenchidos
        /// </summary>
        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (cbPeca.SelectedIndex == -1)
            {
                cbPeca.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                cbPeca.BackColor = Color.White;
            }
            if (cbArranjo.Text == "")
            {
                cbArranjo.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                cbArranjo.BackColor = Color.White;
            }
            return preenchido;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            int pecaid = Int32.Parse(cbPeca.SelectedValue.ToString());
            int arranjoid = Int32.Parse(cbArranjo.SelectedValue.ToString());

            PecaArranjo novoPecaArranjo = new PecaArranjo();
            novoPecaArranjo.PecaId = pecaid;
            novoPecaArranjo.ArranjoId = arranjoid;
            novoPecaArranjo.Preco = 3;

            retrosaria.PecaArranjoSet.Add(novoPecaArranjo);
            retrosaria.SaveChanges();
        }

        private void GestaoPecaArranjo_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarComboboxes();
        }

        private void btAdicionarPecaArranjo_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                //Obter informação nos campos e atribui esse valor ao novaPeca
                Peca novaPeca = new Peca();
                novaPeca.TipoPeca = tbPeca.Text;

                //Adicionar peça à base de dados
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                retrosaria.PecaSet.Add(novaPeca);
                retrosaria.SaveChanges();

                //Obter informação nos campos e atribui esse valor ao novoArranjo
                Arranjo novoArranjo = new Arranjo();
                novoArranjo.TipoArranjo = tbArranjo.Text;

                //Adicionar arranjo à base de dados
                retrosaria.ArranjoSet.Add(novoArranjo);
                retrosaria.SaveChanges();

                

            }
        }
    }
}

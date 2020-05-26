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
    public partial class EditarTrabalho : Form
    {
        private Trabalho _trabalho;
        private RetrosariaModelContainer retrosaria;
        public EditarTrabalho(Trabalho trabalho)
        {
            InitializeComponent();
            this._trabalho = trabalho;
        }

        private void carregarComboboxPeca()
        {

            //Assign Entity as DataSource.
            cbPeca.DataSource = retrosaria.PecaSet.ToList();
            cbPeca.DisplayMember = "TipoPeca";
            cbPeca.ValueMember = "Id";

            cbPeca.SelectedIndex = -1;
        }
        private void CarregarCampos()
        {
            tbDescricaoPeca.Text = _trabalho.DescricaoPeca;
            tbCorPeca.Text = _trabalho.CorPeca;
            nudValorPago.Value = Convert.ToDecimal(_trabalho.ValorPago);
            dtpLevantamento.Value = _trabalho.DataLevantamento;
            tbObservacoes.Text = _trabalho.Observacoes;
            cbPeca.ValueMember= Convert.ToString(_trabalho.PecaArranjo.PecaId);
            cbArranjo.ValueMember = Convert.ToString(_trabalho.PecaArranjo.ArranjoId);
        }

        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (tbDescricaoPeca.Text == "")
            {
                tbDescricaoPeca.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbDescricaoPeca.BackColor = Color.White;
            }
            if (tbCorPeca.Text == "")
            {
                tbCorPeca.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbCorPeca.BackColor = Color.White;
            }
            if (nudValorPago.Value == 0)
            {
                nudValorPago.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudValorPago.BackColor = Color.White;
            }
            if (tbObservacoes.Text == "")
            {
                tbObservacoes.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbObservacoes.BackColor = Color.White;
            }
            if (cbPeca.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma peça.");
                preenchido = false;
            }
            if (cbArranjo.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um arranjo.");
                preenchido = false;
            }


            return preenchido;
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

        }

        private void EditarTrabalho_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            CarregarCampos();
            carregarComboboxPeca();
        }

        private void cbPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPeca.SelectedIndex != -1)
                {
                    int pecaid = Int32.Parse(cbPeca.SelectedValue.ToString());
                    Console.WriteLine("cbPeca - " + cbPeca.SelectedValue);
                    List<PecaArranjo> listaPecaArranjo = retrosaria.PecaArranjoSet.Where(u => u.PecaId == pecaid).ToList();
                    if (listaPecaArranjo.Count != 0)
                    {
                        List<Arranjo> listaArranjo = new List<Arranjo>();
                        foreach (PecaArranjo pecaarranjo in listaPecaArranjo)
                        {
                            foreach (Arranjo arranjo in retrosaria.ArranjoSet)
                            {
                                if (pecaarranjo.ArranjoId == arranjo.Id)
                                {
                                    listaArranjo.Add(arranjo);
                                }
                            }
                        }
                        cbArranjo.DataSource = listaArranjo.ToList();
                        cbArranjo.DisplayMember = "TipoArranjo";
                        cbArranjo.ValueMember = "Id";
                        cbArranjo.SelectedIndex = -1;
                        cbArranjo.Enabled = true;
                    }
                    else
                    {
                        cbArranjo.Enabled = false;
                        cbArranjo.DataSource = null;
                    }
                }
                else
                {
                    cbArranjo.Enabled = false;
                    cbArranjo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

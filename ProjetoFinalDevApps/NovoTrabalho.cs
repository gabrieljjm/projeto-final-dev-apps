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
    public partial class NovoTrabalho : Form
    {
        private string _nomeCliente;
        private RetrosariaModelContainer retrosaria;
        public NovoTrabalho(string nomeCliente)
        {
            InitializeComponent();
            this._nomeCliente = nomeCliente;
        }

        private void carregarComboboxArranjo()
        {
            //Assign Entity as DataSource.
            cbArranjo.DataSource = retrosaria.ArranjoSet.ToList();
            cbArranjo.DisplayMember = "TipoArranjo";
            cbArranjo.ValueMember = "Id";
            
            cbArranjo.SelectedIndex = -1;
        }

        

        private void NovoTrabalho_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            labelCliente.Text = _nomeCliente;
            carregarComboboxArranjo();
        }

        private void cbArranjo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbArranjo.SelectedIndex != -1)
                {
                    int arranjoID = Int32.Parse(cbArranjo.SelectedValue.ToString());
                    Console.WriteLine("cbArranjo - " + cbArranjo.SelectedValue);
                    List<PecaArranjo> listaPecaArranjo = retrosaria.PecaArranjoSet.Where(u => u.ArranjoId == arranjoID).ToList();
                    if (listaPecaArranjo.Count != 0)
                    {
                        List<Peca> listaPeca = new List<Peca>();
                        foreach (PecaArranjo pecaarranjo in listaPecaArranjo)
                        {
                            foreach (Peca peca in retrosaria.PecaSet)
                            {
                                if (pecaarranjo.PecaId == peca.Id)
                                {
                                    listaPeca.Add(peca);
                                }
                            }
                        }
                        cbPeca.DataSource = listaPeca.ToList();
                        cbPeca.DisplayMember = "TipoPeca";
                        cbPeca.ValueMember = "Id";
                        cbPeca.SelectedIndex = -1;
                        cbPeca.Enabled = true;
                    }
                    else
                    {
                        cbPeca.Enabled = false;
                        cbPeca.DataSource = null;
                    }
                }
                else
                {
                    cbPeca.Enabled = false;
                    cbPeca.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbPeca - " + cbPeca.SelectedValue);
        }
    }
}

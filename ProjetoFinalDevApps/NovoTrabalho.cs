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

            List<Arranjo> arranjos = (from a in retrosaria.ArranjoSet
                                      select a).ToList();

            //Assign Entity as DataSource.
            cbArranjo.DataSource = arranjos;
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
            int arranjoID = Int32.Parse(cbArranjo.SelectedValue.ToString());

            Console.WriteLine(cbArranjo.SelectedValue);
            if (cbArranjo.SelectedIndex != -1)
            {
                List<PecaArranjo> pecaArranjos = (from a in retrosaria.PecaArranjoSet
                                                  where a.ArranjoId == arranjoID
                                                  select a).ToList();

                cbPeca.DataSource = pecaArranjos.ToList();
                cbPeca.SelectedIndex = -1;
                cbPeca.Enabled = true;
            }
            else
            {
                cbPeca.Enabled = false;
                cbPeca.DataSource = null;
            }


        }
    }
}

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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btFormClientes_Click(object sender, EventArgs e)
        {
            GestaoClientes form = new GestaoClientes();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestaoPedidos form = new GestaoPedidos();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GestaoFornecedores form = new GestaoFornecedores();
            form.Show();
        }
    }
}

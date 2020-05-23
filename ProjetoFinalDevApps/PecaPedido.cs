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
    public partial class PecaPedido : Form
    {
        public PecaPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestaoPedidosTabelados gestaoPedidosTabelados = new GestaoPedidosTabelados();
            gestaoPedidosTabelados.ShowDialog();
        }

        private void PecaPedido_Load(object sender, EventArgs e)
        {

        }

        private void btAdicionarPeca_Click(object sender, EventArgs e)
        {
            GestaoPecaArranjo gestaoPeca = new GestaoPecaArranjo();
            gestaoPeca.ShowDialog();
        }
    }
}

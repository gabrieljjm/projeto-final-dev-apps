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
    public partial class GestaoPedidosTabelados : Form
    {
        public GestaoPedidosTabelados()
        {
            InitializeComponent();
        }

        private void GestaoPedidosTabelados_Load(object sender, EventArgs e)
        {

        }

        private void btNovoPedidoTabelado_Click(object sender, EventArgs e)
        {
            NovoPedidoTabelado novoPedido = new NovoPedidoTabelado();
            novoPedido.ShowDialog();
        }
    }
}

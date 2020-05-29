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
    public partial class GestaoDevolucoes : Form
    {
        private PedidoTabelado _pedido;
        public GestaoDevolucoes(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            RegistarDevolucao form = new RegistarDevolucao(_pedido);
            form.ShowDialog();
        }
    }
}

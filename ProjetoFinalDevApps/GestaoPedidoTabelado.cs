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
    public partial class GestaoPedidoTabelado : Form
    {
        private RetrosariaModelContainer retrosaria;

        private Pedido _pedido;
        private string _nomeCliente;
        public GestaoPedidoTabelado(Pedido pedido, string nomeCliente)
        {
            InitializeComponent();

            this._pedido = pedido;
            this._nomeCliente = nomeCliente;
        }

        private void GestaoPedidoTabelado_Load(object sender, EventArgs e)
        {

        }
    }
}

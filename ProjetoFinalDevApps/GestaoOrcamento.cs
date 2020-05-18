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
    public partial class GestaoOrcamento : Form
    {
        private RetrosariaModelContainer retrosaria;

        private Pedido _pedido;
        private string _nomeCliente;
        public GestaoOrcamento(Pedido pedido, string nomeCliente)
        {
            InitializeComponent();
            this._pedido = pedido;
            this._nomeCliente = nomeCliente;
        }

        private void GestaoOrcamento_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            lbCliente.Text = _nomeCliente;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

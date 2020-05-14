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
    public partial class EditarPedido : Form
    {
        private Pedido pedido;
        public EditarPedido(Pedido pedido)
        {
            InitializeComponent();
            this.pedido = pedido;
        }

        private void EditarPedido_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

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
    
    public partial class GestaoPedidos : Form
    {

        private RetrosariaModelContainer retrosaria;
        public GestaoPedidos()
        {
            InitializeComponent();
        }

        public void AtualizarPedidos()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = retrosaria.PedidoSet.ToList();
        }


        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void GestaoPedidos_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            AtualizarPedidos();
            dataGridView1.RowHeadersVisible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoPedido frmNovoForm = new NovoPedido();
            frmNovoForm.Show(this);
            
        }
    }
}

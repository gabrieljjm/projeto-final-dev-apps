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
            dgvPedido.DataSource = null;
            dgvPedido.DataSource = retrosaria.PedidoSet.ToList();
        }


        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void GestaoPedidos_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            AtualizarPedidos();
            dgvPedido.RowHeadersVisible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoPedido frmNovoForm = new NovoPedido();
            frmNovoForm.Show(this);
            
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (dgvPedido.SelectedRows == null)
            {
                MessageBox.Show("Selecione um pedido");
            }
            else
            {
                string message = "Tem a certeza que deseja remover o pedido ?";
                string title = "Apagar pedido";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Pedido selecionado = (Pedido)dgvPedido.CurrentRow.DataBoundItem;
                    retrosaria.PedidoSet.Remove(selecionado);
                    retrosaria.SaveChanges();

                }

                AtualizarPedidos();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Pedido selecionado = (Pedido)dgvPedido.CurrentRow.DataBoundItem;
            string nomeCliente = this.dgvPedido.CurrentRow.Cells[7].Value.ToString();
            EditarPedido editar = new EditarPedido(selecionado, nomeCliente);
            
            editar.Show();
        }


        private void GestaoPedidos_Activated(object sender, EventArgs e)
        {
            //AtualizarPedidos();
        }
    }
}

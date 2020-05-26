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
    public partial class NovoPedidoTabelado : Form
    {
        private RetrosariaModelContainer retrosaria;

       

        public NovoPedidoTabelado()
        {
            InitializeComponent();
        }

        private void GestaoPedidoTabelado_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarClientes();
            
        }

         private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (cbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um cliente");
                preenchido = false;
            }
            if (tbObservacoes.Text == "")
            {
                tbObservacoes.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbObservacoes.BackColor = Color.White;
            }

            return preenchido;
        }

        private void carregarClientes()
        {
            cbCliente.DataSource = retrosaria.ClienteSet.ToList();
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1; 
        }

        private void btTrabalho_Click(object sender, EventArgs e)
        {
            
        }

        private void GestaoPedidoTabelado_Activated(object sender, EventArgs e)
        {
            
        }

        private void btRegistarTabelado_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                PedidoTabelado pedido = new PedidoTabelado();
                pedido.DataPedido = dtpPedido.Value;
                pedido.Observacoes = tbObservacoes.Text;
                pedido.ClienteId = Int32.Parse(cbCliente.SelectedValue.ToString());
                pedido.Levantado = false;
                pedido.Pago = true;
                pedido.TipoPedido = "Pedido tabelado";
                retrosaria.PedidoSet.Add(pedido);
                retrosaria.SaveChanges();

                this.Close();
            }
        }
    }
}

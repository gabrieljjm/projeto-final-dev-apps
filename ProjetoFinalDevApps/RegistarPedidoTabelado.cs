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
    public partial class RegistarPedidoTabelado : Form
    {
        private RetrosariaModelContainer retrosaria;
        private PedidoTabelado _pedidoTabelado;
        private bool editar = false;

        public RegistarPedidoTabelado()
        {
            InitializeComponent();
        }

        public RegistarPedidoTabelado(PedidoTabelado pedidoTabelado)
        {
            InitializeComponent();
            this._pedidoTabelado = pedidoTabelado;
            editar = true;
            btRegistarTabelado.Text = "Guardar";
            lbCliente.Enabled = false;
            cbCliente.Enabled = false;
        }

        private void GestaoPedidoTabelado_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarClientes();

            if (editar)
            {
                CarregarCampos();
                cbCliente.SelectedValue = _pedidoTabelado.ClienteId;
            }

        }

        private void CarregarCampos()
        {
            dtpPedido.Value = _pedidoTabelado.DataPedido;
            tbObservacoes.Text = _pedidoTabelado.Observacoes;
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
            //if (EstaPreenchido())
            //{
            //    PedidoTabelado pedido = new PedidoTabelado();
            //    pedido.DataPedido = dtpPedido.Value;
            //    pedido.Observacoes = tbObservacoes.Text;
            //    pedido.ClienteId = Int32.Parse(cbCliente.SelectedValue.ToString());
            //    pedido.Levantado = false;
            //    pedido.Pago = true;
            //    pedido.TipoPedido = "Pedido tabelado";
            //    retrosaria.PedidoSet.Add(pedido);
            //    retrosaria.SaveChanges();

            //    this.Close();
            //}





            try
            {
                if (EstaPreenchido())
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    PedidoTabelado pedidoTabelado;
                    if (!editar)
                    {
                        pedidoTabelado = new PedidoTabelado();
                    }
                    else
                    {
                        pedidoTabelado = (PedidoTabelado)retrosaria.PedidoSet.Single(a => a.Id == _pedidoTabelado.Id);
                    }
                    //Obter informação nos campos e atribui esse valor ao novoCliente
                    pedidoTabelado.DataPedido = dtpPedido.Value;
                    pedidoTabelado.Observacoes = tbObservacoes.Text;
                    pedidoTabelado.ClienteId = Int32.Parse(cbCliente.SelectedValue.ToString());
                    pedidoTabelado.Levantado = false;
                    pedidoTabelado.Pago = true;
                    pedidoTabelado.TipoPedido = "Pedido tabelado";
                    if (!editar)
                    {
                        retrosaria.PedidoSet.Add(pedidoTabelado);
                    }
                    retrosaria.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

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
        private Pedido _pedido;
        private string _nomeCliente;
        public EditarPedido(Pedido pedido, string nomeCliente)
        {
            InitializeComponent();
            this._pedido = pedido;
            this._nomeCliente = nomeCliente;
        }

        private void carregarCampos()
        {
            lbCliente.Text = _nomeCliente;
            dtpDataPedido.Value = _pedido.DataPedido;
            tbObservacoes.Text = _pedido.Observacoes;
            if (_pedido.TipoPedido == "Orçamento")
            {
                rbOrcamento.Checked = true;
            }
            else
            {
                rbPedidoTabelado.Checked = true;
            }
        }

        private void EditarPedido_Load(object sender, EventArgs e)
        {
            carregarCampos();



        }
        
        private void btRegistar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

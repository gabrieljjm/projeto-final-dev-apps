using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalDevApps
{
    public partial class EditarPedido : Form
    {
        private RetrosariaModelContainer retrosaria;

        private Pedido _pedido;
        private string _nomeCliente;
        public EditarPedido(Pedido pedido, string nomeCliente)
        {
            InitializeComponent();
            this._pedido = pedido;
            this._nomeCliente = nomeCliente;
        }

        void AtualizarPedidos() => (Owner as GestaoPedidos).AtualizarPedidos();

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
            retrosaria = new RetrosariaModelContainer();
            carregarCampos();
            


        }
        
        private void btRegistar_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            _pedido.Levantado = false;
            _pedido.Pago = false;
            _pedido.DataPedido = dtpDataPedido.Value.Date;
            _pedido.TipoPedido = getSelectedRadioButtonName();
            _pedido.Observacoes = tbObservacoes.Text;

            if (tbObservacoes.Text == "")
            {
                tbObservacoes.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbObservacoes.BackColor = Color.White;
            }
            if (preenchido)
            {
                retrosaria.SaveChanges();
            }


            AtualizarPedidos();
        }

        private String getSelectedRadioButtonName()
        {
            foreach (Control c in gbRadioButtons.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text;
                }
            }
            return "Nenhum foi selecionado";
        }

        private void EditarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void EditarPedido_Activated(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class EditarPedidoTabelado : Form
    {
        private RetrosariaModelContainer retrosaria;
        private PedidoTabelado _pedido;

        public EditarPedidoTabelado(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }

        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            
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
        private void CarregarCampos()
        {
            dtpPedido.Value = _pedido.DataPedido;
            tbObservacoes.Text = _pedido.Observacoes;
        }
        private void EditarPedidoTabelado_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            CarregarCampos();
        }

        private void btAlterarPedido_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                PedidoTabelado pedido = (PedidoTabelado)retrosaria.PedidoSet.Single(a => a.Id == _pedido.Id);
                pedido.DataPedido = dtpPedido.Value;
                pedido.Observacoes = tbObservacoes.Text;
                retrosaria.SaveChanges();

                this.Close();
            }
        }
    }
}

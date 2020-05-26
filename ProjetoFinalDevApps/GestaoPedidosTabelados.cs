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
    public partial class GestaoPedidosTabelados : Form
    {
        public GestaoPedidosTabelados()
        {
            InitializeComponent();
        }

        private void GestaoPedidosTabelados_Activated(object sender, EventArgs e)
        {
            LerDadosPedidos();
        }

        private bool EstaSelecionado()
        {
            if (dgvPedido.SelectedRows != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Método <c>LerDadosPedidos</c> carrega os Pedidos da base de dados para a <c>bsPedidosTabelados</c>
        /// </summary>
        private void LerDadosPedidos()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsPedidosTabelados.DataSource = null;
            bsPedidosTabelados.DataSource = (from Pedido tabelado in retrosaria.PedidoSet
                                             where tabelado.TipoPedido == "Pedido tabelado"
                                             select tabelado).ToList();
        }

        private void btNovoPedidoTabelado_Click(object sender, EventArgs e)
        {
            NovoPedidoTabelado novoPedido = new NovoPedidoTabelado();
            novoPedido.ShowDialog();
        }

        private void btAdicionarTrabalho_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                PedidoTabelado selecionado = (PedidoTabelado)dgvPedido.CurrentRow.DataBoundItem;
                GestaoTrabalhos trabalho = new GestaoTrabalhos(selecionado);
                trabalho.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um pedido");
            }
        }

        private void GestaoPedidosTabelados_Load(object sender, EventArgs e)
        {
            LerDadosPedidos();
        }

        private void btVerPedidoTabelado_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                PedidoTabelado selecionado = (PedidoTabelado)dgvPedido.CurrentRow.DataBoundItem;
                EditarPedidoTabelado editarPedido = new EditarPedidoTabelado(selecionado);
                editarPedido.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um pedido");
            }
        }
    }
}

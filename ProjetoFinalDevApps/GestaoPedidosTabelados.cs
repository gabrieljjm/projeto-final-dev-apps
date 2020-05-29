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
            if (dgvPedido.SelectedRows.Count != 0)
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
            RegistarPedidoTabelado novoPedido = new RegistarPedidoTabelado();
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
                if (selecionado.Levantado == false)
                {
                    RegistarPedidoTabelado form = new RegistarPedidoTabelado(selecionado);
                    form.Text = "Editar Pedido Tabelado";
                    form.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Não é possível editar um pedido levantado.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido");
            }
        }

        private void btDevolucoes_Click(object sender, EventArgs e)
        {
            PedidoTabelado selecionado = (PedidoTabelado)dgvPedido.CurrentRow.DataBoundItem;
            GestaoDevolucoes form = new GestaoDevolucoes(selecionado);
            form.ShowDialog(this);
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                string message = "Tem a certeza que deseja remover o pedido ?";
                string title = "Apagar pedido";

                PedidoTabelado selecionado = (PedidoTabelado)dgvPedido.CurrentRow.DataBoundItem;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    retrosaria.PedidoSet.Remove(retrosaria.PedidoSet.Single(a => a.Id == selecionado.Id));
                    try
                    {
                        retrosaria.SaveChanges();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("O pedido que deseja apagar já contém trabalhos.");
                    }
                    LerDadosPedidos();
                }
            }

        }
    }
}

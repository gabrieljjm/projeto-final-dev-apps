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
    public partial class GestaoDevolucoes : Form
    {
        private PedidoTabelado _pedido;
        public GestaoDevolucoes(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }

        private void GestaoDevolucoes_Activated(object sender, EventArgs e)
        {
            LerDadosDevolucoes();
        }

        private void LerDadosDevolucoes()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsDevolucoes.DataSource = retrosaria.DevolucaoSet.Where(u => u.PedidoId == _pedido.Id).ToList();
        }
        private bool EstaSelecionado()
        {
            if (dgvDevolucoes.SelectedRows != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Selecione uma devolução");
                return false;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            if(_pedido.Levantado == false)
            {
                RegistarDevolucao form = new RegistarDevolucao(_pedido);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não é possível criar devolução se o pedido foi levantado.");
            }
            
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Devolucao selecionado = (Devolucao)dgvDevolucoes.CurrentRow.DataBoundItem;
                RegistarDevolucao form = new RegistarDevolucao(selecionado);
                form.Text = "Editar Devolução";
                form.ShowDialog(this);
            }
        }

        private void GestaoDevolucoes_Load(object sender, EventArgs e)
        {

        }
    }
}

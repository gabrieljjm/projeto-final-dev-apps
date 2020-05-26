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
    public partial class GestaoTrabalhos : Form
    {

        private RetrosariaModelContainer retrosaria;
        private PedidoTabelado _pedido;
        public GestaoTrabalhos(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }

        private bool EstaSelecionado()
        {
            if (dgvTrabalhos.SelectedRows != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void CarregarTrabalhos()
        {
            bsTrabalhos.DataSource = retrosaria.TrabalhoSet.Where(u => u.PedidoTabeladoId == _pedido.Id).ToList();
        }

        private void btNovoPedidoTabelado_Click(object sender, EventArgs e)
        {
            NovoTrabalho trabalho = new NovoTrabalho(_pedido);
            trabalho.ShowDialog(this);
        }

        private void GestaoTrabalhos_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            
            
        }

        private void GestaoTrabalhos_Activated(object sender, EventArgs e)
        {
            CarregarTrabalhos();
        }

        private void btVerPedidoTabelado_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Trabalho selecionado = (Trabalho)dgvTrabalhos.CurrentRow.DataBoundItem;
                EditarTrabalho editar = new EditarTrabalho(selecionado);
                editar.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Selecione um trabalho");
            }

        }
    }
}

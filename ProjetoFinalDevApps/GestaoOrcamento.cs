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
    public partial class GestaoOrcamento : Form
    {
        private RetrosariaModelContainer retrosaria;
        public GestaoOrcamento()
        {
            InitializeComponent();
        }

        //FUNÇÕES
        public void AtualizarPedidos()
        {
            dgvPedido.DataSource = null;
            dgvPedido.DataSource = retrosaria.PedidoSet.ToList();
        }
        //FUNÇÕES


        private void btNovoOrcamento_Click(object sender, EventArgs e)
        {
            NovoOrcamento novoOrcamento = new NovoOrcamento();
            novoOrcamento.ShowDialog(this);
        }

        private void btVerOrcamento_Click(object sender, EventArgs e)
        {
            EditarOrcamento editarOrcamento = new EditarOrcamento();
            editarOrcamento.ShowDialog();

        }

        private void GestaoOrcamento_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            AtualizarPedidos();
        }
    }
}

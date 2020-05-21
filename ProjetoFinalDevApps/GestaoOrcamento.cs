using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            retrosaria = new RetrosariaModelContainer();
        }

        //FUNÇÕES
        public void salvarOrcamento()
        {
            retrosaria.SaveChanges();
        }
        //FUNÇÕES


        private void btNovoOrcamento_Click(object sender, EventArgs e)
        {
            NovoOrcamento novoOrcamento = new NovoOrcamento();
            novoOrcamento.ShowDialog(this);
        }

        private void btVerOrcamento_Click(object sender, EventArgs e)
        {
            if (dgvPedido.SelectedRows.Count == 1)
            {
                Orcamento selecionado = (Orcamento)dgvPedido.CurrentRow.DataBoundItem;

                EditarOrcamento editar = new EditarOrcamento(selecionado);
                editar.ShowDialog(this);

            }
            else
            {
                MessageBox.Show("Selecione um cliente");
            }

        }

        private void GestaoOrcamento_Load(object sender, EventArgs e)
        {
            dgvPedido.RowHeadersVisible = false;

        }

        private void GestaoOrcamento_Activated(object sender, EventArgs e)
        {
            bsOrcamento.Clear();
            var listaOrcamentos = (from Pedido orcamento in retrosaria.PedidoSet
                                   where orcamento.TipoPedido == "Orçamento"
                                   select orcamento).ToList();


            foreach (Orcamento item in listaOrcamentos)
            {
                bsOrcamento.Add(item);
            }
        }
    }
}

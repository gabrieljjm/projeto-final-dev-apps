﻿using System;
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


        private string TipoPedido = "Orçamento";
        public GestaoOrcamento()
        {
            InitializeComponent();
        }

        //FUNÇÕES
        public void AtualizarPedidos()
        {
            Orcamento orc = new Orcamento();
            dgvPedido.DataSource = null;
            dgvPedido.DataSource = retrosaria.PedidoSet.Where( u => u.TipoPedido == "Orçamento").ToList();

           
        
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
            dgvPedido.Columns[4].Visible = false;
        }
    }
}

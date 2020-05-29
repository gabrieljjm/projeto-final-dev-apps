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
    public partial class GestaoOrcamentos : Form
    {
        private RetrosariaModelContainer retrosaria;

        public GestaoOrcamentos()
        {
            InitializeComponent();
            retrosaria = new RetrosariaModelContainer();
        }

        //FUNÇÕES
        public void salvarOrcamento()
        {
            retrosaria.SaveChanges();
        }

        private void LerDadosOrcamento()
        {
            RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
            bsOrcamento.Clear();
            var listaOrcamentos = (from Pedido orcamento in retrosaria.PedidoSet
                                   where orcamento.TipoPedido == "Orçamento"
                                   select orcamento).ToList();


            foreach (Orcamento item in listaOrcamentos)
            {
                bsOrcamento.Add(item);
            }
        }
        private bool EstaSelecionado()
        {
            if (dgvPedido.SelectedRows != null)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Selecione um orçamento");
                return false;
            }
        }
        //FUNÇÕES


        private void btNovoOrcamento_Click(object sender, EventArgs e)
        {
            RegistarOrcamento form = new RegistarOrcamento();
            form.ShowDialog(this);
        }

        private void btVerOrcamento_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Orcamento selecionado = (Orcamento)dgvPedido.CurrentRow.DataBoundItem;
                RegistarOrcamento form = new RegistarOrcamento(selecionado);
                form.Text = "Editar orçamento";
                form.ShowDialog(this);
            }
        }

        private void GestaoOrcamento_Load(object sender, EventArgs e)
        {
            LerDadosOrcamento();
            dgvPedido.RowHeadersVisible = false;

        }

        private void GestaoOrcamento_Activated(object sender, EventArgs e)
        {
            LerDadosOrcamento();
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (EstaSelecionado())
            {
                Orcamento selecionado = (Orcamento)dgvPedido.CurrentRow.DataBoundItem;
                if (selecionado.Aceite == false)
                {
                    string message = "Tem a certeza que deseja remover o pedido?";
                    string title = "Apagar pedido";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        retrosaria = new RetrosariaModelContainer();
                        retrosaria.PedidoSet.Remove(retrosaria.PedidoSet.Single(a => a.Id == selecionado.Id));
                        try
                        {
                            retrosaria.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        LerDadosOrcamento();
                    }
                }
                else
                {
                    MessageBox.Show("Não é possível apagar um pedido aceite.");
                }
                
            }
        }
    }
}

﻿using System;
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
    }
}

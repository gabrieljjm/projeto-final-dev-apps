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
    
    public partial class GestaoPedidos : Form
    {

        private RetrosariaModelContainer retrosaria;
        public GestaoPedidos()
        {
            InitializeComponent();
        }

        


        

        
        

        private void GestaoPedidos_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        


        private void GestaoPedidos_Activated(object sender, EventArgs e)
        {
           
        }

        

        private void GestaoPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            retrosaria.SaveChanges();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GestaoOrcamento gestaoOrcamento = new GestaoOrcamento();
            gestaoOrcamento.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GestaoPedidoTabelado gestaoPedido = new GestaoPedidoTabelado();
            gestaoPedido.ShowDialog();
        }
    }
}

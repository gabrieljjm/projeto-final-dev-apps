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
    public partial class EditarFornecedores : Form
    {
        private Fornecedor _fornecedor;

        public EditarFornecedores(Fornecedor fornecedor)
        {
            InitializeComponent();
            _fornecedor = fornecedor;
        }

        private void EditarFornecedores_Load(object sender, EventArgs e)
        {
            CarregarCampos();
        }
        /// <summary>
        /// Método <c>CarregarCampos</c> carrega os dados do fornecedor para os campos do formulário
        /// </summary>
        private void CarregarCampos()
        {
            tbNome.Text = _fornecedor.Nome;
            tbMorada.Text = _fornecedor.Morada;
            tbLocalidade.Text = _fornecedor.Localidade;
            tbCodPostal.Text = _fornecedor.CodigoPostal;
            tbNif.Text = _fornecedor.NIF;
            tbTelefone.Text = _fornecedor.Telefone;
        }
        /// <summary>
        /// Método <c>EstaPreenchido</c> verifica se os campos do formulário estão corretamente preenhidos
        /// </summary>
        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (tbNome.Text == "")
            {
                tbNome.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbNome.BackColor = Color.White;
            }
            if (tbMorada.Text == "")
            {
                tbMorada.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbMorada.BackColor = Color.White;
            }
            if (tbLocalidade.Text == "")
            {
                tbLocalidade.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbLocalidade.BackColor = Color.White;
            }
            if (!tbCodPostal.MaskCompleted)
            {
                tbCodPostal.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbCodPostal.BackColor = Color.White;
            }
            if (!tbNif.MaskCompleted)
            {
                tbNif.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbNif.BackColor = Color.White;
            }
            if (!tbTelefone.MaskCompleted)
            {
                tbTelefone.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbTelefone.BackColor = Color.White;
            }

            return preenchido;
        }
        /// <summary>
        /// Método <c>btAlterar_Click</c> altera os valores na base de dados
        /// </summary>
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                Fornecedor fornecedor = retrosaria.FornecedorSet.Single(a => a.Id == _fornecedor.Id);
                fornecedor.Nome = tbNome.Text;
                fornecedor.Morada = tbMorada.Text;
                fornecedor.Localidade = tbLocalidade.Text;
                fornecedor.CodigoPostal = tbCodPostal.Text;
                fornecedor.NIF = tbNif.Text;
                fornecedor.Telefone = tbTelefone.Text;
                retrosaria.SaveChanges();
                this.Close();
            }
        }
    }
}

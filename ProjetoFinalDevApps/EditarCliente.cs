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
    public partial class EditarCliente : Form
    {
        private Cliente _cliente;

        public EditarCliente(Cliente cliente)
        {
            InitializeComponent();
            this._cliente = cliente;
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            CarregarCampos();
        }

        /// <summary>
        /// Método <c>CarregarCampos</c> carrega os dados do fornecedor para os campos do formulário
        /// </summary>
        private void CarregarCampos()
        {
            tbNome.Text = _cliente.Nome;
            tbMorada.Text = _cliente.Morada;
            tbLocalidade.Text = _cliente.Localidade;
            tbCodPostal.Text = _cliente.Codigo_Postal;
            tbNif.Text = _cliente.NIF;
            tbTelefone.Text = _cliente.Telefone_Contacto;
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
                Cliente cliente = retrosaria.ClienteSet.Single(a => a.Id == _cliente.Id);
                cliente.Nome = tbNome.Text;
                cliente.Morada = tbMorada.Text;
                cliente.Localidade = tbLocalidade.Text;
                cliente.Codigo_Postal = tbCodPostal.Text;
                cliente.NIF = tbNif.Text;
                cliente.Telefone_Contacto = tbTelefone.Text;
                retrosaria.SaveChanges();
                this.Close();
            }
        }

        /// <summary>
        /// Método <c>tbNome_KeyPress</c> proíbe o utilizador de inserir símbolos e números na <c>tbNome</c>
        /// </summary>
        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
    }
}

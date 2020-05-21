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
    public partial class GestaoClientes : Form
    {
        private RetrosariaModelContainer retrosaria;
        public GestaoClientes()
        {
            InitializeComponent();
        }

        //FUNÇÕES
        public void lerDadosCliente()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = retrosaria.ClienteSet.ToList();

            retrosaria.SaveChanges();
        }

        public void AtivarBotoes()
        {
            
            if (dgvClientes.SelectedRows.Count == 1)
            {
                btAlterar.Enabled = true;
                btApagar.Enabled = true;
            }
        }
        public void tirarSelecao()
        {
            dgvClientes.Rows[0].Selected = false;
            btAlterar.Enabled = false;
            btApagar.Enabled = false;
        }

        
        private void limpaCampos()
        {
            tbNome.Text = "";
            tbLocalidade.Text = "";
            tbMorada.Text = "";
            tbCodPostal.Text = "";
            tbNif.Text = "";
            tbTelefone.Text = "";
        }
        public void esconderColuna()
        {
            this.dgvClientes.Columns["Id"].Visible = false;
            this.dgvClientes.Columns["Pedido"].Visible = false;
        }

        public void mudaNomeColuna()
        {
            dgvClientes.Columns["Nome"].HeaderText = "Cliente";
            dgvClientes.Columns["Morada"].HeaderText = "Morada";
            dgvClientes.Columns["Localidade"].HeaderText = "Localidade";
            dgvClientes.Columns["Codigo_Postal"].HeaderText = "Código-Postal";
            dgvClientes.Columns["NIF"].HeaderText = "Nif";
            dgvClientes.Columns["Telefone_Contacto"].HeaderText = "Telefone";
        }

        //FUNÇÕES
        private void GestaoClientes_Load(object sender, EventArgs e)
        {
            
            retrosaria = new RetrosariaModelContainer();
            lerDadosCliente();
            esconderColuna();
            mudaNomeColuna();
            dgvClientes.Rows[0].Selected = false;
        }

        private void btCriar_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            //Obter informação digitada e atribuir esse valor às variàveis
            Cliente novoCliente = new Cliente();
            novoCliente.Nome = tbNome.Text;
            novoCliente.Localidade = tbLocalidade.Text;
            novoCliente.Morada = tbMorada.Text;
            novoCliente.Codigo_Postal = tbCodPostal.Text;
            novoCliente.NIF = tbNif.Text;
            novoCliente.Telefone_Contacto = tbTelefone.Text;

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

            if (preenchido)
            {
                //Adicionar cliente à base de dados
                retrosaria.ClienteSet.Add(novoCliente);
                retrosaria.SaveChanges();

                limpaCampos();

                //Atualizar DataGridView
                lerDadosCliente();
            }
        }

        private void btApagar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows == null)
            {
                MessageBox.Show("Selecione um Cliente");
            }
            else
            {
                string message = "Tem a certeza que deseja remover o cliente ?";
                string title = "Apagar cliente";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Cliente selecionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                    tbNome.Text = selecionado.Nome;
                    retrosaria.ClienteSet.Remove(selecionado);
                    retrosaria.SaveChanges();

                }

                lerDadosCliente();
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                Cliente selecionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                
                EditarCliente editar = new EditarCliente(selecionado);
                editar.ShowDialog(this);
               
            }
            else
            {
                MessageBox.Show("Selecione um cliente");
            }
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbNome_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void dgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void GestaoClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            retrosaria.SaveChanges();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AtivarBotoes();
        }
    }
}

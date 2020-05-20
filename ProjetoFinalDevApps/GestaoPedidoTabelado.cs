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
    public partial class GestaoPedidoTabelado : Form
    {
        private RetrosariaModelContainer retrosaria;
        public GestaoPedidoTabelado()
        {
            InitializeComponent();
        }

        private void GestaoPedidoTabelado_Load(object sender, EventArgs e)
        {
            carregarClientes();
            
        }



        
        private void carregarClientes()
        {
            RetrosariaModelContainer entidades = new RetrosariaModelContainer();
            List<Cliente> clientes = (from cliente in entidades.ClienteSet
                                      select cliente).ToList();

            //Insert the Default Item to List.
            clientes.Insert(0, new Cliente
            {
                Nome = "Selecione um cliente",
                Id = 0
            });

            //Assign Entity as DataSource.
            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";

            //FUNÇÕES 
        }

        private void btTrabalho_Click(object sender, EventArgs e)
        {
            string nomeCliente = cbCliente.Text;

            if (cbCliente.Text == "Selecione um cliente"  || tbObservacoes.Text == "" )
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                NovoTrabalho trabalho = new NovoTrabalho(nomeCliente);
                trabalho.ShowDialog(this);
            }
            
            
        }

        //FUNÇÕES 

    }
}

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
    public partial class NovoPedido : Form
    {
        private RetrosariaModelContainer retrosaria;
        public NovoPedido()
        {
            InitializeComponent();
        }

        void AtualizarPedidos() => (Owner as GestaoPedidos).AtualizarPedidos();

        private void limpaCampos()
        {
            cbCliente.SelectedIndex = 1;
            rbOrcamento.Checked = false;
            rbPedidoTabelado.Checked = false;
            tbObservacoes.Text = "";
        }
        private void NovoPedido_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
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

        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            Pedido novoPedido = new Pedido();
            novoPedido.Pago = false;
            novoPedido.Levantado = false;
            novoPedido.DataPedido = dtpDataPedido.Value.Date;
            novoPedido.TipoPedido = getSelectedRadioButtonName();
            novoPedido.Observacoes = tbObservacoes.Text;
            novoPedido.ClienteId = Int32.Parse(cbCliente.SelectedValue.ToString());

                    
            //Verificar se todos os campos estão preenchidos
            if (cbCliente.Text == "Selecione um cliente")
            {
                cbCliente.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                cbCliente.BackColor = Color.White;
            }
            if (tbObservacoes.Text == "")
            {
                tbObservacoes.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbObservacoes.BackColor = Color.White;
            }
            if (preenchido)
            {
                retrosaria.PedidoSet.Add(novoPedido);
                retrosaria.SaveChanges();
            }

            AtualizarPedidos();
            limpaCampos();

        }
        private String getSelectedRadioButtonName()
        {
            foreach (Control c in gbRadioButtons.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text;
                }
            }
            return "Nenhum foi selecionado";
        }

        private void rbOrcamento_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

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
    public partial class NovoOrcamento : Form
    {

        private RetrosariaModelContainer retrosaria;
        public NovoOrcamento()
        {
            InitializeComponent();
        }

        //FUNÇÔES
        void AtualizarPedidos() => (Owner as GestaoOrcamento).AtualizarPedidos();
        private void carregar_cbCliente()
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
        }

        private void validarCheckBoxClick()
        {
            if (ckPago.Checked == true)
            {
                ckLevantado.Enabled = true;
            }
            if (ckPago.Checked == false)
            {
                ckLevantado.Enabled = false;
                ckLevantado.Checked = false;
            }
        }

        //FUNÇÕES
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NovoOrcamento_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregar_cbCliente();
        }

        private void btRegistarOrcamento_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            Orcamento novoOrcamento = new Orcamento();
            novoOrcamento.Pago = ckPago.Checked;
            novoOrcamento.Levantado = ckLevantado.Checked;
            novoOrcamento.Aceite = ckAceite.Checked;
            novoOrcamento.DataPedido = dtpPedido.Value.Date;
            novoOrcamento.TipoPedido = "Orçamento";
            novoOrcamento.Observacoes = tbObservacoes.Text;
            novoOrcamento.Descricao = tbDescricao.Text;
            novoOrcamento.Valor = Convert.ToDouble(nudValor.Value);
            novoOrcamento.ClienteId = Int32.Parse(cbCliente.SelectedValue.ToString());

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
                retrosaria.PedidoSet.Add(novoOrcamento);
                retrosaria.SaveChanges();
            }

            AtualizarPedidos();
            this.Close();
        }

        private void ckAceite_Click(object sender, EventArgs e)
        {
            if(ckAceite.Checked == true)
            {
                ckPago.Enabled = true;
            }
            else
            {
                ckPago.Enabled= false;
                ckPago.Checked = false;
                ckLevantado.Enabled = false;
                ckLevantado.Checked = false;

            }
        }

        private void ckPago_Click(object sender, EventArgs e)
        {
            validarCheckBoxClick();
        }
    }
}

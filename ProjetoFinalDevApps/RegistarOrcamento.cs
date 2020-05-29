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
    public partial class RegistarOrcamento : Form
    {

        private RetrosariaModelContainer retrosaria;
        private bool editar = false;
        private Orcamento _orcamento;
        public RegistarOrcamento()
        {
            InitializeComponent();
        }

        public RegistarOrcamento(Orcamento orcamento)
        {
            InitializeComponent();
            this._orcamento = orcamento;
            editar = true;
            btRegistarOrcamento.Text = "Guardar";
            cbCliente.Enabled = false;
            lbCliente.Enabled = false;
        }

        //FUNÇÔES
        private void carregar_cbCliente()
        {
            retrosaria = new RetrosariaModelContainer();

            //Assign Entity as DataSource.
            cbCliente.DataSource = retrosaria.ClienteSet.ToList();
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1;
        }

        private void CarregaCampos()
        {
            dtpPedido.Value = _orcamento.DataPedido;
            tbObservacoes.Text = _orcamento.Observacoes;
            tbDescricao.Text = _orcamento.Descricao;
            nudValor.Value = Convert.ToDecimal(_orcamento.Valor);
            ckAceite.Checked = _orcamento.Aceite;
            ckPago.Checked = _orcamento.Pago;
            ckLevantado.Checked = _orcamento.Levantado;
        }

        private void ValidarCheckBoxClick()
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

        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (cbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente");
                preenchido = false;
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
            if (tbDescricao.Text == "")
            {
                tbDescricao.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbDescricao.BackColor = Color.White;
            }
            if (nudValor.Value == 0)
            {
                nudValor.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudValor.BackColor = Color.White;
            }
            return preenchido;
        }

        private void NovoOrcamento_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregar_cbCliente();
            
            if (editar)
            {
                CarregaCampos();
                cbCliente.SelectedValue = _orcamento.ClienteId;
            }
        }

        private void btRegistarOrcamento_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstaPreenchido())
                {
                    RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                    Orcamento orcamento;
                    if (!editar)
                    {
                        orcamento = new Orcamento();
                    }
                    else
                    {
                        orcamento = (Orcamento)retrosaria.PedidoSet.Single(a => a.Id == _orcamento.Id);
                    }
                    //Obter informação nos campos e atribui esse valor ao fornecedor
                    orcamento.Pago = ckPago.Checked;
                    orcamento.Levantado = ckLevantado.Checked;
                    orcamento.Aceite = ckAceite.Checked;
                    orcamento.DataPedido = dtpPedido.Value.Date;
                    orcamento.TipoPedido = "Orçamento";
                    orcamento.Observacoes = tbObservacoes.Text;
                    orcamento.Descricao = tbDescricao.Text;
                    orcamento.Valor = Convert.ToDouble(nudValor.Value);
                    orcamento.ClienteId = Int32.Parse(cbCliente.SelectedValue.ToString());
                    if (!editar)
                    {
                        retrosaria.PedidoSet.Add(orcamento);
                    }
                    retrosaria.SaveChanges();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            ValidarCheckBoxClick();
        }

        private void ckAceite_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAceite.Checked == true)
            {
                ckPago.Enabled = true;
                
            }
            else
            {
                ckPago.Enabled = false;
                ckPago.Checked = false;
                ckLevantado.Enabled = true;
                ckLevantado.Checked = false;
            }
        }

        private void ckPago_CheckedChanged(object sender, EventArgs e)
        {
            if (editar)
            {
                ckLevantado.Enabled = true;
            }
        }
    }
}

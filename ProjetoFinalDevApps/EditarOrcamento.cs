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
    public partial class EditarOrcamento : Form
    {
        private RetrosariaModelContainer retrosaria;

        private Orcamento _selecionado;
        public EditarOrcamento(Orcamento selecionado)
        {
            InitializeComponent();
            this._selecionado = selecionado;
        }

        //FUNÇÕES
        void salvarOrcamento() => (Owner as GestaoOrcamentos).salvarOrcamento();
        private void carregaCampos()
        {
            dtpPedido.Value = _selecionado.DataPedido;
            tbObservacoes.Text = _selecionado.Observacoes;
            tbDescricao.Text = _selecionado.Descricao;
            nudValor.Value = Convert.ToDecimal(_selecionado.Valor);
            ckAceite.Checked = _selecionado.Aceite;
            ckPago.Checked = _selecionado.Pago;
            ckLevantado.Checked = _selecionado.Levantado;
        }

        private void EditarOrcamento_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregaCampos();
        }

        private void btAlterarOrcamento_Click(object sender, EventArgs e)
        {
            bool preenchido = true;

            _selecionado.DataPedido = dtpPedido.Value;
            _selecionado.Observacoes = tbObservacoes.Text;
            _selecionado.Descricao = tbDescricao.Text;
            _selecionado.Valor = Convert.ToDouble(nudValor.Value);
            _selecionado.Aceite = ckAceite.Checked;
            _selecionado.Pago = ckPago.Checked;
            _selecionado.Levantado = ckPago.Checked;

            
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
                salvarOrcamento();
            }


            this.Close();
        }
    }
}

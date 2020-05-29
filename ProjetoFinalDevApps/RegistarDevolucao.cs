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
    public partial class RegistarDevolucao : Form
    {
        private RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
        private PedidoTabelado _pedido;
        private Devolucao _devolucao;
        private bool editar = false;

        public RegistarDevolucao(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }

        public RegistarDevolucao(Devolucao devolucao)
        {
            InitializeComponent();
            this._devolucao = devolucao;
            editar = true;
        }

        private void RegistarDevolucao_Load(object sender, EventArgs e)
        {
            CarregarDados();

            if (editar)
            {
                dgvTrabalhos.Enabled = false;
                btAdd.Enabled = false;
                btRem.Enabled = false;
                btLimpar.Enabled = false;
                btDevolverTodos.Enabled = false;
                dtpData.Enabled = false;
                btRegistar.Text = "Guardar";
            }
            
        }

        private void CarregarDados()
        {
            if (editar)
            {
                bsSelecionados.DataSource = retrosaria.TrabalhoSet.Where(u => u.DevolucaoId == _devolucao.Id).ToList();
                tbDescricao.Text = _devolucao.Descricao;
                dtpData.Value = _devolucao.DataDevolucao;
            }
            else
            {
                bsTrabalhos.DataSource = retrosaria.TrabalhoSet.Where(u => u.PedidoTabeladoId == _pedido.Id && u.DevolucaoId == null).ToList();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (dgvTrabalhos.SelectedRows.Count != 0)
            {
                Trabalho trabalho = (Trabalho)dgvTrabalhos.CurrentRow.DataBoundItem;
                bsTrabalhos.Remove(trabalho);
                bsSelecionados.Add(trabalho);
            }
        }

        private void btRem_Click(object sender, EventArgs e)
        {
            if (dgvSelecionado.SelectedRows.Count != 0)
            {
                Trabalho trabalho = (Trabalho)dgvSelecionado.CurrentRow.DataBoundItem;
                bsSelecionados.Remove(trabalho);
                bsTrabalhos.Add(trabalho);
            }
            
        }

        private void btDevolverTodos_Click(object sender, EventArgs e)
        {
            foreach (var item in bsTrabalhos)
            {
                bsSelecionados.Add(item);
            }
            bsTrabalhos.DataSource = new Trabalho();
            bsTrabalhos.DataSource = null;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            foreach (var item in bsSelecionados)
            {
                bsTrabalhos.Add(item);
            }
            bsSelecionados.DataSource = new Trabalho();
            bsSelecionados.DataSource = null;
        }

        private void btRegistar_Click(object sender, EventArgs e)
        {
            if (dgvSelecionado.Rows.Count != 0 || editar)
            {
                Devolucao devolucao;
                if (!editar)
                {
                    devolucao = new Devolucao();
                    devolucao.PedidoId = _pedido.Id;
                    devolucao.DataDevolucao = dtpData.Value;
                }
                else
                {
                    devolucao = (Devolucao)retrosaria.DevolucaoSet.Single(a => a.Id == _devolucao.Id);
                }
                devolucao.Descricao = tbDescricao.Text;
                if (!editar)
                    retrosaria.DevolucaoSet.Add(devolucao);

                retrosaria.SaveChanges();
                if (!editar)
                {
                    foreach (Trabalho trabalho in bsSelecionados)
                    {
                        trabalho.DevolucaoId = devolucao.Id;
                        trabalho.Levantado = true;
                        trabalho.DataLevantamento = dtpData.Value;
                        trabalho.Devolucao = devolucao;
                    }
                    retrosaria.SaveChanges();

                    List<Trabalho> trabalhos = retrosaria.TrabalhoSet.Where(u => u.PedidoTabeladoId == _pedido.Id && u.DevolucaoId == null).ToList();
                
                    if (trabalhos.Count == 0)
                    {
                        PedidoTabelado pedido = (PedidoTabelado)retrosaria.PedidoSet.Single(d => d.Id == _pedido.Id);
                        pedido.Levantado = true;
                        retrosaria.SaveChanges();
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione no mínimo um trabalho");
            }
        }
    }
}

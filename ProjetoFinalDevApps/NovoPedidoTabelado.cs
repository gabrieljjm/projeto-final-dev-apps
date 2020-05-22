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
    public partial class NovoPedidoTabelado : Form
    {
        private RetrosariaModelContainer retrosaria;
        public static List<Trabalho> listaTrabalhos = new List<Trabalho>();


        public static List<Devolucao> listaDevolucao = new List<Devolucao>();
        public void recebeTrabalho(Trabalho trblh, Devolucao dev)
        {
            listaDevolucao.Add(dev);
            listaTrabalhos.Add(trblh);
            carregarTrabalhos();
        }

        public NovoPedidoTabelado()
        {
            InitializeComponent();
        }

        private void GestaoPedidoTabelado_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarClientes();
            
        }

        private void carregarTrabalhos()
        {
            bsTrabalhos.DataSource = listaTrabalhos.ToList();
        }

        private void carregarClientes()
        {
            cbCliente.DataSource = retrosaria.ClienteSet.ToList();
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
            cbCliente.SelectedIndex = -1; 
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

        private void GestaoPedidoTabelado_Activated(object sender, EventArgs e)
        {
            
        }

        private void btRegistarTabelado_Click(object sender, EventArgs e)
        {
            if (listaTrabalhos.Count != 0)
            {
                PedidoTabelado pedido = new PedidoTabelado();
                pedido.DataPedido = dtpPedido.Value;
                pedido.Observacoes = tbObservacoes.Text;
                pedido.ClienteId = Int32.Parse(cbCliente.SelectedValue.ToString());
                pedido.Levantado = false;
                pedido.Pago = true;
                pedido.TipoPedido = "Pedido tabelado";
                retrosaria.PedidoSet.Add(pedido);
                retrosaria.SaveChanges();

                pedido = (PedidoTabelado)retrosaria.PedidoSet.OrderByDescending(p => p.Id).FirstOrDefault();
                

                var zip = listaDevolucao.Zip(listaTrabalhos, (n, p) => new { listaDevolucao= n, listaTrabalhos = p } );

                foreach (var item in zip)
                {
                    
                    item.listaDevolucao.PedidoId = pedido.Id;
                    retrosaria.DevolucaoSet.Add(item.listaDevolucao);
                    retrosaria.SaveChanges();

                    Devolucao dev = retrosaria.DevolucaoSet.OrderByDescending(p => p.Id).FirstOrDefault();

                    item.listaTrabalhos.DevolucaoId = dev.Id; 
                    item.listaTrabalhos.PedidoTabeladoId = pedido.Id;
                    //item.listaTrabalhos.PedidoTabelado = (PedidoTabelado)retrosaria.PedidoSet.Where(u => u.Id == idPedidoTabelado).FirstOrDefault();
                    //item.listaTrabalhos.Devolucao = (Devolucao)retrosaria.DevolucaoSet.Where(u => u.Id == idDevolucao).FirstOrDefault();
                    retrosaria.TrabalhoSet.Add(item.listaTrabalhos);
                    retrosaria.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Adicione um trabalho.");
            }
        }
    }
}

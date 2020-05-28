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
    public partial class NovoTrabalho : Form
    {
       
        private RetrosariaModelContainer retrosaria;
        private PedidoTabelado _pedido;
        public NovoTrabalho(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }

        private bool EstaPreenchido()
        {
            bool preenchido = true;

            //Verificar se todos os campos estão preenchidos
            if (tbDescricaoPeca.Text == "")
            {
                tbDescricaoPeca.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbDescricaoPeca.BackColor = Color.White;
            }
            if (tbCorPeca.Text == "")
            {
                tbCorPeca.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                tbCorPeca.BackColor = Color.White;
            }
            if (nudValorPago.Value == 0)
            {
                nudValorPago.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                nudValorPago.BackColor = Color.White;
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
            if (cbPeca.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha uma peça.");
                preenchido = false;
            }
            if (cbArranjo.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha um arranjo.");
                preenchido = false;
            }


            return preenchido;
        }
        private void carregarComboboxPeca()
        {
            
            //Assign Entity as DataSource.
            cbPeca.DataSource = retrosaria.PecaSet.ToList();
            cbPeca.DisplayMember = "TipoPeca";
            cbPeca.ValueMember = "Id";

            cbPeca.SelectedIndex = -1;
        }

        private void NovoTrabalho_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarComboboxPeca();
        }

        private void cbArranjo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("cbArranjo - " + cbArranjo.SelectedValue);
        }

        private void cbPeca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbPeca.SelectedIndex != -1)
                {
                    int pecaid = Int32.Parse(cbPeca.SelectedValue.ToString());
                    Console.WriteLine("cbPeca - " + cbPeca.SelectedValue);
                    List<PecaArranjo> listaPecaArranjo = retrosaria.PecaArranjoSet.Where(u => u.PecaId == pecaid).ToList();
                    if (listaPecaArranjo.Count != 0)
                    {
                        List<Arranjo> listaArranjo = new List<Arranjo>();
                        foreach (PecaArranjo pecaarranjo in listaPecaArranjo)
                        {
                            foreach (Arranjo arranjo in retrosaria.ArranjoSet)
                            {
                                if (pecaarranjo.ArranjoId == arranjo.Id)
                                {
                                    listaArranjo.Add(arranjo);
                                }
                            }
                        }
                        cbArranjo.DataSource = listaArranjo.ToList();
                        cbArranjo.DisplayMember = "TipoArranjo";
                        cbArranjo.ValueMember = "Id";
                        cbArranjo.SelectedIndex = -1;
                        cbArranjo.Enabled = true;
                    }
                    else
                    {
                        cbArranjo.Enabled = false;
                        cbArranjo.DataSource = null;
                    }
                }
                else
                {
                    cbArranjo.Enabled = false;
                    cbArranjo.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void btRegistar_Click(object sender, EventArgs e)
        {
            if (EstaPreenchido())
            {
                Trabalho novoTrabalho = new Trabalho();

                int pecaid = Int32.Parse(cbPeca.SelectedValue.ToString());
                int arranjoid = Int32.Parse(cbArranjo.SelectedValue.ToString());

                novoTrabalho.DescricaoPeca = tbDescricaoPeca.Text;
                novoTrabalho.CorPeca = tbCorPeca.Text;
                novoTrabalho.ValorPago = Convert.ToInt32(nudValorPago.Value);
                novoTrabalho.DataLevantamento = dtpLevantamento.Value;
                novoTrabalho.Observacoes = tbObservacoes.Text;
                novoTrabalho.PecaArranjo = retrosaria.PecaArranjoSet.Where(u => u.PecaId == pecaid && u.ArranjoId == arranjoid).FirstOrDefault();
                novoTrabalho.Levantado = false;
                novoTrabalho.Pago = true;
                //novoTrabalho.DevolucaoId = 1;
                novoTrabalho.PedidoTabelado = (PedidoTabelado)retrosaria.PedidoSet.Where(u => u.Id == _pedido.Id).FirstOrDefault();
                novoTrabalho.PedidoTabeladoId = _pedido.Id;

                retrosaria.TrabalhoSet.Add(novoTrabalho);
                retrosaria.SaveChanges();

                this.Close();
            }
        }
    }
}

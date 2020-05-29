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
    public partial class RegistarTrabalho : Form
    {
       
        private RetrosariaModelContainer retrosaria;
        private PedidoTabelado _pedido;
        private Trabalho _trabalho;
        private bool editar = false;
        public RegistarTrabalho(PedidoTabelado pedido)
        {
            InitializeComponent();
            this._pedido = pedido;
        }

        public RegistarTrabalho(Trabalho trabalho)
        {
            InitializeComponent();
            this._trabalho = trabalho;
            editar = true;
            btRegistar.Text = "Guardar";
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
            if (cbCor.SelectedIndex == -1)
            {
                cbCor.BackColor = Color.Aqua;
                preenchido = false;
            }
            else
            {
                cbCor.BackColor = Color.White;
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

        private void CarregarCampos()
        {
            tbDescricaoPeca.Text = _trabalho.DescricaoPeca;
            cbCor.Text = _trabalho.CorPeca;
            dtpLevantamento.Value = _trabalho.DataLevantamento;
            tbObservacoes.Text = _trabalho.Observacoes;
            cbPeca.SelectedValue = _trabalho.PecaArranjo.PecaId;
            cbArranjo.SelectedValue = _trabalho.PecaArranjo.ArranjoId;
        }

        private void NovoTrabalho_Load(object sender, EventArgs e)
        {
            retrosaria = new RetrosariaModelContainer();
            carregarComboboxPeca();
            cbCor.SelectedIndex = -1;
            if (editar)
            {
                CarregarCampos();
            }
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
            int pecaid = Int32.Parse(cbPeca.SelectedValue.ToString());
            int arranjoid = Int32.Parse(cbArranjo.SelectedValue.ToString());

          
            if (EstaPreenchido())
            {
                RetrosariaModelContainer retrosaria = new RetrosariaModelContainer();
                Trabalho trabalho;
                if (!editar)
                {
                    trabalho = new Trabalho();
                    PedidoTabelado pedido = (PedidoTabelado)retrosaria.PedidoSet.Single(a => a.Id == _pedido.Id);
                    trabalho.PedidoTabelado = pedido;
                    trabalho.PedidoTabeladoId = pedido.Id;
                }
                else
                {
                    trabalho = retrosaria.TrabalhoSet.Single(a => a.Id == _trabalho.Id);
                }
                //Obter informação nos campos e atribui esse valor ao trabalho

                PecaArranjo pecaarranjo = retrosaria.PecaArranjoSet.Where(u => u.PecaId == pecaid && u.ArranjoId == arranjoid).FirstOrDefault();

                trabalho.DescricaoPeca = tbDescricaoPeca.Text;
                trabalho.CorPeca = cbCor.Text;
                trabalho.ValorPago = pecaarranjo.Preco;
                trabalho.DataLevantamento = dtpLevantamento.Value;
                trabalho.Pago = true;
                trabalho.Levantado = false;
                trabalho.Observacoes = tbObservacoes.Text;
                trabalho.PecaArranjo = pecaarranjo;
                    
                if (!editar)
                {
                    retrosaria.TrabalhoSet.Add(trabalho);
                }
                retrosaria.SaveChanges();
                this.Close();
            }
            
        }

        private void tbObservacoes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

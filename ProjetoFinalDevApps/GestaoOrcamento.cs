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
    public partial class GestaoOrcamento : Form
    {
        public GestaoOrcamento()
        {
            InitializeComponent();
        }

        private void btNovoOrcamento_Click(object sender, EventArgs e)
        {
            NovoOrcamento novoOrcamento = new NovoOrcamento();
            novoOrcamento.ShowDialog();
        }
    }
}

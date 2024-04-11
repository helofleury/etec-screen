using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etec.Bill.UI
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }
        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            TelaFuncionarios TelaFuncionarios = new TelaFuncionarios();
            TelaFuncionarios.Show();
            this.Hide();
        }

        private void BtnFornecedor_Click(object sender, EventArgs e)
        {
            TelaFornecedor TelaFornecedor = new TelaFornecedor();
            TelaFornecedor.Show();
            this.Hide();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            TelaCliente TelaCliente = new TelaCliente();
            TelaCliente.Show();
            this.Hide();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Hide();
        }
    }
}

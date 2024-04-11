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
    public partial class TelaEsqueciSenha : Form
    {
        public TelaEsqueciSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtSenhaA.Text == "")
            {
                MessageBox.Show("Campo SENHA ATUAL não preenchido");
            }
            else if (TxtSenhaN.Text == "")
            {
                MessageBox.Show("Campo NOVA SENHA não preenchido");
            }
            else if (TxtSenhaNConf.Text == "")
            {
                MessageBox.Show("Campo CONFIRMAR NOVA SENHA não preenchido");
            }
            else if (TxtSenhaA.Text != "bill")
            {
                MessageBox.Show("SENHA ATUAL incoretta");
            }
            else if (TxtSenhaN.Text =="bill")
            {
                MessageBox.Show("NOVA SENHA nao pode ser igual a SENHA ATUAL");
            }
            else if (TxtSenhaNConf.Text == "bill")
            {
                MessageBox.Show("CONFIRMAR SENHA nao pode ser igual a SENHA ATUAL");
            }
            else if (TxtSenhaN.Text != TxtSenhaNConf.Text)
            {
                MessageBox.Show("CONFIRMAR SENHA deve ser igual a NOVA SENHA");
            }
            else if (TxtSenhaA.Text=="bill" && TxtSenhaN.Text == TxtSenhaNConf.Text)
            {
                MessageBox.Show("SENHA ALTERADA");
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Form1 TelaLogin = new Form1();
            TelaLogin.Show();
            this.Hide();
        }
    }
}

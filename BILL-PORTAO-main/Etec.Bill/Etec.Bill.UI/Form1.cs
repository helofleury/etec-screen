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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "bill" && TxtPass.Text == "portao")
            {
                MessageBox.Show("Seja bem-Vindo!!!");
                TelaMenu TelaMenu = new TelaMenu();
                TelaMenu.Show();
                this.Hide();
            }
            else if (TxtUser.Text == "" )
            {
                MessageBox.Show("Campo USUARIO não preenchido");
            }
            else if (TxtPass.Text == "")
            {
                MessageBox.Show("Campo SENHA não preenchido");
            }
            else if (TxtUser.Text != "bill") 
            {
                MessageBox.Show("Usuario INCORRETO");
            }
            else if (TxtPass.Text != "bill")
            {
                MessageBox.Show("Senha INCORRETO");
            }
        }

        private void LblSetPass_Click(object sender, EventArgs e)
        {
            TelaEsqueciSenha TelaEsqueciSenha = new TelaEsqueciSenha();
            TelaEsqueciSenha.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

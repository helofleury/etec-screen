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
    public partial class TelaFornecedor : Form
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            TelaMenu TelaMenu = new TelaMenu();
            TelaMenu.Show();
            this.Hide();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (TxtName.Text != "" && TxtCpf.Text != "" &&
                TxtTelefone.Text != "" && TxtMail.Text != "" &&
                TxtRua.Text != "" && TxtCidade.Text != "" && TxtProduto.Text != "")
            {
                MessageBox.Show("Cadastro concluido");
                TxtName.Text = "";
                TxtCpf.Text = "";
                TxtTelefone.Text = "";
                TxtMail.Text = "";
                TxtRua.Text = "";
                TxtCidade.Text = "";
                TxtProduto.Text = "";
            }
            else if (TxtName.Text == "")
            {
                MessageBox.Show("Campo NOME não preenchido");
            }
            else if (TxtCpf.Text == "")
            {
                MessageBox.Show("Campo CPF/CNPJ não preenchido");
            }
            else if (TxtTelefone.Text == "")
            {
                MessageBox.Show("Campo TELEFONE não preenchido");
            }
            else if (TxtMail.Text == "")
            {
                MessageBox.Show("Campo E-MAIL não preenchido");
            }
            else if (TxtRua.Text == "")
            {
                MessageBox.Show("Campo RUA não preenchido");
            }
            else if (TxtCidade.Text == "")
            {
                MessageBox.Show("Campo CIDADE não preenchido");
            }
            else if (TxtProduto.Text == "")
            {
                MessageBox.Show("Campo PRODUTO não preenchido");
            }
        }

        private void BtnLimparCampos_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtCpf.Text = "";
            TxtTelefone.Text = "";
            TxtMail.Text = "";
            TxtRua.Text = "";
            TxtCidade.Text = "";
            TxtProduto.Text = "";
        }
    }
}

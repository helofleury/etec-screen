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
    public partial class TelaFuncionarios : Form
    {
        public TelaFuncionarios()
        {
            InitializeComponent();
        }

        private void TelaFuncionarios_Load(object sender, EventArgs e)
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
                TxtTurno.Text != "" &&
                TxtTelefone.Text != "" && TxtMail.Text != "" &&
                TxtRua.Text != "" && TxtCidade.Text != "")
            {
                MessageBox.Show("Cadastro concluido");
                TxtName.Text = "";
                TxtCpf.Text = "";
                TxtTurno.Text = "";
                TxtTelefone.Text = "";
                TxtMail.Text = "";
                TxtRua.Text = "";
                TxtCidade.Text = "";
            }
            else if (TxtName.Text == "")
            {
                MessageBox.Show("Campo NOME não preenchido");
            }
            else if (TxtCpf.Text == "")
            {
                MessageBox.Show("Campo CPF/CNPJ não preenchido");
            }
            else if (TxtTurno.Text == "")
            {
                MessageBox.Show("Campo TURNO não preenchido");
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
        }

        private void BtnLimparCampos_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtCpf.Text = "";
            TxtTurno.Text = "";
            TxtTelefone.Text = "";
            TxtMail.Text = "";
            TxtRua.Text = "";
            TxtCidade.Text = "";
        }
    }
}

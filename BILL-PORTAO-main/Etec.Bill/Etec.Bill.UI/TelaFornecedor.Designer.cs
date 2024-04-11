
namespace Etec.Bill.UI
{
    partial class TelaFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.LblRuaNum = new System.Windows.Forms.Label();
            this.LblMail = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblTitleFornecedor = new System.Windows.Forms.Label();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.LblProduto = new System.Windows.Forms.Label();
            this.BtnLimparCampos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtCidade
            // 
            this.TxtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCidade.Location = new System.Drawing.Point(369, 282);
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(191, 20);
            this.TxtCidade.TabIndex = 25;
            // 
            // TxtRua
            // 
            this.TxtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRua.Location = new System.Drawing.Point(369, 242);
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(191, 20);
            this.TxtRua.TabIndex = 24;
            this.TxtRua.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // TxtMail
            // 
            this.TxtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMail.Location = new System.Drawing.Point(369, 204);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(191, 20);
            this.TxtMail.TabIndex = 23;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTelefone.Location = new System.Drawing.Point(369, 161);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(191, 20);
            this.TxtTelefone.TabIndex = 22;
            // 
            // TxtCpf
            // 
            this.TxtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCpf.Location = new System.Drawing.Point(369, 121);
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(191, 20);
            this.TxtCpf.TabIndex = 21;
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Location = new System.Drawing.Point(369, 82);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(191, 20);
            this.TxtName.TabIndex = 20;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Location = new System.Drawing.Point(280, 289);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(47, 13);
            this.LblCidade.TabIndex = 19;
            this.LblCidade.Text = "CIDADE";
            // 
            // LblRuaNum
            // 
            this.LblRuaNum.AutoSize = true;
            this.LblRuaNum.Location = new System.Drawing.Point(280, 249);
            this.LblRuaNum.Name = "LblRuaNum";
            this.LblRuaNum.Size = new System.Drawing.Size(83, 13);
            this.LblRuaNum.TabIndex = 18;
            this.LblRuaNum.Text = "RUA/NÚMERO";
            // 
            // LblMail
            // 
            this.LblMail.AutoSize = true;
            this.LblMail.Location = new System.Drawing.Point(280, 211);
            this.LblMail.Name = "LblMail";
            this.LblMail.Size = new System.Drawing.Size(42, 13);
            this.LblMail.TabIndex = 17;
            this.LblMail.Text = "E-MAIL";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(280, 168);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(63, 13);
            this.LblTelefone.TabIndex = 16;
            this.LblTelefone.Text = "TELEFONE";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Location = new System.Drawing.Point(280, 128);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(34, 13);
            this.LblCpf.TabIndex = 15;
            this.LblCpf.Text = "CNPJ";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(280, 89);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(39, 13);
            this.LblName.TabIndex = 14;
            this.LblName.Text = "NOME";
            // 
            // LblTitleFornecedor
            // 
            this.LblTitleFornecedor.AutoSize = true;
            this.LblTitleFornecedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleFornecedor.Location = new System.Drawing.Point(251, 33);
            this.LblTitleFornecedor.Name = "LblTitleFornecedor";
            this.LblTitleFornecedor.Size = new System.Drawing.Size(345, 29);
            this.LblTitleFornecedor.TabIndex = 13;
            this.LblTitleFornecedor.Text = "CADASTRO FORNECEDOR";
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(1, 0);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 41;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(369, 349);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(191, 24);
            this.BtnCadastrar.TabIndex = 42;
            this.BtnCadastrar.Text = "CONCLUIR";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxtProduto
            // 
            this.TxtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProduto.Location = new System.Drawing.Point(369, 313);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(191, 20);
            this.TxtProduto.TabIndex = 44;
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(280, 320);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(61, 13);
            this.LblProduto.TabIndex = 43;
            this.LblProduto.Text = "PRODUTO";
            // 
            // BtnLimparCampos
            // 
            this.BtnLimparCampos.Location = new System.Drawing.Point(407, 379);
            this.BtnLimparCampos.Name = "BtnLimparCampos";
            this.BtnLimparCampos.Size = new System.Drawing.Size(116, 23);
            this.BtnLimparCampos.TabIndex = 45;
            this.BtnLimparCampos.Text = "LIMPAR CAMPOS";
            this.BtnLimparCampos.UseVisualStyleBackColor = true;
            this.BtnLimparCampos.Click += new System.EventHandler(this.BtnLimparCampos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(75, 452);
            this.dataGridView1.TabIndex = 46;
            // 
            // TelaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnLimparCampos);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.TxtCidade);
            this.Controls.Add(this.TxtRua);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblCidade);
            this.Controls.Add(this.LblRuaNum);
            this.Controls.Add(this.LblMail);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblTitleFornecedor);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaFornecedor";
            this.Text = "TelaFornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.Label LblRuaNum;
        private System.Windows.Forms.Label LblMail;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblTitleFornecedor;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.Button BtnLimparCampos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
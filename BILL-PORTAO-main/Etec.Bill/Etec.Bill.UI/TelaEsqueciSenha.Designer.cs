
namespace Etec.Bill.UI
{
    partial class TelaEsqueciSenha
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
            this.LblTitleEsqSenha = new System.Windows.Forms.Label();
            this.LblSenhaAtual = new System.Windows.Forms.Label();
            this.TxtSenhaA = new System.Windows.Forms.TextBox();
            this.BtnConfirmar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.TxtSenhaNConf = new System.Windows.Forms.TextBox();
            this.LblNovaNConf = new System.Windows.Forms.Label();
            this.TxtSenhaN = new System.Windows.Forms.TextBox();
            this.LblSenhaN = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitleEsqSenha
            // 
            this.LblTitleEsqSenha.AutoSize = true;
            this.LblTitleEsqSenha.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleEsqSenha.Location = new System.Drawing.Point(344, 60);
            this.LblTitleEsqSenha.Name = "LblTitleEsqSenha";
            this.LblTitleEsqSenha.Size = new System.Drawing.Size(226, 29);
            this.LblTitleEsqSenha.TabIndex = 0;
            this.LblTitleEsqSenha.Text = "ALTERAR SENHA";
            // 
            // LblSenhaAtual
            // 
            this.LblSenhaAtual.AutoSize = true;
            this.LblSenhaAtual.Location = new System.Drawing.Point(260, 123);
            this.LblSenhaAtual.Name = "LblSenhaAtual";
            this.LblSenhaAtual.Size = new System.Drawing.Size(82, 13);
            this.LblSenhaAtual.TabIndex = 1;
            this.LblSenhaAtual.Text = "SENHA ATUAL";
            // 
            // TxtSenhaA
            // 
            this.TxtSenhaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenhaA.Location = new System.Drawing.Point(348, 116);
            this.TxtSenhaA.Name = "TxtSenhaA";
            this.TxtSenhaA.Size = new System.Drawing.Size(221, 20);
            this.TxtSenhaA.TabIndex = 2;
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.Location = new System.Drawing.Point(348, 228);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(222, 23);
            this.BtnConfirmar.TabIndex = 4;
            this.BtnConfirmar.Text = "ALTERAR SENHA";
            this.BtnConfirmar.UseVisualStyleBackColor = true;
            this.BtnConfirmar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(1, -1);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // TxtSenhaNConf
            // 
            this.TxtSenhaNConf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenhaNConf.Location = new System.Drawing.Point(348, 189);
            this.TxtSenhaNConf.Name = "TxtSenhaNConf";
            this.TxtSenhaNConf.Size = new System.Drawing.Size(221, 20);
            this.TxtSenhaNConf.TabIndex = 7;
            // 
            // LblNovaNConf
            // 
            this.LblNovaNConf.AutoSize = true;
            this.LblNovaNConf.Location = new System.Drawing.Point(198, 196);
            this.LblNovaNConf.Name = "LblNovaNConf";
            this.LblNovaNConf.Size = new System.Drawing.Size(144, 13);
            this.LblNovaNConf.TabIndex = 6;
            this.LblNovaNConf.Text = "CONFIRMAR NOVA SENHA";
            // 
            // TxtSenhaN
            // 
            this.TxtSenhaN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenhaN.Location = new System.Drawing.Point(348, 152);
            this.TxtSenhaN.Name = "TxtSenhaN";
            this.TxtSenhaN.Size = new System.Drawing.Size(221, 20);
            this.TxtSenhaN.TabIndex = 9;
            // 
            // LblSenhaN
            // 
            this.LblSenhaN.AutoSize = true;
            this.LblSenhaN.Location = new System.Drawing.Point(260, 159);
            this.LblSenhaN.Name = "LblSenhaN";
            this.LblSenhaN.Size = new System.Drawing.Size(77, 13);
            this.LblSenhaN.TabIndex = 8;
            this.LblSenhaN.Text = "NOVA SENHA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(75, 452);
            this.dataGridView1.TabIndex = 10;
            // 
            // TelaEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtSenhaN);
            this.Controls.Add(this.LblSenhaN);
            this.Controls.Add(this.TxtSenhaNConf);
            this.Controls.Add(this.LblNovaNConf);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnConfirmar);
            this.Controls.Add(this.TxtSenhaA);
            this.Controls.Add(this.LblSenhaAtual);
            this.Controls.Add(this.LblTitleEsqSenha);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaEsqueciSenha";
            this.Text = "TelaEsqueciSenha";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitleEsqSenha;
        private System.Windows.Forms.Label LblSenhaAtual;
        private System.Windows.Forms.TextBox TxtSenhaA;
        private System.Windows.Forms.Button BtnConfirmar;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.TextBox TxtSenhaNConf;
        private System.Windows.Forms.Label LblNovaNConf;
        private System.Windows.Forms.TextBox TxtSenhaN;
        private System.Windows.Forms.Label LblSenhaN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
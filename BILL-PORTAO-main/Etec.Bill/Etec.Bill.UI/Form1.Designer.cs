
namespace Etec.Bill.UI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblSetPass = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblSetPass
            // 
            this.LblSetPass.AutoSize = true;
            this.LblSetPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblSetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetPass.Location = new System.Drawing.Point(332, 197);
            this.LblSetPass.Name = "LblSetPass";
            this.LblSetPass.Size = new System.Drawing.Size(79, 13);
            this.LblSetPass.TabIndex = 16;
            this.LblSetPass.Text = "Esqueci Senha";
            this.LblSetPass.Click += new System.EventHandler(this.LblSetPass_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(12, 415);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "SAIR";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnEnter
            // 
            this.BtnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEnter.Location = new System.Drawing.Point(331, 228);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(169, 23);
            this.BtnEnter.TabIndex = 14;
            this.BtnEnter.Text = "CONFIRMAR";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(300, 65);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(200, 29);
            this.LblTitle.TabIndex = 13;
            this.LblTitle.Text = "BILL PORTÕES";
            this.LblTitle.Click += new System.EventHandler(this.LblTitle_Click);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Location = new System.Drawing.Point(281, 177);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(44, 13);
            this.LblPass.TabIndex = 12;
            this.LblPass.Text = "SENHA";
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(269, 142);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(56, 13);
            this.LblUser.TabIndex = 11;
            this.LblUser.Text = "USUÁRIO";
            // 
            // TxtPass
            // 
            this.TxtPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtPass.Location = new System.Drawing.Point(331, 170);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(169, 20);
            this.TxtPass.TabIndex = 10;
            // 
            // TxtUser
            // 
            this.TxtUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtUser.Location = new System.Drawing.Point(331, 135);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(169, 20);
            this.TxtUser.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblSetPass);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSetPass;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtUser;
    }
}


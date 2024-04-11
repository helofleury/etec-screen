
namespace Etec.Bill.UI
{
    partial class TelaMenu
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
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnFuncionarios = new System.Windows.Forms.Button();
            this.BtnFornecedor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.LblTitleFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(234, 189);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(104, 23);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "CLIENTE";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnFuncionarios
            // 
            this.BtnFuncionarios.Location = new System.Drawing.Point(380, 189);
            this.BtnFuncionarios.Name = "BtnFuncionarios";
            this.BtnFuncionarios.Size = new System.Drawing.Size(104, 23);
            this.BtnFuncionarios.TabIndex = 1;
            this.BtnFuncionarios.Text = "FUNCIONÁRIO";
            this.BtnFuncionarios.UseVisualStyleBackColor = true;
            this.BtnFuncionarios.Click += new System.EventHandler(this.BtnFuncionarios_Click);
            // 
            // BtnFornecedor
            // 
            this.BtnFornecedor.Location = new System.Drawing.Point(529, 189);
            this.BtnFornecedor.Name = "BtnFornecedor";
            this.BtnFornecedor.Size = new System.Drawing.Size(104, 23);
            this.BtnFornecedor.TabIndex = 2;
            this.BtnFornecedor.Text = "FORNECEDOR";
            this.BtnFornecedor.UseVisualStyleBackColor = true;
            this.BtnFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(75, 452);
            this.dataGridView1.TabIndex = 6;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Location = new System.Drawing.Point(2, 0);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(75, 23);
            this.BtnVoltar.TabIndex = 7;
            this.BtnVoltar.Text = "VOLTAR";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // LblTitleFornecedor
            // 
            this.LblTitleFornecedor.AutoSize = true;
            this.LblTitleFornecedor.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleFornecedor.Location = new System.Drawing.Point(229, 76);
            this.LblTitleFornecedor.Name = "LblTitleFornecedor";
            this.LblTitleFornecedor.Size = new System.Drawing.Size(404, 29);
            this.LblTitleFornecedor.TabIndex = 27;
            this.LblTitleFornecedor.Text = "SELECIONE UMA DAS OPÇÔES";
            // 
            // TelaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTitleFornecedor);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnFornecedor);
            this.Controls.Add(this.BtnFuncionarios);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaMenu";
            this.Text = "TelaMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnFuncionarios;
        private System.Windows.Forms.Button BtnFornecedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label LblTitleFornecedor;
    }
}
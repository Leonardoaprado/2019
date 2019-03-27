namespace SistemaBasico
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCProdutos = new System.Windows.Forms.Button();
            this.btnCFuncionarios = new System.Windows.Forms.Button();
            this.btnCClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::SistemaBasico.Properties.Resources._1;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(323, 134);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(131, 73);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCProdutos
            // 
            this.btnCProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCProdutos.Image = global::SistemaBasico.Properties.Resources._3;
            this.btnCProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCProdutos.Location = new System.Drawing.Point(12, 134);
            this.btnCProdutos.Name = "btnCProdutos";
            this.btnCProdutos.Size = new System.Drawing.Size(197, 73);
            this.btnCProdutos.TabIndex = 2;
            this.btnCProdutos.Text = "Cadastro de Produtos";
            this.btnCProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCProdutos.UseVisualStyleBackColor = true;
            this.btnCProdutos.Click += new System.EventHandler(this.btnCProdutos_Click);
            // 
            // btnCFuncionarios
            // 
            this.btnCFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCFuncionarios.Image = global::SistemaBasico.Properties.Resources._4;
            this.btnCFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCFuncionarios.Location = new System.Drawing.Point(215, 55);
            this.btnCFuncionarios.Name = "btnCFuncionarios";
            this.btnCFuncionarios.Size = new System.Drawing.Size(239, 73);
            this.btnCFuncionarios.TabIndex = 1;
            this.btnCFuncionarios.Text = "Cadastro de Funcionários";
            this.btnCFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCFuncionarios.UseVisualStyleBackColor = true;
            this.btnCFuncionarios.Click += new System.EventHandler(this.btnCFuncionarios_Click);
            // 
            // btnCClientes
            // 
            this.btnCClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCClientes.Image = global::SistemaBasico.Properties.Resources._2;
            this.btnCClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCClientes.Location = new System.Drawing.Point(12, 55);
            this.btnCClientes.Name = "btnCClientes";
            this.btnCClientes.Size = new System.Drawing.Size(197, 73);
            this.btnCClientes.TabIndex = 0;
            this.btnCClientes.Text = "Cadastro de Clientes";
            this.btnCClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCClientes.UseVisualStyleBackColor = true;
            this.btnCClientes.Click += new System.EventHandler(this.btnCClientes_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 256);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCProdutos);
            this.Controls.Add(this.btnCFuncionarios);
            this.Controls.Add(this.btnCClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCClientes;
        private System.Windows.Forms.Button btnCFuncionarios;
        private System.Windows.Forms.Button btnCProdutos;
        private System.Windows.Forms.Button btnSair;
    }
}
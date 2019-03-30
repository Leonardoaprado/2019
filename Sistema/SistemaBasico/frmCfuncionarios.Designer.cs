namespace SistemaBasico
{
    partial class frmCfuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCfuncionarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.gboxEscolaridade = new System.Windows.Forms.GroupBox();
            this.rbFundamental = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbSuperior = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.cboxCidade = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.maskCel = new System.Windows.Forms.MaskedTextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.maskTel = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gboxEscolaridade.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(8, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(316, 24);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CADASTRO DE FUNCIONÁRIOS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtSalario);
            this.panel1.Controls.Add(this.lblSalario);
            this.panel1.Controls.Add(this.gboxEscolaridade);
            this.panel1.Controls.Add(this.gbEstadoCivil);
            this.panel1.Controls.Add(this.cboxEstado);
            this.panel1.Controls.Add(this.cboxCidade);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblCidade);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.maskCel);
            this.panel1.Controls.Add(this.lblCel);
            this.panel1.Controls.Add(this.maskTel);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 278);
            this.panel1.TabIndex = 6;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(372, 195);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(105, 20);
            this.txtSalario.TabIndex = 27;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(265, 198);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(101, 13);
            this.lblSalario.TabIndex = 26;
            this.lblSalario.Text = "Salario:               R$";
            // 
            // gboxEscolaridade
            // 
            this.gboxEscolaridade.Controls.Add(this.rbFundamental);
            this.gboxEscolaridade.Controls.Add(this.rbMedio);
            this.gboxEscolaridade.Controls.Add(this.rbSuperior);
            this.gboxEscolaridade.Location = new System.Drawing.Point(261, 69);
            this.gboxEscolaridade.Name = "gboxEscolaridade";
            this.gboxEscolaridade.Size = new System.Drawing.Size(216, 102);
            this.gboxEscolaridade.TabIndex = 25;
            this.gboxEscolaridade.TabStop = false;
            this.gboxEscolaridade.Text = "Escolaridade:";
            // 
            // rbFundamental
            // 
            this.rbFundamental.AutoSize = true;
            this.rbFundamental.Location = new System.Drawing.Point(17, 75);
            this.rbFundamental.Name = "rbFundamental";
            this.rbFundamental.Size = new System.Drawing.Size(121, 17);
            this.rbFundamental.TabIndex = 2;
            this.rbFundamental.TabStop = true;
            this.rbFundamental.Text = "Ensino Fundamental";
            this.rbFundamental.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Location = new System.Drawing.Point(17, 52);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(89, 17);
            this.rbMedio.TabIndex = 1;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Ensino Médio";
            this.rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbSuperior
            // 
            this.rbSuperior.AutoSize = true;
            this.rbSuperior.Location = new System.Drawing.Point(17, 29);
            this.rbSuperior.Name = "rbSuperior";
            this.rbSuperior.Size = new System.Drawing.Size(99, 17);
            this.rbSuperior.TabIndex = 0;
            this.rbSuperior.TabStop = true;
            this.rbSuperior.Text = "Ensino Superior";
            this.rbSuperior.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Controls.Add(this.rbSolteiro);
            this.gbEstadoCivil.Location = new System.Drawing.Point(12, 192);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(220, 76);
            this.gbEstadoCivil.TabIndex = 23;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil:";
            // 
            // rbCasado
            // 
            this.rbCasado.AutoSize = true;
            this.rbCasado.Location = new System.Drawing.Point(128, 32);
            this.rbCasado.Name = "rbCasado";
            this.rbCasado.Size = new System.Drawing.Size(61, 17);
            this.rbCasado.TabIndex = 1;
            this.rbCasado.TabStop = true;
            this.rbCasado.Text = "Casado";
            this.rbCasado.UseVisualStyleBackColor = true;
            // 
            // rbSolteiro
            // 
            this.rbSolteiro.AutoSize = true;
            this.rbSolteiro.Location = new System.Drawing.Point(23, 32);
            this.rbSolteiro.Name = "rbSolteiro";
            this.rbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rbSolteiro.TabIndex = 0;
            this.rbSolteiro.TabStop = true;
            this.rbSolteiro.Text = "Solteiro";
            this.rbSolteiro.UseVisualStyleBackColor = true;
            // 
            // cboxEstado
            // 
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.cboxEstado.Location = new System.Drawing.Point(148, 150);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(85, 21);
            this.cboxEstado.TabIndex = 22;
            // 
            // cboxCidade
            // 
            this.cboxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCidade.FormattingEnabled = true;
            this.cboxCidade.Items.AddRange(new object[] {
            "Americana ",
            "Santa Barbara do Oeste",
            "Nova Odessa",
            "Sumaré ",
            "Limeira ",
            "Piracicaba",
            "São Paulo",
            "Rio de Janeiro",
            "Parati",
            "Sapucaia",
            "São Bernardino",
            "Rio fortuna",
            "Saltinho"});
            this.cboxCidade.Location = new System.Drawing.Point(12, 150);
            this.cboxCidade.Name = "cboxCidade";
            this.cboxCidade.Size = new System.Drawing.Size(130, 21);
            this.cboxCidade.TabIndex = 21;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(145, 134);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(9, 134);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 19;
            this.lblCidade.Text = "Cidade:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(258, 224);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(219, 41);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // maskCel
            // 
            this.maskCel.Location = new System.Drawing.Point(132, 87);
            this.maskCel.Mask = "(99) 0 0000-0000";
            this.maskCel.Name = "maskCel";
            this.maskCel.Size = new System.Drawing.Size(101, 20);
            this.maskCel.TabIndex = 15;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(129, 67);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(42, 13);
            this.lblCel.TabIndex = 14;
            this.lblCel.Text = "Celular:";
            // 
            // maskTel
            // 
            this.maskTel.Location = new System.Drawing.Point(12, 87);
            this.maskTel.Mask = "(99) 0000-0000";
            this.maskTel.Name = "maskTel";
            this.maskTel.Size = new System.Drawing.Size(99, 20);
            this.maskTel.TabIndex = 13;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(9, 67);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 12;
            this.lblTel.Text = "Telefone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(258, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(255, 8);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome:";
            // 
            // frmCfuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCfuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gboxEscolaridade.ResumeLayout(false);
            this.gboxEscolaridade.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskCel;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.MaskedTextBox maskTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.ComboBox cboxCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.GroupBox gboxEscolaridade;
        private System.Windows.Forms.RadioButton rbFundamental;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbSuperior;
    }
}
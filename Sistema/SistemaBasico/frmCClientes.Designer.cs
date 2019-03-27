namespace SistemaBasico
{
    partial class frmCClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCClientes));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTel = new System.Windows.Forms.Label();
            this.maskTel = new System.Windows.Forms.MaskedTextBox();
            this.maskCel = new System.Windows.Forms.MaskedTextBox();
            this.lblCel = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbSolteiro = new System.Windows.Forms.RadioButton();
            this.rbCasado = new System.Windows.Forms.RadioButton();
            this.lblPreferencias = new System.Windows.Forms.Label();
            this.cbVegetariano = new System.Windows.Forms.CheckBox();
            this.cbVegano = new System.Windows.Forms.CheckBox();
            this.cvIntolerante = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(8, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(221, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(254, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(220, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(251, 14);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(261, 24);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "CADASTRO DE CLIENTES";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.cvIntolerante);
            this.panel1.Controls.Add(this.cbVegano);
            this.panel1.Controls.Add(this.cbVegetariano);
            this.panel1.Controls.Add(this.lblPreferencias);
            this.panel1.Controls.Add(this.gbEstadoCivil);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblCidade);
            this.panel1.Controls.Add(this.maskCel);
            this.panel1.Controls.Add(this.lblCel);
            this.panel1.Controls.Add(this.maskTel);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(9, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 298);
            this.panel1.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(5, 73);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Telefone:";
            // 
            // maskTel
            // 
            this.maskTel.Location = new System.Drawing.Point(8, 93);
            this.maskTel.Mask = "(99) 0 0000-0000";
            this.maskTel.Name = "maskTel";
            this.maskTel.Size = new System.Drawing.Size(99, 20);
            this.maskTel.TabIndex = 5;
            // 
            // maskCel
            // 
            this.maskCel.Location = new System.Drawing.Point(128, 93);
            this.maskCel.Mask = "(99) 0 0000-0000";
            this.maskCel.Name = "maskCel";
            this.maskCel.Size = new System.Drawing.Size(101, 20);
            this.maskCel.TabIndex = 7;
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(125, 73);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(42, 13);
            this.lblCel.TabIndex = 6;
            this.lblCel.Text = "Celular:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(154, 127);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(5, 127);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(144, 153);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Controls.Add(this.rbCasado);
            this.gbEstadoCivil.Controls.Add(this.rbSolteiro);
            this.gbEstadoCivil.Location = new System.Drawing.Point(8, 201);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(220, 76);
            this.gbEstadoCivil.TabIndex = 12;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Estado Civil:";
            this.gbEstadoCivil.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.rbSolteiro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // lblPreferencias
            // 
            this.lblPreferencias.AutoSize = true;
            this.lblPreferencias.Location = new System.Drawing.Point(251, 80);
            this.lblPreferencias.Name = "lblPreferencias";
            this.lblPreferencias.Size = new System.Drawing.Size(69, 13);
            this.lblPreferencias.TabIndex = 13;
            this.lblPreferencias.Text = "Preferências:";
            // 
            // cbVegetariano
            // 
            this.cbVegetariano.AutoSize = true;
            this.cbVegetariano.Location = new System.Drawing.Point(254, 111);
            this.cbVegetariano.Name = "cbVegetariano";
            this.cbVegetariano.Size = new System.Drawing.Size(83, 17);
            this.cbVegetariano.TabIndex = 14;
            this.cbVegetariano.Text = "Vegetariano";
            this.cbVegetariano.UseVisualStyleBackColor = true;
            // 
            // cbVegano
            // 
            this.cbVegano.AutoSize = true;
            this.cbVegano.Location = new System.Drawing.Point(254, 134);
            this.cbVegano.Name = "cbVegano";
            this.cbVegano.Size = new System.Drawing.Size(63, 17);
            this.cbVegano.TabIndex = 15;
            this.cbVegano.Text = "Vegano";
            this.cbVegano.UseVisualStyleBackColor = true;
            // 
            // cvIntolerante
            // 
            this.cvIntolerante.AutoSize = true;
            this.cvIntolerante.Location = new System.Drawing.Point(254, 157);
            this.cvIntolerante.Name = "cvIntolerante";
            this.cvIntolerante.Size = new System.Drawing.Size(126, 17);
            this.cvIntolerante.TabIndex = 16;
            this.cvIntolerante.Text = "Intolerante á Lactose";
            this.cvIntolerante.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(254, 180);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 17);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Diabético";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(254, 233);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(220, 41);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // frmCClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox maskTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox maskCel;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbCasado;
        private System.Windows.Forms.RadioButton rbSolteiro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox cvIntolerante;
        private System.Windows.Forms.CheckBox cbVegano;
        private System.Windows.Forms.CheckBox cbVegetariano;
        private System.Windows.Forms.Label lblPreferencias;
    }
}
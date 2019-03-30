using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBasico
{
    public partial class frmCfuncionarios : Form
    {
        public frmCfuncionarios()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string estadoCivil, escolaridade, nome, email, telefone, celular, estado, cidade, salario;
            nome = txtNome.Text;
            email = txtEmail.Text;
            salario = txtSalario.Text;
            telefone = maskTel.Text;
            celular = maskCel.Text;
            estado = cboxEstado.Items[cboxEstado.SelectedIndex].ToString();
            cidade = cboxCidade.Items[cboxCidade.SelectedIndex].ToString();

            if (rbCasado.Checked == true)
            {
                estadoCivil = "Casado";
            }
            else
            {
                estadoCivil = "Solteiro";
            }

            if(rbFundamental.Checked == true)
            {
                escolaridade = "Ensino Fundamental";
            }
            else if(rbMedio.Checked == true)
            {
                escolaridade = "Ensino Médio";
            }
            else
            {
                escolaridade = "Ensino Superior";
            }

            GravarFuncionario(nome, email, salario, telefone, celular, cidade, estado, estadoCivil, escolaridade);

            LimparCampos();

        }

        private void GravarFuncionario(string nome, string email, string salario, string telefone, string celular, string cidade, string estado, string estadoCivil, string escolaridade)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema\\Funcionarios.txt";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone(s) " + telefone + " " + celular);
            arquivo.WriteLine("Local: " + cidade + "" + estado);
            arquivo.WriteLine("Estado Civil " + estadoCivil);
            arquivo.WriteLine("Escolaridade? " + escolaridade);
            arquivo.WriteLine("Salario:  R$ " + salario);
            arquivo.WriteLine("================================================");
            arquivo.WriteLine();
            arquivo.WriteLine();
            arquivo.Close();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtSalario.Text = "";
            maskCel.Text = "";
            maskTel.Text = "";
            cboxCidade.Text = null;
            cboxEstado.Text = null;
            rbCasado.Checked = false;
            rbSolteiro.Checked = false;
            rbFundamental.Checked = false;
            rbMedio.Checked = false;
            rbSuperior.Checked = false;
        }
    }
}

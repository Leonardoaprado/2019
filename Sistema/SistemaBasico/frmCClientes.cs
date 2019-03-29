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
    public partial class frmCClientes : Form
    {
        public frmCClientes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmCClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string vegano, lactose, diabetico, estadocivil, vegetariano;
            if (cbVegano.Checked == true)
            {
                vegano = "Sim";
            }
            else
            {
                vegano = "Não";
            }
            if (cbDiabetico.Checked == true)
            {
                diabetico = "Sim";
            }
            else
            {
                diabetico = "Não";
            }
            if (cbVegetariano.Checked == true)
            {
                vegetariano = "Sim";
            }
            else
            {
                vegetariano = "Não";
            }
            if (cbIntolerante.Checked == true)
            {
                lactose = "Sim";
            }
            else
            {
                lactose = "Não";
            }
            if (rbCasado.Checked == true)
            {
                estadocivil = "Sim";
            }
            else if (rbSolteiro.Checked == true)
            {
                estadocivil = "Solteiro";
            }
            else
            {
                estadocivil = "";
            }
            GravarCliente(txtNome.Text, txtEmail.Text, maskTel.Text, maskCel.Text, cboxCidade.Items[cboxCidade.SelectedIndex].ToString(), cboxEstado.Items[cboxEstado.SelectedIndex].ToString(), estadocivil, vegetariano, vegano, lactose, diabetico);
            MessageBox.Show("Cliente gravado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparCampos();
        }

        private void GravarCliente(string nome, string email, string telefone, string celular, string cidade, string estado, string estadocivil, string vegetariano, string vegano, string lactose, string diabetico)
        {
            StreamWriter arquivo;
            string caminho = "c:\\sistema\\cliente.txt";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone(s): " + telefone + celular);
            arquivo.WriteLine("Local: " + cidade + " (" + estado + ") ");
            arquivo.WriteLine("Estado Civil: " + estadocivil);
            arquivo.WriteLine("Vegetariano? " + vegetariano);
            arquivo.WriteLine("Vegano? " + vegano);
            arquivo.WriteLine("Intolerante a Lactose? " + lactose);
            arquivo.WriteLine("Diabético? " + diabetico);
            arquivo.WriteLine("================================================================");
            arquivo.WriteLine("");
            arquivo.WriteLine("");
            arquivo.Close();
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            maskCel.Text = "";
            maskTel.Text = "";
            cboxCidade.Text = null;
            cboxEstado.Text = null;
            cbVegano.Checked = false;
            cbVegetariano.Checked = false;
            cbIntolerante.Checked = false;
            cbDiabetico.Checked = false;
            rbCasado.Checked = false;
            rbSolteiro.Checked = false;
        }
        

                       
    }
}

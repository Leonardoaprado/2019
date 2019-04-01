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
    public partial class frmCProdutos : Form
    {
        public frmCProdutos()
        {
            InitializeComponent();
        }

        private void txtValorTotal_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private double Multiplicacao(int num1, int num2)
        {
           
            int total;
            total = num1 * num2;
            return total;
            
         
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantidade.Text == "" || txtValorUnitario.Text == "")
            {

                MessageBox.Show(" Os Campos Quantidade e Valor Unitario não pode estar Vazio", "ATENÇÃO!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtValorTotal.Text = (Multiplicacao(Convert.ToInt32(txtValorUnitario.Text), Convert.ToInt32(txtQuantidade.Text))).ToString("N");
            }
            
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string Codigo, Descricao, Quantidade, Fabricante, Local, Unidade, Validade, ValorUnitario, ValorTotal;
            Codigo = txtCodigo.Text;
            Descricao = txtDescricao.Text;
            Quantidade = txtQuantidade.Text;
            Fabricante = txtFabricante.Text;
            Local = txtLocalizacao.Text;
            Unidade = txtUnidade.Text;
            Validade = txtValidade.Text;
            ValorUnitario = txtValorUnitario.Text;
            ValorTotal = txtValorTotal.Text;

            CadastrarProdutos(Codigo, Descricao, Quantidade, Fabricante, Local, Unidade, Validade, ValorUnitario, ValorTotal);
            LimparCampos();

        }

        private void CadastrarProdutos(string Codigo, string Descricao, string Quantidade, string Fabricante, string Local, string Unidade, string Validade, string ValorUnitario, string ValorTotal)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema\\Produtos.txt";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Codigo: " + Codigo);
            arquivo.WriteLine("Descrição: " + Descricao);
            arquivo.WriteLine("Quantidade: " + Quantidade);
            arquivo.WriteLine("Fabricante: " + Fabricante);
            arquivo.WriteLine("Localização no Estoque: " + Local);
            arquivo.WriteLine("Unidade: " + Unidade);
            arquivo.WriteLine("Validade: " + Validade);
            arquivo.WriteLine("Valor Unitario: " + ValorUnitario);
            arquivo.WriteLine("Valor Total: " + ValorTotal);
            arquivo.WriteLine("================================================");
            arquivo.WriteLine();
            arquivo.WriteLine();
            arquivo.Close();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtFabricante.Text = "";
            txtLocalizacao.Text = "";
            txtQuantidade.Text = "";
            txtUnidade.Text = "";
            txtValidade.Text = "";
            txtValorTotal.Text = "";
            txtValorUnitario.Text = "";

        }
    }
}

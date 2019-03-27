using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBasico
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCClientes_Click(object sender, EventArgs e)
        {
            frmCClientes fCliente = new frmCClientes();
            fCliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCFuncionarios_Click(object sender, EventArgs e)
        {
            frmCfuncionarios fFuncionarios = new frmCfuncionarios();
            fFuncionarios.ShowDialog();
        }

        private void btnCProdutos_Click(object sender, EventArgs e)
        {
            frmCProdutos fProdutos = new frmCProdutos();
            fProdutos.ShowDialog();
        }
    }
}

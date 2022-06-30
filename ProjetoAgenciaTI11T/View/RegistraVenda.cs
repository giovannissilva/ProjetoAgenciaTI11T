using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenciaTI11T.View
{
    public partial class RegistraVenda : Form
    {
        public RegistraVenda()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void btnCodCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();

            }
            else
            {
                clientes.CodigoCliente = Convert.ToInt32(tbxCodCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();


            }
            if (Clientes.Retorno == "Não")
            {
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                return;
            }
            else
            {
                tbxCodCli.Text = Clientes.CodigoCliente.ToString();
                tbxNomeCli.Text = Clientes.NomeCliente;


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;
using ProjetoAgenciaTI11T.Controller;
using System.IO;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                
            }
            else
            {
                Clientes.CodigoCliente = Convert.ToInt32(tbxCodCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();

                tbxCodCli.Text = Clientes.CodigoCliente.ToString();
                tbxNomeCli.Text = Clientes.NomeCliente;
                tbxEmailCli.Text = Clientes.EmailCliente;
                tbxSenhaCli.Text = Clientes.SenhaCliente;

                MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCliente);
                pictureBox1.Image = Image.FromStream(ms);
            }
            if (Clientes.Retorno == "Não")
            {
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox1.Image = null;
                return;
            }
        }
    }
}

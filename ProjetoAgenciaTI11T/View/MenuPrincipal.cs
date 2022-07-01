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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrarCliente telaCadastrarCliente = new TelaCadastrarCliente();
            telaCadastrarCliente.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario telaCadastrarFuncionario = new TelaCadastrarFuncionario();
            telaCadastrarFuncionario.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaCadastrarPacote telaCadastrarPacote = new TelaCadastrarPacote();
            telaCadastrarPacote.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarCliente telaPesquisarCliente = new TelaPesquisarCliente();
            telaPesquisarCliente.Show();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaPesquisarFuncionario telaPesquisarFuncionario = new TelaPesquisarFuncionario();
            telaPesquisarFuncionario.Show();
        }

        private void pesquisarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TelaPesquisarPacote telaPesquisarPacote = new TelaPesquisarPacote();
            telaPesquisarPacote.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistraVenda registraVenda = new RegistraVenda();
            registraVenda.Show();
        }
    }
}

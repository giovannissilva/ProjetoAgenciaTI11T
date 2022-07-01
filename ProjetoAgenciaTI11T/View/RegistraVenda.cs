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
    public partial class RegistraVenda : Form
    {
        public RegistraVenda()
        {
            InitializeComponent();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxFun.Text = string.Empty;

            }
            else
            {
                Funcionario.CodigoFun = Convert.ToInt32(tbxCodFun.Text);
                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.pesquisarCodigoFun();



            }
            if (Clientes.Retorno == "Não")
            {
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxFun.Text = string.Empty;
                return;
            }
            else
            {
                tbxCodFun.Text = Funcionario.CodigoFun.ToString();
                tbxFun.Text = Funcionario.NomeFun;
            }
        }

        private void btnCodCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxCli.Text = string.Empty;

            }
            else
            {
                Clientes.CodigoCliente = Convert.ToInt32(tbxCodCli.Text);
                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.pesquisarCodigoCliente();


            }
            if (Clientes.Retorno == "Não")
            {
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxCli.Text = string.Empty;
                return;
            }
            else
            {
                tbxCodCli.Text = Clientes.CodigoCliente.ToString();
                tbxCli.Text = Clientes.NomeCliente;
            }
        }

        private void btnPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Pacotes", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxValor.SelectAll();

            }
            else
            {
                Pacotes.CodigoPacote = Convert.ToInt32(tbxCodPac.Text);
                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.pesquisarCodigoPac();


            }
            if (Pacotes.Retorno == "Não")
            {
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxValor.SelectAll();
                return;
            }
            else
            {
                tbxCodPac.Text = Pacotes.CodigoPacote.ToString();
                tbxValor.Text = Convert.ToString(Pacotes.ValorPacote);
            }
        }
        private void TelaCadastrarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                limparTela();

            }
        }

        public void fecharCadastro()
        {
            this.Close();
        }

        public void limparTela()
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    ctl.Text = string.Empty;
                }
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (tbxCli.Text == "" | tbxCodCli.Text == "" | tbxFun.Text == "" | tbxCodFun.Text == "" | tbxCodPac.Text == "" | cbxPagamento.Text == "")
            {
                MessageBox.Show("Preencha todas as informações Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clientes.NomeCliente = tbxCli.Text;
                Funcionario.NomeFun = tbxFun.Text;

                ManipulaCliente manipulaCliente = new ManipulaCliente();
                manipulaCliente.cadastrarCliente();
            }

            if (Clientes.Retorno == "Sim")
            {
                limparTela();
                return;
            }

            if (Clientes.Retorno == "Não")
            {
                fecharCadastro();
                return;
            }

        }
    }
}
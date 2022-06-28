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
    public partial class TelaPesquisarFuncionario : Form
    {
        public TelaPesquisarFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCodFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;

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
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
                return;
            }
            else
            {
                tbxCodFun.Text = Funcionario.CodigoFun.ToString();
                tbxNomeFun.Text = Funcionario.NomeFun;
                tbxEmailFun.Text = Funcionario.EmailFun;
                tbxSenhaFun.Text = Funcionario.Senha;
            }
        }

        private void TelaPesquisarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterarCodFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um código do Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
            }

            else
            {
                var resposta = MessageBox.Show("Deseja alterar o Funcionario " + tbxCodFun.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.CodigoFun = Convert.ToInt32(tbxCodFun.Text);
                    Funcionario.NomeFun = tbxNomeFun.Text;
                    Funcionario.EmailFun = tbxEmailFun.Text;
                    Funcionario.Senha = tbxSenhaFun.Text;

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.alterarFun();
                }
                return;
            }
        }

        private void btnDeletarCodFun_Click(object sender, EventArgs e)
        {
            if (tbxCodFun.Text == "")
            {
                MessageBox.Show("Digite um código do Funcionario", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
            }

            else
            {
                var resposta = MessageBox.Show("Deseja excluir o Funcionario " + tbxCodFun.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCliente = Convert.ToInt32(tbxCodFun.Text);

                    ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                    manipulaFuncionario.deletarFun();
                }

                tbxCodFun.Text = string.Empty;
                tbxCodFun.Focus();
                tbxCodFun.SelectAll();
                tbxNomeFun.Text = string.Empty;
                tbxEmailFun.Text = string.Empty;
                tbxSenhaFun.Text = string.Empty;
                return;
            }
        }
    }
}
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

                tbxCodFun.Text = Funcionario.CodigoFun.ToString();
                tbxNomeFun.Text = Funcionario.NomeFun;
                tbxEmailFun.Text = Funcionario.EmailFun;
                tbxSenhaFun.Text = Funcionario.Senha;

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
        }

        private void TelaPesquisarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
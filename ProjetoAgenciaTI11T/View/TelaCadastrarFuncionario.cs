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
using ProjetoAgenciaTI11T.Controller;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.View
{
    public partial class TelaCadastrarFuncionario : Form
    {
        public TelaCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            if (tbxEmailFuncionario.Text == "" | tbxNomeFuncionario.Text == "" | tbxSenhaFuncionario.Text == "")
            {
                MessageBox.Show("Preencha todas as informações Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Funcionario.NomeFun = tbxNomeFuncionario.Text;
                Funcionario.EmailFun = tbxEmailFuncionario.Text;
                Funcionario.Senha = tbxSenhaFuncionario.Text;

                ManipulaFuncionario manipulaFuncionario = new ManipulaFuncionario();
                manipulaFuncionario.cadastrarFuncionario();
            }
            if (Funcionario.Retorno == "Sim")
            {
                limparTela();
               
            }

            if (Funcionario.Retorno == "Não")
            {
                fecharCadastro();
                
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
    }
}

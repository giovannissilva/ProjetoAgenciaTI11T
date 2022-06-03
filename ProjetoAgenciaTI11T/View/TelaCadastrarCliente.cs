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
    public partial class TelaCadastrarCliente : Form
    {
        public TelaCadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            if (tbxNomeCliente.Text == "" | tbxEmailCliente.Text == "" | tbxSenhaCliente.Text == "" | pictureBoxFotoCliente.Image == null)
            {
                MessageBox.Show("Preencha todas as informações Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clientes.NomeCliente = tbxNomeCliente.Text;
                Clientes.EmailCliente = tbxEmailCliente.Text;
                Clientes.SenhaCliente = tbxSenhaCliente.Text;
                if (pictureBoxFotoCliente.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    pictureBoxFotoCliente.Image.Save(memoryStream, pictureBoxFotoCliente.Image.RawFormat);
                    Clientes.ImagemCliente = memoryStream.ToArray();
                }

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



        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {
            openFileDialogImagem.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg;*.png";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFotoCliente.Image = Image.FromFile(openFileDialogImagem.FileName);
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
                if (ctl is PictureBox)
                {
                    pictureBoxFotoCliente.Image = null;
                }
            }
        }

        private void tbxNomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

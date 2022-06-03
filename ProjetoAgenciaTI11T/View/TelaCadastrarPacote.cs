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
    public partial class TelaCadastrarPacote : Form
    {
        public TelaCadastrarPacote()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void SalvarImagem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
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
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cbxDestino.SelectedItem == null | cbxOrigem.SelectedItem == null | mtbValor.Text == "" | pictureBox1.Image == null | rtbDescricao.Text == "" | dateIda.Value > dateVolta.Value)
            {
                MessageBox.Show("Preencha todas as informações Corretamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Pacotes.DestinoPacote = cbxDestino.Text;
                Pacotes.OrigimPacote = cbxOrigem.Text;
                Pacotes.ValorPacote = Convert.ToDecimal(mtbValor.Text);
                Pacotes.DataPacoteIda = dateIda.Value;
                Pacotes.DataPacoteVolta = dateVolta.Value;
                Pacotes.DescricaoPacote = rtbDescricao.Text;

                if (pictureBox1.Image != null)
                {
                    MemoryStream memoryStream = new MemoryStream();
                    pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
                    Pacotes.ImagemPacote = memoryStream.ToArray();
                }

                ManipulaPacote manipulaPacote = new ManipulaPacote();
                manipulaPacote.cadastrarPacote();

                if (Pacotes.Retorno == "Sim")
                {
                    limparTela();

                }

                if (Pacotes.Retorno == "Não")
                {
                    fecharCadastro();

                }
            }
        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

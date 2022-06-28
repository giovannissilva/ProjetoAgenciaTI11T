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
    public partial class TelaPesquisarPacote : Form
    {
        public TelaPesquisarPacote()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Pacotes", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxValorPac.SelectAll();
                tbxOrigemPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dateIdaPac.Text = string.Empty;
                dateVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
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
                tbxValorPac.SelectAll();
                tbxOrigemPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dateIdaPac.Text = string.Empty;
                dateVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                pictureBox1.Image = null;
                return;
            }
            else
            {
                tbxCodPac.Text = Pacotes.CodigoPacote.ToString();
                tbxValorPac.Text = Convert.ToString(Pacotes.ValorPacote);
                tbxOrigemPac.Text = Pacotes.OrigimPacote;
                tbxDestinoPac.Text = Pacotes.DestinoPacote;
                dateIdaPac.Text = Convert.ToString(Pacotes.DataPacoteIda);
                dateVoltaPac.Text = Convert.ToString(Pacotes.DataPacoteVolta);
                rtbDescricaoPac.Text = Pacotes.DescricaoPacote;

                MemoryStream ms = new MemoryStream((byte[])Pacotes.ImagemPacote);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btnAlterarCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                tbxValorPac.Text = string.Empty;
                tbxOrigemPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dateIdaPac.Text = string.Empty;
                dateVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                pictureBox1.Image = null;
            }

            else
            {
                var resposta = MessageBox.Show("Alterar  o Pacote " + tbxCodPac.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.CodigoPacote = Convert.ToInt32(tbxCodPac.Text);
                    Pacotes.ValorPacote = Convert.ToDecimal(tbxValorPac.Text);
                    Pacotes.OrigimPacote = Convert.ToString(tbxOrigemPac.Text);
                    Pacotes.DestinoPacote = Convert.ToString(tbxDestinoPac.Text);
                    Pacotes.DataPacoteIda = Convert.ToDateTime(dateIdaPac.Value);
                    Pacotes.DataPacoteVolta = Convert.ToDateTime(dateVoltaPac.Value);
                    Pacotes.DescricaoPacote = Convert.ToString(rtbDescricaoPac.Text);


                    MemoryStream ms = new MemoryStream((byte[])Pacotes.ImagemPacote);
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    Pacotes.ImagemPacote = ms.ToArray();

                    ManipulaPacote manipulaPacote = new ManipulaPacote();
                    manipulaPacote.alterarPac();
                }
                return;
            }
        }

        private void btnDeletarCodPac_Click(object sender, EventArgs e)
        {
            if (tbxCodPac.Text == "")
            {
                MessageBox.Show("Digite um código do Pacote", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                tbxValorPac.Text = string.Empty;
                tbxOrigemPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dateIdaPac.Text = string.Empty;
                dateVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                pictureBox1.Image = null;
            }

            else
            {
                var resposta = MessageBox.Show("Deseja excluir o cliente " + tbxCodPac.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.CodigoPacote = Convert.ToInt32(tbxCodPac.Text);

                    ManipulaPacote manipulaPacote = new ManipulaPacote();
                    manipulaPacote.deletarPac();
                }

                tbxCodPac.Text = string.Empty;
                tbxCodPac.Focus();
                tbxCodPac.SelectAll();
                tbxValorPac.Text = string.Empty;
                tbxOrigemPac.Text = string.Empty;
                tbxDestinoPac.Text = string.Empty;
                dateIdaPac.Text = string.Empty;
                dateVoltaPac.Text = string.Empty;
                rtbDescricaoPac.Text = string.Empty;
                pictureBox1.Image = null;
                return;
            }
        }

        private void btnBuscarImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Escolha uma imagem (*.jpg;*.png;*.jpeg)" + "| *.jpg; *.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}



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
        }
    }
}

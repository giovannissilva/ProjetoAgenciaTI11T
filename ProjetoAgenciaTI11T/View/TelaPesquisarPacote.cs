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

        private void btnBuscaOrigem_Click(object sender, EventArgs e)
        {
            if (tbxPesquisaOrigem.Text == "")
            {
                MessageBox.Show("Digite um nome para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Pacotes.OrigimPacote = tbxPesquisaOrigem.Text;

            dataGridView1.DataSource = ManipulaPacote.pesquisaOrigemPac();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].HeaderCell.Value = "Valor";
            dataGridView1.Columns[7].HeaderCell.Value = "Destino";
            dataGridView1.Columns[8].HeaderCell.Value = "Origem";
            dataGridView1.Columns[9].HeaderCell.Value = "Ida";
            dataGridView1.Columns[10].HeaderCell.Value = "Volta";
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarDestino_Click(object sender, EventArgs e)
        {
        }

        private void btnBuscarDestino_Click_1(object sender, EventArgs e)
        {
            if (tbxBuscarDestino.Text == "")
            {
                MessageBox.Show("Digite um nome para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Pacotes.DestinoPacote = tbxBuscarDestino.Text;

            dataGridView2.DataSource = ManipulaPacote.pesquisaDestinoPac();

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].HeaderCell.Value = "Valores";
            dataGridView2.Columns[7].HeaderCell.Value = "Destino";
            dataGridView2.Columns[8].HeaderCell.Value = "Origem";
            dataGridView2.Columns[9].HeaderCell.Value = "Ida";
            dataGridView2.Columns[10].HeaderCell.Value = "Volta";
            dataGridView2.Columns[11].Visible = false;
            dataGridView2.Columns[12].Visible = false;


        }

        private void tbxBuscarDestino_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

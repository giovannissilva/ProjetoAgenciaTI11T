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
    public partial class TelaPesquisarCliente : Form
    {
        public TelaPesquisarCliente()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox1.Image = null;
            }

            else
            {
                var resposta = MessageBox.Show("Alterar excluir o cliente " + tbxCodCli.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCliente = Convert.ToInt32(tbxCodCli.Text);
                    Clientes.NomeCliente = tbxNomeCli.Text;
                    Clientes.EmailCliente = tbxEmailCli.Text;
                    Clientes.SenhaCliente = tbxSenhaCli.Text;

                    MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCliente);
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    Clientes.ImagemCliente = ms.ToArray();

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.alterarCliente();
                }
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um Codigo de Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                
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
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox1.Image = null;
                return;
            }
            else
            {
                tbxCodCli.Text = Clientes.CodigoCliente.ToString();
                tbxNomeCli.Text = Clientes.NomeCliente;
                tbxEmailCli.Text = Clientes.EmailCliente;
                tbxSenhaCli.Text = Clientes.SenhaCliente;

                MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCliente);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }

        private void btnDeletarCodCli_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox1.Image = null;
            }

            else
            {
                var resposta = MessageBox.Show("Deseja excluir o cliente " + tbxCodCli.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCliente = Convert.ToInt32(tbxCodCli.Text);

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.deletarCliente();
                }

                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox1.Image = null;
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbxCodCli.Text == "")
            {
                MessageBox.Show("Digite um código do cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbxCodCli.Text = string.Empty;
                tbxCodCli.Focus();
                tbxCodCli.SelectAll();
                tbxNomeCli.Text = string.Empty;
                tbxEmailCli.Text = string.Empty;
                tbxSenhaCli.Text = string.Empty;
                pictureBox1.Image = null;
            }

            else
            {
                var resposta = MessageBox.Show("Alterar  o cliente " + tbxCodCli.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    Clientes.CodigoCliente = Convert.ToInt32(tbxCodCli.Text);
                    Clientes.NomeCliente = tbxNomeCli.Text;
                    Clientes.EmailCliente = tbxEmailCli.Text;
                    Clientes.SenhaCliente = tbxSenhaCli.Text;

                    MemoryStream ms = new MemoryStream((byte[])Clientes.ImagemCliente);
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    Clientes.ImagemCliente = ms.ToArray();

                    ManipulaCliente manipulaCliente = new ManipulaCliente();
                    manipulaCliente.alterarCliente();
                }
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

        private void btnBuscaNomeCli_Click(object sender, EventArgs e)
        {
            if (tbxPesquisaNomeCli.Text == "")
            {
                MessageBox.Show("Digite um nome para buscar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Clientes.NomeCliente = tbxPesquisaNomeCli.Text;

            dataGridView1.DataSource = ManipulaCliente.pesquisaNomeCliente();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderCell.Value = "Código";
            dataGridView1.Columns[5].HeaderCell.Value = "Nome";
            dataGridView1.Columns[6].HeaderCell.Value = "E-mail";
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderCell.Value = "Imagem";




        }
    }
}

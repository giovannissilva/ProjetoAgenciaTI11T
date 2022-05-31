using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(tbxNomeCliente.Text == "" | tbxEmailCliente.Text == "" | tbxSenhaCliente.Text == "" | pictureBoxFotoCliente.Image == null  )
            {
                MessageBox.Show("Preencha todas as informações Corretamente.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }



        }
    }
}

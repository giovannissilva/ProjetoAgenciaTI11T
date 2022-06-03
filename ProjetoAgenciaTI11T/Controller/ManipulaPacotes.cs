using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ProjetoAgenciaTI11T.Model;

namespace ProjetoAgenciaTI11T.Controller
{
    class ManipulaPacote
    {
        public void cadastrarPacote()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@valorPac", Pacotes.ValorPacote);
                cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigimPacote);
                cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPacote);
                cmd.Parameters.AddWithValue("@dataPacIda", Pacotes.DataPacoteIda);
                cmd.Parameters.AddWithValue("@dataPacVolta", Pacotes.DataPacoteVolta);
                cmd.Parameters.AddWithValue("@descPac", Pacotes.DescricaoPacote);
                cmd.Parameters.AddWithValue("@imgPac", Pacotes.ImagemPacote);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codPac", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Pacote efetuado com sucesso, deseja fazer outro pacote?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Pacotes.Retorno = "Sim";
                    return;
                }
                else
                {
                    Pacotes.Retorno = "Não";
                    return;
                }

            }
            catch
            {

            }


        }
    }
}
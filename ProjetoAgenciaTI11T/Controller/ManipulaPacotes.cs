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
        public void pesquisarCodigoPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacotes.CodigoPacote);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Pacotes.CodigoPacote = Convert.ToInt32(arrayDados["codPac"]);
                    Pacotes.ValorPacote = Convert.ToDecimal(arrayDados["valorPac"]);
                    Pacotes.OrigimPacote = arrayDados["origemPac"].ToString();
                    Pacotes.DestinoPacote = arrayDados["destinoPac"].ToString();
                    Pacotes.DescricaoPacote = arrayDados["descPac"].ToString();
                    Pacotes.DataPacoteIda =  Convert.ToDateTime(arrayDados["dataPacIda"]);
                    Pacotes.DataPacoteVolta = Convert.ToDateTime(arrayDados["dataPacVolta"]);
                    Pacotes.ImagemPacote = (System.Array)arrayDados["imgPac"];
                    Pacotes.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Pacotes.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacotes.CodigoPacote);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Pacotes excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {
                MessageBox.Show("O Pacotes não pode ser excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public void alterarPac()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codPac", Pacotes.CodigoPacote);
                cmd.Parameters.AddWithValue("@valorPac", Pacotes.ValorPacote);
                cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigimPacote);
                cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPacote);
                cmd.Parameters.AddWithValue("@dataPacIda", Pacotes.DataPacoteIda);
                cmd.Parameters.AddWithValue("@dataPacVolta", Pacotes.DataPacoteVolta);
                cmd.Parameters.AddWithValue("@descPac", Pacotes.DescricaoPacote);
                cmd.Parameters.AddWithValue("@imgPac", Pacotes.ImagemPacote);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pacotes alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Pacotes não pode ser Alterado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public static BindingSource pesquisaOrigemPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaOrigemPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@origemPac", Pacotes.OrigimPacote);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
        public static BindingSource pesquisaDestinoPac()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaDestinoPac", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@destinoPac", Pacotes.DestinoPacote);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;
        }
    }
}
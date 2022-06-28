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
    class ManipulaFuncionario
    {
    public void cadastrarFuncionario()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFun",Funcionario.NomeFun );
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.Senha);
                SqlParameter nv = cmd.Parameters.AddWithValue("@codFun", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro do Fúncionario efetuado com sucesso, deseja efetuar um novo registro?",
                    "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    Funcionario.Retorno = "Sim";
                    return;
                }
                else
                {
                    Funcionario.Retorno = "Não";
                    return;
                }

            }
            catch
            {

            }


        }
        public void pesquisarCodigoFun()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaCodFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@CodFun", Funcionario.CodigoFun);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    Funcionario.CodigoFun = Convert.ToInt32(arrayDados["CodFun"]);
                    Funcionario.NomeFun = arrayDados["nomeFun"].ToString();
                    Funcionario.EmailFun = arrayDados["emailFun"].ToString();
                    Funcionario.Senha = arrayDados["senhaFun"].ToString();
                    Funcionario.Retorno = "Sim";
                }
                else
                {
                    MessageBox.Show("Código não localizado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Funcionario.Retorno = "Não";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void deletarFun()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pDeletarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@CodFun", Funcionario.CodigoFun);
                cn.Open();
                cmd.ExecuteReader();
                MessageBox.Show("Funcionario excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {
                MessageBox.Show("O Funcionario não pode ser excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public void alterarFun()
        {

            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pAlterarFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.AddWithValue("@codFun", Funcionario.CodigoFun);
                cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
                cmd.Parameters.AddWithValue("@emailFun", Funcionario.EmailFun);
                cmd.Parameters.AddWithValue("@senhaFun", Funcionario.Senha);

                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario alterado com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Funcionario não pode ser excluido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public static BindingSource pesquisarNomeFun()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pPesquisaNomeFun", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeFun", Funcionario.NomeFun);
            cn.Open();
            cmd.ExecuteReader();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }
    }
}
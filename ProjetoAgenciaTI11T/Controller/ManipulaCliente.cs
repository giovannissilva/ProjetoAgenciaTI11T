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
    class ManipulaCliente
    {
        public void cadastrarCliente()
        {
            SqlConnection cn = new SqlConnection(ConexaoBanco.conectar());
            SqlCommand cmd = new SqlCommand("pCadastrarCliente",cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCli",Clientes.NomeCliente);
                cmd.Parameters.AddWithValue("@emailCli",Clientes.EmailCliente);
                cmd.Parameters.AddWithValue("@senhaCli",Clientes.SenhaCliente);
                cmd.Parameters.AddWithValue("@imgCli",Clientes.ImagemCliente);

                SqlParameter nv = cmd.Parameters.AddWithValue("@codCli", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Cadastro de Cliente efetuado com sucesso, deseja efetuar um novo registro?",
                    "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    Clientes.Retorno = "Sim";
                    return;
                }
                else
                {
                    Clientes.Retorno = "Não";
                    return;
                }

            }
            catch
            {
                
            }


        }
    }
}

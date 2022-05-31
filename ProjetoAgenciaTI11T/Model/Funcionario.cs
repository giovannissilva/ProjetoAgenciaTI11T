using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Funcionario
    {
        private static int codigoFun;
        private static string nomeFun;
        private static string emailFun;
        private static string senha;

        public static int CodigoFun { get => codigoFun; set => codigoFun = value; }
        public static string NomeFun { get => nomeFun; set => nomeFun = value; }
        public static string EmailFun { get => emailFun; set => emailFun = value; }
        public static string Senha { get => senha; set => senha = value; }
    }
}

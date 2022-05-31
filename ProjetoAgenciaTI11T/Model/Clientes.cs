using System;


namespace ProjetoAgenciaTI11T.Model
{
    class Clientes
    {
        private static int codigoCliente;
        private static string nomeCliente;
        private static string emailCliente;
        private static string senhaCliente;
        private static Array imagemCliente;
        private static string retorno;


        public static int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public static string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public static string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public static string SenhaCliente { get => senhaCliente; set => senhaCliente = value; }
        public static Array ImagemCliente { get => imagemCliente; set => imagemCliente = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}

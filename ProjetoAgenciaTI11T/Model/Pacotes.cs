using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Pacotes
    {
        private static int codigoPacote;
        private static Double valorPacote;
        private static string origimPacote;
        private static string destinoPacote;
        private static DateTime dataPacoteIda;
        private static DateTime dataPacoteVolta;
        private static string descricaoPacote;
        private static Array imagemPacote;

        public static int CodigoPacote { get => codigoPacote; set => codigoPacote = value; }
        public static double ValorPacote { get => valorPacote; set => valorPacote = value; }
        public static string OrigimPacote { get => origimPacote; set => origimPacote = value; }
        public static string DestinoPacote { get => destinoPacote; set => destinoPacote = value; }
        public static DateTime DataPacoteIda { get => dataPacoteIda; set => dataPacoteIda = value; }
        public static DateTime DataPacoteVolta { get => dataPacoteVolta; set => dataPacoteVolta = value; }
        public static string DescricaoPacote { get => descricaoPacote; set => descricaoPacote = value; }
        public static Array ImagemPacote { get => imagemPacote; set => imagemPacote = value; }
    }
}

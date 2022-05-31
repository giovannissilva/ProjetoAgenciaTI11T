using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Model
{
    class Venda
    {
        private static int codigoVenda;
        private static int codigoCliFK;
        private static int codigoFunFK;
        private static int codigoPacoteFK;
        private static Double pagoVenda;

        public static int CodigoVenda { get => codigoVenda; set => codigoVenda = value; }
        public static int CodigoCliFK { get => codigoCliFK; set => codigoCliFK = value; }
        public static int CodigoFunFK { get => codigoFunFK; set => codigoFunFK = value; }
        public static int CodigoPacoteFK { get => codigoPacoteFK; set => codigoPacoteFK = value; }
        public static double PagoVenda { get => pagoVenda; set => pagoVenda = value; }
    }
}

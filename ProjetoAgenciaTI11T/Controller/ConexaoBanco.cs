using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenciaTI11T.Controller
{
    class ConexaoBanco
    {
       public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\giovanni.ssilva7\Source\Repos\ProjetoAgenciaTI11T\ProjetoAgenciaTI11T\bdagencia.mdf;Integrated Security=True";
        }
    }
}

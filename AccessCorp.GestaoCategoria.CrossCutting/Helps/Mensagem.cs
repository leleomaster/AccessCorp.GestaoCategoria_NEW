using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.CrossCutting.Helps
{
    public static class Mensagem
    {
        public static string Exibir(string retorno)
        {
            if (retorno.ToUpper() == "TRUE")
            {
                return "SUCESSO";
            }
            else 
            {
                return "ERROR";
            }
        }
    }
}

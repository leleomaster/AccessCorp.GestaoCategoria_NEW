using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccessCorp.GestaoCategoria.Web.EndPoints
{
    public static class WebApiGestaoCategoria
    {
        private const string url = "http://localhost:57956/";

        // EndPointsa para a área de Admin
        public const string AdminCadastrarCategoria = url + "api/v1/categoria/cadastrar";
        public const string AdminCadastrarSubCategoria = url + "api/v1/subcategoria/cadastrar";


        // EndPoints para a área publica
        public const string ListaTipoCampo = url + "api/v1/tipocampos/lista";
        public const string ListaCategoria = url + "api/v1/categoria/lista";
    }
}
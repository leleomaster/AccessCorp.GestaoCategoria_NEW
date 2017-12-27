using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccessCorp.GestaoCategoria.Web.Models
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Slug { get; set; }
    }
}
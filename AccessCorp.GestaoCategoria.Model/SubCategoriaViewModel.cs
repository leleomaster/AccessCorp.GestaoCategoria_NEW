using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Model
{
    public class SubCategoriaViewModel
    {
        public int SubCategoriaId { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }
        public string Descricao { get; set; }
        public int IdCategoria { get; set; }
        public IList<CampoViewModel> CamposViewModel { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Model
{
    public class FormularioViewModel
    {
        public CategoriaViewModel CategoriaViewModel { get; set; }
        public List<SubCategoriaViewModel> ListaSubCategoriaViewModel { get; set; }
        public SubCategoriaViewModel SubCategoriaViewModel { get; set; }
    }
}

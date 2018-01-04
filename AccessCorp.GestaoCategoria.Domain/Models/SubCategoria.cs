using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Domain.Models
{
    public class SubCategoria
    {
        public int SubCategoriaId { get; set; }
        public string Nome { get; set; }
        public string Slug { get; set; }
        public string Descricao { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Campo> Campos { get; set; }
    }
}

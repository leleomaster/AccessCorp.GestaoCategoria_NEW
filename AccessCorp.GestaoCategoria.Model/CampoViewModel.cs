using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Model
{
    public class CampoViewModel
    {
        public int CampoId { get; set; }
        public short Ordem { get; set; }
        public bool Obrigatorio { get; set; }
        public int IdTipoCampo { get; set; }
        public IList<TextoCampoViewModel> TextoCampos { get; set; }// Caso o TipoCampo seja combobox esta propriedade terá de 1 a N valores para o combobox, se não terá apenas 1 valor
    }
}

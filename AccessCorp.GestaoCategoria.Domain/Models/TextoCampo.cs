using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Domain.Models
{
    /// <summary>
    ///     PARA ARMAZENAR OS TEXTOS QUE VÃO FICAR NO COMBOBOX(SELECT)
    /// </summary>
    /// 
    public class TextoCampo
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public virtual Campo Campo { get; set; }
    }
}

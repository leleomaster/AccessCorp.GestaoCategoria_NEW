﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Domain.Models
{
    public class Campo
    {
        public int Id { get; set; }
        public short Ordem { get; set; }
        public bool Obrigatorio { get; set; }
        public virtual SubCategoria SubCategoria { get; set; }
        public virtual TipoCampo TipoCampo { get; set; }
        public virtual ICollection<TextoCampo> TextoCampos { get; set; }// Caso o TipoCampo seja combobox esta propriedade terá de 1 a N valores para o combobox, se não terá apenas 1 valor

    }
}

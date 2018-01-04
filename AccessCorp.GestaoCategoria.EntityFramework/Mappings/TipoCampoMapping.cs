using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Mappings
{
    public class TipoCampoMapping : EntityTypeConfiguration<TipoCampo>
    {
        public TipoCampoMapping()
        {
            ToTable("TIPOCAMPO", "FORMULARIO");

            HasKey(c => c.TipoCampoId);

            Property(c => c.TipoCampoId).HasColumnName("TIPO_CAMPO_ID");
            Property(c => c.Nome).HasColumnName("NOME").HasMaxLength(40).IsRequired(); 
        }
    }
}

using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Mappings
{
    public class TextoCampoMapping :  EntityTypeConfiguration<TextoCampo>
    {
        public TextoCampoMapping()
        {
            ToTable("TEXTOCAMPO", "FORMULARIO");

            HasKey(s => s.TextoCampoId);

            Property(s => s.TextoCampoId).HasColumnName("TEXTO_CAMPO_ID");
            Property(s => s.Texto).HasColumnName("TEXTO");
            
            HasRequired(c => c.Campo)
               .WithMany(c => c.TextoCampos)
                .Map(m => m.MapKey("CAMPO_ID"));
        }
    }
}


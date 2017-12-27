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
            ToTable("TEXTOCAMPO");

            HasKey(s => s.Id);

            Property(s => s.Id).HasColumnName("ID");
            Property(s => s.Texto).HasColumnName("TEXTO");

            //Mapeando o relacionamento
            HasRequired(s => s.Campo)
            .WithMany(s => s.TextoCampos)
            .HasForeignKey(s => s.Id);
        }
    }
}

using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework.Mappings
{
    public class CampoMapping : EntityTypeConfiguration<Campo>
    {
        public CampoMapping()
        {
            ToTable("CAMPO", "FORMULARIO");

            HasKey(c => c.CampoId);

            Property(c => c.CampoId).HasColumnName("CAMPO_ID");
            Property(c => c.Obrigatorio).IsRequired().HasColumnName("OBRIGATORIO"); ;
            Property(c => c.Ordem).IsRequired().HasColumnName("ORDEM"); ;
            Property(c => c.Descricao).IsRequired().HasColumnName("DESCRICAO"); ;

            HasRequired(c => c.SubCategoria)
                .WithMany(c => c.Campos)
                .Map(c => c.MapKey("SUB_CATEGORIA_ID"));

            HasRequired(c => c.TipoCampo)
                 .WithMany()
                 .Map(m => m.MapKey("TIPO_CAMPO_ID"));
        }
    }
}

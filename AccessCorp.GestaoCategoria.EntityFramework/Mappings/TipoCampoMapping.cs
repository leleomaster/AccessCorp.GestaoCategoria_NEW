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
            ToTable("TIPOCAMPO");

            HasKey(c => c.Id);

            Property(c => c.Id).HasColumnName("ID");
            Property(c => c.Nome).HasColumnName("NOME");
        }
    }
}

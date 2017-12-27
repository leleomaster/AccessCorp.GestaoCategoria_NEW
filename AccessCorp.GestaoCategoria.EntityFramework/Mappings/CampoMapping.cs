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
            ToTable("CAMPO");

            HasKey(c => c.Id);

            Property(c => c.Id);
            Property(c => c.Obrigatorio);
            Property(c => c.Ordem);
        }
    }
}

using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.EntityFramework
{
    public class GestaoCategoriaDBInitializer : DropCreateDatabaseIfModelChanges<DbContextAccessCorp>
    {
        protected override void Seed(DbContextAccessCorp context)
        {
            IList<TipoCampo> defaultStandards = new List<TipoCampo>();

            defaultStandards.Add(new TipoCampo() { Nome = "checkbox", TipoCampoId = 1 });
            defaultStandards.Add(new TipoCampo() { Nome = "textarea", TipoCampoId = 1 });
            defaultStandards.Add(new TipoCampo() { Nome = "number", TipoCampoId = 1 });
            defaultStandards.Add(new TipoCampo() { Nome = "text", TipoCampoId = 1 });
            defaultStandards.Add(new TipoCampo() { Nome = "radio", TipoCampoId = 1 });
            defaultStandards.Add(new TipoCampo() { Nome = "select", TipoCampoId = 6 });

            foreach (TipoCampo std in defaultStandards)
            {
                context.TipoCampos.Add(std);
            }

            base.Seed(context);
        }
    }
}

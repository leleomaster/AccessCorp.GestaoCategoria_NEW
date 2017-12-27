using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class SubCategoriaService: ISubCategoriaService
    {
        private readonly ISubCategoriaRepository _subCategoriaRepository;

        public SubCategoriaService(ISubCategoriaRepository subCategoriaRepository)
        {
            _subCategoriaRepository = subCategoriaRepository;
        }
    }
}

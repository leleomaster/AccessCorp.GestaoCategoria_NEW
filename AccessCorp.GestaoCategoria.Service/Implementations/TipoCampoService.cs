using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class TipoCampoService: ITipoCampoService
    {
        private readonly ITipoCampoRepository _tipoCampoRepository;

        public TipoCampoService(ITipoCampoRepository tipoCampoRepository)
        {
            _tipoCampoRepository = tipoCampoRepository;
        }
    }
}

using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class CampoService: ICampoService
    {
        private readonly ICampoRepository _campoRepository;

        public CampoService(ICampoRepository campoRepository)
        {
            _campoRepository = campoRepository;
        }
    }
}

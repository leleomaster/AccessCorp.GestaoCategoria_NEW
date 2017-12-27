using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Service.Implementations
{
    public class TextoCampoService: ITextoCampoService
    {
        private readonly ITextoCampoRepository _textoCampoRepository;

        public TextoCampoService(ITextoCampoRepository textoCampoRepository)
        {
            _textoCampoRepository = textoCampoRepository;
        }
    }
}

using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Service.Interfaces
{
    public interface ICategoriaService
    {
        bool Cadastrar(Categoria categoria);
    }
}

﻿using AccessCorp.GestaoCategoria.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessCorp.GestaoCategoria.Repository.Interfaces
{
    public interface ITextoCampoRepository
    {
        void Cadastrar(TextoCampo textoCampo);
        TextoCampo GetById(int id);
    }
}

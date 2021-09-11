using System;
using System.Collections.Generic;
using App.Domain.Entities;

namespace App.Domain.Interfaces.Application
{
    public interface IPessoaService
    {
        Pessoa BuscaPorId(Guid id);

        List<Pessoa> listaPessoas();
        void Salvar(Pessoa obj);
        void Remover (Guid id);
        
    }


}



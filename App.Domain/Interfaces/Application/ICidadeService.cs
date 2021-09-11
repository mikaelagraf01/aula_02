using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Interfaces.Application
{
    public interface ICidadeService
    {
        Cidade GetBuscaPorId();

        Cidade BuscaPorId { get; }

        List<Cidade> listaCidades();
        void Salvar(Cidade obj);
        object ListaPessoas();
        void Remover(Guid id);
    }

}
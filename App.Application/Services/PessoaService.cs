using App.Domain.Entities;
using App.Domain.Interfaces;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class PessoaService : IPessoaService
    {

        private IRepositoryBase<Pessoa> _repository { get; set; }
        public Guid Id { get; private set; }

        Pessoa IPessoaService.BuscaPorId(Guid id)
        {
            var obj = _repository.Query(x => x.Id == Id).FirstOrDefault();
            return obj;
        }

        public PessoaService(IRepositoryBase<Pessoa> repository)
        {
            _repository = repository;
        }


        public List<Pessoa> listaPessoas()
        {

            return _repository.Query(x => 1 == 1)
            .Select(p => new Pessoa
            {
                Id = p.Id,
                Nome = p.Nome,
                Peso = p.Peso,
                Cidade = new Cidade
                {
                    Nome = p.Cidade.Nome
                }
            }).ToList();
        }
        public void Salvar(Pessoa obj)
        {
            if (String.IsNullOrEmpty(obj.Nome))
            {
                throw new Exception("informe o nome");
            }
            _repository.Save(obj);
            _repository.SaveChanges();
        }

        void IPessoaService.Salvar(Pessoa obj)
        {
            throw new NotImplementedException();
        }

        public Pessoa BuscaPorId()
        {
            var obj = _repository.Query(x => x.Id == Id).FirstOrDefault();
            return obj;

        }
       public void Remover(Guid id)
        {

        }


    }
}

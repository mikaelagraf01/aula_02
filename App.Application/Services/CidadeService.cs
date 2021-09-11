using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Interfaces;
using App.Domain.Interfaces.Application;
using App.Domain.Interfaces.Repositories;

namespace App.Application.Services
{
    public class CidadeService : ICidadeService
    {
        private object x;

        private IRepositoryBase<Cidade> _repository { get; set; }
        public Guid Id { get; private set; }

        Cidade ICidadeService.GetBuscaPorId()
        {
            throw new NotImplementedException();
        }

        public CidadeService(IRepositoryBase<Cidade> repository)
        {
            _repository = repository;
        }


        public List<Cidade> listaCidade()
        {
            return _repository.Query(x => 1 == 1).ToList();
        }
        public void Salvar(Cidade obj)
        {
            if (String.IsNullOrEmpty(obj.Nome))
            {
                throw new Exception("informe o nome");
            }
            _repository.Save(obj);
            _repository.SaveChanges();
        }

        void ICidadeService.Salvar(Cidade obj)
        {
            throw new NotImplementedException();
        }

        public Cidade BuscaPorId
        {
            get
            {
                var obj = _repository.Query(x => x.Id == Id).FirstOrDefault();
                return obj;
            }
        }

        public List<Cidade> listaCidades()
        {
            throw new NotImplementedException();
        }

        public object ListaPessoas()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            _repository.Delete(id);
            _repository.SaveChanges();
        }
    }
}
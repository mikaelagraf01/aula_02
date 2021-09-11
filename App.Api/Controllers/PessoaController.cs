using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private IPessoaService _service;
        private object _services;

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Peso { get; private set; }
        public bool Ativo { get; private set; }

        public PessoaController(IPessoaService service)
        {
            _service = service;
        }

        [HttpGet("ListaPessoas")]
        public JsonResult ListaPessoas(string nome, int pessoaMaiorQue, int pesoMenorQue)
        {
            return Json(_service.listaPessoas(nome, pessoaMaiorQue, pesoMenorQue));
        }
        [HttpGet("BuscarPorId")]
        public JsonResult BuscaPorId(Guid id)
        {
            return Json(_service.BuscaPorId(id));
        }
        [HttpPost("Salvar")]
        public JsonResult Salvar(string nome, int peso, DateTime dataNascimento, bool ativo, Guid IdCidade)
        {
            var obj = new Pessoa
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Peso = peso,
                Ativo = ativo,
                CidadeId = IdCidade

               
            };
            _service.Salvar(obj);
            return Json(true);
        }
      [HttpPost("Remover")]
        public JsonResult Salvar(Guid id)
        {
            _service.Remover(id);
            return Json(true);
        }

    }


}




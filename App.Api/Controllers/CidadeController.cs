using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Domain.Interfaces;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    public class CidadeController : Controller
    {
        private ICidadeService _service;
        public CidadeController(IPessoaService service)
        {
            _service = (ICidadeService)service;
        }

        [HttpGet("ListaCidade")]
        public JsonResult ListaCidades()
        {
            return Json(_service.listaCidades());
        }

        [HttpPost("Salvar")]
        public JsonResult Salvar(string nome, string cep, string uf)
        {
            var cidade = new Cidade
            {
                Nome = nome,
                Uf = uf,
                Cep = cep
            };
            _service.Salvar(cidade);
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


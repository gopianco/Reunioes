using Microsoft.AspNetCore.Mvc;
using Reunioes.Dominio.Contratos;
using Reunioes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reunioes.Web.Controllers
{
    [Route("api/[Controller]")]
    public class SalaController : Controller
    {
        private readonly ISalaRepositorio _salaRepositorio;
        public SalaController(ISalaRepositorio salaRepositorio)
        {
            _salaRepositorio = salaRepositorio;
        }

        [HttpGet]
        public IActionResult Get()

        {
            try
            {
                return Json(_salaRepositorio.ObterTodos());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody] Sala sala)
        {
            try
            {
                sala.Validate();
                if (!sala.EhValido)
                {
                    return BadRequest(sala.ObterMensagensDeValidacao());
                }

                _salaRepositorio.Adicionar(sala);
                return Created("api/sala", sala);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPost("Deletar")]
        public IActionResult Deletar([FromBody] Sala sala)
        {
            try
            {
                _salaRepositorio.Remover(sala);
                return Json(_salaRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

    }
}

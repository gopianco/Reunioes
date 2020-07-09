using System;
using Microsoft.AspNetCore.Mvc;
using Reunioes.Dominio.Contratos;
using Reunioes.Dominio.Entidades;

namespace Reunioes.Web.Controllers
{

    [Route("api/[Controller]")]
    public class ReuniaoController : Controller
    {
        private readonly IReuniaoRepositorio _reuniaoRepositorio;
        public ReuniaoController(IReuniaoRepositorio reuniaoRepositorio)
        {
            _reuniaoRepositorio = reuniaoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_reuniaoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reuniao reuniao)
        {
            try
            {
                _reuniaoRepositorio.Adicionar(reuniao);
                return Created("api/reuniao", reuniao);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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
                var reuniaoExistente = _reuniaoRepositorio
                    .ObterPorDataHora(reuniao.DataHoraInicio, reuniao.DataHoraFim, reuniao.SalaId);


                reuniao.Validate();
                if (!reuniao.EhValido)
                {
                    return BadRequest(reuniao.ObterMensagensDeValidacao());
                }
                if (reuniaoExistente != null)
                {
                    return BadRequest("Já existe uma reunião entre as datas: "
                        + reuniaoExistente.DataHoraInicio.ToString("f")
                        + " e "
                        + reuniaoExistente.DataHoraFim.ToString("f")
                        + " na sala desejada "
                        + reuniaoExistente.Sala.Nome
                        + "\n"
                        + "Reuniao Conflitante: "
                        + reuniaoExistente.Titulo
                        );
                }


                _reuniaoRepositorio.Adicionar(reuniao);
                return Created("api/reuniao", reuniao);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("Consultar")]
        public IActionResult Consultar([FromBody] Reuniao reuniao)
        {
            try
            {
                var reuniaoExistente = _reuniaoRepositorio.ObterPorDataHora(reuniao.DataHoraInicio,
                    reuniao.DataHoraFim, reuniao.SalaId);

                reuniao.Validate();
                if (!reuniao.EhValido)
                {
                    return BadRequest(reuniao.ObterMensagensDeValidacao());
                }
                if (reuniaoExistente != null)
                {
                    return BadRequest("Já existe uma reunião entre as datas: "
                        + reuniaoExistente.DataHoraInicio.ToString("f")
                        + " e "
                        + reuniaoExistente.DataHoraFim.ToString("f")
                        + " na sala desejada "
                        + reuniaoExistente.Sala.Nome
                        + "\n"
                        + "Reuniao Conflitante: "
                        + reuniaoExistente.Titulo
                        );
                }

                return Ok(reuniao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message.ToString());
            }
        }



    }
}

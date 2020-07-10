﻿using Microsoft.AspNetCore.Mvc;
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
                return Ok(_salaRepositorio.ObterTodos());
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpPost]
        public IActionResult Post([FromBody]Sala sala)
        {
            try
            {
                _salaRepositorio.Adicionar(sala);
                return Created("api/sala", sala);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
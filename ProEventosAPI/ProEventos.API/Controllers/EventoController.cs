﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento()            {
                    EventoId = 1,
                    Tema = "Angular e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    ImagemURL = "Foto.png"

            },  new Evento()            {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote = "2° Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString(),
                    ImagemURL = "Foto1.png"

            }
       };


        public EventoController()
        {
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(_evento => _evento.EventoId == id);
        }


        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }


        [HttpPost]
        public string Post()
        {
            return "Retornando um POST";
        }

        [HttpPut]
        public string Put()
        {
            return "Retornando um PUT";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Retornando um PUT";
        }
    }
}

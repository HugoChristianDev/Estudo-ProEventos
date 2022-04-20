using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(
                    _evento => _evento.EventoId == id);
        }


        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
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

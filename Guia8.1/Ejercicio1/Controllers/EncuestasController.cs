using EncuestasBase.Models;
using EncuestasLib.Models;
using EncuestasLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ejercicio1.Controllers
{
    public class EncuestasController : ApiController
    {
        EncuestaService _service=new EncuestaService();

        // POST: api/Encuestas
        [HttpGet]
        [Route("api/Encuestas/{anio}")]
        public EncuestaDTO Get(int anio)
        {
            return _service.BuscarEncuestaPorAnio(anio);
        }

        [HttpGet]
        public EncuestaDTO Get()
        {
            return _service.BuscarEncuestaVigente();
        }

        // POST: api/Encuestas
        [HttpPost]
        public EncuestaDTO Post([FromBody]int anio)
        {
            EncuestaDTO dto = new EncuestaDTO() { Anio = anio };
            dto = _service.AbrirNuevaEncuesta(dto);
            return dto;
        }

        // POST: api/Encuestas
        [HttpPut]
        public EncuestaDTO Put()
        {
            EncuestaDTO dto=_service.CerrarEncuestaVigente();
            return dto;
        }

    }
}

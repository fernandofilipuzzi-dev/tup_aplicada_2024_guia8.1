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

        [HttpGet]
        public EncuestaDTO Get(int anio)
        {
            return _service.BuscarEncuestaPorAnio(anio);
        }

        // POST: api/Encuestas
        [HttpPost]
        public void Post([FromBody]int anio)
        {
            EncuestaDTO dto = new EncuestaDTO() { Anio = anio };
            _service.CrearEncuesta(dto);
        }

    }
}

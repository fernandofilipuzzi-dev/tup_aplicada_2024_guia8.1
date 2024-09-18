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
    public class RespuestasController : ApiController
    {
        EncuestaService _service = new EncuestaService();

        // POST: api/Respuestas
        [HttpPost]
        public void Post([FromBody]RespuestaDTO respuesta)
        {
            EncuestaDTO dto = _service.BuscarEncuestaVigente();
            dto.Respuestas.Add(respuesta);
        }

    }
}

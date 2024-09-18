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
        // GET: api/Respuestas
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Respuestas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Respuestas
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Respuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Respuestas/5
        public void Delete(int id)
        {
        }
    }
}

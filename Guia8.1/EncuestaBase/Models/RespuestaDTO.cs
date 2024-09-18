using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestasBase.Models
{
    public class RespuestaDTO
    {
        public bool UsaBicicleta{ get;set; }
        public bool UsaAutomovil { get; set; }
        public bool UsaTransportePublico { get; set; }
        public string Email { get; set; }
        public double DistanciaDestino { get; set; }
        public string DomicilioOrigen { get; set; }
        public string DomicilioDestino { get; set; }
    }
}

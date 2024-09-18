using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestasLib.Models
{
    public class RespuestaDTO
    {
        public bool UsaBicleta{ get;set; }
        public bool UsaAutomovil { get; set; }
        public bool UsaTransportePublico { get; set; }
        public string Email { get; set; }
        public double DistanciaOrigen { get; set; }
        public double DistanciaDestino { get; set; }
    }
}

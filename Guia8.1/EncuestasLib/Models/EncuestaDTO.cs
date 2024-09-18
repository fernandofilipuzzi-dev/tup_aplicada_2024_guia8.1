using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncuestasLib.Models
{
    public class EncuestaDTO
    {
        public int Anio { get; set; }
        public bool EstaAbierta { get; set; }
        public int CantidadContactables { get; set; }
        public double PorcentajeBicleta { get; set; }
        public double PorcentajeAutomovil { get; set; }
        public double PorcentajeTransportePublico { get; set; }
        public List<RespuestaDTO> Respuestas { get; set; } = new List<RespuestaDTO>();
    }
}

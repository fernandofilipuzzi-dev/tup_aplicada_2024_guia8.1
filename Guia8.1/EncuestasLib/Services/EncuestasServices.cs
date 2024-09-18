using EncuestasBase.Models;
using EncuestasLib.Models;
using System.Collections.Generic;
using System.Linq;


namespace EncuestasLib.Services
{
    public class EncuestaService
    {
        static public List<EncuestaDTO> encuestas = new List<EncuestaDTO>();

        public EncuestaDTO AbrirNuevaEncuesta(EncuestaDTO dto)
        {
            
            var buscado = BuscarEncuestaPorAnio(dto.Anio);

            if (buscado == null)
            {
                encuestas.Add(dto);
                dto.EstaAbierta = true;
                return dto;
            }

            return null;
        }

        public EncuestaDTO BuscarEncuestaPorAnio(int anio)
        {
            int n = 0;
            while (n < encuestas.Count)
            {
                if (encuestas[n].Anio == anio)
                    return encuestas[n];
            }
            return null;
        }

        /// <summary>
        /// devuelve la última encuesta en estado abierto
        /// </summary>
        /// <returns></returns>
        public EncuestaDTO BuscarEncuestaVigente()
        {
            var lista = encuestas.OrderByDescending(e => e.Anio).Where(e => e.EstaAbierta = true).ToList();
            if (lista.Count > 0) return lista[0];
            return null;
        }

        private void ProcesarEncuesta(EncuestaDTO e)
        {
            int cantBici = 0;
            int cantAuto = 0;
            int cantPublico = 0;
            int cantContactables=0;

            foreach (var r in e.Respuestas)
            {
                if (r.UsaBicicleta) cantBici++;
                if (r.UsaAutomovil) cantAuto++;
                if (r.UsaTransportePublico) cantPublico++;
                if (string.IsNullOrEmpty(r.Email)) cantContactables++;
            }
            e.CantidadContactables = cantContactables;

            int total = cantAuto + cantBici + cantPublico;

            if (total > 0)
            {
                e.PorcentajeBicleta = 100.0*cantBici / total ;
                e.PorcentajeAutomovil = 100.0 * cantAuto / total;
                e.PorcentajeTransportePublico = 100.0 * cantPublico / total;
            }
        }

        public EncuestaDTO CerrarEncuestaVigente()
        {
            var buscado = BuscarEncuestaVigente();

            if (buscado != null)
            {
                buscado.EstaAbierta = false;

                ProcesarEncuesta(buscado);
                
                return buscado;
            }

            return null;
        }
    }
}

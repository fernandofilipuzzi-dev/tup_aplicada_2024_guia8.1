using EncuestasLib.Models;
using System.Collections.Generic;


namespace EncuestasLib.Services
{
    public class EncuestaService
    {
        static public List<EncuestaDTO> encuestas = new List<EncuestaDTO>();

        public EncuestaDTO CrearEncuesta(EncuestaDTO dto)
        {
            
            var buscado = BuscarEncuestaPorAnio(dto.Anio);

            if (buscado == null)
            {
                encuestas.Add(dto);
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
    }
}

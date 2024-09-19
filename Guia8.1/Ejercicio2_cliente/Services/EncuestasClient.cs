using EncuestasBase.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncuestasForm.Services
{
    public class Estado 
    {
        public bool HuboError { get; set; }
        public string Mensaje { get; set; }
        public object Contenido { get; set; }
    }

    public class EncuestasClient
    {
        
        public async Task<Estado> AbrirEncuesta(int anio)
        {
            Estado estado = new Estado();
            string url = "https://localhost:44377/api/Encuestas";

            using (var client = new HttpClient())
            {
                string jsonContent = anio.ToString();
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();

                        var resultado = JsonConvert.DeserializeObject<EncuestaDTO>(responseContent);

                        if (resultado == null)
                        {
                            estado.HuboError = true;
                            estado.Mensaje = "Ya existe una encuesta abierta en curso";
                        }
                    }
                    else
                    {
                        estado.HuboError = true;
                        estado.Mensaje=$"{response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    estado.HuboError = true;
                    estado.Mensaje = $"{ex.Message}\r\n{ex?.InnerException?.Message}";                    
                }
            }
            return estado;
        }

        public async Task<Estado> RegistrarRespuesta(RespuestaDTO nuevo)
        {
            var estado=new Estado();
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44377/api/Respuestas";

                string jsonContent = JsonConvert.SerializeObject(nuevo);
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        estado.HuboError = true;
                        estado.Mensaje=$"Error: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    estado.HuboError = true;
                    estado.Mensaje = $"{ex.Message}\r\n{ex?.InnerException?.Message}";
                }
            }
            return estado;
        }

        public async Task<Estado> BuscarEncuestaAbierta()
        {
            var estado = new Estado();
            
            using (var client = new HttpClient())
            {
                string url = "https://localhost:44377/api/Encuestas";

                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();

                        estado.Contenido= JsonConvert.DeserializeObject<EncuestaDTO>(responseContent);
                    }
                    else
                    {
                        estado.HuboError = true;
                        estado.Mensaje = $"Error: {response.StatusCode}";
                    }
                }
                catch (Exception ex)
                {
                    estado.HuboError = true;
                    estado.Mensaje = $"{ex.Message}\r\n{ex?.InnerException?.Message}";
                }
            }
            return estado;
        }

        public async Task<EncuestaDTO> CerrarEncuestaVigente()
        {
            EncuestaDTO resultado = null;

            using (var client = new HttpClient())
            {
                string url = "https://localhost:44377/api/Encuestas";
                                
                StringContent content = null;

                try
                {
                    HttpResponseMessage response = await client.PostAsync(url,content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();

                        resultado=JsonConvert.DeserializeObject<EncuestaDTO>(responseContent);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al hacer la solicitud: {ex.Message}");
                }
            }

            return resultado;
        }
    }
}

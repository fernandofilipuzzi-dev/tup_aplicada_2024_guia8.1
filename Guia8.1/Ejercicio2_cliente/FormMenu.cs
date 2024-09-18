using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EncuestasLib;
using EncuestasLib.Models;

namespace EncuestasForm
{
    public partial class FormMenu : Form
    {
        
       
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnRegistroDeEncuesta_Click(object sender, EventArgs e)
        {
            //FormDatosRespuesta fRegistro = new FormDatosRespuesta();

            //if (fRegistro.ShowDialog() == DialogResult.OK)
            //{
            //    Encuesta nuevo = new Encuesta();

            //    nuevo.UsaBicicleta = fRegistro.chkUsaBicicleta.Checked;
            //    nuevo.UsaAuto = fRegistro.chkUsaAuto.Checked;
            //    nuevo.UsaTransportePublico = fRegistro.chkTranspPub.Checked;
            //    nuevo.DistanciaASuDestino = Convert.ToDouble( fRegistro.tbDistanciaASuDestino.Text);

            //    nuevo.Email = fRegistro.tbEmail.Text;

            //    bool puedeSerContactado = fRegistro.chkPuedeSerContactado.Checked;

            //    proceso.RegistrarEncuesta(nuevo, puedeSerContactado);
            //}

            //fRegistro.Dispose();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            //FormInforme fInforme = new FormInforme();

            //fInforme.Text = "Informe.";

            //fInforme.lbxVer.Items.Add("\t\t Informe de resultados");
            //fInforme.lbxVer.Items.Add("");
            //fInforme.lbxVer.Items.Add("Modo de transporte habitual");
            //fInforme.lbxVer.Items.Add($"\t{"Bicicleta:",-20}  {proceso.PorcBicleta,10:f2}%");
            //fInforme.lbxVer.Items.Add($"\t{"Automóvil:",-20}  {proceso.PorcAuto,10:f2}%");
            //fInforme.lbxVer.Items.Add($"\t{"Transporte público:",-20}  {proceso.PorcTranspPublico,10:f2}%");

            //fInforme.ShowDialog();
            //fInforme.Dispose();
        }

        private void btnListadoContactables_Click(object sender, EventArgs e)
        {
            //FormInforme fInforme = new FormInforme();

            //fInforme.Text = "Informe.";

            //fInforme.lbxVer.Items.Add("\t\t Informe de encuestados contactables");
            //fInforme.lbxVer.Items.Add("");

            //proceso.OrdernarEncuestables();
            //fInforme.lbxVer.Items.Add($"\t{"Email",-30} {"Distancia",10}");
            //for (int n = 0; n < proceso.CantContactables; n++)
            //{
            //    fInforme.lbxVer.Items.Add($"\t{proceso.VerContactable(n).Email,-30} {proceso.VerContactable(n).DistanciaASuDestino,10:f2}");
            //}

            //fInforme.ShowDialog();
            //fInforme.Dispose();
        }

       
        private async void btnAltaEncuesta_Click(object sender, EventArgs e)
        {
            FormDatosEncuesta fDatos = new FormDatosEncuesta();

            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int anio = Convert.ToInt32(fDatos.tbAnio.Text);

                using (var client = new HttpClient())
                {
                    string url = "https://localhost:44377/api/Encuestas";

                    string jsonContent = "2025";
                    StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    try
                    {
                        HttpResponseMessage response = await client.PostAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseContent = await response.Content.ReadAsStringAsync();

                            MessageBox.Show("Registro Realizado");
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

            }
        }
    }
}

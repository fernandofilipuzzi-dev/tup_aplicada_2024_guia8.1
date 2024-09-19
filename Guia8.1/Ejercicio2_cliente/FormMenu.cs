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
using EncuestasBase.Models;
using EncuestasForm.Services;
using Newtonsoft.Json;

namespace EncuestasForm
{
    public partial class FormMenu : Form
    {        
        public FormMenu()
        {
            InitializeComponent();
        }

        private async void btnAltaEncuesta_Click(object sender, EventArgs e)
        {
            FormDatosEncuesta fDatos = new FormDatosEncuesta();

            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                int anio = Convert.ToInt32(fDatos.tbAnio.Text);

                var estado=await new EncuestasClient().AbrirEncuesta(anio);

                MostrarResultados(estado);
            }
        }

        private async void btnRegistroDeEncuesta_Click(object sender, EventArgs e)
        {
            FormDatosRespuesta fRegistro = new FormDatosRespuesta();

            if (fRegistro.ShowDialog() == DialogResult.OK)
            {
                RespuestaDTO nuevo = new RespuestaDTO();

                #region parseo de datos
                nuevo.UsaBicicleta = fRegistro.chkUsaBicicleta.Checked;
                nuevo.UsaAutomovil = fRegistro.chkUsaAuto.Checked;
                nuevo.UsaTransportePublico = fRegistro.chkTranspPub.Checked;
                nuevo.DistanciaDestino = Convert.ToDouble(fRegistro.tbDistanciaDestino.Text);
                nuevo.DomicilioOrigen= fRegistro.tbDomicilioOrigen.Text;
                nuevo.DomicilioDestino = fRegistro.tbDomicilioDestino.Text;
                nuevo.Email = fRegistro.tbEmail.Text;
                #endregion

                bool puedeSerContactado = fRegistro.chkPuedeSerContactado.Checked;

                var estado=await new EncuestasClient().RegistrarRespuesta(nuevo);
                MostrarResultados(estado);
            }

            fRegistro.Dispose();
        }

        private async void btnCerrarEncuesta_Click(object sender, EventArgs e)
        {
            FormDatosEncuesta fDatos = new FormDatosEncuesta();

            var estado = await new EncuestasClient().BuscarEncuestaAbierta();

            if (estado.HuboError==false && estado.Contenido == null)
            {
                MessageBox.Show("No hay encuesta abierta", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(estado.HuboError == true )
            {
                MessageBox.Show(estado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fDatos.tbAnio.Text=((EncuestaDTO)(estado.Contenido)).Anio.ToString();
            if (fDatos.ShowDialog() == DialogResult.OK)
            {
                await new EncuestasClient().CerrarEncuestaVigente();
            }


            //en edición

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

        private void MostrarResultados(Estado estado)
        {
            if (estado.HuboError)
            {
                MessageBox.Show(estado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Encuesta dada de alta", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

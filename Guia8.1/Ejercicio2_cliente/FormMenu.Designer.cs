
namespace EncuestasForm
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistroDeEncuesta = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.btnListadoContactables = new System.Windows.Forms.Button();
            this.btnAltaEncuesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroDeEncuesta
            // 
            this.btnRegistroDeEncuesta.Location = new System.Drawing.Point(97, 76);
            this.btnRegistroDeEncuesta.Name = "btnRegistroDeEncuesta";
            this.btnRegistroDeEncuesta.Size = new System.Drawing.Size(183, 38);
            this.btnRegistroDeEncuesta.TabIndex = 0;
            this.btnRegistroDeEncuesta.Text = "Registro De Encuesta";
            this.btnRegistroDeEncuesta.UseVisualStyleBackColor = true;
            this.btnRegistroDeEncuesta.Click += new System.EventHandler(this.btnRegistroDeEncuesta_Click);
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(97, 120);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(183, 38);
            this.btnInforme.TabIndex = 1;
            this.btnInforme.Text = "Resultados";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // btnListadoContactables
            // 
            this.btnListadoContactables.Location = new System.Drawing.Point(97, 164);
            this.btnListadoContactables.Name = "btnListadoContactables";
            this.btnListadoContactables.Size = new System.Drawing.Size(183, 38);
            this.btnListadoContactables.TabIndex = 2;
            this.btnListadoContactables.Text = "Listado contactables";
            this.btnListadoContactables.UseVisualStyleBackColor = true;
            this.btnListadoContactables.Click += new System.EventHandler(this.btnListadoContactables_Click);
            // 
            // btnAltaEncuesta
            // 
            this.btnAltaEncuesta.Location = new System.Drawing.Point(97, 32);
            this.btnAltaEncuesta.Name = "btnAltaEncuesta";
            this.btnAltaEncuesta.Size = new System.Drawing.Size(183, 38);
            this.btnAltaEncuesta.TabIndex = 3;
            this.btnAltaEncuesta.Text = "Alta Encuesta";
            this.btnAltaEncuesta.UseVisualStyleBackColor = true;
            this.btnAltaEncuesta.Click += new System.EventHandler(this.btnAltaEncuesta_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 232);
            this.Controls.Add(this.btnAltaEncuesta);
            this.Controls.Add(this.btnListadoContactables);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnRegistroDeEncuesta);
            this.Name = "FormMenu";
            this.Text = "Secretaría de transporte de su magestad!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroDeEncuesta;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.Button btnListadoContactables;
        private System.Windows.Forms.Button btnAltaEncuesta;
    }
}


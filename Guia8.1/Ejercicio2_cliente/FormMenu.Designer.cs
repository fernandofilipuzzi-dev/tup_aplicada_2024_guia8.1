
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
            this.btnCerrarEncuesta = new System.Windows.Forms.Button();
            this.btnListadoContactables = new System.Windows.Forms.Button();
            this.btnAltaEncuesta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroDeEncuesta
            // 
            this.btnRegistroDeEncuesta.Location = new System.Drawing.Point(129, 94);
            this.btnRegistroDeEncuesta.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistroDeEncuesta.Name = "btnRegistroDeEncuesta";
            this.btnRegistroDeEncuesta.Size = new System.Drawing.Size(244, 47);
            this.btnRegistroDeEncuesta.TabIndex = 0;
            this.btnRegistroDeEncuesta.Text = "Registro De Encuesta";
            this.btnRegistroDeEncuesta.UseVisualStyleBackColor = true;
            this.btnRegistroDeEncuesta.Click += new System.EventHandler(this.btnRegistroDeEncuesta_Click);
            // 
            // btnCerrarEncuesta
            // 
            this.btnCerrarEncuesta.Location = new System.Drawing.Point(129, 148);
            this.btnCerrarEncuesta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarEncuesta.Name = "btnCerrarEncuesta";
            this.btnCerrarEncuesta.Size = new System.Drawing.Size(244, 47);
            this.btnCerrarEncuesta.TabIndex = 1;
            this.btnCerrarEncuesta.Text = "Cerrar Encuesta";
            this.btnCerrarEncuesta.UseVisualStyleBackColor = true;
            this.btnCerrarEncuesta.Click += new System.EventHandler(this.btnCerrarEncuesta_Click);
            // 
            // btnListadoContactables
            // 
            this.btnListadoContactables.Location = new System.Drawing.Point(129, 202);
            this.btnListadoContactables.Margin = new System.Windows.Forms.Padding(4);
            this.btnListadoContactables.Name = "btnListadoContactables";
            this.btnListadoContactables.Size = new System.Drawing.Size(244, 47);
            this.btnListadoContactables.TabIndex = 2;
            this.btnListadoContactables.Text = "Ver Estadistica";
            this.btnListadoContactables.UseVisualStyleBackColor = true;
            this.btnListadoContactables.Click += new System.EventHandler(this.btnListadoContactables_Click);
            // 
            // btnAltaEncuesta
            // 
            this.btnAltaEncuesta.Location = new System.Drawing.Point(129, 39);
            this.btnAltaEncuesta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaEncuesta.Name = "btnAltaEncuesta";
            this.btnAltaEncuesta.Size = new System.Drawing.Size(244, 47);
            this.btnAltaEncuesta.TabIndex = 3;
            this.btnAltaEncuesta.Text = "Alta Encuesta";
            this.btnAltaEncuesta.UseVisualStyleBackColor = true;
            this.btnAltaEncuesta.Click += new System.EventHandler(this.btnAltaEncuesta_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 286);
            this.Controls.Add(this.btnAltaEncuesta);
            this.Controls.Add(this.btnListadoContactables);
            this.Controls.Add(this.btnCerrarEncuesta);
            this.Controls.Add(this.btnRegistroDeEncuesta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaría de transporte de su magestad!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroDeEncuesta;
        private System.Windows.Forms.Button btnCerrarEncuesta;
        private System.Windows.Forms.Button btnListadoContactables;
        private System.Windows.Forms.Button btnAltaEncuesta;
    }
}


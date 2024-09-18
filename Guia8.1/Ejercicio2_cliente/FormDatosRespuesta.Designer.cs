
namespace EncuestasForm
{
    partial class FormDatosRespuesta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkUsaBicicleta = new System.Windows.Forms.CheckBox();
            this.chkUsaAuto = new System.Windows.Forms.CheckBox();
            this.chkTranspPub = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDistanciaDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPuedeSerContactado = new System.Windows.Forms.CheckBox();
            this.tbDomicilioOrigen = new System.Windows.Forms.TextBox();
            this.tbDomicilioDestino = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Location = new System.Drawing.Point(39, 395);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(252, 395);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkUsaBicicleta
            // 
            this.chkUsaBicicleta.AutoSize = true;
            this.chkUsaBicicleta.Location = new System.Drawing.Point(153, 38);
            this.chkUsaBicicleta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUsaBicicleta.Name = "chkUsaBicicleta";
            this.chkUsaBicicleta.Size = new System.Drawing.Size(109, 20);
            this.chkUsaBicicleta.TabIndex = 2;
            this.chkUsaBicicleta.Text = "¿Usa Bicleta?";
            this.chkUsaBicicleta.UseVisualStyleBackColor = true;
            // 
            // chkUsaAuto
            // 
            this.chkUsaAuto.AutoSize = true;
            this.chkUsaAuto.Location = new System.Drawing.Point(153, 66);
            this.chkUsaAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkUsaAuto.Name = "chkUsaAuto";
            this.chkUsaAuto.Size = new System.Drawing.Size(126, 20);
            this.chkUsaAuto.TabIndex = 3;
            this.chkUsaAuto.Text = "¿Usa automóvil?";
            this.chkUsaAuto.UseVisualStyleBackColor = true;
            // 
            // chkTranspPub
            // 
            this.chkTranspPub.AutoSize = true;
            this.chkTranspPub.Location = new System.Drawing.Point(153, 95);
            this.chkTranspPub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTranspPub.Name = "chkTranspPub";
            this.chkTranspPub.Size = new System.Drawing.Size(175, 20);
            this.chkTranspPub.TabIndex = 4;
            this.chkTranspPub.Text = "¿Usa transporte público?";
            this.chkTranspPub.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUsaBicicleta);
            this.groupBox1.Controls.Add(this.chkTranspPub);
            this.groupBox1.Controls.Add(this.chkUsaAuto);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(395, 133);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de transporte habitual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbDomicilioDestino);
            this.groupBox2.Controls.Add(this.tbDomicilioOrigen);
            this.groupBox2.Controls.Add(this.tbDistanciaDestino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(395, 149);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobre el destino al trabajo/estudio";
            // 
            // tbDistanciaDestino
            // 
            this.tbDistanciaDestino.Location = new System.Drawing.Point(160, 26);
            this.tbDistanciaDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDistanciaDestino.Name = "tbDistanciaDestino";
            this.tbDistanciaDestino.Size = new System.Drawing.Size(115, 22);
            this.tbDistanciaDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia en (km)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chkPuedeSerContactado);
            this.groupBox3.Location = new System.Drawing.Point(7, 300);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(395, 87);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(155, 52);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(212, 22);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDistanciaASuDestino_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // chkPuedeSerContactado
            // 
            this.chkPuedeSerContactado.AutoSize = true;
            this.chkPuedeSerContactado.Location = new System.Drawing.Point(155, 23);
            this.chkPuedeSerContactado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPuedeSerContactado.Name = "chkPuedeSerContactado";
            this.chkPuedeSerContactado.Size = new System.Drawing.Size(172, 20);
            this.chkPuedeSerContactado.TabIndex = 2;
            this.chkPuedeSerContactado.Text = "¿Puede ser contactado?";
            this.chkPuedeSerContactado.UseVisualStyleBackColor = true;
            this.chkPuedeSerContactado.CheckedChanged += new System.EventHandler(this.chkPuedeSerContactado_CheckedChanged);
            // 
            // tbDomicilioOrigen
            // 
            this.tbDomicilioOrigen.Location = new System.Drawing.Point(160, 69);
            this.tbDomicilioOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDomicilioOrigen.Name = "tbDomicilioOrigen";
            this.tbDomicilioOrigen.Size = new System.Drawing.Size(225, 22);
            this.tbDomicilioOrigen.TabIndex = 2;
            // 
            // tbDomicilioDestino
            // 
            this.tbDomicilioDestino.Location = new System.Drawing.Point(160, 101);
            this.tbDomicilioDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDomicilioDestino.Name = "tbDomicilioDestino";
            this.tbDomicilioDestino.Size = new System.Drawing.Size(225, 22);
            this.tbDomicilioDestino.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Domicilio Origen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Domicilio Destino";
            // 
            // FormDatosRespuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirmar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormDatosRespuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de encuesta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox chkUsaBicicleta;
        public System.Windows.Forms.CheckBox chkUsaAuto;
        public System.Windows.Forms.CheckBox chkTranspPub;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox tbDistanciaDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkPuedeSerContactado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbDomicilioDestino;
        public System.Windows.Forms.TextBox tbDomicilioOrigen;
    }
}
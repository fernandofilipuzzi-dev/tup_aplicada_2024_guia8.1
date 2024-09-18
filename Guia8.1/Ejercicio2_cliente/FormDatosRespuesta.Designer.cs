
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
            this.tbDistanciaASuDestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPuedeSerContactado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmar.Location = new System.Drawing.Point(29, 255);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(189, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // chkUsaBicicleta
            // 
            this.chkUsaBicicleta.AutoSize = true;
            this.chkUsaBicicleta.Location = new System.Drawing.Point(115, 31);
            this.chkUsaBicicleta.Name = "chkUsaBicicleta";
            this.chkUsaBicicleta.Size = new System.Drawing.Size(92, 17);
            this.chkUsaBicicleta.TabIndex = 2;
            this.chkUsaBicicleta.Text = "¿Usa Bicleta?";
            this.chkUsaBicicleta.UseVisualStyleBackColor = true;
            // 
            // chkUsaAuto
            // 
            this.chkUsaAuto.AutoSize = true;
            this.chkUsaAuto.Location = new System.Drawing.Point(115, 54);
            this.chkUsaAuto.Name = "chkUsaAuto";
            this.chkUsaAuto.Size = new System.Drawing.Size(105, 17);
            this.chkUsaAuto.TabIndex = 3;
            this.chkUsaAuto.Text = "¿Usa automóvil?";
            this.chkUsaAuto.UseVisualStyleBackColor = true;
            // 
            // chkTranspPub
            // 
            this.chkTranspPub.AutoSize = true;
            this.chkTranspPub.Location = new System.Drawing.Point(115, 77);
            this.chkTranspPub.Name = "chkTranspPub";
            this.chkTranspPub.Size = new System.Drawing.Size(144, 17);
            this.chkTranspPub.TabIndex = 4;
            this.chkTranspPub.Text = "¿Usa transporte público?";
            this.chkTranspPub.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUsaBicicleta);
            this.groupBox1.Controls.Add(this.chkTranspPub);
            this.groupBox1.Controls.Add(this.chkUsaAuto);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de transporte habitual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDistanciaASuDestino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sobre el destino al trabajo/estudio";
            // 
            // tbDistanciaASuDestino
            // 
            this.tbDistanciaASuDestino.Location = new System.Drawing.Point(120, 21);
            this.tbDistanciaASuDestino.Name = "tbDistanciaASuDestino";
            this.tbDistanciaASuDestino.Size = new System.Drawing.Size(87, 20);
            this.tbDistanciaASuDestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distancia en (km)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbEmail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.chkPuedeSerContactado);
            this.groupBox3.Location = new System.Drawing.Point(5, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 71);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contacto";
            // 
            // tbEmail
            // 
            this.tbEmail.Enabled = false;
            this.tbEmail.Location = new System.Drawing.Point(116, 42);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(160, 20);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDistanciaASuDestino_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // chkPuedeSerContactado
            // 
            this.chkPuedeSerContactado.AutoSize = true;
            this.chkPuedeSerContactado.Location = new System.Drawing.Point(116, 19);
            this.chkPuedeSerContactado.Name = "chkPuedeSerContactado";
            this.chkPuedeSerContactado.Size = new System.Drawing.Size(143, 17);
            this.chkPuedeSerContactado.TabIndex = 2;
            this.chkPuedeSerContactado.Text = "¿Puede ser contactado?";
            this.chkPuedeSerContactado.UseVisualStyleBackColor = true;
            this.chkPuedeSerContactado.CheckedChanged += new System.EventHandler(this.chkPuedeSerContactado_CheckedChanged);
            // 
            // FormRegistroDeEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 281);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "FormRegistroDeEncuesta";
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
        public System.Windows.Forms.TextBox tbDistanciaASuDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox chkPuedeSerContactado;
    }
}
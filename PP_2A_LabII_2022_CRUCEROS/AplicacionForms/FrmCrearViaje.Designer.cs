
namespace AplicacionForms
{
    partial class FrmCrearViaje
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCruceros = new System.Windows.Forms.GroupBox();
            this.cbCruceros = new System.Windows.Forms.ComboBox();
            this.groupBoxCruceros2 = new System.Windows.Forms.GroupBox();
            this.rbExtraRegional = new System.Windows.Forms.RadioButton();
            this.rbRegional = new System.Windows.Forms.RadioButton();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.gbFechasOcupadas = new System.Windows.Forms.GroupBox();
            this.cbFechaLlegada = new System.Windows.Forms.ComboBox();
            this.cbFechaInicio = new System.Windows.Forms.ComboBox();
            this.gbFechaSalida = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCruceros.SuspendLayout();
            this.groupBoxCruceros2.SuspendLayout();
            this.gbFechasOcupadas.SuspendLayout();
            this.gbFechaSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacionForms.Properties.Resources.cruise_ship_logo_icon_png_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(735, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(770, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 94);
            this.label1.TabIndex = 9;
            this.label1.Text = " CREAR\r\nVIAJES";
            // 
            // gbCruceros
            // 
            this.gbCruceros.Controls.Add(this.cbCruceros);
            this.gbCruceros.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbCruceros.Location = new System.Drawing.Point(26, 46);
            this.gbCruceros.Name = "gbCruceros";
            this.gbCruceros.Size = new System.Drawing.Size(300, 150);
            this.gbCruceros.TabIndex = 10;
            this.gbCruceros.TabStop = false;
            this.gbCruceros.Text = "CRUCEROS";
            // 
            // cbCruceros
            // 
            this.cbCruceros.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCruceros.FormattingEnabled = true;
            this.cbCruceros.Location = new System.Drawing.Point(28, 57);
            this.cbCruceros.Name = "cbCruceros";
            this.cbCruceros.Size = new System.Drawing.Size(241, 34);
            this.cbCruceros.TabIndex = 0;
            this.cbCruceros.SelectedIndexChanged += new System.EventHandler(this.cbCruceros_SelectedIndexChanged);
            // 
            // groupBoxCruceros2
            // 
            this.groupBoxCruceros2.Controls.Add(this.rbExtraRegional);
            this.groupBoxCruceros2.Controls.Add(this.rbRegional);
            this.groupBoxCruceros2.Controls.Add(this.cbDestino);
            this.groupBoxCruceros2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxCruceros2.Location = new System.Drawing.Point(394, 46);
            this.groupBoxCruceros2.Name = "groupBoxCruceros2";
            this.groupBoxCruceros2.Size = new System.Drawing.Size(300, 202);
            this.groupBoxCruceros2.TabIndex = 11;
            this.groupBoxCruceros2.TabStop = false;
            this.groupBoxCruceros2.Text = "CRUCEROS (Destino)";
            // 
            // rbExtraRegional
            // 
            this.rbExtraRegional.AutoSize = true;
            this.rbExtraRegional.Location = new System.Drawing.Point(26, 93);
            this.rbExtraRegional.Name = "rbExtraRegional";
            this.rbExtraRegional.Size = new System.Drawing.Size(205, 30);
            this.rbExtraRegional.TabIndex = 2;
            this.rbExtraRegional.TabStop = true;
            this.rbExtraRegional.Text = "Extra Regional";
            this.rbExtraRegional.UseVisualStyleBackColor = true;
            this.rbExtraRegional.CheckedChanged += new System.EventHandler(this.rbExtraRegional_CheckedChanged);
            // 
            // rbRegional
            // 
            this.rbRegional.AutoSize = true;
            this.rbRegional.Location = new System.Drawing.Point(26, 45);
            this.rbRegional.Name = "rbRegional";
            this.rbRegional.Size = new System.Drawing.Size(133, 30);
            this.rbRegional.TabIndex = 1;
            this.rbRegional.TabStop = true;
            this.rbRegional.Text = "Regional";
            this.rbRegional.UseVisualStyleBackColor = true;
            this.rbRegional.CheckedChanged += new System.EventHandler(this.rbRegional_CheckedChanged);
            // 
            // cbDestino
            // 
            this.cbDestino.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(26, 144);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(241, 34);
            this.cbDestino.TabIndex = 0;
            // 
            // gbFechasOcupadas
            // 
            this.gbFechasOcupadas.Controls.Add(this.cbFechaLlegada);
            this.gbFechasOcupadas.Controls.Add(this.cbFechaInicio);
            this.gbFechasOcupadas.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbFechasOcupadas.Location = new System.Drawing.Point(26, 229);
            this.gbFechasOcupadas.Name = "gbFechasOcupadas";
            this.gbFechasOcupadas.Size = new System.Drawing.Size(300, 180);
            this.gbFechasOcupadas.TabIndex = 12;
            this.gbFechasOcupadas.TabStop = false;
            this.gbFechasOcupadas.Text = "FECHAS OCUPADAS";
            // 
            // cbFechaLlegada
            // 
            this.cbFechaLlegada.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFechaLlegada.FormattingEnabled = true;
            this.cbFechaLlegada.Location = new System.Drawing.Point(28, 114);
            this.cbFechaLlegada.Name = "cbFechaLlegada";
            this.cbFechaLlegada.Size = new System.Drawing.Size(241, 34);
            this.cbFechaLlegada.TabIndex = 13;
            // 
            // cbFechaInicio
            // 
            this.cbFechaInicio.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFechaInicio.FormattingEnabled = true;
            this.cbFechaInicio.Location = new System.Drawing.Point(28, 43);
            this.cbFechaInicio.Name = "cbFechaInicio";
            this.cbFechaInicio.Size = new System.Drawing.Size(241, 34);
            this.cbFechaInicio.TabIndex = 0;
            this.cbFechaInicio.SelectedIndexChanged += new System.EventHandler(this.cbFechaInicio_SelectedIndexChanged);
            // 
            // gbFechaSalida
            // 
            this.gbFechaSalida.Controls.Add(this.dateTimePickerFechaSalida);
            this.gbFechaSalida.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbFechaSalida.Location = new System.Drawing.Point(394, 272);
            this.gbFechaSalida.Name = "gbFechaSalida";
            this.gbFechaSalida.Size = new System.Drawing.Size(300, 137);
            this.gbFechaSalida.TabIndex = 13;
            this.gbFechaSalida.TabStop = false;
            this.gbFechaSalida.Text = "FECHA SALIDA";
            // 
            // dateTimePickerFechaSalida
            // 
            this.dateTimePickerFechaSalida.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFechaSalida.Location = new System.Drawing.Point(17, 57);
            this.dateTimePickerFechaSalida.Name = "dateTimePickerFechaSalida";
            this.dateTimePickerFechaSalida.Size = new System.Drawing.Size(266, 29);
            this.dateTimePickerFechaSalida.TabIndex = 1;
            this.dateTimePickerFechaSalida.CloseUp += new System.EventHandler(this.dateTimePickerFechaSalida_CloseUp);
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrearViaje.FlatAppearance.BorderSize = 0;
            this.btnCrearViaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearViaje.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearViaje.ForeColor = System.Drawing.Color.Black;
            this.btnCrearViaje.Location = new System.Drawing.Point(67, 444);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(164, 90);
            this.btnCrearViaje.TabIndex = 21;
            this.btnCrearViaje.Text = "CREAR\r\nVIAJE";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(770, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(164, 90);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.Black;
            this.btnHelp.Location = new System.Drawing.Point(420, 444);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(164, 90);
            this.btnHelp.TabIndex = 23;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FrmCrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(985, 546);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearViaje);
            this.Controls.Add(this.gbFechaSalida);
            this.Controls.Add(this.gbFechasOcupadas);
            this.Controls.Add(this.groupBoxCruceros2);
            this.Controls.Add(this.gbCruceros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCrearViaje";
            this.Text = "FrmCrearViaje";
            this.Load += new System.EventHandler(this.FrmCrearViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCruceros.ResumeLayout(false);
            this.groupBoxCruceros2.ResumeLayout(false);
            this.groupBoxCruceros2.PerformLayout();
            this.gbFechasOcupadas.ResumeLayout(false);
            this.gbFechaSalida.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCruceros;
        private System.Windows.Forms.ComboBox cbCruceros;
        private System.Windows.Forms.GroupBox groupBoxCruceros2;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.RadioButton rbRegional;
        private System.Windows.Forms.RadioButton rbExtraRegional;
        private System.Windows.Forms.GroupBox gbFechasOcupadas;
        private System.Windows.Forms.ComboBox cbFechaInicio;
        private System.Windows.Forms.ComboBox cbFechaLlegada;
        private System.Windows.Forms.GroupBox gbFechaSalida;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaSalida;
        private System.Windows.Forms.Button btnCrearViaje;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnHelp;
    }
}
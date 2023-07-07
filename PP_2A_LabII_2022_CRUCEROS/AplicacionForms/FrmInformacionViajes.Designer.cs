
namespace AplicacionForms
{
    partial class FrmInformacionViajes
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbViajes = new System.Windows.Forms.ComboBox();
            this.txtViajes = new System.Windows.Forms.TextBox();
            this.txtCrucero = new System.Windows.Forms.TextBox();
            this.txtPasajeros1 = new System.Windows.Forms.TextBox();
            this.txtPasajeros2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.cbNacionalidad = new System.Windows.Forms.ComboBox();
            this.btnApellido = new System.Windows.Forms.Button();
            this.buttonDNI = new System.Windows.Forms.Button();
            this.btnNacionalidad = new System.Windows.Forms.Button();
            this.btnSacarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplicacionForms.Properties.Resources.cruise_ship_logo_icon_png_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(79, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(79, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 28);
            this.label5.TabIndex = 19;
            this.label5.Text = "TITANIC RISEN";
            // 
            // cbViajes
            // 
            this.cbViajes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbViajes.FormattingEnabled = true;
            this.cbViajes.Location = new System.Drawing.Point(653, 31);
            this.cbViajes.Name = "cbViajes";
            this.cbViajes.Size = new System.Drawing.Size(663, 30);
            this.cbViajes.TabIndex = 20;
            this.cbViajes.SelectedIndexChanged += new System.EventHandler(this.cbViajes_SelectedIndexChanged);
            // 
            // txtViajes
            // 
            this.txtViajes.BackColor = System.Drawing.SystemColors.Window;
            this.txtViajes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtViajes.Location = new System.Drawing.Point(369, 114);
            this.txtViajes.Margin = new System.Windows.Forms.Padding(4);
            this.txtViajes.Multiline = true;
            this.txtViajes.Name = "txtViajes";
            this.txtViajes.ReadOnly = true;
            this.txtViajes.Size = new System.Drawing.Size(604, 330);
            this.txtViajes.TabIndex = 21;
            // 
            // txtCrucero
            // 
            this.txtCrucero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCrucero.BackColor = System.Drawing.SystemColors.Window;
            this.txtCrucero.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCrucero.Location = new System.Drawing.Point(1017, 114);
            this.txtCrucero.Margin = new System.Windows.Forms.Padding(4);
            this.txtCrucero.Multiline = true;
            this.txtCrucero.Name = "txtCrucero";
            this.txtCrucero.ReadOnly = true;
            this.txtCrucero.Size = new System.Drawing.Size(604, 330);
            this.txtCrucero.TabIndex = 22;
            // 
            // txtPasajeros1
            // 
            this.txtPasajeros1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPasajeros1.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasajeros1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasajeros1.Location = new System.Drawing.Point(369, 508);
            this.txtPasajeros1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasajeros1.Multiline = true;
            this.txtPasajeros1.Name = "txtPasajeros1";
            this.txtPasajeros1.ReadOnly = true;
            this.txtPasajeros1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasajeros1.Size = new System.Drawing.Size(604, 360);
            this.txtPasajeros1.TabIndex = 23;
            // 
            // txtPasajeros2
            // 
            this.txtPasajeros2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPasajeros2.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasajeros2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasajeros2.Location = new System.Drawing.Point(1017, 508);
            this.txtPasajeros2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasajeros2.Multiline = true;
            this.txtPasajeros2.Name = "txtPasajeros2";
            this.txtPasajeros2.ReadOnly = true;
            this.txtPasajeros2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPasajeros2.Size = new System.Drawing.Size(604, 360);
            this.txtPasajeros2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(69, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "FILTRAR PASAJERO";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxApellido.Location = new System.Drawing.Point(12, 508);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(181, 29);
            this.textBoxApellido.TabIndex = 26;
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDNI.Location = new System.Drawing.Point(12, 590);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(181, 29);
            this.textBoxDNI.TabIndex = 27;
            // 
            // cbNacionalidad
            // 
            this.cbNacionalidad.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNacionalidad.FormattingEnabled = true;
            this.cbNacionalidad.Location = new System.Drawing.Point(12, 664);
            this.cbNacionalidad.Name = "cbNacionalidad";
            this.cbNacionalidad.Size = new System.Drawing.Size(182, 30);
            this.cbNacionalidad.TabIndex = 28;
            // 
            // btnApellido
            // 
            this.btnApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApellido.FlatAppearance.BorderSize = 0;
            this.btnApellido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApellido.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApellido.ForeColor = System.Drawing.Color.Black;
            this.btnApellido.Location = new System.Drawing.Point(199, 508);
            this.btnApellido.Name = "btnApellido";
            this.btnApellido.Size = new System.Drawing.Size(163, 42);
            this.btnApellido.TabIndex = 29;
            this.btnApellido.Text = "APELLIDO";
            this.btnApellido.UseVisualStyleBackColor = true;
            this.btnApellido.Click += new System.EventHandler(this.btnApellido_Click);
            // 
            // buttonDNI
            // 
            this.buttonDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDNI.FlatAppearance.BorderSize = 0;
            this.buttonDNI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDNI.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDNI.ForeColor = System.Drawing.Color.Black;
            this.buttonDNI.Location = new System.Drawing.Point(199, 582);
            this.buttonDNI.Name = "buttonDNI";
            this.buttonDNI.Size = new System.Drawing.Size(163, 42);
            this.buttonDNI.TabIndex = 30;
            this.buttonDNI.Text = "DNI";
            this.buttonDNI.UseVisualStyleBackColor = true;
            this.buttonDNI.Click += new System.EventHandler(this.buttonDNI_Click);
            // 
            // btnNacionalidad
            // 
            this.btnNacionalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNacionalidad.FlatAppearance.BorderSize = 0;
            this.btnNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNacionalidad.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNacionalidad.ForeColor = System.Drawing.Color.Black;
            this.btnNacionalidad.Location = new System.Drawing.Point(199, 656);
            this.btnNacionalidad.Name = "btnNacionalidad";
            this.btnNacionalidad.Size = new System.Drawing.Size(163, 42);
            this.btnNacionalidad.TabIndex = 31;
            this.btnNacionalidad.Text = "NACIONALIDAD";
            this.btnNacionalidad.UseVisualStyleBackColor = true;
            this.btnNacionalidad.Click += new System.EventHandler(this.btnNacionalidad_Click);
            // 
            // btnSacarFiltro
            // 
            this.btnSacarFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSacarFiltro.FlatAppearance.BorderSize = 0;
            this.btnSacarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacarFiltro.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSacarFiltro.ForeColor = System.Drawing.Color.Black;
            this.btnSacarFiltro.Location = new System.Drawing.Point(69, 735);
            this.btnSacarFiltro.Name = "btnSacarFiltro";
            this.btnSacarFiltro.Size = new System.Drawing.Size(163, 42);
            this.btnSacarFiltro.TabIndex = 32;
            this.btnSacarFiltro.Text = "QUITAR FILTRO";
            this.btnSacarFiltro.UseVisualStyleBackColor = true;
            this.btnSacarFiltro.Click += new System.EventHandler(this.btnSacarFiltro_Click);
            // 
            // FrmInformacionViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1643, 922);
            this.Controls.Add(this.btnSacarFiltro);
            this.Controls.Add(this.btnNacionalidad);
            this.Controls.Add(this.buttonDNI);
            this.Controls.Add(this.btnApellido);
            this.Controls.Add(this.cbNacionalidad);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasajeros2);
            this.Controls.Add(this.txtPasajeros1);
            this.Controls.Add(this.txtCrucero);
            this.Controls.Add(this.txtViajes);
            this.Controls.Add(this.cbViajes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInformacionViajes";
            this.Text = "FrmInformacionViajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInformacionViajes_FormClosing);
            this.Load += new System.EventHandler(this.FrmInformacionViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbViajes;
        private System.Windows.Forms.TextBox txtViajes;
        private System.Windows.Forms.TextBox txtCrucero;
        private System.Windows.Forms.TextBox txtPasajeros1;
        private System.Windows.Forms.TextBox txtPasajeros2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.ComboBox cbNacionalidad;
        private System.Windows.Forms.Button btnApellido;
        private System.Windows.Forms.Button buttonDNI;
        private System.Windows.Forms.Button btnNacionalidad;
        private System.Windows.Forms.Button btnSacarFiltro;
    }
}

namespace AplicacionForms
{
    partial class FrmContendorEstadisticas
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
            this.btnDestinos = new System.Windows.Forms.Button();
            this.btnCruceros = new System.Windows.Forms.Button();
            this.btnPasajeros = new System.Windows.Forms.Button();
            this.panelEstadisticas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDestinos
            // 
            this.btnDestinos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDestinos.FlatAppearance.BorderSize = 0;
            this.btnDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDestinos.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDestinos.ForeColor = System.Drawing.Color.Black;
            this.btnDestinos.Location = new System.Drawing.Point(-1, -2);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(281, 100);
            this.btnDestinos.TabIndex = 30;
            this.btnDestinos.Text = "DESTINOS";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // btnCruceros
            // 
            this.btnCruceros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCruceros.FlatAppearance.BorderSize = 0;
            this.btnCruceros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCruceros.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCruceros.ForeColor = System.Drawing.Color.Black;
            this.btnCruceros.Location = new System.Drawing.Point(581, -2);
            this.btnCruceros.Name = "btnCruceros";
            this.btnCruceros.Size = new System.Drawing.Size(262, 100);
            this.btnCruceros.TabIndex = 31;
            this.btnCruceros.Text = "CRUCEROS";
            this.btnCruceros.UseVisualStyleBackColor = true;
            this.btnCruceros.Click += new System.EventHandler(this.btnCruceros_Click);
            // 
            // btnPasajeros
            // 
            this.btnPasajeros.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPasajeros.FlatAppearance.BorderSize = 0;
            this.btnPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasajeros.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPasajeros.ForeColor = System.Drawing.Color.Black;
            this.btnPasajeros.Location = new System.Drawing.Point(277, -2);
            this.btnPasajeros.Name = "btnPasajeros";
            this.btnPasajeros.Size = new System.Drawing.Size(308, 100);
            this.btnPasajeros.TabIndex = 32;
            this.btnPasajeros.Text = "PASAJEROS";
            this.btnPasajeros.UseVisualStyleBackColor = true;
            this.btnPasajeros.Click += new System.EventHandler(this.btnPasajeros_Click);
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.Location = new System.Drawing.Point(-1, 95);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(844, 594);
            this.panelEstadisticas.TabIndex = 33;
            // 
            // FrmContendorEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 690);
            this.Controls.Add(this.panelEstadisticas);
            this.Controls.Add(this.btnPasajeros);
            this.Controls.Add(this.btnCruceros);
            this.Controls.Add(this.btnDestinos);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContendorEstadisticas";
            this.Text = "TITANIC RISEN - ESTADISTICAS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Button btnCruceros;
        private System.Windows.Forms.Button btnPasajeros;
        private System.Windows.Forms.Panel panelEstadisticas;
    }
}

namespace App_Forms_Farmacia.Farmaceutico
{
    partial class FrmAddMedicina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddMedicina));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExitPanel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtIDMedicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreMedicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumMedicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantMedicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioPorUnida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaElaboracion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(-7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "AÑADIR MEDICINA";
            // 
            // BtnExitPanel
            // 
            this.BtnExitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitPanel.ForeColor = System.Drawing.Color.White;
            this.BtnExitPanel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExitPanel.Image")));
            this.BtnExitPanel.Location = new System.Drawing.Point(965, -12);
            this.BtnExitPanel.Name = "BtnExitPanel";
            this.BtnExitPanel.Size = new System.Drawing.Size(65, 72);
            this.BtnExitPanel.TabIndex = 12;
            this.BtnExitPanel.UseVisualStyleBackColor = true;
            this.BtnExitPanel.Click += new System.EventHandler(this.BtnExitPanel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(3, 880);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 41);
            this.btnHelp.TabIndex = 14;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // txtIDMedicina
            // 
            this.txtIDMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDMedicina.Location = new System.Drawing.Point(12, 194);
            this.txtIDMedicina.Name = "txtIDMedicina";
            this.txtIDMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtIDMedicina.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Medicina";
            // 
            // txtNombreMedicina
            // 
            this.txtNombreMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreMedicina.Location = new System.Drawing.Point(12, 300);
            this.txtNombreMedicina.Name = "txtNombreMedicina";
            this.txtNombreMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtNombreMedicina.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Medicina";
            // 
            // txtNumMedicina
            // 
            this.txtNumMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumMedicina.Location = new System.Drawing.Point(12, 409);
            this.txtNumMedicina.Name = "txtNumMedicina";
            this.txtNumMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtNumMedicina.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 26);
            this.label3.TabIndex = 19;
            this.label3.Text = "Número Medicina";
            // 
            // txtCantMedicina
            // 
            this.txtCantMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantMedicina.Location = new System.Drawing.Point(12, 531);
            this.txtCantMedicina.Name = "txtCantMedicina";
            this.txtCantMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtCantMedicina.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(12, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "Cantidad";
            // 
            // txtPrecioPorUnida
            // 
            this.txtPrecioPorUnida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioPorUnida.Location = new System.Drawing.Point(597, 409);
            this.txtPrecioPorUnida.Name = "txtPrecioPorUnida";
            this.txtPrecioPorUnida.Size = new System.Drawing.Size(326, 37);
            this.txtPrecioPorUnida.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(597, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 23;
            this.label6.Text = "Precio por Unidad";
            // 
            // dtpFechaElaboracion
            // 
            this.dtpFechaElaboracion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaElaboracion.Location = new System.Drawing.Point(597, 194);
            this.dtpFechaElaboracion.Name = "dtpFechaElaboracion";
            this.dtpFechaElaboracion.Size = new System.Drawing.Size(326, 37);
            this.dtpFechaElaboracion.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(597, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 26);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fecha de Elaboración:";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(597, 300);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(326, 37);
            this.dtpFechaVencimiento.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(597, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "Fecha de Vencimiento:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(824, 515);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 74);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAñadir.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAñadir.ForeColor = System.Drawing.Color.Black;
            this.btnAñadir.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadir.Image")));
            this.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadir.Location = new System.Drawing.Point(575, 515);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(207, 74);
            this.btnAñadir.TabIndex = 29;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // FrmAddMedicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 933);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaElaboracion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecioPorUnida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantMedicina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumMedicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreMedicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDMedicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.BtnExitPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(712, 40);
            this.Name = "FrmAddMedicina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmAddMedicina";
            this.Load += new System.EventHandler(this.FrmAddMedicina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExitPanel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.TextBox txtIDMedicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreMedicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumMedicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantMedicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioPorUnida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaElaboracion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAñadir;
    }
}
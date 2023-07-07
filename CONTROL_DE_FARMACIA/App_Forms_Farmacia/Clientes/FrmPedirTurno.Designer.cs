
namespace App_Forms_Farmacia.Clientes
{
    partial class FrmPedirTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedirTurno));
            this.btnHelp = new System.Windows.Forms.Button();
            this.BtnExitPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaTurno = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEspecialidadMedico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNombreMedico = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHorarios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbObraSocial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLocalidad = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnPedirTurno = new System.Windows.Forms.Button();
            this.btnImprimirTurno = new System.Windows.Forms.Button();
            this.dataGridViewTurno = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(-1, 842);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 41);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // BtnExitPanel
            // 
            this.BtnExitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitPanel.ForeColor = System.Drawing.Color.White;
            this.BtnExitPanel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExitPanel.Image")));
            this.BtnExitPanel.Location = new System.Drawing.Point(1050, -12);
            this.BtnExitPanel.Name = "BtnExitPanel";
            this.BtnExitPanel.Size = new System.Drawing.Size(65, 72);
            this.BtnExitPanel.TabIndex = 15;
            this.BtnExitPanel.UseVisualStyleBackColor = true;
            this.BtnExitPanel.Click += new System.EventHandler(this.BtnExitPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "PEDIR TURNO";
            // 
            // dtpFechaTurno
            // 
            this.dtpFechaTurno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaTurno.Location = new System.Drawing.Point(694, 156);
            this.dtpFechaTurno.Name = "dtpFechaTurno";
            this.dtpFechaTurno.Size = new System.Drawing.Size(335, 37);
            this.dtpFechaTurno.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(694, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(324, 26);
            this.label7.TabIndex = 27;
            this.label7.Text = "SELECCIONAR FECHA DE TURNO";
            // 
            // cbEspecialidadMedico
            // 
            this.cbEspecialidadMedico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEspecialidadMedico.FormattingEnabled = true;
            this.cbEspecialidadMedico.Items.AddRange(new object[] {
            "OTORRINO",
            "CLINICO",
            "OFTALMOLOGO",
            "GINECOLOGO",
            "NUTRICIONISTA",
            "PEDIATRA",
            "UROLOGO"});
            this.cbEspecialidadMedico.Location = new System.Drawing.Point(70, 156);
            this.cbEspecialidadMedico.Name = "cbEspecialidadMedico";
            this.cbEspecialidadMedico.Size = new System.Drawing.Size(326, 38);
            this.cbEspecialidadMedico.TabIndex = 31;
            this.cbEspecialidadMedico.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidadMedico_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(70, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 26);
            this.label2.TabIndex = 32;
            this.label2.Text = "SELECCIONAR ESPECIALIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(70, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "MÉDICOS";
            // 
            // cbNombreMedico
            // 
            this.cbNombreMedico.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbNombreMedico.FormattingEnabled = true;
            this.cbNombreMedico.Location = new System.Drawing.Point(70, 283);
            this.cbNombreMedico.Name = "cbNombreMedico";
            this.cbNombreMedico.Size = new System.Drawing.Size(326, 38);
            this.cbNombreMedico.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(694, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "HORARIOS DISPONIBLES";
            // 
            // cbHorarios
            // 
            this.cbHorarios.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbHorarios.FormattingEnabled = true;
            this.cbHorarios.Location = new System.Drawing.Point(694, 283);
            this.cbHorarios.Name = "cbHorarios";
            this.cbHorarios.Size = new System.Drawing.Size(335, 38);
            this.cbHorarios.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(70, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "OBRA SOCIAL";
            // 
            // cbObraSocial
            // 
            this.cbObraSocial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbObraSocial.FormattingEnabled = true;
            this.cbObraSocial.Items.AddRange(new object[] {
            "Particular",
            "SECLA",
            "OSDE",
            "OSECAC"});
            this.cbObraSocial.Location = new System.Drawing.Point(70, 426);
            this.cbObraSocial.Name = "cbObraSocial";
            this.cbObraSocial.Size = new System.Drawing.Size(326, 38);
            this.cbObraSocial.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(694, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 26);
            this.label6.TabIndex = 40;
            this.label6.Text = "LOCALIDAD";
            // 
            // cbLocalidad
            // 
            this.cbLocalidad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbLocalidad.FormattingEnabled = true;
            this.cbLocalidad.Location = new System.Drawing.Point(694, 426);
            this.cbLocalidad.Name = "cbLocalidad";
            this.cbLocalidad.Size = new System.Drawing.Size(335, 38);
            this.cbLocalidad.TabIndex = 39;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(974, 805);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 65);
            this.btnRefresh.TabIndex = 42;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPedirTurno
            // 
            this.btnPedirTurno.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPedirTurno.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPedirTurno.ForeColor = System.Drawing.Color.Black;
            this.btnPedirTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnPedirTurno.Image")));
            this.btnPedirTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedirTurno.Location = new System.Drawing.Point(517, 805);
            this.btnPedirTurno.Name = "btnPedirTurno";
            this.btnPedirTurno.Size = new System.Drawing.Size(201, 65);
            this.btnPedirTurno.TabIndex = 41;
            this.btnPedirTurno.Text = "    Solicitar Turno";
            this.btnPedirTurno.UseVisualStyleBackColor = false;
            this.btnPedirTurno.Click += new System.EventHandler(this.btnPedirTurno_Click);
            // 
            // btnImprimirTurno
            // 
            this.btnImprimirTurno.BackColor = System.Drawing.Color.OliveDrab;
            this.btnImprimirTurno.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimirTurno.ForeColor = System.Drawing.Color.Black;
            this.btnImprimirTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirTurno.Image")));
            this.btnImprimirTurno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimirTurno.Location = new System.Drawing.Point(743, 805);
            this.btnImprimirTurno.Name = "btnImprimirTurno";
            this.btnImprimirTurno.Size = new System.Drawing.Size(214, 65);
            this.btnImprimirTurno.TabIndex = 82;
            this.btnImprimirTurno.Text = "Imprimir Turno";
            this.btnImprimirTurno.UseVisualStyleBackColor = false;
            this.btnImprimirTurno.Click += new System.EventHandler(this.btnImprimirTurno_Click);
            // 
            // dataGridViewTurno
            // 
            this.dataGridViewTurno.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTurno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewTurno.Location = new System.Drawing.Point(81, 565);
            this.dataGridViewTurno.Name = "dataGridViewTurno";
            this.dataGridViewTurno.RowHeadersWidth = 62;
            this.dataGridViewTurno.RowTemplate.Height = 33;
            this.dataGridViewTurno.Size = new System.Drawing.Size(963, 182);
            this.dataGridViewTurno.TabIndex = 83;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Especialidad";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Médico";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de Turno";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Horario";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Localidad";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Obra Social";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // FrmPedirTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 882);
            this.Controls.Add(this.dataGridViewTurno);
            this.Controls.Add(this.btnImprimirTurno);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnPedirTurno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbLocalidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbObraSocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbHorarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbNombreMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEspecialidadMedico);
            this.Controls.Add(this.dtpFechaTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.BtnExitPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(625, 69);
            this.Name = "FrmPedirTurno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmPedirTurno";
            this.Load += new System.EventHandler(this.FrmPedirTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button BtnExitPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaTurno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEspecialidadMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNombreMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbHorarios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbObraSocial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLocalidad;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnPedirTurno;
        private System.Windows.Forms.Button btnImprimirTurno;
        private System.Windows.Forms.DataGridView dataGridViewTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
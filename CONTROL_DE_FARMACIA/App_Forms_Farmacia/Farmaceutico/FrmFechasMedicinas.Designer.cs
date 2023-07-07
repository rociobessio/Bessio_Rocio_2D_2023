
namespace App_Forms_Farmacia.Farmaceutico
{
    partial class FrmFechasMedicinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFechasMedicinas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.BtnExitPanel = new System.Windows.Forms.Button();
            this.dataGridViewMedicinas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFechasMedicinas = new System.Windows.Forms.ComboBox();
            this.labelSet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicinas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "FECHAS DE MEDICINAS";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(1, 779);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 41);
            this.btnHelp.TabIndex = 27;
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
            this.BtnExitPanel.Location = new System.Drawing.Point(919, -12);
            this.BtnExitPanel.Name = "BtnExitPanel";
            this.BtnExitPanel.Size = new System.Drawing.Size(65, 72);
            this.BtnExitPanel.TabIndex = 28;
            this.BtnExitPanel.UseVisualStyleBackColor = true;
            this.BtnExitPanel.Click += new System.EventHandler(this.BtnExitPanel_Click);
            // 
            // dataGridViewMedicinas
            // 
            this.dataGridViewMedicinas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMedicinas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMedicinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicinas.Location = new System.Drawing.Point(24, 259);
            this.dataGridViewMedicinas.Name = "dataGridViewMedicinas";
            this.dataGridViewMedicinas.RowHeadersWidth = 62;
            this.dataGridViewMedicinas.RowTemplate.Height = 33;
            this.dataGridViewMedicinas.Size = new System.Drawing.Size(933, 473);
            this.dataGridViewMedicinas.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(272, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Check:";
            // 
            // cbFechasMedicinas
            // 
            this.cbFechasMedicinas.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbFechasMedicinas.FormattingEnabled = true;
            this.cbFechasMedicinas.Items.AddRange(new object[] {
            "Medicinas Validas",
            "Medicinas Vencidas",
            "Ver todas las medicinas"});
            this.cbFechasMedicinas.Location = new System.Drawing.Point(272, 164);
            this.cbFechasMedicinas.Name = "cbFechasMedicinas";
            this.cbFechasMedicinas.Size = new System.Drawing.Size(304, 34);
            this.cbFechasMedicinas.TabIndex = 31;
            this.cbFechasMedicinas.SelectedIndexChanged += new System.EventHandler(this.cbFechasMedicinas_SelectedIndexChanged);
            // 
            // labelSet
            // 
            this.labelSet.AutoSize = true;
            this.labelSet.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelSet.Location = new System.Drawing.Point(24, 228);
            this.labelSet.Name = "labelSet";
            this.labelSet.Size = new System.Drawing.Size(51, 28);
            this.labelSet.TabIndex = 32;
            this.labelSet.Text = "Set";
            // 
            // FrmFechasMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 821);
            this.Controls.Add(this.labelSet);
            this.Controls.Add(this.cbFechasMedicinas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMedicinas);
            this.Controls.Add(this.BtnExitPanel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(712, 40);
            this.Name = "FrmFechasMedicinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmFechasMedicinas";
            this.Load += new System.EventHandler(this.FrmFechasMedicinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button BtnExitPanel;
        private System.Windows.Forms.DataGridView dataGridViewMedicinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFechasMedicinas;
        private System.Windows.Forms.Label labelSet;
    }
}
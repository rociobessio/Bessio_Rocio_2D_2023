
namespace App_Forms_Farmacia.Clientes
{
    partial class FrmVerTurnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerTurnos));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExitPanel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.dataGridViewTurnos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 51);
            this.label1.TabIndex = 18;
            this.label1.Text = "VISUALIZAR TURNOS";
            // 
            // BtnExitPanel
            // 
            this.BtnExitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitPanel.ForeColor = System.Drawing.Color.White;
            this.BtnExitPanel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExitPanel.Image")));
            this.BtnExitPanel.Location = new System.Drawing.Point(1048, -6);
            this.BtnExitPanel.Name = "BtnExitPanel";
            this.BtnExitPanel.Size = new System.Drawing.Size(65, 72);
            this.BtnExitPanel.TabIndex = 19;
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
            this.btnHelp.Location = new System.Drawing.Point(0, 843);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 41);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // dataGridViewTurnos
            // 
            this.dataGridViewTurnos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTurnos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTurnos.Location = new System.Drawing.Point(77, 288);
            this.dataGridViewTurnos.Name = "dataGridViewTurnos";
            this.dataGridViewTurnos.RowHeadersWidth = 62;
            this.dataGridViewTurnos.RowTemplate.Height = 33;
            this.dataGridViewTurnos.Size = new System.Drawing.Size(933, 473);
            this.dataGridViewTurnos.TabIndex = 21;
            this.dataGridViewTurnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTurnos_CellClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(939, 818);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 52);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(438, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 24;
            this.label2.Text = "Especialidad";
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEspecialidad.Location = new System.Drawing.Point(372, 225);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.PlaceholderText = "Buscar........";
            this.txtEspecialidad.Size = new System.Drawing.Size(313, 33);
            this.txtEspecialidad.TabIndex = 23;
            this.txtEspecialidad.TextChanged += new System.EventHandler(this.txtMedicina_TextChanged);
            // 
            // FrmVerTurnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 882);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridViewTurnos);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.BtnExitPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(625, 69);
            this.Name = "FrmVerTurnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmVerTurnos";
            this.Load += new System.EventHandler(this.FrmVerTurnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExitPanel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridView dataGridViewTurnos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEspecialidad;
    }
}
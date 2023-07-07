
namespace App_Forms_Farmacia.Farmaceutico
{
    partial class FrmVerMedicinas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerMedicinas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.BtnExitPanel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMedicina = new System.Windows.Forms.TextBox();
            this.dataGridViewMedicinas = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicinas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "VER MEDICINAS";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(-2, 837);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 41);
            this.btnHelp.TabIndex = 15;
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
            this.BtnExitPanel.Location = new System.Drawing.Point(939, -4);
            this.BtnExitPanel.Name = "BtnExitPanel";
            this.BtnExitPanel.Size = new System.Drawing.Size(65, 72);
            this.BtnExitPanel.TabIndex = 16;
            this.BtnExitPanel.UseVisualStyleBackColor = true;
            this.BtnExitPanel.Click += new System.EventHandler(this.BtnExitPanel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(342, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Medicina:";
            // 
            // txtMedicina
            // 
            this.txtMedicina.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMedicina.Location = new System.Drawing.Point(342, 270);
            this.txtMedicina.Name = "txtMedicina";
            this.txtMedicina.PlaceholderText = "Buscar........";
            this.txtMedicina.Size = new System.Drawing.Size(313, 33);
            this.txtMedicina.TabIndex = 17;
            this.txtMedicina.TextChanged += new System.EventHandler(this.txtMedicina_TextChanged);
            // 
            // dataGridViewMedicinas
            // 
            this.dataGridViewMedicinas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMedicinas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMedicinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicinas.Location = new System.Drawing.Point(28, 334);
            this.dataGridViewMedicinas.Name = "dataGridViewMedicinas";
            this.dataGridViewMedicinas.RowHeadersWidth = 62;
            this.dataGridViewMedicinas.RowTemplate.Height = 33;
            this.dataGridViewMedicinas.Size = new System.Drawing.Size(933, 473);
            this.dataGridViewMedicinas.TabIndex = 19;
            this.dataGridViewMedicinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicinas_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(846, 826);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 52);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = " Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmVerMedicinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 877);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewMedicinas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMedicina);
            this.Controls.Add(this.BtnExitPanel);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(712, 40);
            this.Name = "FrmVerMedicinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmVerMedicinas";
            this.Load += new System.EventHandler(this.FrmVerMedicinas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button BtnExitPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedicina;
        private System.Windows.Forms.DataGridView dataGridViewMedicinas;
        private System.Windows.Forms.Button btnDelete;
    }
}
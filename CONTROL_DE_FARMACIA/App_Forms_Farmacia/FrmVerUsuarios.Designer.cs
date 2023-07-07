
namespace App_Forms_Farmacia
{
    partial class FrmVerUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.BtnExitPanel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "VER USUARIOS";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(261, 235);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Buscar........";
            this.txtUsuario.Size = new System.Drawing.Size(313, 33);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(261, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario:";
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(35, 327);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.RowHeadersWidth = 62;
            this.dataGridViewUsuarios.RowTemplate.Height = 33;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(867, 410);
            this.dataGridViewUsuarios.TabIndex = 8;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(744, 743);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(158, 52);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = " Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnExitPanel
            // 
            this.BtnExitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitPanel.ForeColor = System.Drawing.Color.White;
            this.BtnExitPanel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExitPanel.Image")));
            this.BtnExitPanel.Location = new System.Drawing.Point(881, -12);
            this.BtnExitPanel.Name = "BtnExitPanel";
            this.BtnExitPanel.Size = new System.Drawing.Size(65, 72);
            this.BtnExitPanel.TabIndex = 24;
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
            this.btnHelp.Location = new System.Drawing.Point(12, 772);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 41);
            this.btnHelp.TabIndex = 25;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // FrmVerUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 825);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.BtnExitPanel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(700, 100);
            this.Name = "FrmVerUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmVerUsuarios";
            this.Load += new System.EventHandler(this.FrmVerUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button BtnExitPanel;
        private System.Windows.Forms.Button btnHelp;
    }
}
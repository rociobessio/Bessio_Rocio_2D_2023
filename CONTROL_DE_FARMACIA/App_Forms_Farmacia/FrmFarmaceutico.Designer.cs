
namespace App_Forms_Farmacia
{
    partial class FrmFarmaceutico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFarmaceutico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVenderMedicina = new System.Windows.Forms.Button();
            this.btnValidarPrecioMedicina = new System.Windows.Forms.Button();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnModMedicina = new System.Windows.Forms.Button();
            this.btnViewMedicina = new System.Windows.Forms.Button();
            this.btnAddMedicina = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnVenderMedicina);
            this.panel1.Controls.Add(this.btnValidarPrecioMedicina);
            this.panel1.Controls.Add(this.labelUsuario);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnModMedicina);
            this.panel1.Controls.Add(this.btnViewMedicina);
            this.panel1.Controls.Add(this.btnAddMedicina);
            this.panel1.Controls.Add(this.btnDashBoard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 941);
            this.panel1.TabIndex = 1;
            // 
            // btnVenderMedicina
            // 
            this.btnVenderMedicina.FlatAppearance.BorderSize = 0;
            this.btnVenderMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenderMedicina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenderMedicina.ForeColor = System.Drawing.Color.White;
            this.btnVenderMedicina.Image = ((System.Drawing.Image)(resources.GetObject("btnVenderMedicina.Image")));
            this.btnVenderMedicina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenderMedicina.Location = new System.Drawing.Point(39, 746);
            this.btnVenderMedicina.Name = "btnVenderMedicina";
            this.btnVenderMedicina.Size = new System.Drawing.Size(399, 57);
            this.btnVenderMedicina.TabIndex = 11;
            this.btnVenderMedicina.Text = "VENDER MEDICINA";
            this.btnVenderMedicina.UseVisualStyleBackColor = true;
            this.btnVenderMedicina.Click += new System.EventHandler(this.btnVenderMedicina_Click);
            // 
            // btnValidarPrecioMedicina
            // 
            this.btnValidarPrecioMedicina.FlatAppearance.BorderSize = 0;
            this.btnValidarPrecioMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarPrecioMedicina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnValidarPrecioMedicina.ForeColor = System.Drawing.Color.White;
            this.btnValidarPrecioMedicina.Image = ((System.Drawing.Image)(resources.GetObject("btnValidarPrecioMedicina.Image")));
            this.btnValidarPrecioMedicina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidarPrecioMedicina.Location = new System.Drawing.Point(39, 656);
            this.btnValidarPrecioMedicina.Name = "btnValidarPrecioMedicina";
            this.btnValidarPrecioMedicina.Size = new System.Drawing.Size(399, 57);
            this.btnValidarPrecioMedicina.TabIndex = 10;
            this.btnValidarPrecioMedicina.Text = " VALIDAR FECHAS MEDICINAS";
            this.btnValidarPrecioMedicina.UseVisualStyleBackColor = true;
            this.btnValidarPrecioMedicina.Click += new System.EventHandler(this.btnValidarPrecioMedicina_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUsuario.Location = new System.Drawing.Point(147, 9);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(90, 28);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "nombre";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.DarkRed;
            this.label.Location = new System.Drawing.Point(9, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(116, 28);
            this.label.TabIndex = 8;
            this.label.Text = "Usuario:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(36, 834);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(399, 57);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "SALIR";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnModMedicina
            // 
            this.btnModMedicina.FlatAppearance.BorderSize = 0;
            this.btnModMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModMedicina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnModMedicina.ForeColor = System.Drawing.Color.White;
            this.btnModMedicina.Image = ((System.Drawing.Image)(resources.GetObject("btnModMedicina.Image")));
            this.btnModMedicina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModMedicina.Location = new System.Drawing.Point(39, 575);
            this.btnModMedicina.Name = "btnModMedicina";
            this.btnModMedicina.Size = new System.Drawing.Size(399, 57);
            this.btnModMedicina.TabIndex = 6;
            this.btnModMedicina.Text = "MODIFICAR MEDICINA";
            this.btnModMedicina.UseVisualStyleBackColor = true;
            this.btnModMedicina.Click += new System.EventHandler(this.btnModMedicina_Click);
            // 
            // btnViewMedicina
            // 
            this.btnViewMedicina.FlatAppearance.BorderSize = 0;
            this.btnViewMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMedicina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewMedicina.ForeColor = System.Drawing.Color.White;
            this.btnViewMedicina.Image = ((System.Drawing.Image)(resources.GetObject("btnViewMedicina.Image")));
            this.btnViewMedicina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewMedicina.Location = new System.Drawing.Point(39, 499);
            this.btnViewMedicina.Name = "btnViewMedicina";
            this.btnViewMedicina.Size = new System.Drawing.Size(399, 57);
            this.btnViewMedicina.TabIndex = 5;
            this.btnViewMedicina.Text = "VER MEDICINA";
            this.btnViewMedicina.UseVisualStyleBackColor = true;
            this.btnViewMedicina.Click += new System.EventHandler(this.btnViewMedicina_Click);
            // 
            // btnAddMedicina
            // 
            this.btnAddMedicina.FlatAppearance.BorderSize = 0;
            this.btnAddMedicina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicina.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddMedicina.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicina.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicina.Image")));
            this.btnAddMedicina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMedicina.Location = new System.Drawing.Point(39, 416);
            this.btnAddMedicina.Name = "btnAddMedicina";
            this.btnAddMedicina.Size = new System.Drawing.Size(399, 57);
            this.btnAddMedicina.TabIndex = 4;
            this.btnAddMedicina.Text = "AÑADIR MEDICINA";
            this.btnAddMedicina.UseVisualStyleBackColor = true;
            this.btnAddMedicina.Click += new System.EventHandler(this.btnAddMedicina_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(39, 339);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(399, 57);
            this.btnDashBoard.TabIndex = 3;
            this.btnDashBoard.Text = "PANEL";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(58, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "FARMACÉUTICO";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(434, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 767);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(92, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFarmaceutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1564, 941);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFarmaceutico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFarmaceutico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnModMedicina;
        private System.Windows.Forms.Button btnViewMedicina;
        private System.Windows.Forms.Button btnAddMedicina;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVenderMedicina;
        private System.Windows.Forms.Button btnValidarPrecioMedicina;
    }
}
namespace EJERCICIO_C03_UNIDAD_06_GUI
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            label18 = new Label();
            btnMaquinaExpendedora = new Button();
            btnBuffet = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(211, 30);
            label18.Name = "label18";
            label18.Size = new Size(449, 84);
            label18.TabIndex = 2;
            label18.Text = "DEBIDO A LA GRAN DEMANDA EN AUMENTO\r\nAHORA LA SIMPSONITA CUENTA CON BUFFET\r\n              Y MÁQUINA EXPENDEDORA.\r\n";
            // 
            // btnMaquinaExpendedora
            // 
            btnMaquinaExpendedora.BackColor = Color.HotPink;
            btnMaquinaExpendedora.FlatAppearance.BorderSize = 0;
            btnMaquinaExpendedora.FlatStyle = FlatStyle.Flat;
            btnMaquinaExpendedora.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaquinaExpendedora.ForeColor = Color.White;
            btnMaquinaExpendedora.Location = new Point(39, 260);
            btnMaquinaExpendedora.Name = "btnMaquinaExpendedora";
            btnMaquinaExpendedora.Size = new Size(152, 97);
            btnMaquinaExpendedora.TabIndex = 3;
            btnMaquinaExpendedora.Text = "Máquina Expendedora";
            btnMaquinaExpendedora.UseVisualStyleBackColor = false;
            btnMaquinaExpendedora.Click += btnMaquinaExpendedora_Click;
            // 
            // btnBuffet
            // 
            btnBuffet.BackColor = Color.HotPink;
            btnBuffet.FlatAppearance.BorderSize = 0;
            btnBuffet.FlatStyle = FlatStyle.Flat;
            btnBuffet.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuffet.ForeColor = Color.White;
            btnBuffet.Location = new Point(665, 260);
            btnBuffet.Name = "btnBuffet";
            btnBuffet.Size = new Size(152, 97);
            btnBuffet.TabIndex = 4;
            btnBuffet.Text = "Buffet";
            btnBuffet.UseVisualStyleBackColor = false;
            btnBuffet.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(227, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(394, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(874, 427);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuffet);
            Controls.Add(btnMaquinaExpendedora);
            Controls.Add(label18);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label18;
        private Button btnMaquinaExpendedora;
        private Button btnBuffet;
        private PictureBox pictureBox1;
    }
}
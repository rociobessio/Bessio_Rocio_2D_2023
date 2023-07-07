namespace EJERCICIO_C03_UNIDAD_06_GUI
{
    partial class FrmAddCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddCliente));
            label1 = new Label();
            tbNombreCliente = new TextBox();
            pictureBox1 = new PictureBox();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 72);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 3;
            label1.Text = "NOMBRE";
            // 
            // tbNombreCliente
            // 
            tbNombreCliente.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tbNombreCliente.Location = new Point(8, 103);
            tbNombreCliente.Name = "tbNombreCliente";
            tbNombreCliente.Size = new Size(242, 37);
            tbNombreCliente.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(253, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 389);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.HotPink;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(76, 169);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 62);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FrmAddCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(447, 273);
            Controls.Add(btnAgregar);
            Controls.Add(pictureBox1);
            Controls.Add(tbNombreCliente);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAddCliente";
            Text = "FrmAddCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNombreCliente;
        private PictureBox pictureBox1;
        private Button btnAgregar;
    }
}
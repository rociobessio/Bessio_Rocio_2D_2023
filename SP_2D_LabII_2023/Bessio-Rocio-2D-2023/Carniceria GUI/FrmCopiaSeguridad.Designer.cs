namespace Carniceria_GUI
{
    partial class FrmCopiaSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCopiaSeguridad));
            dataGridViewCopiaSeguridad = new DataGridView();
            lblPrintHelp = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            lblVendedorEmail = new Label();
            label14 = new Label();
            lblHoraIngreso = new Label();
            label15 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCopiaSeguridad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCopiaSeguridad
            // 
            dataGridViewCopiaSeguridad.AllowUserToAddRows = false;
            dataGridViewCopiaSeguridad.AllowUserToDeleteRows = false;
            dataGridViewCopiaSeguridad.Anchor = AnchorStyles.None;
            dataGridViewCopiaSeguridad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCopiaSeguridad.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCopiaSeguridad.BackgroundColor = Color.MediumPurple;
            dataGridViewCopiaSeguridad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCopiaSeguridad.Location = new Point(12, 100);
            dataGridViewCopiaSeguridad.Name = "dataGridViewCopiaSeguridad";
            dataGridViewCopiaSeguridad.ReadOnly = true;
            dataGridViewCopiaSeguridad.RowHeadersWidth = 62;
            dataGridViewCopiaSeguridad.RowTemplate.Height = 33;
            dataGridViewCopiaSeguridad.Size = new Size(976, 285);
            dataGridViewCopiaSeguridad.TabIndex = 0;
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.None;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(12, 400);
            lblPrintHelp.MinimumSize = new Size(37, 60);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 16;
            lblPrintHelp.Text = " ";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.call_center_contact_information_service_icon_1872701;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(118, 28);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 34;
            label8.Text = "VENDEDOR:";
            // 
            // lblVendedorEmail
            // 
            lblVendedorEmail.Anchor = AnchorStyles.None;
            lblVendedorEmail.AutoSize = true;
            lblVendedorEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedorEmail.ForeColor = Color.White;
            lblVendedorEmail.Location = new Point(291, 32);
            lblVendedorEmail.Name = "lblVendedorEmail";
            lblVendedorEmail.Size = new Size(65, 28);
            lblVendedorEmail.TabIndex = 35;
            lblVendedorEmail.Text = "label1";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(660, 9);
            label14.Name = "label14";
            label14.Size = new Size(128, 21);
            label14.TabIndex = 46;
            label14.Text = "Hora de ingreso:";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.Anchor = AnchorStyles.None;
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHoraIngreso.ForeColor = Color.White;
            lblHoraIngreso.Location = new Point(818, 9);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(30, 21);
            lblHoraIngreso.TabIndex = 47;
            lblHoraIngreso.Text = "hs.";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(893, 9);
            label15.Name = "label15";
            label15.Size = new Size(30, 21);
            label15.TabIndex = 48;
            label15.Text = "hs.";
            // 
            // FrmCopiaSeguridad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(1000, 469);
            Controls.Add(label15);
            Controls.Add(lblHoraIngreso);
            Controls.Add(label14);
            Controls.Add(lblVendedorEmail);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(lblPrintHelp);
            Controls.Add(dataGridViewCopiaSeguridad);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCopiaSeguridad";
            Text = "FrmCopiaSeguridad";
            Load += FrmCopiaSeguridad_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCopiaSeguridad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCopiaSeguridad;
        protected Label lblPrintHelp;
        private PictureBox pictureBox1;
        private Label label8;
        protected Label lblVendedorEmail;
        private Label label14;
        protected Label lblHoraIngreso;
        private Label label15;
    }
}
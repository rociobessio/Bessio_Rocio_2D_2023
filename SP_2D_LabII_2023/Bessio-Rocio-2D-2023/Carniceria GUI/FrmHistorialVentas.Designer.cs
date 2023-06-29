namespace Carniceria_GUI
{
    partial class FrmHistorialVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialVentas));
            label1 = new Label();
            pictureBoxVendedor = new PictureBox();
            lblVendedorEmail = new Label();
            label12 = new Label();
            lblHoraIngreso = new Label();
            label9 = new Label();
            rtbHistorial = new RichTextBox();
            lstbArchivosNombres = new ListBox();
            label2 = new Label();
            lblPrintHelp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVendedor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(113, 28);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 14;
            label1.Text = "VENDEDOR:";
            // 
            // pictureBoxVendedor
            // 
            pictureBoxVendedor.Anchor = AnchorStyles.None;
            pictureBoxVendedor.Image = Properties.Resources.call_center_contact_information_service_icon_187270;
            pictureBoxVendedor.Location = new Point(12, 12);
            pictureBoxVendedor.Name = "pictureBoxVendedor";
            pictureBoxVendedor.Size = new Size(82, 72);
            pictureBoxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVendedor.TabIndex = 13;
            pictureBoxVendedor.TabStop = false;
            // 
            // lblVendedorEmail
            // 
            lblVendedorEmail.Anchor = AnchorStyles.None;
            lblVendedorEmail.AutoSize = true;
            lblVendedorEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedorEmail.ForeColor = Color.White;
            lblVendedorEmail.Location = new Point(271, 32);
            lblVendedorEmail.Name = "lblVendedorEmail";
            lblVendedorEmail.Size = new Size(65, 28);
            lblVendedorEmail.TabIndex = 12;
            lblVendedorEmail.Text = "label1";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(819, 12);
            label12.Name = "label12";
            label12.Size = new Size(30, 21);
            label12.TabIndex = 45;
            label12.Text = "hs.";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.Anchor = AnchorStyles.None;
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHoraIngreso.ForeColor = Color.White;
            lblHoraIngreso.Location = new Point(769, 12);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(30, 21);
            lblHoraIngreso.TabIndex = 44;
            lblHoraIngreso.Text = "hs.";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(647, 12);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 43;
            label9.Text = "Hora de ingreso:";
            // 
            // rtbHistorial
            // 
            rtbHistorial.BackColor = Color.DarkSlateGray;
            rtbHistorial.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            rtbHistorial.ForeColor = Color.White;
            rtbHistorial.Location = new Point(371, 81);
            rtbHistorial.Name = "rtbHistorial";
            rtbHistorial.Size = new Size(497, 603);
            rtbHistorial.TabIndex = 46;
            rtbHistorial.Text = "";
            // 
            // lstbArchivosNombres
            // 
            lstbArchivosNombres.BackColor = Color.DarkSlateGray;
            lstbArchivosNombres.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lstbArchivosNombres.ForeColor = Color.White;
            lstbArchivosNombres.FormattingEnabled = true;
            lstbArchivosNombres.ItemHeight = 30;
            lstbArchivosNombres.Location = new Point(12, 138);
            lstbArchivosNombres.Name = "lstbArchivosNombres";
            lstbArchivosNombres.Size = new Size(339, 514);
            lstbArchivosNombres.TabIndex = 47;
            lstbArchivosNombres.SelectedIndexChanged += lstbArchivosNombres_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(229, 32);
            label2.TabIndex = 48;
            label2.Text = "Tickets de compra:";
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.None;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(12, 655);
            lblPrintHelp.MinimumSize = new Size(37, 60);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 49;
            lblPrintHelp.Text = " ";
            // 
            // FrmHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(895, 711);
            Controls.Add(lblPrintHelp);
            Controls.Add(label2);
            Controls.Add(lstbArchivosNombres);
            Controls.Add(rtbHistorial);
            Controls.Add(label12);
            Controls.Add(lblHoraIngreso);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(pictureBoxVendedor);
            Controls.Add(lblVendedorEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHistorialVentas";
            Text = "FrmHistorialVentas";
            Load += FrmHistorialVentas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBoxVendedor;
        private Label lblVendedorEmail;
        private Label label12;
        private Label lblHoraIngreso;
        private Label label9;
        private RichTextBox rtbHistorial;
        private ListBox lstbArchivosNombres;
        private Label label2;
        private Label lblPrintHelp;
    }
}
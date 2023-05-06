namespace Carniceria_GUI
{
    partial class FrmHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial));
            dataGridViewProductos = new DataGridView();
            lblPrintHelp = new Label();
            label2 = new Label();
            label8 = new Label();
            lblVendedorEmail = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AllowUserToResizeColumns = false;
            dataGridViewProductos.AllowUserToResizeRows = false;
            dataGridViewProductos.Anchor = AnchorStyles.None;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProductos.BackgroundColor = Color.FloralWhite;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(12, 148);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.RowTemplate.Height = 33;
            dataGridViewProductos.Size = new Size(864, 344);
            dataGridViewProductos.TabIndex = 13;
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.None;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(12, 504);
            lblPrintHelp.MinimumSize = new Size(37, 60);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 15;
            lblPrintHelp.Text = " ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(279, 32);
            label2.TabIndex = 29;
            label2.Text = "HISTORIAL DE VENTAS:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(116, 43);
            label8.Name = "label8";
            label8.Size = new Size(152, 32);
            label8.TabIndex = 31;
            label8.Text = "VENDEDOR:";
            // 
            // lblVendedorEmail
            // 
            lblVendedorEmail.Anchor = AnchorStyles.None;
            lblVendedorEmail.AutoSize = true;
            lblVendedorEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedorEmail.ForeColor = Color.White;
            lblVendedorEmail.Location = new Point(274, 47);
            lblVendedorEmail.Name = "lblVendedorEmail";
            lblVendedorEmail.Size = new Size(65, 28);
            lblVendedorEmail.TabIndex = 30;
            lblVendedorEmail.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.call_center_contact_information_service_icon_1872701;
            pictureBox1.Location = new Point(23, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(888, 567);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(lblVendedorEmail);
            Controls.Add(label2);
            Controls.Add(lblPrintHelp);
            Controls.Add(dataGridViewProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(910, 547);
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private Label lblPrintHelp;
        private Label label2;
        private Label label8;
        private Label lblVendedorEmail;
        private PictureBox pictureBox1;
    }
}
namespace Carniceria_GUI
{
    partial class FrmVisualizacionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizacionProductos));
            dataGridViewCarritos = new DataGridView();
            lblPrintHelp = new Label();
            label2 = new Label();
            label8 = new Label();
            lblVendedorEmail = new Label();
            pictureBox1 = new PictureBox();
            label15 = new Label();
            lblHoraIngreso = new Label();
            label14 = new Label();
            btnVerXML = new Button();
            btnVerJSON = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarritos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCarritos
            // 
            dataGridViewCarritos.AllowUserToAddRows = false;
            dataGridViewCarritos.AllowUserToDeleteRows = false;
            dataGridViewCarritos.AllowUserToResizeColumns = false;
            dataGridViewCarritos.AllowUserToResizeRows = false;
            dataGridViewCarritos.Anchor = AnchorStyles.None;
            dataGridViewCarritos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCarritos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCarritos.BackgroundColor = Color.FloralWhite;
            dataGridViewCarritos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCarritos.Location = new Point(53, 146);
            dataGridViewCarritos.Name = "dataGridViewCarritos";
            dataGridViewCarritos.ReadOnly = true;
            dataGridViewCarritos.RowHeadersWidth = 62;
            dataGridViewCarritos.RowTemplate.Height = 33;
            dataGridViewCarritos.Size = new Size(937, 344);
            dataGridViewCarritos.TabIndex = 13;
            dataGridViewCarritos.CellClick += dataGridViewCarritos_CellClick;
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.None;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(6, 504);
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
            label2.Location = new Point(53, 111);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 29;
            label2.Text = "VER CARRITOS:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(99, 39);
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
            lblVendedorEmail.Location = new Point(257, 43);
            lblVendedorEmail.Name = "lblVendedorEmail";
            lblVendedorEmail.Size = new Size(65, 28);
            lblVendedorEmail.TabIndex = 30;
            lblVendedorEmail.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.call_center_contact_information_service_icon_1872701;
            pictureBox1.Location = new Point(6, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(988, 22);
            label15.Name = "label15";
            label15.Size = new Size(30, 21);
            label15.TabIndex = 47;
            label15.Text = "hs.";
            // 
            // lblHoraIngreso
            // 
            lblHoraIngreso.Anchor = AnchorStyles.None;
            lblHoraIngreso.AutoSize = true;
            lblHoraIngreso.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblHoraIngreso.ForeColor = Color.White;
            lblHoraIngreso.Location = new Point(943, 22);
            lblHoraIngreso.Name = "lblHoraIngreso";
            lblHoraIngreso.Size = new Size(30, 21);
            lblHoraIngreso.TabIndex = 46;
            lblHoraIngreso.Text = "hs.";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(809, 22);
            label14.Name = "label14";
            label14.Size = new Size(128, 21);
            label14.TabIndex = 45;
            label14.Text = "Hora de ingreso:";
            // 
            // btnVerXML
            // 
            btnVerXML.Anchor = AnchorStyles.Bottom;
            btnVerXML.Cursor = Cursors.Hand;
            btnVerXML.FlatStyle = FlatStyle.Popup;
            btnVerXML.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerXML.ForeColor = SystemColors.ButtonHighlight;
            btnVerXML.Image = Properties.Resources.shoppaymentorderbuy_08_icon_icons_com_73885;
            btnVerXML.ImageAlign = ContentAlignment.MiddleRight;
            btnVerXML.Location = new Point(821, 504);
            btnVerXML.Name = "btnVerXML";
            btnVerXML.Size = new Size(169, 60);
            btnVerXML.TabIndex = 48;
            btnVerXML.Text = " Ver Facturas\r\n       XML";
            btnVerXML.TextAlign = ContentAlignment.MiddleLeft;
            btnVerXML.UseVisualStyleBackColor = true;
            btnVerXML.Click += btnVerXML_Click;
            // 
            // btnVerJSON
            // 
            btnVerJSON.Anchor = AnchorStyles.Bottom;
            btnVerJSON.Cursor = Cursors.Hand;
            btnVerJSON.FlatStyle = FlatStyle.Popup;
            btnVerJSON.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerJSON.ForeColor = SystemColors.ButtonHighlight;
            btnVerJSON.Image = Properties.Resources.shoppaymentorderbuy_08_icon_icons_com_73885;
            btnVerJSON.ImageAlign = ContentAlignment.MiddleRight;
            btnVerJSON.Location = new Point(646, 504);
            btnVerJSON.Name = "btnVerJSON";
            btnVerJSON.Size = new Size(169, 60);
            btnVerJSON.TabIndex = 49;
            btnVerJSON.Text = " Ver Facturas\r\n       JSON";
            btnVerJSON.TextAlign = ContentAlignment.MiddleLeft;
            btnVerJSON.UseVisualStyleBackColor = true;
            btnVerJSON.Click += btnVerHTML_Click;
            // 
            // FrmVisualizacionProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1042, 567);
            Controls.Add(btnVerJSON);
            Controls.Add(btnVerXML);
            Controls.Add(label15);
            Controls.Add(lblHoraIngreso);
            Controls.Add(label14);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(lblVendedorEmail);
            Controls.Add(label2);
            Controls.Add(lblPrintHelp);
            Controls.Add(dataGridViewCarritos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(910, 547);
            Name = "FrmVisualizacionProductos";
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCarritos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private PictureBox pictureBox1;
        private Label label15;
        private Label label14;
        protected DataGridView dataGridViewCarritos;
        protected Label lblPrintHelp;
        protected Label label2;
        protected Button btnVerXML;
        protected Button btnVerJSON;
        protected Label lblVendedorEmail;
        protected Label lblHoraIngreso;
    }
}
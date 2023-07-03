namespace Carniceria_GUI
{
    partial class FrmMenuPrincipalVendedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipalVendedor));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnReponer = new Button();
            btnVender = new Button();
            btnHistorial = new Button();
            lblPrintHelp = new Label();
            panel1 = new Panel();
            label12 = new Label();
            lblHoraIngreso = new Label();
            label9 = new Label();
            label1 = new Label();
            pictureBoxVendedor = new PictureBox();
            lblVendedorEmail = new Label();
            btnVisualizarProductos = new Button();
            btnCopiaSeguridad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVendedor).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(506, 377);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 50;
            label2.Text = "MENU VENDEDOR\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.farm_animal_cow_icon_153815;
            pictureBox1.Location = new Point(502, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 49;
            pictureBox1.TabStop = false;
            // 
            // btnReponer
            // 
            btnReponer.Cursor = Cursors.Hand;
            btnReponer.FlatStyle = FlatStyle.Popup;
            btnReponer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReponer.ForeColor = SystemColors.ButtonHighlight;
            btnReponer.Image = Properties.Resources.Fridge_icon_icons_com_53204;
            btnReponer.ImageAlign = ContentAlignment.MiddleRight;
            btnReponer.Location = new Point(21, 171);
            btnReponer.Name = "btnReponer";
            btnReponer.Size = new Size(239, 61);
            btnReponer.TabIndex = 47;
            btnReponer.Text = "     Heladera";
            btnReponer.TextAlign = ContentAlignment.MiddleLeft;
            btnReponer.UseVisualStyleBackColor = true;
            btnReponer.Click += btnReponer_Click;
            // 
            // btnVender
            // 
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatStyle = FlatStyle.Popup;
            btnVender.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVender.ForeColor = Color.White;
            btnVender.Image = Properties.Resources.delivery_payment_cash_service_price_icon_187251;
            btnVender.ImageAlign = ContentAlignment.MiddleRight;
            btnVender.Location = new Point(20, 96);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(239, 57);
            btnVender.TabIndex = 46;
            btnVender.Text = "    Vender";
            btnVender.TextAlign = ContentAlignment.MiddleLeft;
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnHistorial
            // 
            btnHistorial.Anchor = AnchorStyles.Bottom;
            btnHistorial.Cursor = Cursors.Hand;
            btnHistorial.FlatStyle = FlatStyle.Popup;
            btnHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorial.ForeColor = Color.White;
            btnHistorial.Image = Properties.Resources.receipt_information_icon_1774012;
            btnHistorial.ImageAlign = ContentAlignment.MiddleRight;
            btnHistorial.Location = new Point(21, 260);
            btnHistorial.Name = "btnHistorial";
            btnHistorial.Size = new Size(239, 57);
            btnHistorial.TabIndex = 48;
            btnHistorial.Text = "    Historial Ventas";
            btnHistorial.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorial.UseVisualStyleBackColor = true;
            btnHistorial.Click += btnHistorial_Click;
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.Bottom;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(20, 504);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 51;
            lblPrintHelp.Text = " ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lblHoraIngreso);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBoxVendedor);
            panel1.Controls.Add(lblVendedorEmail);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 76);
            panel1.TabIndex = 52;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1089, -3);
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
            lblHoraIngreso.Location = new Point(819, 23);
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
            label9.Location = new Point(697, 23);
            label9.Name = "label9";
            label9.Size = new Size(128, 21);
            label9.TabIndex = 43;
            label9.Text = "Hora de ingreso:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 14;
            label1.Text = "VENDEDOR:";
            // 
            // pictureBoxVendedor
            // 
            pictureBoxVendedor.Anchor = AnchorStyles.None;
            pictureBoxVendedor.Image = Properties.Resources.call_center_contact_information_service_icon_187270;
            pictureBoxVendedor.Location = new Point(3, 3);
            pictureBoxVendedor.Name = "pictureBoxVendedor";
            pictureBoxVendedor.Size = new Size(70, 60);
            pictureBoxVendedor.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxVendedor.TabIndex = 13;
            pictureBoxVendedor.TabStop = false;
            // 
            // lblVendedorEmail
            // 
            lblVendedorEmail.Anchor = AnchorStyles.None;
            lblVendedorEmail.AutoSize = true;
            lblVendedorEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblVendedorEmail.ForeColor = Color.White;
            lblVendedorEmail.Location = new Point(200, 19);
            lblVendedorEmail.Name = "lblVendedorEmail";
            lblVendedorEmail.Size = new Size(59, 25);
            lblVendedorEmail.TabIndex = 12;
            lblVendedorEmail.Text = "label1";
            // 
            // btnVisualizarProductos
            // 
            btnVisualizarProductos.Anchor = AnchorStyles.Bottom;
            btnVisualizarProductos.Cursor = Cursors.Hand;
            btnVisualizarProductos.FlatStyle = FlatStyle.Popup;
            btnVisualizarProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizarProductos.ForeColor = Color.White;
            btnVisualizarProductos.Image = Properties.Resources.zoom_plus_increase_view_icon_145868;
            btnVisualizarProductos.ImageAlign = ContentAlignment.MiddleRight;
            btnVisualizarProductos.Location = new Point(21, 342);
            btnVisualizarProductos.Name = "btnVisualizarProductos";
            btnVisualizarProductos.Size = new Size(239, 67);
            btnVisualizarProductos.TabIndex = 53;
            btnVisualizarProductos.Text = "Deserialización de\r\n      Facturas";
            btnVisualizarProductos.TextAlign = ContentAlignment.MiddleLeft;
            btnVisualizarProductos.UseVisualStyleBackColor = true;
            btnVisualizarProductos.Click += btnVisualizarProductos_Click;
            // 
            // btnCopiaSeguridad
            // 
            btnCopiaSeguridad.Anchor = AnchorStyles.Bottom;
            btnCopiaSeguridad.Cursor = Cursors.Hand;
            btnCopiaSeguridad.FlatStyle = FlatStyle.Popup;
            btnCopiaSeguridad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopiaSeguridad.ForeColor = Color.White;
            btnCopiaSeguridad.Image = Properties.Resources.savedisk_floppydisk_guardar_15432;
            btnCopiaSeguridad.ImageAlign = ContentAlignment.MiddleRight;
            btnCopiaSeguridad.Location = new Point(20, 430);
            btnCopiaSeguridad.Name = "btnCopiaSeguridad";
            btnCopiaSeguridad.Size = new Size(239, 71);
            btnCopiaSeguridad.TabIndex = 54;
            btnCopiaSeguridad.Text = "Ver Copia \r\nde Seguridad";
            btnCopiaSeguridad.TextAlign = ContentAlignment.MiddleLeft;
            btnCopiaSeguridad.UseVisualStyleBackColor = true;
            btnCopiaSeguridad.Click += btnCopiaSeguridad_Click;
            // 
            // FrmMenuPrincipalVendedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumPurple;
            ClientSize = new Size(880, 573);
            Controls.Add(btnCopiaSeguridad);
            Controls.Add(btnVisualizarProductos);
            Controls.Add(panel1);
            Controls.Add(lblPrintHelp);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnReponer);
            Controls.Add(btnVender);
            Controls.Add(btnHistorial);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenuPrincipalVendedor";
            Text = "FrmMenuPrincipalVendedor";
            Load += FrmMenuPrincipalVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private Button btnReponer;
        private Button btnVender;
        private Button btnHistorial;
        private Label lblPrintHelp;
        private Panel panel1;
        private Label label12;
        private Label lblHoraIngreso;
        private Label label9;
        private Label label1;
        private PictureBox pictureBoxVendedor;
        private Label lblVendedorEmail;
        private Button btnVisualizarProductos;
        private Button btnCopiaSeguridad;
    }
}
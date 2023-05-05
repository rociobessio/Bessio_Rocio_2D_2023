namespace Carniceria_GUI
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            txtEmail = new TextBox();
            txtContrasenia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnInicioSesion = new Button();
            pictureBox1 = new PictureBox();
            btnCliente = new Button();
            btnVendedor = new Button();
            lblPrintHelp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(264, 235);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(365, 45);
            txtEmail.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Anchor = AnchorStyles.None;
            txtContrasenia.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(264, 343);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(365, 45);
            txtContrasenia.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(264, 204);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(264, 312);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Anchor = AnchorStyles.None;
            btnInicioSesion.Cursor = Cursors.Hand;
            btnInicioSesion.FlatStyle = FlatStyle.Popup;
            btnInicioSesion.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicioSesion.ForeColor = Color.White;
            btnInicioSesion.Image = Properties.Resources.security_protection_protect_key_password_login_1085541;
            btnInicioSesion.ImageAlign = ContentAlignment.MiddleRight;
            btnInicioSesion.Location = new Point(462, 413);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(167, 42);
            btnInicioSesion.TabIndex = 4;
            btnInicioSesion.Text = " Iniciar sesión";
            btnInicioSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.farm_animal_cow_icon_153815;
            pictureBox1.Location = new Point(354, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnCliente
            // 
            btnCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCliente.Cursor = Cursors.Hand;
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCliente.ForeColor = Color.White;
            btnCliente.Location = new Point(789, 518);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(134, 42);
            btnCliente.TabIndex = 6;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = true;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVendedor.Cursor = Cursors.Hand;
            btnVendedor.FlatStyle = FlatStyle.Popup;
            btnVendedor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVendedor.ForeColor = Color.White;
            btnVendedor.Location = new Point(649, 518);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(134, 42);
            btnVendedor.TabIndex = 7;
            btnVendedor.Text = "Vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(12, 503);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 8;
            lblPrintHelp.Text = " ";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(935, 572);
            Controls.Add(lblPrintHelp);
            Controls.Add(btnVendedor);
            Controls.Add(btnCliente);
            Controls.Add(pictureBox1);
            Controls.Add(btnInicioSesion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasenia);
            Controls.Add(txtEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(957, 628);
            Name = "FrmLogin";
            Text = "Form1";
            FormClosing += FrmLogin_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtContrasenia;
        private Label label1;
        private Label label2;
        private Button btnInicioSesion;
        private PictureBox pictureBox1;
        private Button btnCliente;
        private Button btnVendedor;
        private Label lblPrintHelp;
    }
}
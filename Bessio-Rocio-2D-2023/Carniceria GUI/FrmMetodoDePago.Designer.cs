namespace Carniceria_GUI
{
    partial class FrmMetodoDePago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMetodoDePago));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtTitular = new TextBox();
            label6 = new Label();
            txtTotalTarjeta = new TextBox();
            label5 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label4 = new Label();
            txtCVV = new TextBox();
            label3 = new Label();
            txtNumTarjeta = new TextBox();
            label2 = new Label();
            cbEntidadBancaria = new ComboBox();
            rbTarjetaCredito = new RadioButton();
            groupBox2 = new GroupBox();
            label7 = new Label();
            txtEfectivoAGastar = new TextBox();
            rbEfectivo = new RadioButton();
            btnFinalizar = new Button();
            label1 = new Label();
            lblClienteEmail = new Label();
            lblPrintHelp = new Label();
            groupBox3 = new GroupBox();
            rbTarjetaDebito = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._customer_service_agent_89777;
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTitular);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTotalTarjeta);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpFechaVencimiento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCVV);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNumTarjeta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cbEntidadBancaria);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(362, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(298, 492);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Tarjeta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(18, 349);
            label8.Name = "label8";
            label8.Size = new Size(74, 25);
            label8.TabIndex = 21;
            label8.Text = "Titular:";
            // 
            // txtTitular
            // 
            txtTitular.Location = new Point(110, 343);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(182, 34);
            txtTitular.TabIndex = 20;
            txtTitular.KeyPress += txtTitular_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 274);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 19;
            label6.Text = "Total:";
            // 
            // txtTotalTarjeta
            // 
            txtTotalTarjeta.Location = new Point(110, 268);
            txtTotalTarjeta.Name = "txtTotalTarjeta";
            txtTotalTarjeta.Size = new Size(180, 34);
            txtTotalTarjeta.TabIndex = 18;
            txtTotalTarjeta.KeyPress += txtTotalTarjeta_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 400);
            label5.Name = "label5";
            label5.Size = new Size(203, 25);
            label5.TabIndex = 17;
            label5.Text = "Fecha de Vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.CalendarFont = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaVencimiento.Location = new Point(20, 428);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(272, 34);
            dtpFechaVencimiento.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 182);
            label4.Name = "label4";
            label4.Size = new Size(81, 50);
            label4.TabIndex = 15;
            label4.Text = "Número\r\nCVV:\r\n";
            // 
            // txtCVV
            // 
            txtCVV.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtCVV.Location = new Point(110, 201);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(180, 31);
            txtCVV.TabIndex = 14;
            txtCVV.KeyPress += txtCVV_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 112);
            label3.Name = "label3";
            label3.Size = new Size(81, 50);
            label3.TabIndex = 13;
            label3.Text = "Número\r\nTarjeta:\r\n";
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtNumTarjeta.Location = new Point(114, 131);
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new Size(176, 31);
            txtNumTarjeta.TabIndex = 12;
            txtNumTarjeta.KeyPress += txtNumTarjeta_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 11;
            label2.Text = "Entidad";
            // 
            // cbEntidadBancaria
            // 
            cbEntidadBancaria.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            cbEntidadBancaria.FormattingEnabled = true;
            cbEntidadBancaria.Items.AddRange(new object[] { "Banco Nación", "Banco Francés", "Banco Comafi", "Banco Santander", "Banco Provincia", "Banco Galicia" });
            cbEntidadBancaria.Location = new Point(114, 61);
            cbEntidadBancaria.Name = "cbEntidadBancaria";
            cbEntidadBancaria.Size = new Size(176, 29);
            cbEntidadBancaria.TabIndex = 11;
            // 
            // rbTarjetaCredito
            // 
            rbTarjetaCredito.AutoSize = true;
            rbTarjetaCredito.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbTarjetaCredito.Location = new Point(18, 38);
            rbTarjetaCredito.Name = "rbTarjetaCredito";
            rbTarjetaCredito.Size = new Size(150, 29);
            rbTarjetaCredito.TabIndex = 1;
            rbTarjetaCredito.TabStop = true;
            rbTarjetaCredito.Text = "Tarjeta Crédito";
            rbTarjetaCredito.UseVisualStyleBackColor = true;
            rbTarjetaCredito.CheckedChanged += rbTarjeta_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtEfectivoAGastar);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 370);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 134);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Efectivo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 53);
            label7.Name = "label7";
            label7.Size = new Size(86, 50);
            label7.TabIndex = 20;
            label7.Text = "Total \r\na gastar:";
            // 
            // txtEfectivoAGastar
            // 
            txtEfectivoAGastar.Location = new Point(137, 55);
            txtEfectivoAGastar.Name = "txtEfectivoAGastar";
            txtEfectivoAGastar.Size = new Size(150, 34);
            txtEfectivoAGastar.TabIndex = 12;
            txtEfectivoAGastar.KeyPress += txtEfectivoAGastar_KeyPress;
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbEfectivo.Location = new Point(174, 61);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(99, 29);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            rbEfectivo.CheckedChanged += rbEfectivo_CheckedChanged;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFinalizar.Cursor = Cursors.Hand;
            btnFinalizar.FlatStyle = FlatStyle.Popup;
            btnFinalizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalizar.ForeColor = Color.White;
            btnFinalizar.Image = Properties.Resources.pay_cash_payment_money_dollar_bill_icon_143267;
            btnFinalizar.ImageAlign = ContentAlignment.MiddleRight;
            btnFinalizar.Location = new Point(478, 529);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(174, 50);
            btnFinalizar.TabIndex = 8;
            btnFinalizar.Text = "      Finalizar";
            btnFinalizar.TextAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 26);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 9;
            label1.Text = "BIENVENID@";
            // 
            // lblClienteEmail
            // 
            lblClienteEmail.AutoSize = true;
            lblClienteEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClienteEmail.ForeColor = Color.White;
            lblClienteEmail.Location = new Point(173, 73);
            lblClienteEmail.Name = "lblClienteEmail";
            lblClienteEmail.Size = new Size(75, 25);
            lblClienteEmail.TabIndex = 10;
            lblClienteEmail.Text = "usuario";
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(12, 522);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 11;
            lblPrintHelp.Text = " ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbTarjetaDebito);
            groupBox3.Controls.Add(rbEfectivo);
            groupBox3.Controls.Add(rbTarjetaCredito);
            groupBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(12, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(298, 133);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            groupBox3.Text = "Método de pago";
            // 
            // rbTarjetaDebito
            // 
            rbTarjetaDebito.AutoSize = true;
            rbTarjetaDebito.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbTarjetaDebito.Location = new Point(18, 88);
            rbTarjetaDebito.Name = "rbTarjetaDebito";
            rbTarjetaDebito.Size = new Size(146, 29);
            rbTarjetaDebito.TabIndex = 2;
            rbTarjetaDebito.TabStop = true;
            rbTarjetaDebito.Text = "Tarjeta Debito";
            rbTarjetaDebito.UseVisualStyleBackColor = true;
            rbTarjetaDebito.CheckedChanged += rbTarjetaDebito_CheckedChanged;
            // 
            // FrmMetodoDePago
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(682, 591);
            Controls.Add(groupBox3);
            Controls.Add(lblPrintHelp);
            Controls.Add(lblClienteEmail);
            Controls.Add(label1);
            Controls.Add(btnFinalizar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMetodoDePago";
            Text = "FrmMetodoDePago";
            FormClosing += FrmMetodoDePago_FormClosing;
            Load += FrmMetodoDePago_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbTarjetaCredito;
        private RadioButton rbEfectivo;
        private Button btnFinalizar;
        private Label label1;
        private Label lblClienteEmail;
        private Label label2;
        private ComboBox cbEntidadBancaria;
        private Label label3;
        private TextBox txtNumTarjeta;
        private Label label4;
        private TextBox txtCVV;
        private Label label5;
        private DateTimePicker dtpFechaVencimiento;
        private Label label6;
        private TextBox txtTotalTarjeta;
        private Label lblPrintHelp;
        private Label label8;
        private TextBox txtTitular;
        private Label label7;
        private TextBox txtEfectivoAGastar;
        private GroupBox groupBox3;
        private RadioButton rbTarjetaDebito;
    }
}
namespace Carniceria_GUI
{
    partial class FrmCompraCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompraCliente));
            pictureBox1 = new PictureBox();
            lblClienteEmail = new Label();
            dataGridViewProductos = new DataGridView();
            label2 = new Label();
            lblPrintHelp = new Label();
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label3 = new Label();
            txtTelefono = new TextBox();
            txtDomicilio = new TextBox();
            txtEmail = new TextBox();
            groupBox2 = new GroupBox();
            label13 = new Label();
            label10 = new Label();
            label6 = new Label();
            txtNumTarjeta = new TextBox();
            txtTotalCompra = new TextBox();
            checkBoxEfectivo = new CheckBox();
            checkboxTarjeta = new CheckBox();
            label5 = new Label();
            txtMontoDisponible = new TextBox();
            label4 = new Label();
            txtSaldoDisponible = new TextBox();
            label12 = new Label();
            groupBox3 = new GroupBox();
            label1 = new Label();
            txtPesoRequerido = new TextBox();
            btnAgregarAlCarrito = new Button();
            btnComprar = new Button();
            cbFiltrarPor = new ComboBox();
            label11 = new Label();
            label9 = new Label();
            richTextBoxCarrito = new RichTextBox();
            btnCancelarCompra = new Button();
            btnSacarFiltro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources._customer_service_agent_89777;
            pictureBox1.Location = new Point(40, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblClienteEmail
            // 
            lblClienteEmail.Anchor = AnchorStyles.None;
            lblClienteEmail.AutoSize = true;
            lblClienteEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblClienteEmail.ForeColor = Color.White;
            lblClienteEmail.Location = new Point(0, 132);
            lblClienteEmail.Name = "lblClienteEmail";
            lblClienteEmail.Size = new Size(75, 25);
            lblClienteEmail.TabIndex = 11;
            lblClienteEmail.Text = "usuario";
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
            dataGridViewProductos.Location = new Point(15, 516);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.RowTemplate.Height = 33;
            dataGridViewProductos.Size = new Size(928, 239);
            dataGridViewProductos.TabIndex = 12;
            dataGridViewProductos.CellClick += dataGridViewProductos_CellClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 432);
            label2.Name = "label2";
            label2.Size = new Size(495, 32);
            label2.TabIndex = 13;
            label2.Text = "PRODUCTOS DISPONIBLES EN LA TIENDA:";
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.None;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = Properties.Resources.support_call_center_help_information_customer_service_icon_140644;
            lblPrintHelp.Location = new Point(12, 758);
            lblPrintHelp.MinimumSize = new Size(37, 60);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 14;
            lblPrintHelp.Text = " ";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDomicilio);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(207, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 173);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informacion cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(69, 43);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 27;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(69, 135);
            label7.Name = "label7";
            label7.Size = new Size(92, 25);
            label7.TabIndex = 26;
            label7.Text = "Domicilio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 87);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 23;
            label3.Text = "Télefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(181, 80);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(223, 37);
            txtTelefono.TabIndex = 24;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(181, 128);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(223, 37);
            txtDomicilio.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 36);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(223, 37);
            txtEmail.TabIndex = 25;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.None;
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtNumTarjeta);
            groupBox2.Controls.Add(txtTotalCompra);
            groupBox2.Controls.Add(checkBoxEfectivo);
            groupBox2.Controls.Add(checkboxTarjeta);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtMontoDisponible);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtSaldoDisponible);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(709, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 394);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Billetera";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(90, 37);
            label13.Name = "label13";
            label13.Size = new Size(17, 21);
            label13.TabIndex = 37;
            label13.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(6, 73);
            label10.Name = "label10";
            label10.Size = new Size(144, 25);
            label10.TabIndex = 30;
            label10.Text = "Número Tarjeta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(6, 308);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 22;
            label6.Text = "Total compra:";
            // 
            // txtNumTarjeta
            // 
            txtNumTarjeta.Location = new Point(6, 101);
            txtNumTarjeta.Name = "txtNumTarjeta";
            txtNumTarjeta.Size = new Size(216, 37);
            txtNumTarjeta.TabIndex = 29;
            // 
            // txtTotalCompra
            // 
            txtTotalCompra.Location = new Point(6, 336);
            txtTotalCompra.Name = "txtTotalCompra";
            txtTotalCompra.Size = new Size(217, 37);
            txtTotalCompra.TabIndex = 21;
            // 
            // checkBoxEfectivo
            // 
            checkBoxEfectivo.AutoSize = true;
            checkBoxEfectivo.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxEfectivo.Location = new Point(124, 36);
            checkBoxEfectivo.Name = "checkBoxEfectivo";
            checkBoxEfectivo.Size = new Size(98, 25);
            checkBoxEfectivo.TabIndex = 16;
            checkBoxEfectivo.Text = "Efectivo";
            checkBoxEfectivo.UseVisualStyleBackColor = true;
            // 
            // checkboxTarjeta
            // 
            checkboxTarjeta.AutoSize = true;
            checkboxTarjeta.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point);
            checkboxTarjeta.Location = new Point(8, 36);
            checkboxTarjeta.Name = "checkboxTarjeta";
            checkboxTarjeta.Size = new Size(88, 25);
            checkboxTarjeta.TabIndex = 15;
            checkboxTarjeta.Text = "Tarjeta";
            checkboxTarjeta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 151);
            label5.Name = "label5";
            label5.Size = new Size(220, 25);
            label5.TabIndex = 14;
            label5.Text = "Monto máximo  a gastar";
            // 
            // txtMontoDisponible
            // 
            txtMontoDisponible.Location = new Point(6, 179);
            txtMontoDisponible.Name = "txtMontoDisponible";
            txtMontoDisponible.Size = new Size(216, 37);
            txtMontoDisponible.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(6, 228);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 12;
            label4.Text = "Saldo disponible";
            label4.Click += label4_Click;
            // 
            // txtSaldoDisponible
            // 
            txtSaldoDisponible.Location = new Point(6, 256);
            txtSaldoDisponible.Name = "txtSaldoDisponible";
            txtSaldoDisponible.Size = new Size(219, 37);
            txtSaldoDisponible.TabIndex = 0;
            txtSaldoDisponible.TextChanged += txtSaldoDisponible_TextChanged;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 6F, FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(70, 773);
            label12.Name = "label12";
            label12.Size = new Size(112, 45);
            label12.TabIndex = 31;
            label12.Text = "* Tarjeta de Crédito \r\ntiene un 5% de \r\nrecargo.";
            label12.Click += label12_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtPesoRequerido);
            groupBox3.Controls.Add(btnAgregarAlCarrito);
            groupBox3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(12, 191);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(328, 215);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Comprar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 74);
            label1.Name = "label1";
            label1.Size = new Size(70, 50);
            label1.TabIndex = 20;
            label1.Text = "Pesaje \r\n(kgs):";
            // 
            // txtPesoRequerido
            // 
            txtPesoRequerido.Location = new Point(104, 82);
            txtPesoRequerido.Name = "txtPesoRequerido";
            txtPesoRequerido.Size = new Size(218, 37);
            txtPesoRequerido.TabIndex = 1;
            txtPesoRequerido.KeyPress += textBox2_KeyPress;
            // 
            // btnAgregarAlCarrito
            // 
            btnAgregarAlCarrito.Anchor = AnchorStyles.Bottom;
            btnAgregarAlCarrito.Cursor = Cursors.Hand;
            btnAgregarAlCarrito.FlatStyle = FlatStyle.Popup;
            btnAgregarAlCarrito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarAlCarrito.ForeColor = Color.White;
            btnAgregarAlCarrito.Image = Properties.Resources.shopping_action_basket_shop_buy_add_108644;
            btnAgregarAlCarrito.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregarAlCarrito.Location = new Point(104, 152);
            btnAgregarAlCarrito.Name = "btnAgregarAlCarrito";
            btnAgregarAlCarrito.Size = new Size(218, 57);
            btnAgregarAlCarrito.TabIndex = 19;
            btnAgregarAlCarrito.Text = "Agregar al carrito";
            btnAgregarAlCarrito.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarAlCarrito.UseVisualStyleBackColor = true;
            btnAgregarAlCarrito.Click += btnAgregarAlCarrito_Click;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom;
            btnComprar.Cursor = Cursors.Hand;
            btnComprar.FlatStyle = FlatStyle.Popup;
            btnComprar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Image = Properties.Resources.pay_cash_payment_money_dollar_bill_icon_143267;
            btnComprar.ImageAlign = ContentAlignment.MiddleRight;
            btnComprar.Location = new Point(786, 761);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(157, 57);
            btnComprar.TabIndex = 18;
            btnComprar.Text = "    Comprar";
            btnComprar.TextAlign = ContentAlignment.MiddleLeft;
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // cbFiltrarPor
            // 
            cbFiltrarPor.Anchor = AnchorStyles.None;
            cbFiltrarPor.FormattingEnabled = true;
            cbFiltrarPor.Location = new Point(167, 472);
            cbFiltrarPor.Name = "cbFiltrarPor";
            cbFiltrarPor.Size = new Size(140, 33);
            cbFiltrarPor.TabIndex = 19;
            cbFiltrarPor.SelectedIndexChanged += cbFiltrarPor_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(458, 192);
            label11.Name = "label11";
            label11.Size = new Size(117, 32);
            label11.TabIndex = 30;
            label11.Text = "CARRITO";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(15, 475);
            label9.Name = "label9";
            label9.Size = new Size(146, 25);
            label9.TabIndex = 28;
            label9.Text = "Filtrar por corte";
            // 
            // richTextBoxCarrito
            // 
            richTextBoxCarrito.Anchor = AnchorStyles.None;
            richTextBoxCarrito.BackColor = Color.FloralWhite;
            richTextBoxCarrito.Location = new Point(373, 226);
            richTextBoxCarrito.Name = "richTextBoxCarrito";
            richTextBoxCarrito.Size = new Size(305, 175);
            richTextBoxCarrito.TabIndex = 32;
            richTextBoxCarrito.Text = "";
            // 
            // btnCancelarCompra
            // 
            btnCancelarCompra.Anchor = AnchorStyles.Bottom;
            btnCancelarCompra.Cursor = Cursors.Hand;
            btnCancelarCompra.FlatStyle = FlatStyle.Popup;
            btnCancelarCompra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelarCompra.ForeColor = Color.White;
            btnCancelarCompra.Image = Properties.Resources.Cartmultiply_icon_icons1;
            btnCancelarCompra.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelarCompra.Location = new Point(612, 761);
            btnCancelarCompra.Name = "btnCancelarCompra";
            btnCancelarCompra.Size = new Size(157, 57);
            btnCancelarCompra.TabIndex = 33;
            btnCancelarCompra.Text = "    Cancelar";
            btnCancelarCompra.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelarCompra.UseVisualStyleBackColor = true;
            btnCancelarCompra.Click += button1_Click;
            // 
            // btnSacarFiltro
            // 
            btnSacarFiltro.Anchor = AnchorStyles.None;
            btnSacarFiltro.Cursor = Cursors.Hand;
            btnSacarFiltro.FlatAppearance.BorderSize = 0;
            btnSacarFiltro.FlatStyle = FlatStyle.Flat;
            btnSacarFiltro.Image = Properties.Resources.Cancel_icon_icons_com_54824;
            btnSacarFiltro.Location = new Point(313, 468);
            btnSacarFiltro.Name = "btnSacarFiltro";
            btnSacarFiltro.Size = new Size(35, 39);
            btnSacarFiltro.TabIndex = 36;
            btnSacarFiltro.UseVisualStyleBackColor = true;
            btnSacarFiltro.Click += btnSacarFiltro_Click;
            // 
            // FrmCompraCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(955, 827);
            Controls.Add(btnSacarFiltro);
            Controls.Add(label12);
            Controls.Add(btnCancelarCompra);
            Controls.Add(richTextBoxCarrito);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(cbFiltrarPor);
            Controls.Add(btnComprar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblPrintHelp);
            Controls.Add(label2);
            Controls.Add(dataGridViewProductos);
            Controls.Add(lblClienteEmail);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(977, 883);
            Name = "FrmCompraCliente";
            Text = "FrmCompraCliente";
            FormClosing += FrmCompraCliente_FormClosing;
            Load += FrmCompraCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
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
        private Label lblClienteEmail;
        private DataGridView dataGridViewProductos;
        private Label label2;
        private Label lblPrintHelp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnAgregarAlCarrito;
        private Button btnComprar;
        private ComboBox cbFiltrarPor;
        private CheckBox checkBoxEfectivo;
        private CheckBox checkboxTarjeta;
        private Label label5;
        private TextBox txtMontoDisponible;
        private Label label4;
        private TextBox txtSaldoDisponible;
        private Label label1;
        private TextBox txtPesoRequerido;
        private Label label6;
        private TextBox txtTotalCompra;
        private Label label8;
        private Label label7;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtDomicilio;
        private Label label10;
        private TextBox txtNumTarjeta;
        private Label label11;
        private Label label9;
        private ListBox listBoxCarrito;
        private RichTextBox richTextBoxCarrito;
        private Button btnCancelarCompra;
        private Button btnSacarFiltro;
        private Label label12;
        private Label label13;
    }
}
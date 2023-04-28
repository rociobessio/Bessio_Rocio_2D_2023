namespace Carniceria_GUI
{
    partial class FrmHeladera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHeladera));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewProductos = new DataGridView();
            label2 = new Label();
            groupBoxReponer = new GroupBox();
            label11 = new Label();
            txtPrecioCompra = new TextBox();
            label10 = new Label();
            txtProveedor = new TextBox();
            label9 = new Label();
            numericStock = new NumericUpDown();
            cbTipoDeCarneReponer = new ComboBox();
            label8 = new Label();
            btnReponer = new Button();
            label7 = new Label();
            dtpFechaVencimiento = new DateTimePicker();
            label6 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtPesoCarne = new TextBox();
            cbTexturaCarne = new ComboBox();
            label4 = new Label();
            cbCorteCarne = new ComboBox();
            label3 = new Label();
            btnVender = new Button();
            lblPrintHelp = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            groupBoxReponer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 208);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(17, 608);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.RowTemplate.Height = 33;
            dataGridViewProductos.Size = new Size(1147, 225);
            dataGridViewProductos.TabIndex = 2;
            dataGridViewProductos.CellClick += dataGridViewProductos_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 573);
            label2.Name = "label2";
            label2.Size = new Size(323, 32);
            label2.TabIndex = 3;
            label2.Text = "PRODUCTOS DISPONIBLES:";
            // 
            // groupBoxReponer
            // 
            groupBoxReponer.Controls.Add(label11);
            groupBoxReponer.Controls.Add(txtPrecioCompra);
            groupBoxReponer.Controls.Add(label10);
            groupBoxReponer.Controls.Add(txtProveedor);
            groupBoxReponer.Controls.Add(label9);
            groupBoxReponer.Controls.Add(numericStock);
            groupBoxReponer.Controls.Add(cbTipoDeCarneReponer);
            groupBoxReponer.Controls.Add(label8);
            groupBoxReponer.Controls.Add(btnReponer);
            groupBoxReponer.Controls.Add(label7);
            groupBoxReponer.Controls.Add(dtpFechaVencimiento);
            groupBoxReponer.Controls.Add(label6);
            groupBoxReponer.Controls.Add(txtPrecio);
            groupBoxReponer.Controls.Add(label5);
            groupBoxReponer.Controls.Add(txtPesoCarne);
            groupBoxReponer.Controls.Add(cbTexturaCarne);
            groupBoxReponer.Controls.Add(label4);
            groupBoxReponer.Controls.Add(cbCorteCarne);
            groupBoxReponer.Controls.Add(label3);
            groupBoxReponer.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxReponer.ForeColor = Color.White;
            groupBoxReponer.Location = new Point(531, 3);
            groupBoxReponer.Name = "groupBoxReponer";
            groupBoxReponer.Size = new Size(633, 467);
            groupBoxReponer.TabIndex = 4;
            groupBoxReponer.TabStop = false;
            groupBoxReponer.Text = "Reponer Carne";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 308);
            label11.Name = "label11";
            label11.Size = new Size(170, 56);
            label11.TabIndex = 22;
            label11.Text = "Precio de compra \r\ndel Frigorifico:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(168, 327);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(182, 37);
            txtPrecioCompra.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(30, 265);
            label10.Name = "label10";
            label10.Size = new Size(107, 28);
            label10.TabIndex = 20;
            label10.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(168, 261);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(182, 37);
            txtProveedor.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(391, 182);
            label9.Name = "label9";
            label9.Size = new Size(64, 28);
            label9.TabIndex = 18;
            label9.Text = "Stock:";
            // 
            // numericStock
            // 
            numericStock.Location = new Point(523, 179);
            numericStock.Name = "numericStock";
            numericStock.Size = new Size(94, 37);
            numericStock.TabIndex = 17;
            // 
            // cbTipoDeCarneReponer
            // 
            cbTipoDeCarneReponer.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTipoDeCarneReponer.FormattingEnabled = true;
            cbTipoDeCarneReponer.Location = new Point(168, 38);
            cbTipoDeCarneReponer.Name = "cbTipoDeCarneReponer";
            cbTipoDeCarneReponer.Size = new Size(182, 36);
            cbTipoDeCarneReponer.TabIndex = 16;
            cbTipoDeCarneReponer.SelectedIndexChanged += cbTipoDeCarneReponer_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(15, 39);
            label8.Name = "label8";
            label8.Size = new Size(137, 28);
            label8.TabIndex = 15;
            label8.Text = "Tipo de Carne:";
            // 
            // btnReponer
            // 
            btnReponer.Cursor = Cursors.Hand;
            btnReponer.FlatStyle = FlatStyle.Popup;
            btnReponer.Location = new Point(485, 391);
            btnReponer.Name = "btnReponer";
            btnReponer.Size = new Size(132, 61);
            btnReponer.TabIndex = 5;
            btnReponer.Text = "Reponer";
            btnReponer.UseVisualStyleBackColor = true;
            btnReponer.Click += btnReponer_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(391, 278);
            label7.Name = "label7";
            label7.Size = new Size(206, 28);
            label7.TabIndex = 14;
            label7.Text = "Fecha de Vencimiento:";
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.Location = new Point(391, 325);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(226, 37);
            dtpFechaVencimiento.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(359, 103);
            label6.Name = "label6";
            label6.Size = new Size(102, 42);
            label6.TabIndex = 12;
            label6.Text = "Precio Venta \r\nPara Clientes:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(467, 108);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(156, 37);
            txtPrecio.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(391, 45);
            label5.Name = "label5";
            label5.Size = new Size(56, 28);
            label5.TabIndex = 10;
            label5.Text = "Peso:";
            // 
            // txtPesoCarne
            // 
            txtPesoCarne.Location = new Point(467, 40);
            txtPesoCarne.Name = "txtPesoCarne";
            txtPesoCarne.Size = new Size(156, 37);
            txtPesoCarne.TabIndex = 9;
            // 
            // cbTexturaCarne
            // 
            cbTexturaCarne.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbTexturaCarne.FormattingEnabled = true;
            cbTexturaCarne.Location = new Point(168, 182);
            cbTexturaCarne.Name = "cbTexturaCarne";
            cbTexturaCarne.Size = new Size(182, 36);
            cbTexturaCarne.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 182);
            label4.Name = "label4";
            label4.Size = new Size(78, 28);
            label4.TabIndex = 7;
            label4.Text = "Textura:";
            // 
            // cbCorteCarne
            // 
            cbCorteCarne.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cbCorteCarne.FormattingEnabled = true;
            cbCorteCarne.Location = new Point(168, 108);
            cbCorteCarne.Name = "cbCorteCarne";
            cbCorteCarne.Size = new Size(182, 36);
            cbCorteCarne.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 112);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 5;
            label3.Text = "Corte:";
            // 
            // btnVender
            // 
            btnVender.Cursor = Cursors.Hand;
            btnVender.FlatStyle = FlatStyle.Popup;
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(348, 202);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(111, 40);
            btnVender.TabIndex = 6;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            // 
            // lblPrintHelp
            // 
            lblPrintHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPrintHelp.AutoSize = true;
            lblPrintHelp.Cursor = Cursors.Hand;
            lblPrintHelp.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrintHelp.Image = (Image)resources.GetObject("lblPrintHelp.Image");
            lblPrintHelp.Location = new Point(198, 17);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 9;
            lblPrintHelp.Text = " ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnVender);
            groupBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(27, 263);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 248);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cliente vender Carne";
            // 
            // FrmHeladera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(1176, 845);
            Controls.Add(groupBox1);
            Controls.Add(lblPrintHelp);
            Controls.Add(groupBoxReponer);
            Controls.Add(label2);
            Controls.Add(dataGridViewProductos);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHeladera";
            Text = "FrmHeladera";
            FormClosing += FrmHeladera_FormClosing;
            Load += FrmHeladera_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            groupBoxReponer.ResumeLayout(false);
            groupBoxReponer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericStock).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewProductos;
        private Label label2;
        private GroupBox groupBoxReponer;
        private Button btnReponer;
        private Label label7;
        private DateTimePicker dtpFechaVencimiento;
        private Label label6;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtPesoCarne;
        private ComboBox cbTexturaCarne;
        private Label label4;
        private ComboBox cbCorteCarne;
        private Label label3;
        private ComboBox cbTipoDeCarneReponer;
        private Label label8;
        private Label label10;
        private TextBox txtProveedor;
        private Label label9;
        private NumericUpDown numericStock;
        private Button btnVender;
        private Label lblPrintHelp;
        private GroupBox groupBox1;
        private Label label11;
        private TextBox txtPrecioCompra;
    }
}
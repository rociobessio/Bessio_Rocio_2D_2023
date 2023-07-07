
namespace App_Forms_Farmacia.Farmaceutico
{
    partial class FrmVenderMedicina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenderMedicina));
            this.BtnExitPanel = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.labelMedicinas = new System.Windows.Forms.Label();
            this.txtBuscarMedicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxMedicinas = new System.Windows.Forms.ListBox();
            this.txtCantMedicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreMedicina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMedicina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioPorUnida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAñadirAlCarrito = new System.Windows.Forms.Button();
            this.dataGridViewMedicinas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarDelCarrito = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.labelPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicinas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExitPanel
            // 
            this.BtnExitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExitPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitPanel.ForeColor = System.Drawing.Color.White;
            this.BtnExitPanel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExitPanel.Image")));
            this.BtnExitPanel.Location = new System.Drawing.Point(1187, -1);
            this.BtnExitPanel.Name = "BtnExitPanel";
            this.BtnExitPanel.Size = new System.Drawing.Size(65, 54);
            this.BtnExitPanel.TabIndex = 30;
            this.BtnExitPanel.UseVisualStyleBackColor = true;
            this.BtnExitPanel.Click += new System.EventHandler(this.BtnExitPanel_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(12, 901);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(68, 40);
            this.btnHelp.TabIndex = 29;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // labelMedicinas
            // 
            this.labelMedicinas.AutoSize = true;
            this.labelMedicinas.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMedicinas.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelMedicinas.Location = new System.Drawing.Point(0, 2);
            this.labelMedicinas.Name = "labelMedicinas";
            this.labelMedicinas.Size = new System.Drawing.Size(406, 51);
            this.labelMedicinas.TabIndex = 31;
            this.labelMedicinas.Text = "VENDER MEDICINAS";
            // 
            // txtBuscarMedicina
            // 
            this.txtBuscarMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBuscarMedicina.Location = new System.Drawing.Point(26, 133);
            this.txtBuscarMedicina.Name = "txtBuscarMedicina";
            this.txtBuscarMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtBuscarMedicina.TabIndex = 62;
            this.txtBuscarMedicina.TextChanged += new System.EventHandler(this.txtBuscarMedicina_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(102, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 26);
            this.label4.TabIndex = 61;
            this.label4.Text = "Buscar Medicina";
            // 
            // listBoxMedicinas
            // 
            this.listBoxMedicinas.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBoxMedicinas.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.listBoxMedicinas.FormattingEnabled = true;
            this.listBoxMedicinas.ItemHeight = 23;
            this.listBoxMedicinas.Location = new System.Drawing.Point(26, 190);
            this.listBoxMedicinas.Name = "listBoxMedicinas";
            this.listBoxMedicinas.Size = new System.Drawing.Size(326, 648);
            this.listBoxMedicinas.TabIndex = 63;
            this.listBoxMedicinas.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicinas_SelectedIndexChanged);
            // 
            // txtCantMedicina
            // 
            this.txtCantMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantMedicina.Location = new System.Drawing.Point(812, 133);
            this.txtCantMedicina.Name = "txtCantMedicina";
            this.txtCantMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtCantMedicina.TabIndex = 71;
            this.txtCantMedicina.TextChanged += new System.EventHandler(this.txtCantMedicina_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(812, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 26);
            this.label5.TabIndex = 70;
            this.label5.Text = "Unidades";
            // 
            // txtNombreMedicina
            // 
            this.txtNombreMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreMedicina.Location = new System.Drawing.Point(420, 219);
            this.txtNombreMedicina.Name = "txtNombreMedicina";
            this.txtNombreMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtNombreMedicina.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(420, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 66;
            this.label2.Text = "Nombre Medicina";
            // 
            // txtIDMedicina
            // 
            this.txtIDMedicina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDMedicina.Location = new System.Drawing.Point(420, 133);
            this.txtIDMedicina.Name = "txtIDMedicina";
            this.txtIDMedicina.Size = new System.Drawing.Size(326, 37);
            this.txtIDMedicina.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(420, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 26);
            this.label6.TabIndex = 64;
            this.label6.Text = "ID Medicina";
            // 
            // dtpFechaVencimiento
            // 
            this.dtpFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFechaVencimiento.Location = new System.Drawing.Point(812, 224);
            this.dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            this.dtpFechaVencimiento.Size = new System.Drawing.Size(326, 37);
            this.dtpFechaVencimiento.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(812, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 26);
            this.label8.TabIndex = 74;
            this.label8.Text = "Fecha de Vencimiento:";
            // 
            // txtPrecioPorUnida
            // 
            this.txtPrecioPorUnida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioPorUnida.Location = new System.Drawing.Point(420, 316);
            this.txtPrecioPorUnida.Name = "txtPrecioPorUnida";
            this.txtPrecioPorUnida.Size = new System.Drawing.Size(326, 37);
            this.txtPrecioPorUnida.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(420, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 26);
            this.label3.TabIndex = 72;
            this.label3.Text = "Precio por Unidad";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrecioTotal.Location = new System.Drawing.Point(812, 316);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(326, 37);
            this.txtPrecioTotal.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(812, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 26);
            this.label7.TabIndex = 76;
            this.label7.Text = "Precio Total";
            // 
            // btnAñadirAlCarrito
            // 
            this.btnAñadirAlCarrito.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAñadirAlCarrito.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAñadirAlCarrito.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirAlCarrito.Image = ((System.Drawing.Image)(resources.GetObject("btnAñadirAlCarrito.Image")));
            this.btnAñadirAlCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirAlCarrito.Location = new System.Drawing.Point(874, 374);
            this.btnAñadirAlCarrito.Name = "btnAñadirAlCarrito";
            this.btnAñadirAlCarrito.Size = new System.Drawing.Size(264, 65);
            this.btnAñadirAlCarrito.TabIndex = 78;
            this.btnAñadirAlCarrito.Text = "Añadir al carrito";
            this.btnAñadirAlCarrito.UseVisualStyleBackColor = false;
            this.btnAñadirAlCarrito.Click += new System.EventHandler(this.btnAñadirAlCarrito_Click);
            // 
            // dataGridViewMedicinas
            // 
            this.dataGridViewMedicinas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMedicinas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMedicinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMedicinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewMedicinas.Location = new System.Drawing.Point(420, 520);
            this.dataGridViewMedicinas.Name = "dataGridViewMedicinas";
            this.dataGridViewMedicinas.RowHeadersWidth = 62;
            this.dataGridViewMedicinas.RowTemplate.Height = 33;
            this.dataGridViewMedicinas.Size = new System.Drawing.Size(816, 318);
            this.dataGridViewMedicinas.TabIndex = 79;
            this.dataGridViewMedicinas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicinas_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Medicina";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha de Vencimiento";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio por Unidad";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Número de Unidades";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio Total";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // btnQuitarDelCarrito
            // 
            this.btnQuitarDelCarrito.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuitarDelCarrito.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitarDelCarrito.ForeColor = System.Drawing.Color.Black;
            this.btnQuitarDelCarrito.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarDelCarrito.Image")));
            this.btnQuitarDelCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarDelCarrito.Location = new System.Drawing.Point(420, 864);
            this.btnQuitarDelCarrito.Name = "btnQuitarDelCarrito";
            this.btnQuitarDelCarrito.Size = new System.Drawing.Size(144, 65);
            this.btnQuitarDelCarrito.TabIndex = 80;
            this.btnQuitarDelCarrito.Text = "Quitar";
            this.btnQuitarDelCarrito.UseVisualStyleBackColor = false;
            this.btnQuitarDelCarrito.Click += new System.EventHandler(this.btnQuitarDelCarrito_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnComprar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnComprar.ForeColor = System.Drawing.Color.Black;
            this.btnComprar.Image = ((System.Drawing.Image)(resources.GetObject("btnComprar.Image")));
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(972, 864);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(264, 65);
            this.btnComprar.TabIndex = 81;
            this.btnComprar.Text = "  Comprar e Imprimir";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.DarkSalmon;
            this.labelPrecio.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrecio.Location = new System.Drawing.Point(830, 884);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(71, 37);
            this.labelPrecio.TabIndex = 82;
            this.labelPrecio.Text = "USS";
            // 
            // FrmVenderMedicina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1248, 941);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnQuitarDelCarrito);
            this.Controls.Add(this.dataGridViewMedicinas);
            this.Controls.Add(this.btnAñadirAlCarrito);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFechaVencimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecioPorUnida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantMedicina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreMedicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDMedicina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxMedicinas);
            this.Controls.Add(this.txtBuscarMedicina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelMedicinas);
            this.Controls.Add(this.BtnExitPanel);
            this.Controls.Add(this.btnHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(610, 39);
            this.Name = "FrmVenderMedicina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmVenderMedicina";
            this.Load += new System.EventHandler(this.FrmVenderMedicina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnExitPanel;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label labelMedicinas;
        private System.Windows.Forms.TextBox txtBuscarMedicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxMedicinas;
        private System.Windows.Forms.TextBox txtCantMedicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreMedicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDMedicina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaVencimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecioPorUnida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAñadirAlCarrito;
        private System.Windows.Forms.DataGridView dataGridViewMedicinas;
        private System.Windows.Forms.Button btnQuitarDelCarrito;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
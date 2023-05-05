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
            lblUsuario = new Label();
            cbFiltrarPorUsuario = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
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
            dataGridViewProductos.Location = new Point(12, 69);
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
            lblPrintHelp.Location = new Point(12, 425);
            lblPrintHelp.MinimumSize = new Size(37, 60);
            lblPrintHelp.Name = "lblPrintHelp";
            lblPrintHelp.Size = new Size(37, 60);
            lblPrintHelp.TabIndex = 15;
            lblPrintHelp.Text = " ";
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(568, 36);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(153, 25);
            lblUsuario.TabIndex = 31;
            lblUsuario.Text = "Filtrar por usario";
            // 
            // cbFiltrarPorUsuario
            // 
            cbFiltrarPorUsuario.Anchor = AnchorStyles.None;
            cbFiltrarPorUsuario.FormattingEnabled = true;
            cbFiltrarPorUsuario.Location = new Point(736, 33);
            cbFiltrarPorUsuario.Name = "cbFiltrarPorUsuario";
            cbFiltrarPorUsuario.Size = new Size(140, 33);
            cbFiltrarPorUsuario.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(306, 32);
            label2.TabIndex = 29;
            label2.Text = "HISTORIAL DE COMPRAS:";
            // 
            // FrmHistorial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(888, 491);
            Controls.Add(lblUsuario);
            Controls.Add(cbFiltrarPorUsuario);
            Controls.Add(label2);
            Controls.Add(lblPrintHelp);
            Controls.Add(dataGridViewProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(910, 547);
            Name = "FrmHistorial";
            Text = "FrmHistorial";
            Load += FrmHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private Label lblPrintHelp;
        private Label lblUsuario;
        private ComboBox cbFiltrarPorUsuario;
        private Label label2;
    }
}
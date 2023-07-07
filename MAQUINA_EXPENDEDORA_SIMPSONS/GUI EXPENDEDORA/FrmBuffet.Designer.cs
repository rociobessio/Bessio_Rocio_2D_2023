namespace EJERCICIO_C03_UNIDAD_06_GUI
{
    partial class FrmBuffet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuffet));
            btnIngresar = new Button();
            btnBorrar = new Button();
            btnNum5 = new Button();
            brnNum4 = new Button();
            btnNum3 = new Button();
            btnNum2 = new Button();
            btnNum1 = new Button();
            tbIngresoNumero = new TextBox();
            panel1 = new Panel();
            panel18 = new Panel();
            lblInformacionExpendedora = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            pictureBoxPancho = new PictureBox();
            panel3 = new Panel();
            pictureBoxSoup = new PictureBox();
            panel14 = new Panel();
            pictureBoxSanguche = new PictureBox();
            panel2 = new Panel();
            pictureBoxTacos = new PictureBox();
            panel5 = new Panel();
            pictureBoxNachos = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel18.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPancho).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSoup).BeginInit();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSanguche).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTacos).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNachos).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(24, 165);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(376, 50);
            btnIngresar.TabIndex = 60;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBorrar.Location = new Point(24, 221);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(376, 49);
            btnBorrar.TabIndex = 59;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnNum5
            // 
            btnNum5.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum5.Location = new Point(341, 92);
            btnNum5.Name = "btnNum5";
            btnNum5.Size = new Size(59, 50);
            btnNum5.TabIndex = 53;
            btnNum5.Text = "5";
            btnNum5.UseVisualStyleBackColor = true;
            btnNum5.Click += btnNum5_Click;
            // 
            // brnNum4
            // 
            brnNum4.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            brnNum4.Location = new Point(258, 93);
            brnNum4.Name = "brnNum4";
            brnNum4.Size = new Size(59, 49);
            brnNum4.TabIndex = 52;
            brnNum4.Text = "4";
            brnNum4.UseVisualStyleBackColor = true;
            brnNum4.Click += brnNum4_Click;
            // 
            // btnNum3
            // 
            btnNum3.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum3.Location = new Point(180, 93);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(59, 49);
            btnNum3.TabIndex = 51;
            btnNum3.Text = "3";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click;
            // 
            // btnNum2
            // 
            btnNum2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum2.Location = new Point(101, 93);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(59, 49);
            btnNum2.TabIndex = 50;
            btnNum2.Text = "2";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum2_Click;
            // 
            // btnNum1
            // 
            btnNum1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnNum1.Location = new Point(24, 93);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(59, 49);
            btnNum1.TabIndex = 49;
            btnNum1.Text = "1";
            btnNum1.UseVisualStyleBackColor = true;
            btnNum1.Click += btnNum1_Click;
            // 
            // tbIngresoNumero
            // 
            tbIngresoNumero.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tbIngresoNumero.Location = new Point(24, 37);
            tbIngresoNumero.Name = "tbIngresoNumero";
            tbIngresoNumero.Size = new Size(376, 50);
            tbIngresoNumero.TabIndex = 48;
            tbIngresoNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(tbIngresoNumero);
            panel1.Controls.Add(btnBorrar);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(btnNum5);
            panel1.Controls.Add(brnNum4);
            panel1.Controls.Add(btnNum1);
            panel1.Controls.Add(btnNum3);
            panel1.Controls.Add(btnNum2);
            panel1.Location = new Point(402, 206);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 295);
            panel1.TabIndex = 61;
            // 
            // panel18
            // 
            panel18.BackColor = Color.ForestGreen;
            panel18.Controls.Add(lblInformacionExpendedora);
            panel18.Location = new Point(12, 420);
            panel18.Name = "panel18";
            panel18.Size = new Size(374, 50);
            panel18.TabIndex = 62;
            // 
            // lblInformacionExpendedora
            // 
            lblInformacionExpendedora.AutoSize = true;
            lblInformacionExpendedora.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblInformacionExpendedora.ForeColor = Color.White;
            lblInformacionExpendedora.Location = new Point(3, 14);
            lblInformacionExpendedora.Name = "lblInformacionExpendedora";
            lblInformacionExpendedora.Size = new Size(0, 30);
            lblInformacionExpendedora.TabIndex = 0;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Black;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(336, 351);
            label16.Name = "label16";
            label16.Size = new Size(24, 28);
            label16.TabIndex = 70;
            label16.Text = "5";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Black;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(134, 351);
            label15.Name = "label15";
            label15.Size = new Size(24, 28);
            label15.TabIndex = 69;
            label15.Text = "4";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Black;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(336, 160);
            label14.Name = "label14";
            label14.Size = new Size(24, 28);
            label14.TabIndex = 68;
            label14.Text = "2";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Black;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(137, 163);
            label13.Name = "label13";
            label13.Size = new Size(24, 28);
            label13.TabIndex = 67;
            label13.Text = "1";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(pictureBoxPancho);
            panel4.Location = new Point(15, 206);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 142);
            panel4.TabIndex = 65;
            // 
            // pictureBoxPancho
            // 
            pictureBoxPancho.Image = (Image)resources.GetObject("pictureBoxPancho.Image");
            pictureBoxPancho.Location = new Point(3, -15);
            pictureBoxPancho.Name = "pictureBoxPancho";
            pictureBoxPancho.Size = new Size(132, 188);
            pictureBoxPancho.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPancho.TabIndex = 1;
            pictureBoxPancho.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(pictureBoxSoup);
            panel3.Location = new Point(214, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(146, 142);
            panel3.TabIndex = 64;
            // 
            // pictureBoxSoup
            // 
            pictureBoxSoup.Image = (Image)resources.GetObject("pictureBoxSoup.Image");
            pictureBoxSoup.Location = new Point(-47, -15);
            pictureBoxSoup.Name = "pictureBoxSoup";
            pictureBoxSoup.Size = new Size(241, 188);
            pictureBoxSoup.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSoup.TabIndex = 1;
            pictureBoxSoup.TabStop = false;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Controls.Add(pictureBoxSanguche);
            panel14.Location = new Point(214, 206);
            panel14.Name = "panel14";
            panel14.Size = new Size(146, 142);
            panel14.TabIndex = 66;
            // 
            // pictureBoxSanguche
            // 
            pictureBoxSanguche.Image = (Image)resources.GetObject("pictureBoxSanguche.Image");
            pictureBoxSanguche.Location = new Point(0, 0);
            pictureBoxSanguche.Name = "pictureBoxSanguche";
            pictureBoxSanguche.Size = new Size(140, 141);
            pictureBoxSanguche.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSanguche.TabIndex = 30;
            pictureBoxSanguche.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(pictureBoxTacos);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(149, 145);
            panel2.TabIndex = 63;
            // 
            // pictureBoxTacos
            // 
            pictureBoxTacos.Image = (Image)resources.GetObject("pictureBoxTacos.Image");
            pictureBoxTacos.Location = new Point(-4, 0);
            pictureBoxTacos.Name = "pictureBoxTacos";
            pictureBoxTacos.Size = new Size(150, 142);
            pictureBoxTacos.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTacos.TabIndex = 0;
            pictureBoxTacos.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Controls.Add(pictureBoxNachos);
            panel5.Location = new Point(402, 15);
            panel5.Name = "panel5";
            panel5.Size = new Size(146, 142);
            panel5.TabIndex = 71;
            // 
            // pictureBoxNachos
            // 
            pictureBoxNachos.Image = (Image)resources.GetObject("pictureBoxNachos.Image");
            pictureBoxNachos.Location = new Point(0, 20);
            pictureBoxNachos.Name = "pictureBoxNachos";
            pictureBoxNachos.Size = new Size(153, 119);
            pictureBoxNachos.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNachos.TabIndex = 1;
            pictureBoxNachos.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(524, 160);
            label1.Name = "label1";
            label1.Size = new Size(24, 28);
            label1.TabIndex = 72;
            label1.Text = "3";
            // 
            // FrmBuffet
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(821, 497);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel14);
            Controls.Add(panel2);
            Controls.Add(panel18);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBuffet";
            Text = "FrmBuffet";
            Load += FrmBuffet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPancho).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSoup).EndInit();
            panel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSanguche).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTacos).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxNachos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Button btnBorrar;
        private Button btnNum5;
        private Button brnNum4;
        private Button btnNum3;
        private Button btnNum2;
        private Button btnNum1;
        private TextBox tbIngresoNumero;
        private Panel panel1;
        private Panel panel18;
        private Label lblInformacionExpendedora;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Panel panel4;
        private PictureBox pictureBoxPancho;
        private Panel panel3;
        private PictureBox pictureBoxSoup;
        private Panel panel14;
        private PictureBox pictureBoxSanguche;
        private Panel panel2;
        private PictureBox pictureBoxTacos;
        private Panel panel5;
        private PictureBox pictureBoxNachos;
        private Label label1;
    }
}
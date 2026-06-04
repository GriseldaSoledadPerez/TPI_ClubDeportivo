namespace Proyecto
{
    partial class Cobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cobrar));
            txtDNI = new TextBox();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            btnCobrar = new Button();
            btnComprobante = new Button();
            cmbCuotas = new ComboBox();
            lblCuotas = new Label();
            lblIngrese = new Label();
            btnVolver = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnCarnet = new Button();
            lblAclaracion = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(40, 175);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(160, 23);
            txtDNI.TabIndex = 0;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            optEfectivo.Location = new Point(35, 20);
            optEfectivo.Name = "optEfectivo";
            optEfectivo.Size = new Size(81, 20);
            optEfectivo.TabIndex = 1;
            optEfectivo.TabStop = true;
            optEfectivo.Text = "Efectivo";
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            optTarjeta.Location = new Point(35, 56);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(75, 20);
            optTarjeta.TabIndex = 2;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // btnCobrar
            // 
            btnCobrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnCobrar.Location = new Point(40, 224);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(160, 34);
            btnCobrar.TabIndex = 3;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.BackColor = SystemColors.Info;
            btnComprobante.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnComprobante.Location = new Point(43, 281);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(157, 34);
            btnComprobante.TabIndex = 4;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // cmbCuotas
            // 
            cmbCuotas.FormattingEnabled = true;
            cmbCuotas.Items.AddRange(new object[] { "3", "6" });
            cmbCuotas.Location = new Point(40, 124);
            cmbCuotas.Name = "cmbCuotas";
            cmbCuotas.Size = new Size(76, 23);
            cmbCuotas.TabIndex = 5;
            cmbCuotas.SelectedIndexChanged += cmbCuotas_SelectedIndexChanged;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblCuotas.Location = new Point(55, 95);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(55, 16);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas";
            // 
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblIngrese.Location = new Point(53, 148);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(135, 16);
            lblIngrese.TabIndex = 7;
            lblIngrese.Text = "Ingrese N°  de DNI";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SteelBlue;
            btnVolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(296, 12);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(110, 23);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(optEfectivo);
            panel1.Controls.Add(optTarjeta);
            panel1.Controls.Add(lblCuotas);
            panel1.Controls.Add(cmbCuotas);
            panel1.Location = new Point(256, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 168);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = SystemColors.Info;
            btnCarnet.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnCarnet.Location = new Point(43, 341);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(157, 34);
            btnCarnet.TabIndex = 11;
            btnCarnet.Text = "Ver Carnet";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // lblAclaracion
            // 
            lblAclaracion.AutoSize = true;
            lblAclaracion.Location = new Point(221, 351);
            lblAclaracion.Name = "lblAclaracion";
            lblAclaracion.Size = new Size(212, 15);
            lblAclaracion.TabIndex = 12;
            lblAclaracion.Text = "*Si es SOCIO puede acceder al CARNET";
            // 
            // Cobrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(469, 406);
            Controls.Add(lblAclaracion);
            Controls.Add(btnCarnet);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnVolver);
            Controls.Add(lblIngrese);
            Controls.Add(btnComprobante);
            Controls.Add(btnCobrar);
            Controls.Add(txtDNI);
            Name = "Cobrar";
            Text = "CobrarCuota";
            Load += CobrarCuota_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDNI;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta;
        private Button btnCobrar;
        private Button btnComprobante;
        private ComboBox cmbCuotas;
        private Label lblCuotas;
        private Label lblIngrese;
        private Button btnVolver;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnCarnet;
        private Label lblAclaracion;
    }
}
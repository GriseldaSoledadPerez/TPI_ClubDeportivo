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
            txtID = new TextBox();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            btnCobrar = new Button();
            btnComprobante = new Button();
            cmbCuotas = new ComboBox();
            lblCuotas = new Label();
            lblIngrese = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(48, 70);
            txtID.Name = "txtID";
            txtID.Size = new Size(160, 23);
            txtID.TabIndex = 0;
            // 
            // optEfectivo
            // 
            optEfectivo.AutoSize = true;
            optEfectivo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            optEfectivo.Location = new Point(287, 64);
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
            optTarjeta.Location = new Point(287, 99);
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
            btnCobrar.Location = new Point(48, 115);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(160, 34);
            btnCobrar.TabIndex = 3;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = true;
            btnCobrar.Click += btnCobrar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnComprobante.Location = new Point(51, 169);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(157, 34);
            btnComprobante.TabIndex = 4;
            btnComprobante.Text = "Comprobante";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // cmbCuotas
            // 
            cmbCuotas.FormattingEnabled = true;
            cmbCuotas.Items.AddRange(new object[] { "3", "6" });
            cmbCuotas.Location = new Point(287, 149);
            cmbCuotas.Name = "cmbCuotas";
            cmbCuotas.Size = new Size(76, 23);
            cmbCuotas.TabIndex = 5;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblCuotas.Location = new Point(287, 130);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(55, 16);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas";
            // 
            // lblIngrese
            // 
            lblIngrese.AutoSize = true;
            lblIngrese.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblIngrese.Location = new Point(51, 52);
            lblIngrese.Name = "lblIngrese";
            lblIngrese.Size = new Size(157, 16);
            lblIngrese.TabIndex = 7;
            lblIngrese.Text = "Ingrese N°  de Cliente";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnVolver.Location = new Point(234, 237);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(157, 31);
            btnVolver.TabIndex = 8;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // CobrarCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(428, 327);
            Controls.Add(btnVolver);
            Controls.Add(lblIngrese);
            Controls.Add(lblCuotas);
            Controls.Add(cmbCuotas);
            Controls.Add(btnComprobante);
            Controls.Add(btnCobrar);
            Controls.Add(optTarjeta);
            Controls.Add(optEfectivo);
            Controls.Add(txtID);
            Name = "CobrarCuota";
            Text = "CobrarCuota";
            Load += CobrarCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta;
        private Button btnCobrar;
        private Button btnComprobante;
        private ComboBox cmbCuotas;
        private Label lblCuotas;
        private Label lblIngrese;
        private Button btnVolver;
    }
}
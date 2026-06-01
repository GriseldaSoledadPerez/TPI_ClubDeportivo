namespace Proyecto
{
    partial class Comprobante
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
            lblNumero = new Label();
            lblCliente = new Label();
            lblTipo = new Label();
            lblMonto = new Label();
            lblFecha = new Label();
            lblForma = new Label();
            lblCuotas = new Label();
            lblValorCuota = new Label();
            btnImprimir = new Button();
            lblNumeroCC = new Label();
            lblClienteCC = new Label();
            lblTipoCC = new Label();
            lblMontoCC = new Label();
            lblFormaDePagoCC = new Label();
            lblCuotasCC = new Label();
            lblValorCuotaCC = new Label();
            lblTitulo = new Label();
            lblConcepto = new Label();
            lblActividades = new Label();
            lblConceptoCC = new Label();
            lblActividadesCC = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(121, 101);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            lblNumero.Click += label1_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(115, 129);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(99, 160);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(125, 248);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(253, 79);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Location = new Point(174, 282);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(87, 15);
            lblForma.TabIndex = 5;
            lblForma.Text = "Forma de Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(115, 314);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas";
            lblCuotas.Click += lblCuotas_Click;
            // 
            // lblValorCuota
            // 
            lblValorCuota.AutoSize = true;
            lblValorCuota.Location = new Point(164, 343);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(68, 15);
            lblValorCuota.TabIndex = 7;
            lblValorCuota.Text = "Valor Cuota";
            // 
            // btnImprimir
            // 
            btnImprimir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnImprimir.Location = new Point(99, 383);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(147, 36);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNumeroCC
            // 
            lblNumeroCC.AutoSize = true;
            lblNumeroCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblNumeroCC.Location = new Point(50, 100);
            lblNumeroCC.Name = "lblNumeroCC";
            lblNumeroCC.Size = new Size(65, 16);
            lblNumeroCC.TabIndex = 9;
            lblNumeroCC.Text = "Número:";
            // 
            // lblClienteCC
            // 
            lblClienteCC.AutoSize = true;
            lblClienteCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblClienteCC.Location = new Point(50, 128);
            lblClienteCC.Name = "lblClienteCC";
            lblClienteCC.Size = new Size(59, 16);
            lblClienteCC.TabIndex = 10;
            lblClienteCC.Text = "Cliente:";
            // 
            // lblTipoCC
            // 
            lblTipoCC.AutoSize = true;
            lblTipoCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblTipoCC.Location = new Point(50, 159);
            lblTipoCC.Name = "lblTipoCC";
            lblTipoCC.Size = new Size(43, 16);
            lblTipoCC.TabIndex = 11;
            lblTipoCC.Text = "Tipo:";
            // 
            // lblMontoCC
            // 
            lblMontoCC.AutoSize = true;
            lblMontoCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblMontoCC.Location = new Point(50, 247);
            lblMontoCC.Name = "lblMontoCC";
            lblMontoCC.Size = new Size(69, 16);
            lblMontoCC.TabIndex = 12;
            lblMontoCC.Text = "Monto:  $";
            // 
            // lblFormaDePagoCC
            // 
            lblFormaDePagoCC.AutoSize = true;
            lblFormaDePagoCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblFormaDePagoCC.Location = new Point(50, 281);
            lblFormaDePagoCC.Name = "lblFormaDePagoCC";
            lblFormaDePagoCC.Size = new Size(118, 16);
            lblFormaDePagoCC.TabIndex = 14;
            lblFormaDePagoCC.Text = "Forma de Pago:";
            // 
            // lblCuotasCC
            // 
            lblCuotasCC.AutoSize = true;
            lblCuotasCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblCuotasCC.Location = new Point(50, 313);
            lblCuotasCC.Name = "lblCuotasCC";
            lblCuotasCC.Size = new Size(59, 16);
            lblCuotasCC.TabIndex = 15;
            lblCuotasCC.Text = "Cuotas:";
            // 
            // lblValorCuotaCC
            // 
            lblValorCuotaCC.AutoSize = true;
            lblValorCuotaCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblValorCuotaCC.Location = new Point(50, 342);
            lblValorCuotaCC.Name = "lblValorCuotaCC";
            lblValorCuotaCC.Size = new Size(108, 16);
            lblValorCuotaCC.TabIndex = 16;
            lblValorCuotaCC.Text = "Valor Cuota:  $";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.Location = new Point(33, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 16);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Comprobante de Pago - Club Deportivo";
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Location = new Point(133, 190);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(59, 15);
            lblConcepto.TabIndex = 18;
            lblConcepto.Text = "Concepto";
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(149, 218);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(68, 15);
            lblActividades.TabIndex = 19;
            lblActividades.Text = "Actividades";
            // 
            // lblConceptoCC
            // 
            lblConceptoCC.AutoSize = true;
            lblConceptoCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblConceptoCC.Location = new Point(50, 188);
            lblConceptoCC.Name = "lblConceptoCC";
            lblConceptoCC.Size = new Size(77, 16);
            lblConceptoCC.TabIndex = 20;
            lblConceptoCC.Text = "Concepto:";
            // 
            // lblActividadesCC
            // 
            lblActividadesCC.AutoSize = true;
            lblActividadesCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblActividadesCC.Location = new Point(50, 217);
            lblActividadesCC.Name = "lblActividadesCC";
            lblActividadesCC.Size = new Size(93, 16);
            lblActividadesCC.TabIndex = 21;
            lblActividadesCC.Text = "Actividades:";
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(354, 478);
            Controls.Add(lblActividadesCC);
            Controls.Add(lblConceptoCC);
            Controls.Add(lblActividades);
            Controls.Add(lblConcepto);
            Controls.Add(lblTitulo);
            Controls.Add(lblValorCuotaCC);
            Controls.Add(lblCuotasCC);
            Controls.Add(lblFormaDePagoCC);
            Controls.Add(lblMontoCC);
            Controls.Add(lblTipoCC);
            Controls.Add(lblClienteCC);
            Controls.Add(lblNumeroCC);
            Controls.Add(btnImprimir);
            Controls.Add(lblValorCuota);
            Controls.Add(lblCuotas);
            Controls.Add(lblForma);
            Controls.Add(lblFecha);
            Controls.Add(lblMonto);
            Controls.Add(lblTipo);
            Controls.Add(lblCliente);
            Controls.Add(lblNumero);
            Name = "Comprobante";
            Text = "ComprobanteCuota";
            Load += ComprobanteCuota_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblCliente;
        private Label lblTipo;
        private Label lblMonto;
        private Label lblFecha;
        private Label lblForma;
        private Label lblCuotas;
        private Label lblValorCuota;
        private Button btnImprimir;
        private Label lblNumeroCC;
        private Label lblClienteCC;
        private Label lblTipoCC;
        private Label lblMontoCC;
        private Label lblFormaDePagoCC;
        private Label lblCuotasCC;
        private Label lblValorCuotaCC;
        private Label lblTitulo;
        private Label lblConcepto;
        private Label lblActividades;
        private Label lblConceptoCC;
        private Label lblActividadesCC;
    }
}
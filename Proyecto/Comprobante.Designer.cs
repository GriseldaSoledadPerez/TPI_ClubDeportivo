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
            panel1 = new Panel();
            lblComp = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(122, 79);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            lblNumero.Click += label1_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(122, 104);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(122, 132);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(30, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMonto.Location = new Point(127, 216);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(55, 20);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(27, 44);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Location = new Point(146, 254);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(87, 15);
            lblForma.TabIndex = 5;
            lblForma.Text = "Forma de Pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(123, 287);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 6;
            lblCuotas.Text = "Cuotas";
            lblCuotas.Click += lblCuotas_Click;
            // 
            // lblValorCuota
            // 
            lblValorCuota.AutoSize = true;
            lblValorCuota.Location = new Point(136, 317);
            lblValorCuota.Name = "lblValorCuota";
            lblValorCuota.Size = new Size(68, 15);
            lblValorCuota.TabIndex = 7;
            lblValorCuota.Text = "Valor Cuota";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.PaleGreen;
            btnImprimir.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            btnImprimir.Location = new Point(104, 400);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(147, 36);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblNumeroCC
            // 
            lblNumeroCC.AutoSize = true;
            lblNumeroCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblNumeroCC.Location = new Point(22, 78);
            lblNumeroCC.Name = "lblNumeroCC";
            lblNumeroCC.Size = new Size(65, 16);
            lblNumeroCC.TabIndex = 9;
            lblNumeroCC.Text = "Número:";
            // 
            // lblClienteCC
            // 
            lblClienteCC.AutoSize = true;
            lblClienteCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblClienteCC.Location = new Point(22, 103);
            lblClienteCC.Name = "lblClienteCC";
            lblClienteCC.Size = new Size(59, 16);
            lblClienteCC.TabIndex = 10;
            lblClienteCC.Text = "Cliente:";
            // 
            // lblTipoCC
            // 
            lblTipoCC.AutoSize = true;
            lblTipoCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblTipoCC.Location = new Point(22, 131);
            lblTipoCC.Name = "lblTipoCC";
            lblTipoCC.Size = new Size(43, 16);
            lblTipoCC.TabIndex = 11;
            lblTipoCC.Text = "Tipo:";
            lblTipoCC.Click += lblTipoCC_Click;
            // 
            // lblMontoCC
            // 
            lblMontoCC.AutoSize = true;
            lblMontoCC.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMontoCC.Location = new Point(22, 218);
            lblMontoCC.Name = "lblMontoCC";
            lblMontoCC.Size = new Size(80, 18);
            lblMontoCC.TabIndex = 12;
            lblMontoCC.Text = "Monto:  $";
            // 
            // lblFormaDePagoCC
            // 
            lblFormaDePagoCC.AutoSize = true;
            lblFormaDePagoCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblFormaDePagoCC.Location = new Point(22, 253);
            lblFormaDePagoCC.Name = "lblFormaDePagoCC";
            lblFormaDePagoCC.Size = new Size(118, 16);
            lblFormaDePagoCC.TabIndex = 14;
            lblFormaDePagoCC.Text = "Forma de Pago:";
            // 
            // lblCuotasCC
            // 
            lblCuotasCC.AutoSize = true;
            lblCuotasCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblCuotasCC.Location = new Point(22, 286);
            lblCuotasCC.Name = "lblCuotasCC";
            lblCuotasCC.Size = new Size(59, 16);
            lblCuotasCC.TabIndex = 15;
            lblCuotasCC.Text = "Cuotas:";
            // 
            // lblValorCuotaCC
            // 
            lblValorCuotaCC.AutoSize = true;
            lblValorCuotaCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblValorCuotaCC.Location = new Point(22, 316);
            lblValorCuotaCC.Name = "lblValorCuotaCC";
            lblValorCuotaCC.Size = new Size(108, 16);
            lblValorCuotaCC.TabIndex = 16;
            lblValorCuotaCC.Text = "Valor Cuota:  $";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(5, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(305, 18);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Comprobante de Pago - Club Deportivo";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblConcepto
            // 
            lblConcepto.AutoSize = true;
            lblConcepto.Location = new Point(123, 159);
            lblConcepto.Name = "lblConcepto";
            lblConcepto.Size = new Size(59, 15);
            lblConcepto.TabIndex = 18;
            lblConcepto.Text = "Concepto";
            // 
            // lblActividades
            // 
            lblActividades.AutoSize = true;
            lblActividades.Location = new Point(123, 189);
            lblActividades.Name = "lblActividades";
            lblActividades.Size = new Size(68, 15);
            lblActividades.TabIndex = 19;
            lblActividades.Text = "Actividades";
            // 
            // lblConceptoCC
            // 
            lblConceptoCC.AutoSize = true;
            lblConceptoCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblConceptoCC.Location = new Point(22, 159);
            lblConceptoCC.Name = "lblConceptoCC";
            lblConceptoCC.Size = new Size(77, 16);
            lblConceptoCC.TabIndex = 20;
            lblConceptoCC.Text = "Concepto:";
            // 
            // lblActividadesCC
            // 
            lblActividadesCC.AutoSize = true;
            lblActividadesCC.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic);
            lblActividadesCC.Location = new Point(22, 189);
            lblActividadesCC.Name = "lblActividadesCC";
            lblActividadesCC.Size = new Size(93, 16);
            lblActividadesCC.TabIndex = 21;
            lblActividadesCC.Text = "Actividades:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(lblTitulo);
            panel1.Controls.Add(lblActividadesCC);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(lblConceptoCC);
            panel1.Controls.Add(lblNumeroCC);
            panel1.Controls.Add(lblActividades);
            panel1.Controls.Add(lblNumero);
            panel1.Controls.Add(lblConcepto);
            panel1.Controls.Add(lblClienteCC);
            panel1.Controls.Add(lblValorCuotaCC);
            panel1.Controls.Add(lblCliente);
            panel1.Controls.Add(lblCuotasCC);
            panel1.Controls.Add(lblTipoCC);
            panel1.Controls.Add(lblFormaDePagoCC);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(lblMontoCC);
            panel1.Controls.Add(lblMonto);
            panel1.Controls.Add(lblForma);
            panel1.Controls.Add(lblCuotas);
            panel1.Controls.Add(lblValorCuota);
            panel1.Location = new Point(28, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 357);
            panel1.TabIndex = 22;
            // 
            // lblComp
            // 
            lblComp.AutoSize = true;
            lblComp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComp.Location = new Point(130, 9);
            lblComp.Name = "lblComp";
            lblComp.Size = new Size(102, 17);
            lblComp.TabIndex = 23;
            lblComp.Text = "PAGO EXITOSO";
            // 
            // Comprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(372, 457);
            Controls.Add(lblComp);
            Controls.Add(panel1);
            Controls.Add(btnImprimir);
            Name = "Comprobante";
            Text = "ComprobanteCuota";
            Load += ComprobanteCuota_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label lblComp;
    }
}
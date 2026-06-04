using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCarnet : Form
    {
        public frmCarnet()
        {
            InitializeComponent();
        }
        //variables para traer los datos del formulario
        //donde se ejecuta la lógica
        public int afiliado_ca;
        public int dni_ca;
        public string cliente_ca = "";
        public string estado_ca = "";
        public DateTime fecha_ca;
        public DateTime vencimiento_ca;

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblAfiliado.Text = afiliado_ca.ToString();

            lblDoc.Text = dni_ca.ToString();

            lblCliente.Text = cliente_ca;

            lblEstado.Text = estado_ca;

            lblFecha.Text = fecha_ca.ToShortDateString(); //se obtiene la fecha actual

            lblVencimiento.Text = vencimiento_ca.ToShortDateString();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = pd;
            preview.ShowDialog();

            btnImprimir.Visible = true;
        }
        //Conjunto de sentencias necesarias para el objeto Print
        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}

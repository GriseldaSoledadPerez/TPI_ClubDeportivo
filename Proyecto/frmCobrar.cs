using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmCobrar : Form
    {
        public frmCobrar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void frmCobrar_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnVolver;
        }

        private void btnAsignarActividad_Click(object sender, EventArgs e)
        {
            frmAsignar registro = new frmAsignar();
            registro.Show();
            this.Hide();
        }
    }
}

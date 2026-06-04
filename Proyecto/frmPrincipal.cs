using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        //Variables tipo internal
        internal string? rol;
        internal string? usuario;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.ActualizarVencimientos();
            lblIngreso.Text = "USUARIO:       " + usuario + "        " + "(" + rol + ")";
        }

        private void lblIngreso_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            frmRegistrar registro = new frmRegistrar();
            registro.Show();
            this.Hide();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            frmAsignar registro = new frmAsignar();
            registro.Show();
            this.Hide();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            Cobrar cobrar = new Cobrar();
            cobrar.Show();
            this.Hide();
        }

        private void btnListaVenc_Click(object sender, EventArgs e)
        {
            listarVenc listVenc = new listarVenc();
            listVenc.Show();
            this.Hide();
        }

        private void btnVencHoy_Click(object sender, EventArgs e)
        {
            listarVencHoy listVencHoy = new listarVencHoy();
            listVencHoy.Show();
            this.Hide();
        }
    }
}

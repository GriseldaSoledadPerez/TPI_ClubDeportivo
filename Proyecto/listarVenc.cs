using MySql.Data.MySqlClient;
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
    public partial class listarVenc : Form
    {
        public listarVenc()
        {
            InitializeComponent();
        }

        private void listarVenc_Load(object sender, EventArgs e)
        {
            CargaGrilla(); // llamada al procedimiento
        }
        public void CargaGrilla()
        {
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = @"SELECT c.NCliente,  CONCAT(c.NombreC, ' ', c.ApellidoC) AS Cliente, c.DocC, s.FechaVencimiento
                      FROM cliente c INNER JOIN socio s ON c.NCliente = s.NCliente
                      WHERE s.FecHAVencimiento < CURDATE();";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                dtgvVencidos.Rows.Clear(); // importante para que no duplique datos
                dtgvVencidos.DataSource = null;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvVencidos.Rows.Add();

                        dtgvVencidos.Rows[renglon].Cells[0].Value = reader.GetString(1);
                        dtgvVencidos.Rows[renglon].Cells[1].Value = reader.GetInt32(2);
                        dtgvVencidos.Rows[renglon].Cells[2].Value = reader.GetDateTime(3).ToShortDateString(); ;
                    }
                }
                else
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
        private void dtgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nro = e.RowIndex;
            if (nro != -1)
            {
                string nombre = dtgvVencidos.Rows[nro].Cells[1].Value.ToString();
                string dni = dtgvVencidos.Rows[nro].Cells[2].Value.ToString();
                string vencimiento = dtgvVencidos.Rows[nro].Cells[3].Value.ToString();

                MessageBox.Show(
                    "Cliente: " + nombre + "\n" +
                    "Dni: " + dni + "\n" +
                    "Fecha de vencimiento: " + vencimiento + "", "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
            }
            else
            {
                MessageBox.Show("Selecciono el ENCABEZADO");
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            frmPrincipal formprincipal = new frmPrincipal();
            formprincipal.Show();
            this.Hide();
        }
    }
}

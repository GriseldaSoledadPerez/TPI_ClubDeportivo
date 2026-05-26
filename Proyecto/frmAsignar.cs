using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Proyecto.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto
{
    public partial class frmAsignar : Form
    {
        public frmAsignar()
        {
            InitializeComponent();
        }

        private void frmAsignar_Load(object sender, EventArgs e)
        {
            CargaGrilla(); // llamada al procedimiento
        }
        public void CargaGrilla()
        {
            MySqlConnection sqlCon = null;

            try
            {
                sqlCon = Conexion.getInstancia().CrearConcexion();

                string query = @"select e.idEdicion, a.nombre, e.fecha,
                         concat(p.NombreP,' ',p.ApellidoP),
                         a.precio
                         from edicion e
                         inner join actividad a on e.NActividad = a.NActividad
                         inner join profesor p on e.profesor = p.NProfesor
                         where e.fecha > curdate()
                         order by a.nombre;";

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.CommandType = CommandType.Text;

                sqlCon.Open();

                MySqlDataReader reader = comando.ExecuteReader();

                dtgvActividades.Rows.Clear(); // importante para que no duplique datos
                dtgvActividades.DataSource = null;

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int renglon = dtgvActividades.Rows.Add();

                        dtgvActividades.Rows[renglon].Cells[0].Value = reader.GetInt32(0); // idEdicion
                        dtgvActividades.Rows[renglon].Cells[1].Value = reader.GetString(1);
                        dtgvActividades.Rows[renglon].Cells[2].Value = reader.GetDateTime(2).ToString("yyyy-MM-dd");
                        dtgvActividades.Rows[renglon].Cells[3].Value = reader.GetString(3);
                        dtgvActividades.Rows[renglon].Cells[4].Value = reader.GetDecimal(4).ToString("0.00");
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

        private void dtgvActividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nro = e.RowIndex;
            if (nro != -1)
            {
                string actividad = dtgvActividades.Rows[nro].Cells[1].Value.ToString();
                string fecha = dtgvActividades.Rows[nro].Cells[2].Value.ToString();
                string profesor = dtgvActividades.Rows[nro].Cells[3].Value.ToString();
                string precio = dtgvActividades.Rows[nro].Cells[4].Value.ToString();

                MessageBox.Show(
                    "Actividad: " + actividad + "\n" +
                    "Fecha: " + fecha + "\n" +
                    "Profesor: " + profesor + "\n" +
                    "Precio: " + precio
                    );
            }
            else
            {
                MessageBox.Show("Selecciono el ENCABEZADO");
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "Ingrese numero de DNI")
            {
                txtDni.Text = "";
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "Ingrese numero de DNI";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmCobrar formcobrar = new frmCobrar();
            formcobrar.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.getInstancia().CrearConcexion();

                string query = @"select NCliente, NombreC, ApellidoC
                         from cliente
                         where DocC = @dni";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dni", txtDni.Text);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtDni.Text = reader.GetInt32(0).ToString();
                    lblCliente.Text = reader.GetString(1) + " " + reader.GetString(2);
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado");
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(txtDni.Text);
                int idEdicion = Convert.ToInt32(dtgvActividades.CurrentRow.Cells[0].Value);

                MySqlConnection con = Conexion.getInstancia().CrearConcexion();

                string query = @"insert into inscripcion
                        (NCliente, idEdicion, fecha, pagado)
                        values (@cli, @edi, curdate(), false);";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cli", idCliente);
                cmd.Parameters.AddWithValue("@edi", idEdicion);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Asignación realizada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }
    }
}

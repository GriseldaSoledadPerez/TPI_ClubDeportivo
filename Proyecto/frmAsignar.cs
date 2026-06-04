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
        int numClient;
        bool esSocio;
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
                sqlCon = Conexion.getInstancia().CrearConexion();

                string query = @"select e.idEdicion, a.Nombre, e.dia, e.horario,
                         concat(p.NombreP,' ',p.ApellidoP),
                         a.precio
                         from edicion e
                         inner join actividad a on e.NActividad = a.NActividad
                         inner join profesor p on e.profesor = p.NProfesor
                         ORDER BY FIELD(e.dia,
                         'lunes','martes','miercoles','jueves','viernes','sabado','domingo'),
                 e.horario;";

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
                        dtgvActividades.Rows[renglon].Cells[2].Value = reader.GetString(2);
                        dtgvActividades.Rows[renglon].Cells[3].Value = reader.GetTimeSpan(3).ToString(@"hh\:mm"); ;
                        dtgvActividades.Rows[renglon].Cells[4].Value = reader.GetString(4);
                        dtgvActividades.Rows[renglon].Cells[5].Value = reader.GetDecimal(5).ToString("0.00");
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
                string dia = dtgvActividades.Rows[nro].Cells[2].Value.ToString();
                string horario = dtgvActividades.Rows[nro].Cells[3].Value.ToString();
                string profesor = dtgvActividades.Rows[nro].Cells[4].Value.ToString();
                string precio = dtgvActividades.Rows[nro].Cells[5].Value.ToString();

                MessageBox.Show(
                    "Actividad: " + actividad + "\n" +
                    "Dia: " + dia + "  " + "Horario: " + horario+ "\n" +
                    "Profesor: " + profesor + "\n" +
                    "Precio: " + precio,
                    "",
                     MessageBoxButtons.OK, MessageBoxIcon.Information
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
            frmPrincipal formprincipal = new frmPrincipal();
            formprincipal.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = Conexion.getInstancia().CrearConexion();

                string query = @"select NCliente, NombreC, ApellidoC, EsSocio
                         from cliente
                         where DocC = @dni";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@dni", txtDni.Text);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    numClient = reader.GetInt32(0);
                    lblCliente.Text = reader.GetString(1) + " " + reader.GetString(2);
                    esSocio = reader.GetBoolean(3);
                    if (esSocio)
                    {  
                        MessageBox.Show(
                            "El cliente es SOCIO.\nTiene pase libre a todas las actividades.",
                            "Información",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
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
                int idCliente = Convert.ToInt32(numClient);
                int idEdicion = Convert.ToInt32(dtgvActividades.CurrentRow.Cells[0].Value);

                MySqlConnection con = Conexion.getInstancia().CrearConexion();

                con.Open();

                // Verificar si ya está inscripto
                string verificar = @"SELECT COUNT(*) 
                             FROM inscripcion 
                             WHERE NCliente = @cli 
                             AND idEdicion = @edi";

                MySqlCommand cmdVerificar = new MySqlCommand(verificar, con);
                cmdVerificar.Parameters.AddWithValue("@cli", idCliente);
                cmdVerificar.Parameters.AddWithValue("@edi", idEdicion);

                int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show("El cliente ya está anotado en esta actividad");
                    con.Close();
                    return;
                }

                // Insertar si no existe
                string query = @"INSERT INTO inscripcion
                        (NCliente, idEdicion, fecha, pagado)
                        VALUES (@cli, @edi, CURDATE(), false)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cli", idCliente);
                cmd.Parameters.AddWithValue("@edi", idEdicion);

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

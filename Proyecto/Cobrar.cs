using MySql.Data.MySqlClient;
using Proyecto.Datos;
using Proyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Cobrar : Form
    {
        public frmCarnet carnet = new frmCarnet();
        public Comprobante doc = new Comprobante();
        public Cobrar()
        {
            InitializeComponent();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            doc = new Comprobante();
            carnet = new frmCarnet();

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                /* Consulta simple que proyecta los datos necesarios para rellenar el documento*/

                string query = "SELECT NCliente, DocC, NombreC, ApellidoC, EsSocio " +
                               "FROM cliente " +

                               "WHERE DocC =  @ndni"; //<-- usamos el dato ingresado por el usuario
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@ndni", txtDNI.Text);

                //Usamos la consulta y la conexion
                comando.CommandType = CommandType.Text;

                sqlCon.Open();
                int nCliente = 0;

                MySqlDataReader reader; //el datareader almacena todas las filas

                reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read(); //en este caso sabemos que Si tiene datos es una sola fila
                    nCliente = reader.GetInt32(0);

                    doc.numero_c = reader.GetInt32(1);
                    carnet.dni_ca = reader.GetInt32(1);
                    doc.cliente_c = reader.GetString(2) + " " + reader.GetString(3);
                    carnet.cliente_ca = reader.GetString(2) + " " + reader.GetString(3);

                    bool EsSocio = reader.GetBoolean(4);

                    reader.Close();
                    //cartel para avisar adelanto de couta
                    if (EsSocio)
                    {
                        string sqlVenc = @"SELECT fechaVencimiento, NAfiliado, estadoSocio from socio
                       WHERE NCliente = @cli";

                        MySqlCommand cmdSocio = new MySqlCommand(sqlVenc, sqlCon);
                        cmdSocio.Parameters.AddWithValue("@cli", nCliente);

                        MySqlDataReader rdSocio = cmdSocio.ExecuteReader();

                        rdSocio.Close();

                        MySqlCommand cmdVenc = new MySqlCommand(sqlVenc, sqlCon);
                        cmdVenc.Parameters.AddWithValue("@cli", nCliente);

                        object fecha = cmdVenc.ExecuteScalar();

                        if (fecha != DBNull.Value)
                        {
                            DateTime vencimiento = Convert.ToDateTime(fecha);

                            if (vencimiento >= DateTime.Today)
                            {
                                DialogResult rta = MessageBox.Show(
                                    "CUOTA YA ABONADA.\n¿Desea adelantar la cuota?",
                                    "Confirmación",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question);

                                if (rta == DialogResult.No)
                                {
                                    return;
                                }
                            }
                        }
                    }

                    //Diferenciamos el tipo de cuota

                    if (EsSocio)
                    {
                        doc.tipo_c = "Socio";
                        doc.concepto_c = "Cuota de socio";
                        doc.actividades_c = "Actividad libre";
                        doc.monto_c = 50000;

                    }
                    else
                    {
                        doc.tipo_c = "No Socio";
                        doc.concepto_c = "Cuota por actividades";

                        string sql = @"SELECT a.Nombre, a.precio
               FROM inscripcion i
               INNER JOIN cliente c ON i.NCliente = c.NCliente
               INNER JOIN edicion e ON i.idEdicion = e.idEdicion
               INNER JOIN actividad a ON e.NActividad = a.NActividad
               WHERE c.DocC = @ndni";

                        MySqlCommand cmdAct = new MySqlCommand(sql, sqlCon);

                        cmdAct.Parameters.AddWithValue("@ndni", txtDNI.Text);

                        MySqlDataReader rdAct = cmdAct.ExecuteReader();

                        string actividades = ""; //variable para cada actividad
                        float total = 0; // variable para el total

                        while (rdAct.Read()) //recorre resultados
                        {
                            actividades += rdAct.GetString(0) + ", "; //guarda el nombre

                            total += rdAct.GetFloat(1); //suma el precio
                        }

                        rdAct.Close();

                        if (actividades == "")
                        {
                            MessageBox.Show(
                                "El cliente no tiene actividades asignadas.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }
                        
                        if (actividades.Length > 2)
                        {
                            actividades = actividades.Substring(0, actividades.Length - 2);
                        }
                        //guarda en el comprobante
                        doc.actividades_c = actividades;
                        doc.monto_c = total;
                    }

                    doc.fecha_c = DateTime.Now;
                    carnet.fecha_ca = DateTime.Now;

                    //forma de pago
                    if (optEfectivo.Checked == true) //si seleccionó efectivo
                    {
                        doc.forma_c = "Efectivo";

                        doc.cuotas_c = 1;

                        doc.valorCuota_c = doc.monto_c;
                        //oculta cuotas
                        cmbCuotas.Visible = false;
                        lblCuotas.Visible = false;
                    }
                    else if (optTarjeta.Checked == true) //si seleccionó tarjeta
                    {
                        //muestra cuotas
                        cmbCuotas.Visible = true;
                        lblCuotas.Visible = true;

                        doc.forma_c = "Tarjeta";

                        //validamos que haya seleccionado cuotas
                        if (cmbCuotas.Text == "")
                        {
                            MessageBox.Show("Seleccione cantidad de cuotas");
                            return;
                        }
                        doc.cuotas_c = Convert.ToInt32(cmbCuotas.Text);
                        doc.valorCuota_c = doc.monto_c / doc.cuotas_c;

                        //promociones según cuotas
                        float descuento = 0;

                        if (cmbCuotas.Text == "3")
                        {
                            descuento = 0.15f;
                        }
                        else if (cmbCuotas.Text == "6")
                        {
                            descuento = 0.10f;
                        }
                        doc.monto_c = doc.monto_c - (doc.monto_c * descuento);
                        doc.valorCuota_c = doc.monto_c / doc.cuotas_c;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un método de pago");
                        return;
                    }

                    btnComprobante.Enabled = true;

                    MessageBox.Show("Cobro realizado correctamente");
                    E_Pago pago = new E_Pago();

                    pago.NCliente = nCliente;
                    pago.Monto = doc.monto_c;
                    pago.Fecha = DateTime.Now;
                    pago.FormaPago = doc.forma_c;
                    pago.CantidadCuotas = doc.cuotas_c;

                    Pagos pagos = new Pagos();

                    string respuesta = pagos.Nuevo_Pago(pago);
                    if (EsSocio)
                    {
                        string sqlCarnet = @"SELECT fechaVencimiento,
                                NAfiliado,
                                estadoSocio
                         FROM socio
                         WHERE NCliente = @cli";

                        MySqlCommand cmdCarnet =
                            new MySqlCommand(sqlCarnet, sqlCon);

                        cmdCarnet.Parameters.AddWithValue("@cli", nCliente);

                        MySqlDataReader rdCarnet =
                            cmdCarnet.ExecuteReader();

                        if (rdCarnet.Read())
                        {
                            if (!rdCarnet.IsDBNull(0))
                            {
                                carnet.vencimiento_ca =
                                    rdCarnet.GetDateTime(0);
                            }

                            carnet.afiliado_ca =
                                rdCarnet.GetInt32(1);

                            int estado =
                                rdCarnet.GetInt32(2);

                            carnet.estado_ca =
                                estado == 1 ? "Activo" : "Inactivo";
                        }

                        rdCarnet.Close();

                        btnCarnet.Visible = true;
                        btnCarnet.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Cliente inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }

        private void btnComprobante_Click(object sender, EventArgs e)
        {
            if (doc != null)
            {
                doc.Show();
                btnComprobante.Enabled = false;
            }

        }

        private void CobrarCuota_Load(object sender, EventArgs e)
        {
            cmbCuotas.Items.Clear();
            cmbCuotas.Items.Add("3");
            cmbCuotas.Items.Add("6");

            cmbCuotas.Visible = false;
            lblCuotas.Visible = false;

            btnCarnet.Enabled = false;
            btnComprobante.Enabled = false;
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cmbCuotas.Visible = optTarjeta.Checked;
            lblCuotas.Visible = optTarjeta.Checked;
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            cmbCuotas.Visible = false;
            lblCuotas.Visible = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void cmbCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCarnet_Click(object sender, EventArgs e)
        {
            carnet.Show();
            btnCarnet.Enabled = false;
        }
    }
}

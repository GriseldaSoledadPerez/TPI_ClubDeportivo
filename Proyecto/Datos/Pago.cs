using MySql.Data.MySqlClient;
using Proyecto.Entidades;
using System;
using System.Data;

namespace Proyecto.Datos
{
    internal class Pagos
    {
        public string Nuevo_Pago(E_Pago pago)
        {
            string? salida;

            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand("NuevoPago", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("pNCliente", MySqlDbType.Int32).Value = pago.NCliente;
                comando.Parameters.Add("pMonto", MySqlDbType.Float).Value = pago.Monto;
                comando.Parameters.Add("pFecha", MySqlDbType.Date).Value = pago.Fecha;
                comando.Parameters.Add("pFormaPago", MySqlDbType.VarChar).Value = pago.FormaPago;
                comando.Parameters.Add("pCantidadCuotas", MySqlDbType.Int32).Value = pago.CantidadCuotas;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;

                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return salida;
        }
    }
}
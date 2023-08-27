using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Sistema_de_facturacion.Clases
{
    internal class ctrlHabitacion: cConexion
    {
        public List<Object> consulta(string dato)
        {
            SqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * from tblHabitacion where Eliminada = '" + 0 + "'";
            }
            else
            {
                sql = "SELECT * from tblHabitacion WHERE IdHabitacion LIKE '%" + dato + "%' and Eliminada = '" + 0 + "'";
            }
            //try
            //{
                SqlConnection conexionBD = base.AbrirConexion();
                SqlCommand comando = new SqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();
                
            while (reader.Read())
                {
                    byte[] bytesImagen = (byte[])reader[4];
                    Habitacion _habitacion = new Habitacion();
                    _habitacion.IdHabitacion = reader[0].ToString();
                    _habitacion.CapacidadHabitacion = int.Parse(reader[1].ToString());
                    _habitacion.DescripcionHabitacion = reader[2].ToString();
                    _habitacion.DisponibilidadHabitacion = Convert.ToBoolean(reader[3]);
                    _habitacion.Imagen = bytesImagen;
                    _habitacion.UrlImagen = reader[5].ToString();
                    _habitacion.Eliminada = Convert.ToBoolean(reader[6]);
                    lista.Add(_habitacion);
                }
            //}
            //catch (Exception ex)
            //{
              //  MessageBox.Show(ex.Message.ToString());
            //}
            return lista;
        }

        public List<Object> consultaHabitacionesReserva(string dato)
        {
            SqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * from tblHabitacion where Eliminada = '" + 0 + "' and DisponibilidadHabitacion = '" + 1 + "'";
            }
            else
            {
                sql = "SELECT * from tblHabitacion WHERE IdHabitacion LIKE '%" + dato + "%'";
            }
            //try
            //{
            SqlConnection conexionBD = base.AbrirConexion();
            SqlCommand comando = new SqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                byte[] bytesImagen = (byte[])reader[4];
                Habitacion _habitacion = new Habitacion();
                _habitacion.IdHabitacion = reader[0].ToString();
                _habitacion.CapacidadHabitacion = int.Parse(reader[1].ToString());
                _habitacion.DescripcionHabitacion = reader[2].ToString();
                _habitacion.DisponibilidadHabitacion = Convert.ToBoolean(reader[3]);
                _habitacion.Imagen = bytesImagen;
                _habitacion.UrlImagen = reader[5].ToString();
                _habitacion.Eliminada = Convert.ToBoolean(reader[6]);
                lista.Add(_habitacion);
            }
            //}
            //catch (Exception ex)
            //{
            //  MessageBox.Show(ex.Message.ToString());
            //}
            return lista;
        }
        public bool insertar(Habitacion datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO tblHabitacion (IdHabitacion, CapacidadHabitacion, DescripcionHabitacion, DisponibilidadHabitacion, Imagen, UrlImagen, Eliminada) VALUES('" + datos.IdHabitacion + "','" + datos.CapacidadHabitacion + "','" + datos.DescripcionHabitacion + "','" + datos.DisponibilidadHabitacion + "', CONVERT(varbinary(max), '" + Convert.ToBase64String(datos.Imagen) + "'),'" + datos.UrlImagen + "','" + datos.Eliminada + "')";

            // try
            //{
            SqlConnection conexionBD = base.AbrirConexion();
                SqlCommand comando = new SqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            //}
            //catch (SqlException ex)
            //{
              //  MessageBox.Show("Error: " + ex.Message);
                //bandera = false;
            //}
            return bandera;
        }
        public bool actualizar(Habitacion datos)
        {
            bool bandera = false;
            string sql = "UPDATE tblHabitacion SET IdHabitacion='" + datos.IdHabitacion + "',CapacidadHabitacion ='" + datos.CapacidadHabitacion + "',DescripcionHabitacion ='" + datos.DescripcionHabitacion + "',DisponibilidadHabitacion ='" + datos.DisponibilidadHabitacion + "', Imagen = CONVERT(varbinary(max), '" + Convert.ToBase64String(datos.Imagen) + "'), UrlImagen='" + datos.UrlImagen + "', Eliminada='" + datos.Eliminada + "' WHERE IdHabitacion = '" + datos.IdHabitacion + "'";

            //try
            //{
            SqlConnection conexionBD = base.AbrirConexion();
            SqlCommand comando = new SqlCommand(sql, conexionBD);
            comando.ExecuteNonQuery();
            bandera = true;
            //}
            //catch (SqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    bandera = false;
            //}
            return bandera;
        }
        public bool eliminar(int id)
        {
            bool bandera = false;
            string sql = "UPDATE tblHabitacion SET Eliminada='" + true + "' WHERE IdHabitacion = '" + id + "'";
            // try
            //{
            SqlConnection conexionBD = base.AbrirConexion();
            SqlCommand comando = new SqlCommand(sql, conexionBD);
            comando.ExecuteNonQuery();
            bandera = true;
            // }
            //catch (SqlException ex)
            //{
            // Console.WriteLine(ex.Message);
            // bandera = false;
            //}
            return bandera;
        }
    }
}

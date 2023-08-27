using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion.Clases
{
    internal class ctrlReserva: cConexion
    {
        public List<Object> consulta(string dato)
        {
            SqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM tblReserva INNER JOIN tblHabitacion ON tblReserva.IdHabitacion=tblHabitacion.IdHabitacion INNER JOIN tblCliente ON tblReserva.IdCliente=tblCliente.IdCliente WHERE tblReserva.Estado != 'Eliminada' AND tblReserva.Motivo != 'Cancelada' AND tblReserva.Motivo != 'Terminada'";

            }
            else
            {
                sql = "SELECT * FROM tblReserva INNER JOIN tblHabitacion ON tblReserva.IdHabitacion=tblHabitacion.IdHabitacion INNER JOIN tblCliente ON tblReserva.IdCliente=tblCliente.IdCliente WHERE tblCliente.idCliente='" + dato + "' and Estado != 'Eliminada' and Motivo != 'Cancelada' and Motivo != 'Terminada'";

            }
            //try
            //{
                SqlConnection conexionBD = base.AbrirConexion();
                SqlCommand comando = new SqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Reserva _reserva = new Reserva();
                    _reserva.IdReserva = int.Parse(reader[0].ToString());
                    _reserva.FechaReserva = Convert.ToDateTime(reader[1]).Date; 
                    _reserva.FechaIngreso = DateTime.Parse(reader[2].ToString());
                    _reserva.FechaSalida = DateTime.Parse(reader[3].ToString());
                    _reserva.CantidadPersonas = int.Parse(reader[4].ToString());
                    _reserva.IdCliente = reader[5].ToString();
                    _reserva.IdPlan = reader[6].ToString();
                    _reserva.IdHabitacion = reader[7].ToString();
                    _reserva.Motivo = reader[8].ToString();
                    _reserva.Estado = reader[9].ToString();
                    lista.Add(_reserva);
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            return lista;

        }
        public List<Object> consultaConsumo(string dato)
        {
            SqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * FROM tblReserva INNER JOIN tblHabitacion ON tblReserva.IdHabitacion=tblHabitacion.IdHabitacion INNER JOIN tblCliente ON tblReserva.IdCliente=tblCliente.IdCliente WHERE tblReserva.Estado != 'Eliminada' AND tblReserva.Motivo != 'Cancelada' AND tblReserva.Motivo != 'Terminada'";

            }
            else
            {
                sql = "SELECT * FROM tblReserva INNER JOIN tblHabitacion ON tblReserva.IdHabitacion=tblHabitacion.IdHabitacion INNER JOIN tblCliente ON tblReserva.IdCliente=tblCliente.IdCliente WHERE  tblCliente.IdCliente = '" + dato + "' and tblReserva.Estado != 'Eliminada' AND tblReserva.Motivo != 'Cancelada' AND tblReserva.Motivo != 'Terminada'";

            }
            //try
            //{
            SqlConnection conexionBD = base.AbrirConexion();
            SqlCommand comando = new SqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Reserva _reserva = new Reserva();
                _reserva.IdReserva = int.Parse(reader[0].ToString());
                _reserva.FechaReserva = Convert.ToDateTime(reader[1]).Date;
                _reserva.FechaIngreso = DateTime.Parse(reader[2].ToString());
                _reserva.FechaSalida = DateTime.Parse(reader[3].ToString());
                _reserva.CantidadPersonas = int.Parse(reader[4].ToString());
                _reserva.IdCliente = reader[5].ToString();
                _reserva.IdPlan = reader[6].ToString();
                _reserva.IdHabitacion = reader[7].ToString();
                _reserva.Motivo = reader[8].ToString();
                _reserva.Estado = reader[9].ToString();
                lista.Add(_reserva);
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
            return lista;

        }
        public bool insertar(Reserva datos)
        {
            string fechaReserva = datos.FechaReserva.ToString("yyyy-MM-dd");
            string fechaIngreso = datos.FechaIngreso.ToString("yyyy-MM-dd");
            string fechaSalida = datos.FechaSalida.ToString("yyyy-MM-dd");
            bool bandera = false;
            string sql = "INSERT INTO tblReserva (FechaReserva, FechaIngreso, FechaSalida, CantidadPersonas, IdCliente, IdPlan, IdHabitacion, Motivo,Estado) VALUES('" + fechaReserva + "','" + fechaIngreso + "','" + fechaSalida + "','" + datos.CantidadPersonas + "','" + datos.IdCliente + "','" + datos.IdPlan + "', '" + datos.IdHabitacion + "', '" + datos.Motivo + "', '" + datos.Estado + "')";

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
        public bool actualizar(Reserva datos)
        {
            string fechaReserva = datos.FechaReserva.ToString("yyyy-MM-dd");
            string fechaIngreso = datos.FechaIngreso.ToString("yyyy-MM-dd");
            string fechaSalida = datos.FechaSalida.ToString("yyyy-MM-dd");
            bool bandera = false;
            string sql = "update tblReserva set FechaReserva ='" + fechaReserva + "', FechaIngreso='" + fechaIngreso + "', FechaSalida='" + fechaSalida + "',CantidadPersonas='" + datos.CantidadPersonas + "',IdCliente='" + datos.IdCliente + "',IdPlan='" + datos.IdPlan + "', IdHabitacion='" + datos.IdHabitacion + "' where IdReserva = '" + datos.IdReserva + "'";

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
        public bool eliminar(int id)
        {
            bool bandera = false;
            string sql = "UPDATE tblReserva SET Estado='" + "Eliminada" + "', Motivo='" + "Cancelada" + "' WHERE idReserva = '" + id + "'";
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

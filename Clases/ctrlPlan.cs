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
    internal class ctrlPlan: cConexion
    {
        public List<Object> consulta(string dato)
        {
            SqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if (dato == null)
            {
                sql = "SELECT * from tblPlanes where Eliminado = '" + 0 + "'";
            }
            else
            {
                sql = "SELECT * from tblPlanes WHERE IdPlan LIKE '%" + dato + "%' and Eliminado = '" + 0 + "'";
            }
            //try
            //{
            SqlConnection conexionBD = base.AbrirConexion();
            SqlCommand comando = new SqlCommand(sql, conexionBD);
            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Plan _plan = new Plan();
                _plan.IdPlan= reader[0].ToString();
                _plan.DescripcionPlan = reader[1].ToString();
                _plan.ValorPlan = decimal.Parse(reader[2].ToString());
                _plan.Eliminado = Convert.ToBoolean(reader[3]);
                lista.Add(_plan);
            }
            //}
            //catch (Exception ex)
            //{
            //  MessageBox.Show(ex.Message.ToString());
            //}
            return lista;
        }
        
        public bool insertar(Plan datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO tblPlanes (IdPlan, DescripcionPlan, ValorPlan, Eliminado) VALUES('" + datos.IdPlan + "','" + datos.DescripcionPlan + "','" + datos.ValorPlan + "','" + datos.Eliminado + "')";

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
        public bool actualizar(Plan datos)
        {
            bool bandera = false;
            string sql = "UPDATE tblPlanes SET IdPlan='" + datos.IdPlan + "',DescripcionPlan ='" + datos.DescripcionPlan + "',ValorPlan ='" + datos.ValorPlan + "',Eliminado ='" + datos.Eliminado + "' WHERE IdPlan = '" + datos.IdPlan + "'";

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
            string sql = "UPDATE tblPlanes SET Eliminado='" + true + "' WHERE IdPlan = '" + id + "'";
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

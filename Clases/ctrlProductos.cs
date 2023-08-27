using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistema_de_facturacion.Clases
{
    internal class ctrlProductos: cConexion
    {
        public List<Object> consulta(string dato)
        {
            SqlDataReader reader;
            List<Object> lista = new List<Object>();
            string sql;

            if(dato == null)
            {
                sql = "SELECT idProducto, NombreProd, PrecioProdUnid, CantidadExit from tblProducto where Eliminado = '" + 0 + "' ORDER BY NombreProd ASC";
            }
            else
            {
                sql = "SELECT idProducto, NombreProd, PrecioProdUnid, CantidadExit from tblProducto WHERE NombreProd LIKE '%"+ dato +"%' OR PrecioProdUnid LIKE '%" + dato + "%' and Eliminado = '" + 0 + "' ORDER BY NombreProd ASC";
            }
            try
            {
                SqlConnection conexionBD = base.AbrirConexion();
                SqlCommand comando = new SqlCommand(sql, conexionBD);
                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Productos _producto = new Productos();
                    _producto.idProducto1 = int.Parse(reader[0].ToString());
                    _producto.NombreProd1 = reader[1].ToString();
                    _producto.PrecioPorUnid1 = decimal.Parse(reader[2].ToString());
                    _producto.CantidadExist1 = int.Parse(reader[3].ToString());
                    lista.Add(_producto);
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return lista;
           
        }
        public bool insertar(Productos datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO tblProducto (idProducto,NombreProd,PrecioProdUnid,CantidadExit, Eliminado) VALUES('"+datos.idProducto1+"','" + datos.NombreProd1 + "','" + datos.PrecioPorUnid1 + "','" + datos.CantidadExist1 + "', '" + datos.Eliminado1 + "')";
            //try
            //{
                SqlConnection conexionBD = base.AbrirConexion();
                SqlCommand comando = new SqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                bandera = true;
            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show("Error");
            //   bandera = false;
            //}
            return bandera;
        }
        public bool actualizar(Productos datos)
        {
            bool bandera = false;
            string sql = "UPDATE tblproducto SET idProducto='" + datos.idProducto1 + "', NombreProd='" + datos.NombreProd1 + "', PrecioProdUnid='" + datos.PrecioPorUnid1 + "', CantidadExit='" + datos.CantidadExist1 + "', Eliminado='" + datos.Eliminado1 + "' WHERE idProducto = '" + datos.idProducto1 + "'";
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
            string sql = "UPDATE tblproducto SET Eliminado='" + 1 + "' WHERE idProducto = '" + id + "'";
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

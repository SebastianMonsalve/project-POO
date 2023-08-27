using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion.Clases
{
    internal class ctrlConsumo: cConexion
    {
        public bool insertar(Consumo datos)
        {
            bool bandera = false;
            string sql = "INSERT INTO tblConsumo (IdProducto, idCliente, CantidadProdConsumido, totalConsumo, Estado, idReserva) VALUES (@IdProducto, @IdCliente, @CantidadProdConsumido, @TotalConsumo, @Estado, @idReserva)";
            SqlConnection conexionBD = base.AbrirConexion();
            SqlCommand comando = new SqlCommand(sql, conexionBD);
            comando.Parameters.AddWithValue("@IdProducto", datos.IdProducto);
            comando.Parameters.AddWithValue("@IdCliente", datos.IdCliente);
            comando.Parameters.AddWithValue("@CantidadProdConsumido", datos.CantidadProdConsumido);
            comando.Parameters.AddWithValue("@TotalConsumo", datos.TotalConsumo);
            comando.Parameters.AddWithValue("@Estado", datos.Estado);
            comando.Parameters.AddWithValue("@idReserva", datos.IdReserva);
            comando.ExecuteNonQuery();
            MessageBox.Show("Consumo registrado");
            bandera = true;
            //}
            //catch (SqlException ex)
            //{
            //  MessageBox.Show("Error: " + ex.Message);
            //bandera = false;
            //}
            return bandera;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sistema_de_facturacion.Clases
{
    internal class cConexion
    {

        //Establecemos la ruta
        static private string CadenaConexion = "Data Source=LAPTOP-SEBASTIA\\SQLEXPRESS;Initial Catalog = HotelPOO; Integrated Security = True";

        //Creamos una instancia de la ruta de la base de datos 
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        //Mertodo para abrie la base de datos
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;

        }

        //Metodo para cerrar la conexion
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}

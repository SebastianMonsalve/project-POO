using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion.Clases
{
    internal class Productos
    {
        private int idProducto;
        private string NombreProd;
        private decimal PrecioPorUnid;
        private int CantidadExist;
        private int Eliminado;

        public int idProducto1 { get => idProducto; set => idProducto = value; }
        public string NombreProd1 { get => NombreProd; set => NombreProd = value; }
        public decimal PrecioPorUnid1 { get => PrecioPorUnid; set => PrecioPorUnid = value; }
        public int CantidadExist1 { get => CantidadExist; set => CantidadExist = value; }
        public int Eliminado1 { get => Eliminado; set => Eliminado = value; }
    }
}

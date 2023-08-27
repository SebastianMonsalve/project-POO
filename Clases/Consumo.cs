using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion.Clases
{
    internal class Consumo
    {
        private int idProducto;
        private string idCliente;
        private int cantidadProdConsumido;
        private decimal totalConsumo;
        private string estado;
        private int idReserva;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public int CantidadProdConsumido { get => cantidadProdConsumido; set => cantidadProdConsumido = value; }
        public decimal TotalConsumo { get => totalConsumo; set => totalConsumo = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdReserva { get => idReserva; set => idReserva = value; }
    }
}

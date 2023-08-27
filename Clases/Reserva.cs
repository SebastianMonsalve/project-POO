using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion.Clases
{
    internal class Reserva
    {
        private int idReserva;
        private DateTime fechaReserva;
        private DateTime fechaIngreso;
        private DateTime fechaSalida;
        private int cantidadPersonas;
        private string idCliente;
        private string idPlan;
        private string idHabitacion;
        private string motivo;
        private string estado;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public DateTime FechaReserva { get => fechaReserva; set => fechaReserva = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public int CantidadPersonas { get => cantidadPersonas; set => cantidadPersonas = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string IdPlan { get => idPlan; set => idPlan = value; }
        public string IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public string Motivo { get => motivo; set => motivo = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}

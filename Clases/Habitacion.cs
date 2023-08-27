using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion.Clases
{
    internal class Habitacion
    {
        private string idHabitacion;
        private int capacidadHabitacion;
        private string descripcionHabitacion;
        private bool disponibilidadHabitacion;
        private byte[] imagen;
        private string urlImagen;
        private bool eliminada;

        public string IdHabitacion { get => idHabitacion; set => idHabitacion = value; }
        public int CapacidadHabitacion { get => capacidadHabitacion; set => capacidadHabitacion = value; }
        public string DescripcionHabitacion { get => descripcionHabitacion; set => descripcionHabitacion = value; }
        public bool DisponibilidadHabitacion { get => disponibilidadHabitacion; set => disponibilidadHabitacion = value; }
        public byte[] Imagen { get => imagen; set => imagen = value; }
        public string UrlImagen { get => urlImagen; set => urlImagen = value; }
        public bool Eliminada { get => eliminada; set => eliminada = value; }
        
    }
}

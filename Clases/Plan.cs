using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_facturacion.Clases
{
    internal class Plan
    {
        private string idPlan;
        private string descripcionPlan;
        private decimal valorPlan;
        private bool eliminado;

        public string IdPlan { get => idPlan; set => idPlan = value; }
        public string DescripcionPlan { get => descripcionPlan; set => descripcionPlan = value; }
        public decimal ValorPlan { get => valorPlan; set => valorPlan = value; }
        public bool Eliminado { get => eliminado; set => eliminado = value; }
    }
}

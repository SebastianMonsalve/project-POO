using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sistema_de_facturacion.Clases
{
    public class TemaColor
    {
        public static Color PanelContenedor;
        public static Color Botones;
        public static Color BarraTitulo;
        public static Color Texto1;
        public static Color Texto2;
        public static Color Texto3;
        public static Color Menu;


        //Colores Defecto BLACK
        private static readonly Color PanelContenedorB = Color.FromArgb(37, 33, 74);
        private static readonly Color BotonesB = Color.White;
        private static readonly Color BarraTituloB = Color.FromArgb(11, 7, 30);
        private static readonly Color Texto1B = Color.White;
        private static readonly Color Texto2B = Color.FromArgb(242, 146, 34);
        private static readonly Color Texto3B = Color.Black;
        private static readonly Color MenuB = Color.FromArgb(11, 7, 50);
        //Color WHILE
        private static readonly Color PanelContenedorW = Color.White;
        private static readonly Color BotonesW = Color.Gray;
        private static readonly Color BarraTituloW = Color.Gray;
        private static readonly Color Texto1W = Color.Black;
        private static readonly Color Texto2W = Color.FromArgb(64, 64, 64);
        private static readonly Color Texto3W = Color.Black;
        private static readonly Color MenuW = Color.Silver;

        public static void ElegirTema(string Tema)
        {
            if (Tema == "Oscuro")
            {
                PanelContenedor = PanelContenedorB;
                Botones = BotonesB;
                BarraTitulo = BarraTituloB;
                Texto1 = Texto1B;
                Texto2 = Texto2B;
                Texto3 = Texto3B;
                Menu = MenuB;
            }
            if (Tema == "Claro")
            {
                PanelContenedor = PanelContenedorW;
                Botones = BotonesW;
                BarraTitulo = BarraTituloW;
                Texto1 = Texto1W;
                Texto2 = Texto2W;
                Texto3 = Texto3W;
                Menu = MenuW;
            }
        }
    }
}

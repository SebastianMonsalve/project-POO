using Sistema_de_facturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion.Formularios
{
    //public static class Globals
    //{
    //    public static bool colores = true;
    //}
    public partial class frmBienvenido : Form
    {
        public static bool colores = true;
        public frmBienvenido()
        {
            InitializeComponent();
            Saludo();
            ElegirColor();

        }
        void ElegirColor()
        {
            if (colores == true)
            {
                ColorOscuro();
            }
            else
            {
                ColorClaro();
            }
        }

        private Form formularioActivo = null;
        public void abrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmLogin());
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmCrearCuenta());
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Transicion_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
        }

        private void frmBienvenido_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            Transicion.Start();
            //ColorOscuro();
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            btnWhite.Visible = false;
            btnBlack.Visible = true;
            colores = false;
            ElegirColor();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            btnWhite.Visible = true;
            btnBlack.Visible = false;
            colores = true;
            ElegirColor();
        }
        public void ColorClaro()
        {
            TemaColor.ElegirTema("Claro");
            lblFecha.ForeColor = TemaColor.Texto2;
            lblNombre.ForeColor = TemaColor.Texto1;
            lblTexto.ForeColor = TemaColor.Texto1;
            lblHora.ForeColor = TemaColor.Texto1;
            btnIniciar.ForeColor = TemaColor.Texto1;
            btnRegistrarse.ForeColor = TemaColor.Texto1;
            pnlBarra.BackColor = TemaColor.BarraTitulo;
            btnIniciar.BackColor = TemaColor.BarraTitulo;
            btnRegistrarse.BackColor = TemaColor.BarraTitulo;
            pnlContenedor.BackColor = TemaColor.PanelContenedor;
            pnlImagen.BackColor = TemaColor.Menu;
            lblSaludo.ForeColor = TemaColor.Texto2;
        }
        public void ColorOscuro()
        {
            TemaColor.ElegirTema("Oscuro");
            lblFecha.ForeColor = TemaColor.Texto2;
            lblNombre.ForeColor = TemaColor.Texto2;
            lblTexto.ForeColor = TemaColor.Texto2;
            lblHora.ForeColor = TemaColor.Texto1;
            btnIniciar.ForeColor = TemaColor.Texto1;
            btnRegistrarse.ForeColor = TemaColor.Texto1;
            pnlBarra.BackColor = TemaColor.BarraTitulo;
            btnIniciar.BackColor = TemaColor.BarraTitulo;
            btnRegistrarse.BackColor = TemaColor.BarraTitulo;
            pnlContenedor.BackColor = TemaColor.PanelContenedor;
            pnlImagen.BackColor = TemaColor.Menu;
            lblSaludo.ForeColor = TemaColor.Texto2;
        }
        private void Saludo()
        {
            DateTime horaActual = DateTime.Now;


            if (horaActual.Hour < 12)
            {
                lblSaludo.Text = "Buenos días";
            }
            else if (horaActual.Hour < 18)
            {
                lblSaludo.Text = "Buenas tardes";
            }
            else
            {
                lblSaludo.Text = "Buenas noches";
            }
        }

    }
}

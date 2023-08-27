using Sistema_de_facturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            PersonalizarDiseno();
            if (Acceso.sesion == "00")
            {
                btnPerfilHotel.Visible = true;
                btnEmpleados.Visible = true;
                btnInformes.Visible = true;
                btnFacturar.Visible = true; 
            }
            else
            {
                btnPerfil.Visible = true;
            }
        }
        private void PersonalizarDiseno()
        {
            pnlSubInformes.Visible = false;
            pnlSubServicios.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (pnlSubInformes.Visible == true)
                pnlSubInformes.Visible = false;
            if (pnlSubServicios.Visible == true)
                pnlSubServicios.Visible = false;
        }
        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private Form formularioActivo = null;
        private void abrirFormulariosHijos(Form formularioHijo)
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

            //  abrirFormulariosHijos(new frmHabitacionAdmin());
        }

        private void btnHabitaciones_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmHabitaciones());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            MostrarSubMenu(pnlSubServicios);
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            MostrarSubMenu(pnlSubInformes);
        }

        private void btnHospedaje_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmPlanes());
            OcultarSubMenu();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulariosHijos(new frmReserva());
        }

        private void pnlCerrarSesion_Click(object sender, EventArgs e)
        {
            frmMessageCerrar frm = new frmMessageCerrar();
            frm.Owner = this; // Establecer frmMenu como el formulario padre
            frm.Show();
        }

        private void FechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmProductos());
            OcultarSubMenu();
        }


        private void btnPorHabitacion_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void btnPorProducto_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void btnPorReserva_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulariosHijos(new frmPerfilUsuario());
        }

        private void btnPerfilHotel_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            abrirFormulariosHijos(new frmPerfilHotel());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmEmpleados());
            OcultarSubMenu();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            abrirFormulariosHijos(new frmConsumo());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_facturacion.Clases;
using Sistema_de_facturacion.Formularios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_facturacion.Formularios
{
    public partial class frmMessageCerrar : Form
    {
        public frmMessageCerrar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Obtener una referencia al formulario padre (frmMenu)
            Form frmMenu = this.Owner;

            // Cerrar el formulario padre (frmMenu) y el formulario actual (frmMessageCerrar)
            frmMenu.Close();
            this.Close();

            // Crear una nueva instancia de frmBienvenido y mostrarla
            frmBienvenido frm = new frmBienvenido();
            frm.Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

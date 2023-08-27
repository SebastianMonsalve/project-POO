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
    public partial class frmPlanes : Form
    {
        public frmPlanes()
        {
            InitializeComponent();
            cargarTabla(null);
            if(Acceso.sesion == "00")
            {
                btnEliminar.Visible = true;
                btnGuardar.Visible = true;
                btnLimpiar.Visible = true;
                btnModificar.Visible = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgPlanes.CurrentRow.Cells[0].Value.ToString();
            txtIdPlan.Text = dtgPlanes.CurrentRow.Cells[0].Value.ToString();
            txtDescripcion.Text = dtgPlanes.CurrentRow.Cells[1].Value.ToString();
            txtValor.Text = dtgPlanes.CurrentRow.Cells[2].Value.ToString();
        }
        private void cargarTabla(string dato)
        {
            List<Plan> lista = new List<Plan>();
            ctrlPlan _ctrlPlan = new ctrlPlan();
            dtgPlanes.DataSource = _ctrlPlan.consulta(dato);

        }
        private void limpiar()
        {
            txtId.Clear();
            txtIdPlan.Clear();
            txtDescripcion.Clear();
            txtValor.Clear();
            txtBuscar.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Plan _plan = new Plan();
            _plan.IdPlan = txtIdPlan.Text;
            _plan.DescripcionPlan = txtDescripcion.Text;
            _plan.ValorPlan = decimal.Parse(txtValor.Text);
            _plan.Eliminado = false;
            ctrlPlan ctrl = new ctrlPlan();

            if (txtId.Text != "")
            {
                _plan.IdPlan = txtIdPlan.Text;
                bandera = ctrl.actualizar(_plan);
            }
            else
            {
                bandera = ctrl.insertar(_plan);
            }
            if (bandera)
            {
                MessageBox.Show("Registro guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro " + txtIdPlan.Text, "Salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                ctrlPlan _ctrl = new ctrlPlan();
                bandera = _ctrl.eliminar(Convert.ToInt32(dtgPlanes.CurrentRow.Cells[0].Value.ToString()));

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiar();
                    cargarTabla(null);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargarTabla(dato);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using Sistema_de_facturacion.Clases;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_de_facturacion.Formularios
{
    public partial class frmHabitaciones : Form
    {
        public frmHabitaciones()
        {
            InitializeComponent();
            cargarTabla(null);
            if(Acceso.sesion == "00")
            {
                btnGuardar.Visible = true;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
            }
        }
        private void cargarTabla(string dato)
        {
            List<Habitacion> lista = new List<Habitacion>();
            ctrlHabitacion _ctrlHabitaciones = new ctrlHabitacion();
            dtgHabitaciones.DataSource = _ctrlHabitaciones.consulta(dato);
           
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgHabitaciones.CurrentRow.Cells[0].Value.ToString();
            txtIdHabitacion.Text = dtgHabitaciones.CurrentRow.Cells[0].Value.ToString();
            txtCapacidad.Text = dtgHabitaciones.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtgHabitaciones.CurrentRow.Cells[2].Value.ToString();
            txtDisponibilidad.Text = dtgHabitaciones.CurrentRow.Cells[3].Value.ToString();
            txtRuta.Text = dtgHabitaciones.CurrentRow.Cells[5].Value.ToString();
            pcbHabitacion.Load(txtRuta.Text);
            Habilita();
        }
     
        private void limpiar()
        {
            txtIdHabitacion.Clear();
            txtCapacidad.Clear();
            txtDescripcion.Clear();
            txtDisponibilidad.Clear();
            txtRuta.Clear();
            pcbHabitacion.Image = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            byte[] img = System.IO.File.ReadAllBytes(txtRuta.Text);
            bool bandera = false;
            Habitacion _habitacion = new Habitacion();
            _habitacion.IdHabitacion = txtIdHabitacion.Text;
            _habitacion.CapacidadHabitacion = int.Parse(txtCapacidad.Text);
            _habitacion.DescripcionHabitacion = txtDescripcion.Text;
            _habitacion.DisponibilidadHabitacion = Convert.ToBoolean(txtDisponibilidad.Text);
            _habitacion.Imagen = img;
            _habitacion.UrlImagen = txtRuta.Text;
            _habitacion.Eliminada = false;

            ctrlHabitacion ctrl = new ctrlHabitacion();

            if (txtId.Text != "")
            {
                _habitacion.IdHabitacion = txtIdHabitacion.Text;
                bandera = ctrl.actualizar(_habitacion);
            }
            else
            {
                bandera = ctrl.insertar(_habitacion);
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
            btnAgregar.Visible = false;
            Habilita();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro " + txtIdHabitacion.Text, "Salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                ctrlHabitacion _ctrl = new ctrlHabitacion();
                bandera = _ctrl.eliminar(Convert.ToInt32(dtgHabitaciones.CurrentRow.Cells[0].Value.ToString()));

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    limpiar();
                    cargarTabla(null);
                    Habilita();
                }
            }
        }

        private void txtIdHabitacion_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdHabitacion.Text))
            {
                pcbHabitacion.Visible = true;
                btnAgregar.Visible = true;
                //btnGuardar.Visible = true;  
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            txtId.Text = dtgHabitaciones.CurrentRow.Cells[0].Value.ToString();
            txtIdHabitacion.Text = dtgHabitaciones.CurrentRow.Cells[0].Value.ToString();
            txtCapacidad.Text = dtgHabitaciones.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dtgHabitaciones.CurrentRow.Cells[2].Value.ToString();
            txtDisponibilidad.Text = dtgHabitaciones.CurrentRow.Cells[3].Value.ToString();
            txtRuta.Text = dtgHabitaciones.CurrentRow.Cells[5].Value.ToString();
            pcbHabitacion.Load(txtRuta.Text);
            Desabilita();
        }

        void Desabilita()
        {
            txtIdHabitacion.Enabled = false;
            txtCapacidad.Enabled = false;
            txtDescripcion.Enabled =false;
            txtDisponibilidad.Enabled=false;
            pcbHabitacion.Enabled=false;
            btnAgregar.Enabled = false;
            btnGuardar.Enabled = false; 

            
        }
        void Habilita()
        {
            txtIdHabitacion.Enabled = true;
            txtCapacidad.Enabled =true;
            txtDescripcion.Enabled = true;
            txtDisponibilidad.Enabled = true;
            pcbHabitacion.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargarTabla(dato);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgHabitacion.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtRuta.Text = dlgHabitacion.FileName;
                pcbHabitacion.Load(txtRuta.Text);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using Sistema_de_facturacion.Clases;
using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;

namespace Sistema_de_facturacion.Formularios
{
    public partial class frmReserva : Form
    {
        cConexion cn;
        bool isUpdate = false;
        bool isInser = false;
        public frmReserva()
        {
            InitializeComponent();
            autoCompletar();
            cn = new cConexion();
            SqlCommand sesion = new SqlCommand("select idCliente, NombreCliente, ApellidoCliente from tblCliente where IdCliente = '" + Acceso.sesion + "'", cn.AbrirConexion());
            SqlDataAdapter daSesion = new SqlDataAdapter(sesion);
            DataTable dtSesion = new DataTable();
            daSesion.Fill(dtSesion);
            sesion.ExecuteNonQuery();
            cn.CerrarConexion();

            if (Acceso.sesion == "00")
            {
                LlenarCliente(null);
                LlenarHabitacion(null);
                LlenarPlan(null);
                txtDocumento.Text = dtSesion.Rows[0][0].ToString();
                txtNombre.Text = dtSesion.Rows[0][1].ToString();
                txtApellido.Text = dtSesion.Rows[0][2].ToString();
            }
            else
            {
                LlenarCliente(Acceso.sesion.ToString());
                LlenarHabitacion(null);
                LlenarPlan(null);
                txtDocumento.Text = dtSesion.Rows[0][0].ToString();
                txtNombre.Text = dtSesion.Rows[0][1].ToString();
                txtApellido.Text = dtSesion.Rows[0][2].ToString();
                DesabilitaSesion();
            }

        }
    private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dtpIngreso.Value < dtpSalida.Value && int.Parse(txtPersonas.Text) <= int.Parse(dtgHabitacion.CurrentRow.Cells[1].Value.ToString()))
            {
                isInser = true;
                bool bandera = false;
                Reserva _reserva = new Reserva();
                _reserva.FechaReserva = dtpReserva.Value;
                _reserva.FechaIngreso = dtpIngreso.Value;
                _reserva.FechaSalida = dtpSalida.Value;
                _reserva.CantidadPersonas = int.Parse(txtPersonas.Text);
                _reserva.IdCliente = txtDocumento.Text;
                if (isInser == true && isUpdate == false)
                {
                    _reserva.IdPlan = dtgPlan.CurrentRow.Cells[0].Value.ToString();
                    _reserva.IdHabitacion = dtgHabitacion.CurrentRow.Cells[0].Value.ToString();
                }
                else
                {
                    _reserva.IdPlan = dtgReservas.CurrentRow.Cells[6].Value.ToString();
                    _reserva.IdHabitacion = dtgReservas.CurrentRow.Cells[7].Value.ToString();
                }
                _reserva.Motivo = "No C no T";
                _reserva.Estado = "Activa";
                ctrlReserva ctrl = new ctrlReserva();



                if (txtId.Text != "")
                {
                    _reserva.IdReserva = int.Parse(txtId.Text);
                    bandera = ctrl.actualizar(_reserva);
                }
                else
                {
                    bandera = ctrl.insertar(_reserva);
                }
                if (bandera)
                {
                    MessageBox.Show("Registro guardado");
                    //limpiar();
                    cn = new cConexion();
                    SqlCommand actualizaHabitacion = new SqlCommand("update tblHabitacion set DisponibilidadHabitacion = 0 where IdHabitacion='" + _reserva.IdHabitacion.ToString() + "' ", cn.AbrirConexion());
                    actualizaHabitacion.ExecuteNonQuery();
                    cn.CerrarConexion();
                    if (Acceso.sesion == "00")
                    {
                        cargarTabla(null);
                        LlenarHabitacion(null);
                    }
                    else
                    {
                        cargarTabla(Acceso.sesion);
                        LlenarHabitacion(null);
                    }

                }
            }
            else
            {
                if(dtpIngreso.Value > dtpSalida.Value)
                {
                    MessageBox.Show("La fecha de entrada no debe de ser mayor a la fecha de salida");
                }
                else
                {
                    MessageBox.Show("Verifica la capacidad de la habitacion que estas selecionando");
                }
            }
        }
        private void LlenarCliente(string dato)
        {
            List<Reserva> lista = new List<Reserva>();
            ctrlReserva _ctrlReserva = new ctrlReserva();
            dtgReservas.DataSource = _ctrlReserva.consulta(dato);
        }
        private void LlenarHabitacion(string dato)
        {
            List<Habitacion> lista = new List<Habitacion>();
            ctrlHabitacion _ctrlHabitacion = new ctrlHabitacion();
            dtgHabitacion.DataSource = _ctrlHabitacion.consultaHabitacionesReserva(dato);
        }
        private void LlenarPlan(string dato)
        {
            List<Plan> lista = new List<Plan>();
            ctrlPlan _ctrlPlan = new ctrlPlan();
            dtgPlan.DataSource = _ctrlPlan.consulta(dato);
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            LlenarCliente(dato);
        }
        private void DesabilitaSesion()
        {
            txtDocumento.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCosto.Visible = true;
            txtCosto.Enabled=false;
            txtPersonas.Enabled=false;
            isUpdate = true;
            cn = new cConexion();
            SqlCommand habitacion = new SqlCommand("select UrlImagen from tblHabitacion where IdHabitacion = '" + dtgReservas.CurrentRow.Cells[7].Value.ToString() + "'", cn.AbrirConexion());
            SqlDataAdapter daHabitacion = new SqlDataAdapter(habitacion);
            DataTable dtHabitacion = new DataTable();
            daHabitacion.Fill(dtHabitacion);
            habitacion.ExecuteNonQuery();
            cn.CerrarConexion();

            /////////////////////////
            ///
            cn = new cConexion();
            SqlCommand plan = new SqlCommand("select ValorPlan from tblPlanes where IdPlan = '" + dtgReservas.CurrentRow.Cells[6].Value.ToString() + "'", cn.AbrirConexion());
            SqlDataAdapter daPlan = new SqlDataAdapter(plan);
            DataTable dtPlan = new DataTable();
            daPlan.Fill(dtPlan);
            plan.ExecuteNonQuery();
            cn.CerrarConexion();

            ///////////////////
            ///
            cn = new cConexion();
            SqlCommand cliente = new SqlCommand("select idCliente, NombreCliente, ApellidoCliente from tblCliente where IdCliente = '" + dtgReservas.CurrentRow.Cells[5].Value.ToString() + "'", cn.AbrirConexion());
            SqlDataAdapter daCliente = new SqlDataAdapter(cliente);
            DataTable dtCliente = new DataTable();
            daCliente.Fill(dtCliente);
            cliente.ExecuteNonQuery();
            cn.CerrarConexion();


            txtRuta.Text = dtHabitacion.Rows[0][0].ToString();
            pcbImagen.Load(txtRuta.Text);
            txtId.Text = dtgReservas.CurrentRow.Cells[0].Value.ToString();
            dtpReserva.Value = (DateTime)dtgReservas.CurrentRow.Cells[1].Value;
            dtpIngreso.Value = (DateTime)dtgReservas.CurrentRow.Cells[2].Value;
            dtpSalida.Value = (DateTime)dtgReservas.CurrentRow.Cells[3].Value;
            txtCosto.Text = dtPlan.Rows[0][0].ToString();
            txtPersonas.Text = dtgReservas.CurrentRow.Cells[4].Value.ToString();
            txtDocumento.Text = dtCliente.Rows[0][0].ToString();
            txtNombre.Text = dtCliente.Rows[0][1].ToString();
            txtApellido.Text = dtCliente.Rows[0][2].ToString();

        }
        private void cargarTabla(string dato)
        {
            List<Reserva> lista = new List<Reserva>();
            ctrlReserva _ctrlRese = new ctrlReserva();
            dtgReservas.DataSource = _ctrlRese.consulta(dato);


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro ", "Salir", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.Yes)
            {
                ctrlReserva _ctrl = new ctrlReserva();
                bandera = _ctrl.eliminar(Convert.ToInt32(dtgReservas.CurrentRow.Cells[0].Value.ToString()));

                if (bandera)
                {
                    MessageBox.Show("Registro eliminado");
                    //limpiar();
                    cargarTabla(null);
                    //Habilita();
                }
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            try
            {
                cn = new cConexion();
                SqlCommand buscaCliente = new SqlCommand("select idCliente, NombreCliente, ApellidoCliente from tblCliente where IdCliente = '" + txtDocumento.Text + "'", cn.AbrirConexion());
                SqlDataAdapter daBuscaCliente = new SqlDataAdapter(buscaCliente);
                DataTable dtBuscaCliente = new DataTable();
                daBuscaCliente.Fill(dtBuscaCliente);
                buscaCliente.ExecuteNonQuery();
                cn.CerrarConexion();

                txtDocumento.Text = dtBuscaCliente.Rows[0][0].ToString();
                txtNombre.Text = dtBuscaCliente.Rows[0][1].ToString();
                txtApellido.Text = dtBuscaCliente.Rows[0][2].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("El cliente no existe");
            }
        }

        private void btnVistaPrevia_Click(object sender, EventArgs e)
        {
            txtRuta.Text = dtgHabitacion.CurrentRow.Cells[5].Value.ToString();
            pcbImagen.Load(txtRuta.Text);
            lblCosto.Visible = true;
            txtCosto.Visible = true;
            txtCosto.Enabled = false;
            txtCosto.Text = dtgPlan.CurrentRow.Cells[2].Value.ToString();
        }
        cConexion c = new cConexion();
        DataTable datos = new DataTable();
        void autoCompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM tblCliente", c.AbrirConexion());
            adaptador.Fill(datos);
            c.CerrarConexion();

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["IdCliente"].ToString());
            }
            txtDocumento.AutoCompleteCustomSource = lista;
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPersonas.Clear();
            txtCosto.Clear();
            lblCosto.Visible = false;
            txtCosto.Visible = false;
            pcbImagen.Image = null;
            dtpReserva.Value = DateTime.Now;
            dtpIngreso.Value = DateTime.Now;
            dtpSalida.Value = DateTime.Now;
            txtPersonas.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

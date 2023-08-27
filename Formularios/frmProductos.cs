using Sistema_de_facturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_facturacion.Formularios
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            cargarTabla(null);
            autoCompletar();
            if(Acceso.sesion == "00")
            {
                btnGuardar.Visible = true;
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                btnLimpiar.Visible = true;  
            }
        }

        private void cargarTabla(string dato)
        {
            List<Productos> lista = new List<Productos>();
            ctrlProductos _ctrlProductos = new ctrlProductos();
            dtgTablaProductos.DataSource = _ctrlProductos.consulta(dato);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            string[] precio = txtPrecio.Text.Split(',');
            int precioEntero = Convert.ToInt32(precio[0]);
            Productos _producto = new Productos();
            _producto.idProducto1 = Convert.ToInt32(txtIdProducto.Text);
            _producto.NombreProd1 = txtNombre.Text;
            _producto.PrecioPorUnid1 = precioEntero;
            _producto.CantidadExist1 = Convert.ToInt32(txtCantidad.Text);
            _producto.Eliminado1 = 0;

            ctrlProductos ctrl = new ctrlProductos();

            if(txtId.Text != "")
            {
                _producto.idProducto1 = Convert.ToInt32(txtIdProducto.Text);
                bandera = ctrl.actualizar(_producto);
            }
            else
            {
                bandera = ctrl.insertar(_producto);
            }
            if(bandera)
            {
                MessageBox.Show("Registro guardado");
                limpiar();
                cargarTabla(null);
            }
        }

        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtIdProducto.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
                txtId.Text = dtgTablaProductos.CurrentRow.Cells[0].Value.ToString();
                txtIdProducto.Text = dtgTablaProductos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dtgTablaProductos.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dtgTablaProductos.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dtgTablaProductos.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            DialogResult resultado = MessageBox.Show("Seguro que desea eliminar el registro " + txtIdProducto.Text, "Salir", MessageBoxButtons.YesNoCancel);
            if(resultado == DialogResult.Yes)
            {
                ctrlProductos _ctrl = new ctrlProductos();
                bandera =  _ctrl.eliminar(Convert.ToInt32(dtgTablaProductos.CurrentRow.Cells[0].Value.ToString()));

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


        cConexion cn = new cConexion();
        DataTable datos = new DataTable();
        void autoCompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM tblProducto",cn.AbrirConexion());
            adaptador.Fill(datos);
            cn.CerrarConexion();

            for(int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["NombreProd"].ToString());
            }
            txtBuscar.AutoCompleteCustomSource = lista;
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            cargarTabla(txtBuscar.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

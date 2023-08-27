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
    public partial class frmPerfilUsuario : Form
    {
        cConexion cn = new cConexion();
        public frmPerfilUsuario()
        {
            InitializeComponent();
            DatosUsuario();
            Desabilita();
        }

        private void frmPerfilUsuario_Load(object sender, EventArgs e)
        {
            
        }
        private void DatosUsuario()
        {
            SqlCommand cmdDatosCliente = new SqlCommand("select * from tblCliente where IdCliente = '" + Acceso.sesion.ToString() + "'", cn.AbrirConexion());
            SqlDataAdapter daDatosCliente = new SqlDataAdapter(cmdDatosCliente);
            DataTable dtDatosUsuario = new DataTable();
            daDatosCliente.Fill(dtDatosUsuario);
            cmdDatosCliente.ExecuteNonQuery();
            cn.CerrarConexion();


            txtRuta.Text = dtDatosUsuario.Rows[0][10].ToString();
            txtCedula.Text = dtDatosUsuario.Rows[0][0].ToString();
            txtNombre.Text = dtDatosUsuario.Rows[0][1].ToString();
            txtApellido.Text = dtDatosUsuario.Rows[0][2].ToString();
            txtCelular.Text = dtDatosUsuario.Rows[0][6].ToString();
            txtCorreo.Text = dtDatosUsuario.Rows[0][7].ToString();
            txtProcedencia.Text = dtDatosUsuario.Rows[0][5].ToString();
            txtResidencia.Text = dtDatosUsuario.Rows[0][4].ToString();
            txtContrasena.Text = dtDatosUsuario.Rows[0][8].ToString();
            pcbImagen.Load(txtRuta.Text);
            pcbImagen.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void Habilita()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCelular.Enabled = true;
            txtCorreo.Enabled = true;
            txtResidencia.Enabled = true;
            txtContrasena.Enabled = true;
            btnAgregar.Enabled = true;
        }
        private void Desabilita()
        {
            txtCedula.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtCelular.Enabled = false;
            txtCorreo.Enabled = false;
            txtResidencia.Enabled = false;
            txtContrasena.Enabled = false;
            txtRuta.Enabled = false;
            txtProcedencia.Enabled=false;
            btnAgregar.Enabled=false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdEditarCliente = new SqlCommand("update tblCliente set idCliente='" + txtCedula.Text + "',NombreCliente='" + txtNombre.Text + "',ApellidoCliente='" + txtApellido.Text + "',ResidenciaCliente='" + txtResidencia.Text + "',CelularCliente='" + txtCelular.Text + "',CorreoCliente='" + txtCorreo.Text + "',Contrasena='" + txtContrasena.Text + "',UrlImagen='" + txtRuta.Text + "' where IdCliente = '" + Acceso.sesion.ToString() + "'", cn.AbrirConexion());
                cmdEditarCliente.ExecuteNonQuery();
                cn.CerrarConexion();
                MessageBox.Show("Cliente Editado correctamente");

            }
            catch (Exception) {
                MessageBox.Show("Upps Parece que ha ocurrido un error");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgPerfilUsuario.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtRuta.Text = dlgPerfilUsuario.FileName;
                pcbImagen.Load(txtRuta.Text);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas ELIMINAR su cuenta?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    SqlCommand cmdEditarCliente = new SqlCommand("update tblCliente set Eliminado= 1 where IdCliente = '" + Acceso.sesion.ToString() + "'", cn.AbrirConexion());
                    cmdEditarCliente.ExecuteNonQuery();
                    cn.CerrarConexion();

                    frmBienvenido frmBienvenido = new frmBienvenido();
                    frmBienvenido.Show();
                    this.ParentForm.Hide();
                }
            }
            catch (Exception){
                MessageBox.Show("Upps Parece que ha ocurrido un error");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

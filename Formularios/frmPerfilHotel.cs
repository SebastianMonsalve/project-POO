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
    public partial class frmPerfilHotel : Form
    {
        cConexion cn = new cConexion();
        public frmPerfilHotel()
        {
            InitializeComponent();
        }

        private void frmPerfilHotel_Load(object sender, EventArgs e)
        {
            pcbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            DatosHotel();
            Desabilita();
        }
        private void DatosHotel()
        {
            SqlCommand cmdDatosHotel = new SqlCommand("select * from tblHotel", cn.AbrirConexion());
            SqlDataAdapter daDatosHotel = new SqlDataAdapter(cmdDatosHotel);
            DataTable dtDatosHotel = new DataTable();
            daDatosHotel.Fill(dtDatosHotel);
            cmdDatosHotel.ExecuteNonQuery();
            cn.CerrarConexion();

            SqlCommand cmdContrasenaAdmin = new SqlCommand("select Contrasena from tblCliente where idCliente= '" + Acceso.sesion.ToString() + "'", cn.AbrirConexion());
            SqlDataAdapter daContrasenaAdmin = new SqlDataAdapter(cmdContrasenaAdmin);
            DataTable dtContrasenaAdmin = new DataTable();
            daContrasenaAdmin.Fill(dtContrasenaAdmin);
            cmdContrasenaAdmin.ExecuteNonQuery();
            cn.CerrarConexion();

            if (dtDatosHotel.Rows.Count > 0)
            {
                
                txtNit.Text = dtDatosHotel.Rows[0][0].ToString();
                txtNombre.Text = dtDatosHotel.Rows[0][1].ToString();
                txtSlogan.Text = dtDatosHotel.Rows[0][2].ToString();
                txtTelefono.Text = dtDatosHotel.Rows[0][3].ToString();
                txtCorreo.Text = dtDatosHotel.Rows[0][4].ToString();
                txtDireccion.Text = dtDatosHotel.Rows[0][5].ToString();
                txtCiudad.Text = dtDatosHotel.Rows[0][6].ToString();
                try
                {
                    txtRuta.Text = dtDatosHotel.Rows[0][7].ToString();
                    pcbImagen.Load(txtRuta.Text);
                }
                catch(Exception) { }
                
            }
            else
            {
                SqlCommand cmdNull = new SqlCommand("insert into tblHotel values('null','null','null','null','null','null','null', 'null')", cn.AbrirConexion());
                cmdNull.ExecuteNonQuery();
                cn.CerrarConexion();
            }
            txtContrasena.Text = dtContrasenaAdmin.Rows[0][0].ToString();
        }
        private void Desabilita()
        {
            txtNit.Enabled = false;
            txtNombre.Enabled = false;
            txtSlogan.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
        }
        public void Habilita()
        {
            txtNit.Enabled = true;
            txtNombre.Enabled = true;
            txtSlogan.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //try
            //{
                SqlCommand cmdEditarHotel = new SqlCommand("update tblHotel set Nit='" + txtNit.Text + "',NombreHotel='" + txtNombre.Text + "',Slogan='" + txtSlogan.Text + "',NumeroTelefono='" + txtTelefono.Text + "',CorreoHotel='" + txtCorreo.Text + "',Direccion='" + txtDireccion.Text + "', Ciudad='" + txtCiudad.Text + "',UrlImagen='" + txtRuta.Text + "'", cn.AbrirConexion());
                cmdEditarHotel.ExecuteNonQuery();
                cn.CerrarConexion();

            SqlCommand cmdEditarAdmin = new SqlCommand("update tblCliente set Contrasena='" + txtContrasena.Text + "'where idCliente = '" + Acceso.sesion.ToString() + "'", cn.AbrirConexion());
            cmdEditarAdmin.ExecuteNonQuery();
            cn.CerrarConexion();
            MessageBox.Show("Datos guardados correctamente");

            //}
            //catch (Exception)
            //{
                //MessageBox.Show("Upps Parece que ha ocurrido un error");
            //}
            Desabilita();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgHotel.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtRuta.Text = dlgHotel.FileName;
                pcbImagen.Load(txtRuta.Text);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoVer_Click(object sender, EventArgs e)
        {
            btnVer.Visible = true;
            btnNoVer.Visible = false;
            txtContrasena.PasswordChar = '*';
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            btnVer.Visible = false;
            btnNoVer.Visible = true;
            txtContrasena.PasswordChar = '\0';
        }
    }
}

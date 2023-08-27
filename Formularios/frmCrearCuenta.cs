using Sistema_de_facturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_facturacion.Formularios;

namespace Sistema_de_facturacion.Formularios
{
    public partial class frmCrearCuenta : Form
    {
        cConexion cn;
        frmBienvenido formularioBienvenido = new frmBienvenido();
        public frmCrearCuenta()
        {
            cn = new cConexion();
            InitializeComponent();
            ElegirColor();
        }
        void ElegirColor()
        {
            if (frmBienvenido.colores == true)
            {
                ColorOscuro();
            }
            else
            {
                ColorClaro();
            }
        }
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            string filePath = "C:\\Users\\sebas\\Documents\\Programacion Orientada a Objetos\\Sistema de facturacion\\Resources\\Profile.png";
            byte[] imageData = null;
            using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }
            string fecha = dtpNacimiento.Value.ToString("yyyy-MM-dd");
            TimeSpan diferencia = DateTime.Now - dtpNacimiento.Value;
            int edad = Convert.ToInt32(diferencia.TotalDays / 365.25);

            if (!string.IsNullOrEmpty(txtCedula.Text) && !string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellido.Text) && !string.IsNullOrEmpty(txtCorreo.Text) && !string.IsNullOrEmpty(txtCelular.Text) && !string.IsNullOrEmpty(txtProcedencia.Text) && !string.IsNullOrEmpty(txtResidencia.Text) && !string.IsNullOrEmpty(txtContrasena.Text))
            {
                if (edad >= 18)
                {
                    SqlCommand cmd = new SqlCommand("nuevo_cliente", cn.AbrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@NombreCliente", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@ApellidoCliente", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@FechaNaciCliente", fecha);
                    cmd.Parameters.AddWithValue("@ResidenciaCliente", txtResidencia.Text);
                    cmd.Parameters.AddWithValue("@ProcedenciaCliente", txtProcedencia.Text);
                    cmd.Parameters.AddWithValue("@CelularCliente", txtCelular.Text);
                    cmd.Parameters.AddWithValue("@CorreoCliente", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@Contrasena", txtContrasena.Text);
                    cmd.Parameters.AddWithValue("@Eliminado", 0);
                    cmd.Parameters.AddWithValue("@Imagen", imageData);
                    cmd.Parameters.AddWithValue("@UrlImagen", filePath);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente creado exitosamente");
                    cn.CerrarConexion();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No puedes tener una cuenta si eres menor de edad");
                }
            }
            else
            {
                lblError.Text = "Llena todos los campos solicitados para continuar";
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool AlgoritmoContrasenaSegura(string Contrasena)
        {
            ckbCantidad.Checked = false; ckbMayuscula.Checked = false; ckbMinuscula.Checked = false; ckbNumero.Checked = false;
            for(int i = 0; i < Contrasena.Length; i++)
            {
                if(Contrasena.Length >= 8)
                {
                    ckbCantidad.Checked = true;
                }
                if (Char.IsLower(Contrasena, i))
                {
                    ckbMayuscula.Checked = true;
                }
                if (Char.IsDigit(Contrasena, i))
                {
                    ckbMinuscula.Checked = true;
                }
                if (Char.IsDigit(Contrasena, i))
                {
                    ckbNumero.Checked = true;
                }
            }
            if(ckbCantidad.Checked && ckbMayuscula.Checked && ckbMinuscula.Checked && ckbNumero.Checked && Contrasena.Length >= 8) 
            {
                return true;
            }
            return false;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            if(AlgoritmoContrasenaSegura(txtContrasena.Text))
            {
                btnCrearCuenta.Enabled = true;
            }
            else
            {
                btnCrearCuenta.Enabled = false;
            }
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            btnWhite.Visible = false;
            btnBlack.Visible = true;
            ColorClaro();
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            btnWhite.Visible = true;
            btnBlack.Visible = false;
            ColorOscuro();
        }
        public void ColorClaro()
        {
            TemaColor.ElegirTema("Claro");
            lblCrearCuenta.ForeColor = TemaColor.Texto2;
            lblDocumento.ForeColor = TemaColor.Texto1;
            lblNombre.ForeColor = TemaColor.Texto1;
            lblApellido.ForeColor = TemaColor.Texto1;
            lblCelular.ForeColor = TemaColor.Texto1;
            lblFecha.ForeColor = TemaColor.Texto1;
            lblContraseña.ForeColor = TemaColor.Texto1;
            lblCorreo.ForeColor = TemaColor.Texto1;
            lblError.ForeColor = TemaColor.Texto1;
            lblProcedencia.ForeColor = TemaColor.Texto1;
            lblResidencia.ForeColor = TemaColor.Texto1;
            btnCrearCuenta.BackColor = TemaColor.Botones;
            btnCrearCuenta.ForeColor = TemaColor.Texto3;
            txtApellido.BackColor = TemaColor.Menu;
            txtCedula.BackColor = TemaColor.Menu;
            txtCelular.BackColor = TemaColor.Menu;
            txtContrasena.BackColor = TemaColor.Menu;
            txtCorreo.BackColor = TemaColor.Menu;
            txtNombre.BackColor = TemaColor.Menu;
            txtProcedencia.BackColor = TemaColor.Menu;
            txtResidencia.BackColor = TemaColor.Menu;
            ckbCantidad.ForeColor = TemaColor.Texto1;
            ckbMayuscula.ForeColor = TemaColor.Texto1;
            ckbMinuscula.ForeColor = TemaColor.Texto1;
            ckbNumero.ForeColor = TemaColor.Texto1;
            btnNoVer.BackColor = TemaColor.Menu;
            btnVer.BackColor = TemaColor.Menu;
            btnCerrar.BackColor = TemaColor.Menu;
            this.BackColor = TemaColor.PanelContenedor;
        }
        public void ColorOscuro()
        {
            TemaColor.ElegirTema("Oscuro");
            lblCrearCuenta.ForeColor = TemaColor.Texto2;
            lblDocumento.ForeColor = TemaColor.Texto1;
            lblNombre.ForeColor = TemaColor.Texto1;
            lblApellido.ForeColor = TemaColor.Texto1;
            lblCelular.ForeColor = TemaColor.Texto1;
            lblFecha.ForeColor = TemaColor.Texto1;
            lblContraseña.ForeColor = TemaColor.Texto1;
            lblCorreo.ForeColor = TemaColor.Texto1;
            lblError.ForeColor = TemaColor.Texto1;
            lblProcedencia.ForeColor = TemaColor.Texto1;
            lblResidencia.ForeColor = TemaColor.Texto1;
            btnCrearCuenta.BackColor = TemaColor.Texto1;
            btnCrearCuenta.ForeColor = TemaColor.Texto3;
            txtApellido.BackColor = TemaColor.Botones;
            txtCedula.BackColor = TemaColor.Botones;
            txtCelular.BackColor = TemaColor.Botones;
            txtContrasena.BackColor = TemaColor.Botones;
            txtCorreo.BackColor = TemaColor.Botones;
            txtNombre.BackColor = TemaColor.Botones;
            txtProcedencia.BackColor = TemaColor.Botones;
            txtResidencia.BackColor = TemaColor.Botones;
            ckbCantidad.ForeColor = TemaColor.Texto1;
            ckbMayuscula.ForeColor = TemaColor.Texto1;
            ckbMinuscula.ForeColor = TemaColor.Texto1;
            ckbNumero.ForeColor = TemaColor.Texto1;
            btnNoVer.BackColor = TemaColor.PanelContenedor;
            btnVer.BackColor = TemaColor.PanelContenedor;
            btnCerrar.BackColor = TemaColor.PanelContenedor;
            this.BackColor = TemaColor.PanelContenedor;
        }

        private void frmCrearCuenta_Load(object sender, EventArgs e)
        {

        }
    }
}

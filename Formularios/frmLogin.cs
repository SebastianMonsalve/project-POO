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
    public partial class frmLogin : Form
    {
        cConexion cn; //Variable cConexion
        SqlCommand cmd; //Variaable para entrar los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        public frmLogin()
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
        private void btnVer_Click(object sender, EventArgs e)
        {
            btnVer.Visible = false;
            btnNoVer.Visible = true;
            txtContrasena.PasswordChar = '\0';
        }

        private void btnNoVer_Click(object sender, EventArgs e)
        {
            btnVer.Visible = true;
            btnNoVer.Visible = false;
            txtContrasena.PasswordChar = '*';
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperarContrasena_Click(object sender, EventArgs e)
        {
            frmRecuperarContrasena RC = new frmRecuperarContrasena();
            RC.Show();
            frmBienvenido formularioContenedor = (frmBienvenido)this.ParentForm;
            formularioContenedor.abrirFormulariosHijos(RC);
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmCrearCuenta CC = new frmCrearCuenta();
            frmBienvenido formularioContenedor = (frmBienvenido)this.ParentForm;
            formularioContenedor.abrirFormulariosHijos(CC);
            this.Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select idCliente, contrasena from tblCliente where idCliente = '" + txtCedula.Text + "' and contrasena = '" + txtContrasena.Text + "' and Eliminado !=1", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                lblDocumentoError.Text = "Documento incorrecto";
                lblContrasenaError.Text = "Contraseña incorrecta";
                txtCedula.Clear();
                txtContrasena.Clear();
            }
            else
            {
                Acceso.sesion = dt.Rows[0][0].ToString();
                frmMenu frmMenuAdmin = new frmMenu();
                frmMenuAdmin.Show();
                this.ParentForm.Hide();
            }
        }
        public void ColorClaro()
        {
            TemaColor.ElegirTema("Claro");
            lblTitulo.ForeColor = TemaColor.Texto2;
            lblCont.ForeColor = TemaColor.Texto1;
            lblDoc.ForeColor = TemaColor.Texto1;
            lblContrasenaError.ForeColor = TemaColor.Texto1;
            lblDocumentoError.ForeColor = TemaColor.Texto1;
            txtCedula.BackColor = TemaColor.Menu;
            txtContrasena.BackColor = TemaColor.Menu;
            btnIniciarSesion.BackColor = TemaColor.Botones;
            btnIniciarSesion.ForeColor = TemaColor.Texto3;
            btnRecuperarContrasena.ForeColor = TemaColor.Texto3;
            btnRegistrarse.ForeColor = TemaColor.Texto3;
            btnNoVer.BackColor = TemaColor.Menu;
            btnVer.BackColor = TemaColor.Menu;
            btnCerrar.BackColor = TemaColor.Menu;
            this.BackColor = TemaColor.PanelContenedor;
        }
        public void ColorOscuro()
        {
            TemaColor.ElegirTema("Oscuro");
            lblTitulo.ForeColor = TemaColor.Texto2;
            lblCont.ForeColor = TemaColor.Texto1;
            lblDoc.ForeColor = TemaColor.Texto1;
            lblContrasenaError.ForeColor = TemaColor.Texto1;
            lblDocumentoError.ForeColor = TemaColor.Texto1;
            txtCedula.BackColor = TemaColor.Texto1;
            txtContrasena.BackColor = TemaColor.Texto1;
            btnIniciarSesion.BackColor = TemaColor.Botones;
            btnIniciarSesion.ForeColor = TemaColor.Texto3;
            btnRecuperarContrasena.ForeColor = TemaColor.Texto1;
            btnRegistrarse.ForeColor = TemaColor.Texto1;
            btnNoVer.BackColor = TemaColor.PanelContenedor;
            btnVer.BackColor = TemaColor.PanelContenedor;
            btnCerrar.BackColor = TemaColor.PanelContenedor;
            this.BackColor = TemaColor.PanelContenedor;
        }

        private void btnBlack_Click(object sender, EventArgs e)
        {
            btnWhite.Visible = true;
            btnBlack.Visible = false;
            ColorOscuro();
        }
        private void btnWhite_Click(object sender, EventArgs e)
        {
            btnWhite.Visible = false;
            btnBlack.Visible = true;
            ColorClaro();
        }
    }
}

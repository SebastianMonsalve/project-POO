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
using System.Net;
using System.Net.Mail;


namespace Sistema_de_facturacion.Formularios
{
    public partial class frmRecuperarContrasena : Form
    {
        cConexion cn; //Variable cConexion
        SqlCommand cmd; //Variaable para entrar los comandos de sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        private object alt;

        public frmRecuperarContrasena()
        {
            cn = new cConexion();
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRecuperarContrasena_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblCliente where idCliente = '" + txtCedula.Text + "' and CorreoCliente = '" + txtCorreo.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                lblDocumentoIncorrecto.Text = "Documento incorrecto";
                lblCorreoIncorrecto.Text = "Correo incorrecto";
                txtCedula.Clear();
                txtCorreo.Clear();
            }
            else
            {
                string caracteresPermitidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                Random rnd = new Random();
                string codigoAleatorio = "";
                for (int i = 0; i < 10; i++)
                {
                    int indiceAleatorio = rnd.Next(caracteresPermitidos.Length);
                    char caracterAleatorio = caracteresPermitidos[indiceAleatorio];
                    codigoAleatorio += caracterAleatorio;
                }
                MailMessage correo = new MailMessage();
                correo.From = new MailAddress("hotelbillingsystem5@gmail.com");
                correo.To.Add(new MailAddress(dt.Rows[0][7].ToString()));
                correo.Subject = "Recupera la contraseña de tu cuenta";
                correo.Body = "Deseando que tenga un caluroso saludo Sr. " + dt.Rows[0][1].ToString() + " Hemos recibido una solicitud para restablecer la contraseña de su cuenta creada en Hotel Billing System. Para continuar con el proceso de recuperación de contraseña, por favor use el siguiente codigo como contraseña la proxima vez que ingreses a tu cuenta:\r\n\r\n" + codigoAleatorio.ToString() + "\r\n\r\n Si usted no solicitó la recuperación de su contraseña, por favor contactese con nuestro equipo de soporte para reportar la situación.\r\n\r\nAtentamente,\r\nHotel Billing System Team";
  

                // Configurar el servidor SMTP para enviar el correo electrónico
                SmtpClient clienteSmtp = new SmtpClient();
                clienteSmtp.Host = "smtp.gmail.com";
                clienteSmtp.Port = 587;
                clienteSmtp.EnableSsl = true;
                clienteSmtp.UseDefaultCredentials = false;
                clienteSmtp.Credentials = new NetworkCredential("hotelbillingsystem5@gmail.com", "odjuiyamsgqgphta"); // reemplaza con tus credenciales

                // Enviar el mensaje de correo electrónico
                clienteSmtp.Send(correo);

                //Actualizar
                try
                {
                    SqlCommand cmd = new SqlCommand("actualizar_contrasena_cliente", cn.AbrirConexion());
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idCliente", txtCedula.Text);
                    cmd.Parameters.AddWithValue("@NuevaContrasena", codigoAleatorio.ToString());
                    cmd.ExecuteNonQuery();
                    cn.CerrarConexion();
                    MessageBox.Show("Revisa tu correo");
                    frmLogin lg = new frmLogin();
                    frmBienvenido formularioContenedor = (frmBienvenido)this.ParentForm;
                    formularioContenedor.abrirFormulariosHijos(lg);
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmRecuperarContrasena_Load(object sender, EventArgs e)
        {

        }
    }
}

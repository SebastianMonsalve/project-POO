using Sistema_de_facturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Sistema_de_facturacion.Formularios
{
    public partial class frmConsumo : Form
    {
        cConexion cn = new cConexion();
        decimal totalConsumido = 0;
        decimal reservaTotal = 0;
        decimal totalFactura = 0;
        int c = 0;
        decimal d = 0;
        public frmConsumo()
        {
            InitializeComponent();
            cargarTabla(null);
            cargarTablaReservas(null);
            autoCompletar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            Consumo _consumo = new Consumo();
            _consumo.IdProducto = int.Parse(dtgConsumo.CurrentRow.Cells[0].Value.ToString());
            _consumo.IdCliente = txtDocumento.Text;
            _consumo.CantidadProdConsumido = int.Parse(txtCantidad.Text);
            _consumo.TotalConsumo = decimal.Parse(txtCantidad.Text) * decimal.Parse(dtgConsumo.CurrentRow.Cells[2].Value.ToString());
            _consumo.Estado = "No pagado";
            _consumo.IdReserva = int.Parse(dtgReservasActivas.CurrentRow.Cells[0].Value.ToString());
            ctrlConsumo ctrl = new ctrlConsumo();
            bandera = ctrl.insertar(_consumo);
            InventarioProductos();
        }
        private void cargarTabla(string dato)
        {
            List<Productos> lista = new List<Productos>();
            ctrlProductos _ctrlProductos = new ctrlProductos();
            dtgConsumo.DataSource = _ctrlProductos.consulta(dato);
        }
        private void cargarTablaReservas(string dato)
        {
            List<Reserva> lista = new List<Reserva>();
            ctrlReserva _ctrlReserva = new ctrlReserva();
            dtgReservasActivas.DataSource = _ctrlReserva.consultaConsumo(dato);
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            cargarTabla(txtBuscar.Text);
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            SqlCommand cmdCliente = new SqlCommand("select * from tblCliente where idCliente ='" + txtDocumento.Text + "'", cn.AbrirConexion());
            SqlDataAdapter daCliente = new SqlDataAdapter(cmdCliente);
            DataTable dtCliente = new DataTable();
            daCliente.Fill(dtCliente);
            cmdCliente.ExecuteNonQuery();
            cn.CerrarConexion();
            try
            {
                txtApellido.Text = dtCliente.Rows[0][2].ToString();
                txtNombre.Text = dtCliente.Rows[0][1].ToString();
                txtCorreo.Text = dtCliente.Rows[0][7].ToString();
                cargarTablaReservas(txtDocumento.Text);

            }
            catch (Exception)
            {
                cargarTablaReservas(null);
                MessageBox.Show("El cliente que intentas facturar no existe");
                txtDocumento.Clear();
                txtCorreo.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
            }

        }

        private void dtgReservasActivas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            cn = new cConexion();
            SqlCommand command = new SqlCommand("SELECT SUM(totalConsumo) AS TotalConsumido FROM tblConsumo WHERE idCliente = '" + txtDocumento.Text + "'", cn.AbrirConexion());
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                totalConsumido = (decimal)reader["TotalConsumido"];
            }

            reader.Close();

            //Traemos los datos que los consumos del cliente que se quiera facturar

            SqlCommand consumos = new SqlCommand("SELECT CantidadProdConsumido, NombreProd, PrecioProdUnid, totalConsumo FROM tblConsumo INNER JOIN tblProducto ON tblConsumo.IdProducto = tblProducto.IdProducto INNER JOIN tblCliente ON tblConsumo.idCliente = tblCliente.idCliente WHERE tblConsumo.idCliente = '" + txtDocumento.Text + "' AND Estado != 'Pagado'", cn.AbrirConexion());
            SqlDataAdapter daConsumos = new SqlDataAdapter(consumos);
            DataTable dtConsumo = new DataTable();
            daConsumos.Fill(dtConsumo);
            consumos.ExecuteNonQuery();
            cn.CerrarConexion();


            //Calculamos el valor de la reserva
            SqlCommand totalReserva = new SqlCommand("SELECT tblReserva.CantidadPersonas, tblPlanes.ValorPlan FROM tblReserva INNER JOIN tblPlanes ON tblPlanes.idPlan = tblReserva.IdPlan WHERE tblReserva.idCliente = '" + txtDocumento.Text + "' AND tblReserva.Estado != 'Eliminada' AND tblReserva.Motivo != 'Cancelada' AND tblReserva.Motivo != 'Terminada'", cn.AbrirConexion());
            SqlDataAdapter daTotalReserva = new SqlDataAdapter(totalReserva);
            DataTable dtTotatalReserva = new DataTable();
            daTotalReserva.Fill(dtTotatalReserva);
            totalReserva.ExecuteNonQuery();
            cn.CerrarConexion();
            if(dtTotatalReserva.Rows.Count > 0)
            {
                int c = int.Parse(dtTotatalReserva.Rows[0][0].ToString());
                decimal d = decimal.Parse(dtTotatalReserva.Rows[0][1].ToString());
                reservaTotal = c * d;
                totalFactura = reservaTotal + totalConsumido;
            }
            

            //Trae los datos del hote
            SqlCommand hotel = new SqlCommand("SELECT * FROM tblHotel", cn.AbrirConexion());
            SqlDataAdapter daHotel = new SqlDataAdapter(hotel);
            DataTable dtHotel = new DataTable();
            daConsumos.Fill(dtHotel);
            hotel.ExecuteNonQuery();
            cn.CerrarConexion();


            ///Factura
            DateTime horaActual = DateTime.Now;
            int count = 0;
            try
            {
                Word.Application wordApp = new Word.Application();
                Word.Document wordDoc = wordApp.Documents.Open(@"C:\Users\sebas\Documents\Programacion Orientada a Objetos\Sistema de facturacion\FacturaHotel.docx");

                if (wordDoc.Tables.Count >= 1)
                {
                    Word.Table table = wordDoc.Tables[1];

                    // Update header information
                    table.Cell(2, 3).Range.Text = "00012B";
                    table.Cell(4, 1).Range.Text = txtDocumento.Text;
                    table.Cell(4, 2).Range.Text = txtNombre.Text + " " + txtApellido.Text;
                    table.Cell(4, 3).Range.Text = txtCorreo.Text;
                    table.Cell(4, 4).Range.Text = horaActual.ToString();
                }
                if (wordDoc.Tables.Count >= 2)
                {
                    Word.Table table1 = wordDoc.Tables[2];
                    int rowsN = dtConsumo.Rows.Count;
                    int rowsT = table1.Rows.Count-1;
                    if (rowsN > rowsT)
                    {
                        int rowsA = rowsN - rowsT;
                        
                        for (int i = 0; i < rowsA; i++)
                        {
                            table1.Rows.Add(table1.Rows[2]);
                            
                        }

                    }
                    for (int i = 0; i < dtConsumo.Rows.Count; i++)
                    {
                        table1.Cell(1 + i, 1).Range.Text = dtConsumo.Rows[i][0].ToString();
                        table1.Cell(1 + i, 2).Range.Text = dtConsumo.Rows[i][1].ToString();
                        table1.Cell(1 + i, 3).Range.Text = dtConsumo.Rows[i][2].ToString();
                        table1.Cell(1 + i, 4).Range.Text = dtConsumo.Rows[i][3].ToString();
                        count++;
                    }
                    table1.Cell(count + 1, 1).Range.Text = c.ToString();
                    table1.Cell(count + 1, 2).Range.Text = "Hospedaje";
                    table1.Cell(count + 1, 3).Range.Text = d.ToString();
                    table1.Cell(count + 1, 4).Range.Text = reservaTotal.ToString();
                }
                if (wordDoc.Tables.Count >= 3)
                {
                    Word.Table table2 = wordDoc.Tables[3];
                    table2.Cell(1, 1).Range.Text = txtDescripcion.Text;
                    table2.Cell(1, 3).Range.Text = totalFactura.ToString();
                }
                Pagar();
                FinalizarReserva();

            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void Pagar()
        {
            cn = new cConexion();
            SqlCommand pagar = new SqlCommand("update tblConsumo set Estado = 'Pagado' where idCliente='" + txtDocumento.Text + "' and Estado != 'Pagada'",cn.AbrirConexion());
            pagar.ExecuteNonQuery();
            cn.CerrarConexion();
        }
        private void FinalizarReserva()
        {
            cn = new cConexion();
            SqlCommand pagar = new SqlCommand("update tblReserva set Motivo = 'Terminada' where idCliente='" + txtDocumento.Text + "' and Estado != 'Pagado'", cn.AbrirConexion());
            pagar.ExecuteNonQuery();
            cn.CerrarConexion();
        }
        DataTable datos = new DataTable();
        void autoCompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM tblProducto", cn.AbrirConexion());
            adaptador.Fill(datos);
            cn.CerrarConexion();

            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["NombreProd"].ToString());
            }
            txtBuscar.AutoCompleteCustomSource = lista;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtBuscar.Text;
            cargarTabla(dato);
        }
        private void InventarioProductos()
        {
            int cantidadExistente = 0;
            cantidadExistente = int.Parse(dtgConsumo.CurrentRow.Cells[3].Value.ToString()) - int.Parse(txtCantidad.Text);
            MessageBox.Show(cantidadExistente.ToString());
            cn = new cConexion();
            SqlCommand actualizarProducto = new SqlCommand("update tblProducto set CantidadExit='" + cantidadExistente + "' where idProducto='" + int.Parse(dtgConsumo.CurrentRow.Cells[0].Value.ToString()) + "' and Eliminado=0",cn.AbrirConexion());
            actualizarProducto.ExecuteNonQuery();
            cn.CerrarConexion();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

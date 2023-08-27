namespace Sistema_de_facturacion.Formularios
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnPerfilHotel = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.pnlCerrarSesion = new System.Windows.Forms.Panel();
            this.pnlSubInformes = new System.Windows.Forms.Panel();
            this.btnPorReserva = new System.Windows.Forms.Button();
            this.btnPorProducto = new System.Windows.Forms.Button();
            this.btnPorHabitacion = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.pnlSubServicios = new System.Windows.Forms.Panel();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnHospedaje = new System.Windows.Forms.Button();
            this.btnServicios = new System.Windows.Forms.Button();
            this.btnHabitaciones = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FechaHora = new System.Windows.Forms.Timer(this.components);
            this.pnlLateral.SuspendLayout();
            this.pnlSubInformes.SuspendLayout();
            this.pnlSubServicios.SuspendLayout();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlLateral.Controls.Add(this.btnPerfilHotel);
            this.pnlLateral.Controls.Add(this.btnPerfil);
            this.pnlLateral.Controls.Add(this.lblFecha);
            this.pnlLateral.Controls.Add(this.lblHora);
            this.pnlLateral.Controls.Add(this.pnlCerrarSesion);
            this.pnlLateral.Controls.Add(this.pnlSubInformes);
            this.pnlLateral.Controls.Add(this.btnInformes);
            this.pnlLateral.Controls.Add(this.btnFacturar);
            this.pnlLateral.Controls.Add(this.btnReservar);
            this.pnlLateral.Controls.Add(this.pnlSubServicios);
            this.pnlLateral.Controls.Add(this.btnServicios);
            this.pnlLateral.Controls.Add(this.btnHabitaciones);
            this.pnlLateral.Controls.Add(this.pnlLogo);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(219, 613);
            this.pnlLateral.TabIndex = 0;
            // 
            // btnPerfilHotel
            // 
            this.btnPerfilHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPerfilHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfilHotel.FlatAppearance.BorderSize = 0;
            this.btnPerfilHotel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnPerfilHotel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnPerfilHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilHotel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPerfilHotel.ForeColor = System.Drawing.Color.White;
            this.btnPerfilHotel.Image = global::Sistema_de_facturacion.Properties.Resources.hotel;
            this.btnPerfilHotel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilHotel.Location = new System.Drawing.Point(0, 565);
            this.btnPerfilHotel.Name = "btnPerfilHotel";
            this.btnPerfilHotel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnPerfilHotel.Size = new System.Drawing.Size(219, 42);
            this.btnPerfilHotel.TabIndex = 35;
            this.btnPerfilHotel.Text = "Hotel";
            this.btnPerfilHotel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfilHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfilHotel.UseVisualStyleBackColor = false;
            this.btnPerfilHotel.Visible = false;
            this.btnPerfilHotel.Click += new System.EventHandler(this.btnPerfilHotel_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = global::Sistema_de_facturacion.Properties.Resources.usuario_de_perfil;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(0, 523);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnPerfil.Size = new System.Drawing.Size(219, 42);
            this.btnPerfil.TabIndex = 34;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Visible = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblFecha.Location = new System.Drawing.Point(3, 554);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 17);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "label3";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHora.Location = new System.Drawing.Point(0, 520);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(86, 27);
            this.lblHora.TabIndex = 32;
            this.lblHora.Text = "label3";
            // 
            // pnlCerrarSesion
            // 
            this.pnlCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCerrarSesion.BackColor = System.Drawing.Color.Brown;
            this.pnlCerrarSesion.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.apagar1;
            this.pnlCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlCerrarSesion.Location = new System.Drawing.Point(0, 580);
            this.pnlCerrarSesion.Name = "pnlCerrarSesion";
            this.pnlCerrarSesion.Size = new System.Drawing.Size(219, 33);
            this.pnlCerrarSesion.TabIndex = 31;
            this.pnlCerrarSesion.Click += new System.EventHandler(this.pnlCerrarSesion_Click);
            // 
            // pnlSubInformes
            // 
            this.pnlSubInformes.Controls.Add(this.btnPorReserva);
            this.pnlSubInformes.Controls.Add(this.btnPorProducto);
            this.pnlSubInformes.Controls.Add(this.btnPorHabitacion);
            this.pnlSubInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubInformes.Location = new System.Drawing.Point(0, 415);
            this.pnlSubInformes.Name = "pnlSubInformes";
            this.pnlSubInformes.Size = new System.Drawing.Size(219, 108);
            this.pnlSubInformes.TabIndex = 29;
            // 
            // btnPorReserva
            // 
            this.btnPorReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPorReserva.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorReserva.FlatAppearance.BorderSize = 0;
            this.btnPorReserva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnPorReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnPorReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorReserva.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorReserva.ForeColor = System.Drawing.Color.White;
            this.btnPorReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorReserva.Location = new System.Drawing.Point(0, 70);
            this.btnPorReserva.Name = "btnPorReserva";
            this.btnPorReserva.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPorReserva.Size = new System.Drawing.Size(219, 35);
            this.btnPorReserva.TabIndex = 25;
            this.btnPorReserva.Text = "Por reserva";
            this.btnPorReserva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorReserva.UseVisualStyleBackColor = false;
            this.btnPorReserva.Click += new System.EventHandler(this.btnPorReserva_Click);
            // 
            // btnPorProducto
            // 
            this.btnPorProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPorProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorProducto.FlatAppearance.BorderSize = 0;
            this.btnPorProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnPorProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnPorProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorProducto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorProducto.ForeColor = System.Drawing.Color.White;
            this.btnPorProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorProducto.Location = new System.Drawing.Point(0, 35);
            this.btnPorProducto.Name = "btnPorProducto";
            this.btnPorProducto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPorProducto.Size = new System.Drawing.Size(219, 35);
            this.btnPorProducto.TabIndex = 24;
            this.btnPorProducto.Text = "Por producto";
            this.btnPorProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorProducto.UseVisualStyleBackColor = false;
            this.btnPorProducto.Click += new System.EventHandler(this.btnPorProducto_Click);
            // 
            // btnPorHabitacion
            // 
            this.btnPorHabitacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPorHabitacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPorHabitacion.FlatAppearance.BorderSize = 0;
            this.btnPorHabitacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnPorHabitacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnPorHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPorHabitacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorHabitacion.ForeColor = System.Drawing.Color.White;
            this.btnPorHabitacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorHabitacion.Location = new System.Drawing.Point(0, 0);
            this.btnPorHabitacion.Name = "btnPorHabitacion";
            this.btnPorHabitacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPorHabitacion.Size = new System.Drawing.Size(219, 35);
            this.btnPorHabitacion.TabIndex = 23;
            this.btnPorHabitacion.Text = "Por habitacion";
            this.btnPorHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPorHabitacion.UseVisualStyleBackColor = false;
            this.btnPorHabitacion.Click += new System.EventHandler(this.btnPorHabitacion_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformes.FlatAppearance.BorderSize = 0;
            this.btnInformes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnInformes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInformes.ForeColor = System.Drawing.Color.White;
            this.btnInformes.Image = global::Sistema_de_facturacion.Properties.Resources.Informes;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(0, 373);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnInformes.Size = new System.Drawing.Size(219, 42);
            this.btnInformes.TabIndex = 28;
            this.btnInformes.Text = "Informes";
            this.btnInformes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Visible = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnFacturar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnFacturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Image = global::Sistema_de_facturacion.Properties.Resources.Factura;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.Location = new System.Drawing.Point(0, 331);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnFacturar.Size = new System.Drawing.Size(219, 42);
            this.btnFacturar.TabIndex = 27;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Visible = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnReservar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnReservar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReservar.ForeColor = System.Drawing.Color.White;
            this.btnReservar.Image = global::Sistema_de_facturacion.Properties.Resources.cita__1_;
            this.btnReservar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.Location = new System.Drawing.Point(0, 289);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnReservar.Size = new System.Drawing.Size(219, 42);
            this.btnReservar.TabIndex = 26;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // pnlSubServicios
            // 
            this.pnlSubServicios.AutoSize = true;
            this.pnlSubServicios.Controls.Add(this.btnEmpleados);
            this.pnlSubServicios.Controls.Add(this.btnProductos);
            this.pnlSubServicios.Controls.Add(this.btnHospedaje);
            this.pnlSubServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubServicios.Location = new System.Drawing.Point(0, 184);
            this.pnlSubServicios.Name = "pnlSubServicios";
            this.pnlSubServicios.Size = new System.Drawing.Size(219, 105);
            this.pnlSubServicios.TabIndex = 25;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 70);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(219, 35);
            this.btnEmpleados.TabIndex = 25;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Visible = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(0, 35);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(219, 35);
            this.btnProductos.TabIndex = 24;
            this.btnProductos.Text = "Productos de restaurante";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnHospedaje
            // 
            this.btnHospedaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnHospedaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHospedaje.FlatAppearance.BorderSize = 0;
            this.btnHospedaje.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnHospedaje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnHospedaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospedaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospedaje.ForeColor = System.Drawing.Color.White;
            this.btnHospedaje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospedaje.Location = new System.Drawing.Point(0, 0);
            this.btnHospedaje.Name = "btnHospedaje";
            this.btnHospedaje.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHospedaje.Size = new System.Drawing.Size(219, 35);
            this.btnHospedaje.TabIndex = 23;
            this.btnHospedaje.Text = "Planes de hospedaje";
            this.btnHospedaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHospedaje.UseVisualStyleBackColor = false;
            this.btnHospedaje.Click += new System.EventHandler(this.btnHospedaje_Click);
            // 
            // btnServicios
            // 
            this.btnServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnServicios.ForeColor = System.Drawing.Color.White;
            this.btnServicios.Image = global::Sistema_de_facturacion.Properties.Resources.digital_services;
            this.btnServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.Location = new System.Drawing.Point(0, 142);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnServicios.Size = new System.Drawing.Size(219, 42);
            this.btnServicios.TabIndex = 24;
            this.btnServicios.Text = "Servicios";
            this.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicios.UseVisualStyleBackColor = false;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // btnHabitaciones
            // 
            this.btnHabitaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnHabitaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHabitaciones.FlatAppearance.BorderSize = 0;
            this.btnHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabitaciones.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHabitaciones.ForeColor = System.Drawing.Color.White;
            this.btnHabitaciones.Image = global::Sistema_de_facturacion.Properties.Resources.cama;
            this.btnHabitaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabitaciones.Location = new System.Drawing.Point(0, 100);
            this.btnHabitaciones.Name = "btnHabitaciones";
            this.btnHabitaciones.Size = new System.Drawing.Size(219, 42);
            this.btnHabitaciones.TabIndex = 22;
            this.btnHabitaciones.Text = "Habitaciones";
            this.btnHabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHabitaciones.UseVisualStyleBackColor = false;
            this.btnHabitaciones.Click += new System.EventHandler(this.btnHabitaciones_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.Logo_HBF;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(219, 100);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(25)))));
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(219, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(715, 613);
            this.pnlContenedor.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.Logo_HBF;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(159, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 445);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FechaHora
            // 
            this.FechaHora.Enabled = true;
            this.FechaHora.Tick += new System.EventHandler(this.FechaHora_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(934, 613);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.pnlLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlLateral.ResumeLayout(false);
            this.pnlLateral.PerformLayout();
            this.pnlSubInformes.ResumeLayout(false);
            this.pnlSubServicios.ResumeLayout(false);
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlSubServicios;
        private System.Windows.Forms.Button btnHospedaje;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.Button btnHabitaciones;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Panel pnlSubInformes;
        private System.Windows.Forms.Button btnPorReserva;
        private System.Windows.Forms.Button btnPorProducto;
        private System.Windows.Forms.Button btnPorHabitacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel pnlCerrarSesion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer FechaHora;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPerfilHotel;
    }
}
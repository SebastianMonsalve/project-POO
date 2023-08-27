namespace Sistema_de_facturacion.Formularios
{
    partial class frmCrearCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearCuenta));
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtResidencia = new System.Windows.Forms.TextBox();
            this.txtProcedencia = new System.Windows.Forms.TextBox();
            this.lblResidencia = new System.Windows.Forms.Label();
            this.lblProcedencia = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblCrearCuenta = new System.Windows.Forms.Label();
            this.btnNoVer = new System.Windows.Forms.PictureBox();
            this.btnVer = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.ckbCantidad = new System.Windows.Forms.CheckBox();
            this.ckbMayuscula = new System.Windows.Forms.CheckBox();
            this.ckbMinuscula = new System.Windows.Forms.CheckBox();
            this.ckbNumero = new System.Windows.Forms.CheckBox();
            this.btnBlack = new System.Windows.Forms.PictureBox();
            this.btnWhite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.Enabled = false;
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(100, 433);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(111, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 14);
            this.label1.TabIndex = 70;
            // 
            // lblContraseña
            // 
            this.lblContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContraseña.Location = new System.Drawing.Point(100, 308);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(88, 17);
            this.lblContraseña.TabIndex = 68;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtContrasena.ForeColor = System.Drawing.Color.Black;
            this.txtContrasena.Location = new System.Drawing.Point(103, 328);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(270, 20);
            this.txtContrasena.TabIndex = 67;
            this.txtContrasena.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // txtResidencia
            // 
            this.txtResidencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResidencia.BackColor = System.Drawing.Color.White;
            this.txtResidencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResidencia.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtResidencia.ForeColor = System.Drawing.Color.Black;
            this.txtResidencia.Location = new System.Drawing.Point(256, 280);
            this.txtResidencia.Name = "txtResidencia";
            this.txtResidencia.Size = new System.Drawing.Size(142, 20);
            this.txtResidencia.TabIndex = 66;
            // 
            // txtProcedencia
            // 
            this.txtProcedencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProcedencia.BackColor = System.Drawing.Color.White;
            this.txtProcedencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProcedencia.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProcedencia.ForeColor = System.Drawing.Color.Black;
            this.txtProcedencia.Location = new System.Drawing.Point(103, 280);
            this.txtProcedencia.Name = "txtProcedencia";
            this.txtProcedencia.Size = new System.Drawing.Size(142, 20);
            this.txtProcedencia.TabIndex = 65;
            // 
            // lblResidencia
            // 
            this.lblResidencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResidencia.AutoSize = true;
            this.lblResidencia.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblResidencia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResidencia.Location = new System.Drawing.Point(253, 260);
            this.lblResidencia.Name = "lblResidencia";
            this.lblResidencia.Size = new System.Drawing.Size(88, 17);
            this.lblResidencia.TabIndex = 64;
            this.lblResidencia.Text = "Residencia";
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProcedencia.AutoSize = true;
            this.lblProcedencia.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblProcedencia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProcedencia.Location = new System.Drawing.Point(100, 260);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(97, 17);
            this.lblProcedencia.TabIndex = 63;
            this.lblProcedencia.Text = "Procedencia";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCorreo.Location = new System.Drawing.Point(100, 211);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(145, 17);
            this.lblCorreo.TabIndex = 62;
            this.lblCorreo.Text = "Correo electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(103, 231);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(295, 20);
            this.txtCorreo.TabIndex = 61;
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCelular.BackColor = System.Drawing.Color.White;
            this.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(256, 182);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(142, 20);
            this.txtCelular.TabIndex = 60;
            // 
            // lblCelular
            // 
            this.lblCelular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblCelular.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCelular.Location = new System.Drawing.Point(253, 162);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(120, 17);
            this.lblCelular.TabIndex = 59;
            this.lblCelular.Text = "Numero celular";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(103, 184);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(142, 25);
            this.dtpNacimiento.TabIndex = 58;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellido.BackColor = System.Drawing.Color.White;
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(256, 131);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(142, 20);
            this.txtApellido.TabIndex = 57;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(103, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 20);
            this.txtNombre.TabIndex = 56;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFecha.Location = new System.Drawing.Point(100, 162);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(137, 17);
            this.lblFecha.TabIndex = 55;
            this.lblFecha.Text = "Fecha nacimiento";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.lblApellido.Location = new System.Drawing.Point(253, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(71, 17);
            this.lblApellido.TabIndex = 54;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombre.Location = new System.Drawing.Point(100, 111);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 53;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCedula.ForeColor = System.Drawing.Color.Black;
            this.txtCedula.Location = new System.Drawing.Point(103, 82);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(295, 20);
            this.txtCedula.TabIndex = 52;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblDocumento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDocumento.Location = new System.Drawing.Point(100, 62);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(188, 17);
            this.lblDocumento.TabIndex = 51;
            this.lblDocumento.Text = "Documento de identidad";
            // 
            // lblCrearCuenta
            // 
            this.lblCrearCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCrearCuenta.AutoSize = true;
            this.lblCrearCuenta.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearCuenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.lblCrearCuenta.Location = new System.Drawing.Point(96, 11);
            this.lblCrearCuenta.Name = "lblCrearCuenta";
            this.lblCrearCuenta.Size = new System.Drawing.Size(319, 40);
            this.lblCrearCuenta.TabIndex = 50;
            this.lblCrearCuenta.Text = "CREAR CUENTA";
            // 
            // btnNoVer
            // 
            this.btnNoVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNoVer.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.OjoCiego;
            this.btnNoVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoVer.Location = new System.Drawing.Point(367, 328);
            this.btnNoVer.Name = "btnNoVer";
            this.btnNoVer.Size = new System.Drawing.Size(31, 20);
            this.btnNoVer.TabIndex = 73;
            this.btnNoVer.TabStop = false;
            this.btnNoVer.Visible = false;
            this.btnNoVer.Click += new System.EventHandler(this.btnNoVer_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.OjoVer;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVer.Location = new System.Drawing.Point(367, 328);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(31, 20);
            this.btnVer.TabIndex = 72;
            this.btnVer.TabStop = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.Cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Location = new System.Drawing.Point(14, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 22);
            this.btnCerrar.TabIndex = 71;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCrearCuenta.BackColor = System.Drawing.Color.White;
            this.btnCrearCuenta.FlatAppearance.BorderSize = 0;
            this.btnCrearCuenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnCrearCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnCrearCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuenta.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCrearCuenta.ForeColor = System.Drawing.Color.Black;
            this.btnCrearCuenta.Image = global::Sistema_de_facturacion.Properties.Resources.aceptar;
            this.btnCrearCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearCuenta.Location = new System.Drawing.Point(178, 456);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(146, 45);
            this.btnCrearCuenta.TabIndex = 69;
            this.btnCrearCuenta.Text = "Crear cuenta";
            this.btnCrearCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearCuenta.UseVisualStyleBackColor = false;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // ckbCantidad
            // 
            this.ckbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbCantidad.AutoSize = true;
            this.ckbCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbCantidad.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCantidad.ForeColor = System.Drawing.Color.White;
            this.ckbCantidad.Location = new System.Drawing.Point(103, 354);
            this.ckbCantidad.Name = "ckbCantidad";
            this.ckbCantidad.Size = new System.Drawing.Size(143, 19);
            this.ckbCantidad.TabIndex = 74;
            this.ckbCantidad.Text = "Mínimo 8 caracteres";
            this.ckbCantidad.UseVisualStyleBackColor = true;
            // 
            // ckbMayuscula
            // 
            this.ckbMayuscula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbMayuscula.AutoSize = true;
            this.ckbMayuscula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbMayuscula.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMayuscula.ForeColor = System.Drawing.Color.White;
            this.ckbMayuscula.Location = new System.Drawing.Point(103, 393);
            this.ckbMayuscula.Name = "ckbMayuscula";
            this.ckbMayuscula.Size = new System.Drawing.Size(199, 19);
            this.ckbMayuscula.TabIndex = 75;
            this.ckbMayuscula.Text = "Al menos una letra mayúscula";
            this.ckbMayuscula.UseVisualStyleBackColor = true;
            // 
            // ckbMinuscula
            // 
            this.ckbMinuscula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbMinuscula.AutoSize = true;
            this.ckbMinuscula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbMinuscula.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMinuscula.ForeColor = System.Drawing.Color.White;
            this.ckbMinuscula.Location = new System.Drawing.Point(103, 411);
            this.ckbMinuscula.Name = "ckbMinuscula";
            this.ckbMinuscula.Size = new System.Drawing.Size(195, 19);
            this.ckbMinuscula.TabIndex = 76;
            this.ckbMinuscula.Text = "Al menos una letra minuscula";
            this.ckbMinuscula.UseVisualStyleBackColor = true;
            // 
            // ckbNumero
            // 
            this.ckbNumero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbNumero.AutoSize = true;
            this.ckbNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbNumero.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNumero.ForeColor = System.Drawing.Color.White;
            this.ckbNumero.Location = new System.Drawing.Point(103, 374);
            this.ckbNumero.Name = "ckbNumero";
            this.ckbNumero.Size = new System.Drawing.Size(144, 19);
            this.ckbNumero.TabIndex = 77;
            this.ckbNumero.Text = "Al menos un número";
            this.ckbNumero.UseVisualStyleBackColor = true;
            // 
            // btnBlack
            // 
            this.btnBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlack.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.soleadoBlack;
            this.btnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBlack.Location = new System.Drawing.Point(464, 12);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(30, 30);
            this.btnBlack.TabIndex = 79;
            this.btnBlack.TabStop = false;
            this.btnBlack.Visible = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhite.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.soleado;
            this.btnWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhite.Location = new System.Drawing.Point(464, 12);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(30, 30);
            this.btnWhite.TabIndex = 78;
            this.btnWhite.TabStop = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // frmCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(506, 513);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.ckbNumero);
            this.Controls.Add(this.ckbMinuscula);
            this.Controls.Add(this.ckbMayuscula);
            this.Controls.Add(this.ckbCantidad);
            this.Controls.Add(this.btnNoVer);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtResidencia);
            this.Controls.Add(this.txtProcedencia);
            this.Controls.Add(this.lblResidencia);
            this.Controls.Add(this.lblProcedencia);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblCrearCuenta);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCrearCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearCuenta";
            this.Load += new System.EventHandler(this.frmCrearCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnNoVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.PictureBox btnVer;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtResidencia;
        private System.Windows.Forms.TextBox txtProcedencia;
        private System.Windows.Forms.Label lblResidencia;
        private System.Windows.Forms.Label lblProcedencia;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblCrearCuenta;
        private System.Windows.Forms.PictureBox btnNoVer;
        private System.Windows.Forms.CheckBox ckbCantidad;
        private System.Windows.Forms.CheckBox ckbMayuscula;
        private System.Windows.Forms.CheckBox ckbMinuscula;
        private System.Windows.Forms.CheckBox ckbNumero;
        private System.Windows.Forms.PictureBox btnBlack;
        private System.Windows.Forms.PictureBox btnWhite;
    }
}
namespace Sistema_de_facturacion.Formularios
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblDoc = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDocumentoError = new System.Windows.Forms.Label();
            this.lblCont = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasenaError = new System.Windows.Forms.Label();
            this.btnRecuperarContrasena = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.PictureBox();
            this.btnNoVer = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnBlack = new System.Windows.Forms.PictureBox();
            this.btnWhite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCedula.BackColor = System.Drawing.Color.White;
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtCedula.ForeColor = System.Drawing.Color.Black;
            this.txtCedula.Location = new System.Drawing.Point(96, 188);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(295, 20);
            this.txtCedula.TabIndex = 26;
            // 
            // lblDoc
            // 
            this.lblDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblDoc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDoc.Location = new System.Drawing.Point(93, 168);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(188, 17);
            this.lblDoc.TabIndex = 25;
            this.lblDoc.Text = "Documento de identidad";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Cooper Black", 26.25F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.lblTitulo.Location = new System.Drawing.Point(89, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(318, 40);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "INICIAR SESION";
            // 
            // lblDocumentoError
            // 
            this.lblDocumentoError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDocumentoError.AutoSize = true;
            this.lblDocumentoError.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.lblDocumentoError.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDocumentoError.Location = new System.Drawing.Point(261, 211);
            this.lblDocumentoError.Name = "lblDocumentoError";
            this.lblDocumentoError.Size = new System.Drawing.Size(0, 14);
            this.lblDocumentoError.TabIndex = 31;
            // 
            // lblCont
            // 
            this.lblCont.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCont.AutoSize = true;
            this.lblCont.Font = new System.Drawing.Font("Lucida Sans", 11.25F);
            this.lblCont.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCont.Location = new System.Drawing.Point(93, 228);
            this.lblCont.Name = "lblCont";
            this.lblCont.Size = new System.Drawing.Size(88, 17);
            this.lblCont.TabIndex = 29;
            this.lblCont.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasena.BackColor = System.Drawing.Color.White;
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtContrasena.ForeColor = System.Drawing.Color.Black;
            this.txtContrasena.Location = new System.Drawing.Point(96, 248);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(270, 20);
            this.txtContrasena.TabIndex = 28;
            // 
            // lblContrasenaError
            // 
            this.lblContrasenaError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContrasenaError.AutoSize = true;
            this.lblContrasenaError.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.lblContrasenaError.ForeColor = System.Drawing.SystemColors.Control;
            this.lblContrasenaError.Location = new System.Drawing.Point(261, 271);
            this.lblContrasenaError.Name = "lblContrasenaError";
            this.lblContrasenaError.Size = new System.Drawing.Size(0, 14);
            this.lblContrasenaError.TabIndex = 34;
            // 
            // btnRecuperarContrasena
            // 
            this.btnRecuperarContrasena.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRecuperarContrasena.AutoSize = true;
            this.btnRecuperarContrasena.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarContrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecuperarContrasena.Location = new System.Drawing.Point(53, 472);
            this.btnRecuperarContrasena.Name = "btnRecuperarContrasena";
            this.btnRecuperarContrasena.Size = new System.Drawing.Size(164, 14);
            this.btnRecuperarContrasena.TabIndex = 35;
            this.btnRecuperarContrasena.Text = "¿Has olvidado tu contraseña?";
            this.btnRecuperarContrasena.Click += new System.EventHandler(this.btnRecuperarContrasena_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrarse.AutoSize = true;
            this.btnRegistrarse.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarse.Location = new System.Drawing.Point(279, 472);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(167, 14);
            this.btnRegistrarse.TabIndex = 36;
            this.btnRegistrarse.Text = "¿No tienes cuenta? Registrate";
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVer.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.OjoVer;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVer.Location = new System.Drawing.Point(365, 248);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(26, 20);
            this.btnVer.TabIndex = 33;
            this.btnVer.TabStop = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnNoVer
            // 
            this.btnNoVer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNoVer.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.OjoCiego;
            this.btnNoVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoVer.Location = new System.Drawing.Point(365, 248);
            this.btnNoVer.Name = "btnNoVer";
            this.btnNoVer.Size = new System.Drawing.Size(26, 20);
            this.btnNoVer.TabIndex = 32;
            this.btnNoVer.TabStop = false;
            this.btnNoVer.Visible = false;
            this.btnNoVer.Click += new System.EventHandler(this.btnNoVer_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIniciarSesion.BackColor = System.Drawing.Color.White;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(77)))), ((int)(((byte)(22)))));
            this.btnIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(146)))), ((int)(((byte)(34)))));
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnIniciarSesion.Image = global::Sistema_de_facturacion.Properties.Resources.acceso;
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.Location = new System.Drawing.Point(172, 368);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(146, 45);
            this.btnIniciarSesion.TabIndex = 30;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.Cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Location = new System.Drawing.Point(12, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 22);
            this.btnCerrar.TabIndex = 27;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlack.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.soleadoBlack;
            this.btnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBlack.Location = new System.Drawing.Point(464, 9);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(30, 30);
            this.btnBlack.TabIndex = 81;
            this.btnBlack.TabStop = false;
            this.btnBlack.Visible = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWhite.BackgroundImage = global::Sistema_de_facturacion.Properties.Resources.soleado;
            this.btnWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWhite.Location = new System.Drawing.Point(464, 10);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(30, 30);
            this.btnWhite.TabIndex = 80;
            this.btnWhite.TabStop = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(506, 513);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.btnRecuperarContrasena);
            this.Controls.Add(this.lblContrasenaError);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnNoVer);
            this.Controls.Add(this.lblDocumentoError);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.lblCont);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNoVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWhite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox btnVer;
        private System.Windows.Forms.PictureBox btnNoVer;
        private System.Windows.Forms.Label lblDocumentoError;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblCont;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasenaError;
        private System.Windows.Forms.Label btnRecuperarContrasena;
        private System.Windows.Forms.Label btnRegistrarse;
        private System.Windows.Forms.PictureBox btnBlack;
        private System.Windows.Forms.PictureBox btnWhite;
    }
}
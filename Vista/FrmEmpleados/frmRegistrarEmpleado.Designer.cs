
namespace SistemaFacturacion.Vista.FrmEmpleados
{
    partial class frmRegistrarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarEmpleado));
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.pnlContraseniaActual = new System.Windows.Forms.Panel();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.pbContraseniaActual = new System.Windows.Forms.PictureBox();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlContraseniaActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseniaActual)).BeginInit();
            this.pnlOpciones.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.BackColor = System.Drawing.Color.White;
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(443, 201);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(343, 29);
            this.cmbTipoUsuario.TabIndex = 34;
            // 
            // pnlContraseniaActual
            // 
            this.pnlContraseniaActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContraseniaActual.BackColor = System.Drawing.Color.White;
            this.pnlContraseniaActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContraseniaActual.Controls.Add(this.txtContrasenia);
            this.pnlContraseniaActual.Controls.Add(this.pbContraseniaActual);
            this.pnlContraseniaActual.Location = new System.Drawing.Point(443, 130);
            this.pnlContraseniaActual.Name = "pnlContraseniaActual";
            this.pnlContraseniaActual.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContraseniaActual.Size = new System.Drawing.Size(343, 27);
            this.pnlContraseniaActual.TabIndex = 31;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.White;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(3, 3);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(305, 20);
            this.txtContrasenia.TabIndex = 9;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // pbContraseniaActual
            // 
            this.pbContraseniaActual.BackgroundImage = global::SistemaFacturacion.Properties.Resources.mostrar;
            this.pbContraseniaActual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbContraseniaActual.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbContraseniaActual.Location = new System.Drawing.Point(308, 3);
            this.pbContraseniaActual.Name = "pbContraseniaActual";
            this.pbContraseniaActual.Size = new System.Drawing.Size(30, 19);
            this.pbContraseniaActual.TabIndex = 0;
            this.pbContraseniaActual.TabStop = false;
            this.pbContraseniaActual.Click += new System.EventHandler(this.pbContraseniaActual_Click);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnRegistrar);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 394);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(811, 67);
            this.pnlOpciones.TabIndex = 28;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(443, 16);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(347, 30);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(439, 168);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(121, 20);
            this.lblTipoUsuario.TabIndex = 35;
            this.lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(24, 281);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(343, 29);
            this.dtpFechaNacimiento.TabIndex = 19;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 6, 22, 0, 0, 0, 0);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(439, 24);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(147, 20);
            this.lblNombreUsuario.TabIndex = 27;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(439, 97);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(96, 20);
            this.lblContrasenia.TabIndex = 28;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 248);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(161, 20);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(20, 24);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(63, 20);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "REGISTRAR EMPLEADO";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(443, 59);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(343, 26);
            this.txtNombreUsuario.TabIndex = 30;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(20, 97);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(77, 20);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(20, 169);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(77, 20);
            this.lblNombres.TabIndex = 5;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(24, 59);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(343, 26);
            this.txtCedula.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(24, 130);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(343, 26);
            this.txtApellidos.TabIndex = 10;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.lblTipoUsuario);
            this.pnlContenido.Controls.Add(this.cmbTipoUsuario);
            this.pnlContenido.Controls.Add(this.pnlContraseniaActual);
            this.pnlContenido.Controls.Add(this.dtpFechaNacimiento);
            this.pnlContenido.Controls.Add(this.lblNombreUsuario);
            this.pnlContenido.Controls.Add(this.lblContrasenia);
            this.pnlContenido.Controls.Add(this.lblFechaNacimiento);
            this.pnlContenido.Controls.Add(this.lblCedula);
            this.pnlContenido.Controls.Add(this.txtNombreUsuario);
            this.pnlContenido.Controls.Add(this.lblApellidos);
            this.pnlContenido.Controls.Add(this.lblNombres);
            this.pnlContenido.Controls.Add(this.txtNombres);
            this.pnlContenido.Controls.Add(this.txtCedula);
            this.pnlContenido.Controls.Add(this.txtApellidos);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 46);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(811, 415);
            this.pnlContenido.TabIndex = 29;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(24, 201);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(343, 26);
            this.txtNombres.TabIndex = 11;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(811, 46);
            this.pnlEncabezado.TabIndex = 27;
            // 
            // frmRegistrarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 461);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(827, 500);
            this.MinimumSize = new System.Drawing.Size(827, 500);
            this.Name = "frmRegistrarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar empleado";
            this.Load += new System.EventHandler(this.frmRegistrarEmpleado_Load);
            this.pnlContraseniaActual.ResumeLayout(false);
            this.pnlContraseniaActual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContraseniaActual)).EndInit();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Panel pnlContraseniaActual;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.PictureBox pbContraseniaActual;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Panel pnlEncabezado;
    }
}
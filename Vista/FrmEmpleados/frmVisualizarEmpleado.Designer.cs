
namespace SistemaFacturacion.Vista.FrmEmpleados
{
    partial class frmVisualizarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisualizarEmpleado));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblActivo = new System.Windows.Forms.Label();
            this.cmbActivo = new System.Windows.Forms.ComboBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlEncabezado.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.SuspendLayout();
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
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "ACTUALIZAR EMPLEADO";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.Location = new System.Drawing.Point(439, 224);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(121, 20);
            this.lblTipoUsuario.TabIndex = 35;
            this.lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.BackColor = System.Drawing.Color.White;
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.Enabled = false;
            this.cmbTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Location = new System.Drawing.Point(443, 257);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(343, 29);
            this.cmbTipoUsuario.TabIndex = 34;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.Location = new System.Drawing.Point(439, 145);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(56, 20);
            this.lblActivo.TabIndex = 33;
            this.lblActivo.Text = "Activo:";
            // 
            // cmbActivo
            // 
            this.cmbActivo.BackColor = System.Drawing.Color.White;
            this.cmbActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivo.Enabled = false;
            this.cmbActivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbActivo.FormattingEnabled = true;
            this.cmbActivo.Location = new System.Drawing.Point(443, 174);
            this.cmbActivo.Name = "cmbActivo";
            this.cmbActivo.Size = new System.Drawing.Size(343, 29);
            this.cmbActivo.TabIndex = 32;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(443, 16);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(347, 30);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "";
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(24, 326);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(343, 29);
            this.dtpFechaNacimiento.TabIndex = 19;
            this.dtpFechaNacimiento.Value = new System.DateTime(2024, 6, 22, 0, 0, 0, 0);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(439, 69);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(147, 20);
            this.lblNombreUsuario.TabIndex = 27;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 293);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(161, 20);
            this.lblFechaNacimiento.TabIndex = 12;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(20, 69);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(63, 20);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(443, 104);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ReadOnly = true;
            this.txtNombreUsuario.Size = new System.Drawing.Size(343, 26);
            this.txtNombreUsuario.TabIndex = 30;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(20, 142);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(77, 20);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(20, 214);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(77, 20);
            this.lblNombres.TabIndex = 5;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(24, 246);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(343, 26);
            this.txtNombres.TabIndex = 11;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(24, 104);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(343, 26);
            this.txtCedula.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(24, 175);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.Size = new System.Drawing.Size(343, 26);
            this.txtApellidos.TabIndex = 10;
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.lblTipoUsuario);
            this.pnlContenido.Controls.Add(this.cmbTipoUsuario);
            this.pnlContenido.Controls.Add(this.lblActivo);
            this.pnlContenido.Controls.Add(this.cmbActivo);
            this.pnlContenido.Controls.Add(this.dtpFechaNacimiento);
            this.pnlContenido.Controls.Add(this.lblNombreUsuario);
            this.pnlContenido.Controls.Add(this.lblFechaNacimiento);
            this.pnlContenido.Controls.Add(this.lblCedula);
            this.pnlContenido.Controls.Add(this.txtNombreUsuario);
            this.pnlContenido.Controls.Add(this.lblApellidos);
            this.pnlContenido.Controls.Add(this.lblNombres);
            this.pnlContenido.Controls.Add(this.txtNombres);
            this.pnlContenido.Controls.Add(this.txtCedula);
            this.pnlContenido.Controls.Add(this.txtApellidos);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(811, 389);
            this.pnlContenido.TabIndex = 29;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnCerrar);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 389);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(811, 67);
            this.pnlOpciones.TabIndex = 28;
            // 
            // frmVisualizarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 456);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(827, 495);
            this.MinimumSize = new System.Drawing.Size(827, 495);
            this.Name = "frmVisualizarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar empleado";
            this.Load += new System.EventHandler(this.frmVisualizarEmpleado_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.ComboBox cmbActivo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Panel pnlOpciones;
    }
}
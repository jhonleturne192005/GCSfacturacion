
namespace SistemaFacturacion.Vista
{
    partial class frmListarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.lblTituloNumRegistros = new System.Windows.Forms.Label();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pnlDatosClientes = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumeroRegistros = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.pnlOpcionesEncabezado = new System.Windows.Forms.Panel();
            this.pnlOpcionesDgv = new System.Windows.Forms.Panel();
            this.pnlDgvClientes = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnVisualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnModificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.pnlDatosClientes.SuspendLayout();
            this.pnlOpcionesEncabezado.SuspendLayout();
            this.pnlOpcionesDgv.SuspendLayout();
            this.pnlDgvClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCliente.ColumnHeadersHeight = 25;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdentificacion,
            this.txtApellidos,
            this.txtNombres,
            this.btnVisualizar,
            this.btnModificar,
            this.btnEliminar});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvCliente.Location = new System.Drawing.Point(10, 0);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.Size = new System.Drawing.Size(992, 404);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtIdentificacion.HeaderText = "Identificación";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtApellidos.HeaderText = "Apellidos";
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNombres.HeaderText = "Nombres";
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            // 
            // btnPagAnterior
            // 
            this.btnPagAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagAnterior.BackColor = System.Drawing.Color.White;
            this.btnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagAnterior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagAnterior.Location = new System.Drawing.Point(807, 16);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(83, 32);
            this.btnPagAnterior.TabIndex = 1;
            this.btnPagAnterior.Text = "Anterior";
            this.btnPagAnterior.UseVisualStyleBackColor = false;
            this.btnPagAnterior.Click += new System.EventHandler(this.btnPagAnterior_Click);
            // 
            // lblTituloNumRegistros
            // 
            this.lblTituloNumRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloNumRegistros.AutoSize = true;
            this.lblTituloNumRegistros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTituloNumRegistros.Location = new System.Drawing.Point(20, 24);
            this.lblTituloNumRegistros.Name = "lblTituloNumRegistros";
            this.lblTituloNumRegistros.Size = new System.Drawing.Size(80, 19);
            this.lblTituloNumRegistros.TabIndex = 3;
            this.lblTituloNumRegistros.Text = "Mostrando:";
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagSiguiente.BackColor = System.Drawing.Color.White;
            this.btnPagSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagSiguiente.Location = new System.Drawing.Point(896, 16);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(86, 32);
            this.btnPagSiguiente.TabIndex = 6;
            this.btnPagSiguiente.Text = "Siguiente";
            this.btnPagSiguiente.UseVisualStyleBackColor = false;
            this.btnPagSiguiente.Click += new System.EventHandler(this.btnPagSiguiente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(15, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(97, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "CLIENTES";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1002, 54);
            this.pnlEncabezado.TabIndex = 6;
            // 
            // pnlDatosClientes
            // 
            this.pnlDatosClientes.Controls.Add(this.pnlDgvClientes);
            this.pnlDatosClientes.Controls.Add(this.pnlOpcionesDgv);
            this.pnlDatosClientes.Controls.Add(this.pnlOpcionesEncabezado);
            this.pnlDatosClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosClientes.Location = new System.Drawing.Point(0, 54);
            this.pnlDatosClientes.Name = "pnlDatosClientes";
            this.pnlDatosClientes.Size = new System.Drawing.Size(1002, 538);
            this.pnlDatosClientes.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.Location = new System.Drawing.Point(11, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumeroRegistros.AutoSize = true;
            this.lblNumeroRegistros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumeroRegistros.Location = new System.Drawing.Point(104, 24);
            this.lblNumeroRegistros.Name = "lblNumeroRegistros";
            this.lblNumeroRegistros.Size = new System.Drawing.Size(74, 19);
            this.lblNumeroRegistros.TabIndex = 5;
            this.lblNumeroRegistros.Text = "0 registros";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(881, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTextoBuscar
            // 
            this.txtTextoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextoBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoBuscar.Location = new System.Drawing.Point(99, 16);
            this.txtTextoBuscar.Name = "txtTextoBuscar";
            this.txtTextoBuscar.Size = new System.Drawing.Size(556, 27);
            this.txtTextoBuscar.TabIndex = 1;
            // 
            // pnlOpcionesEncabezado
            // 
            this.pnlOpcionesEncabezado.Controls.Add(this.button1);
            this.pnlOpcionesEncabezado.Controls.Add(this.txtTextoBuscar);
            this.pnlOpcionesEncabezado.Controls.Add(this.btnAgregar);
            this.pnlOpcionesEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpcionesEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlOpcionesEncabezado.Name = "pnlOpcionesEncabezado";
            this.pnlOpcionesEncabezado.Size = new System.Drawing.Size(1002, 62);
            this.pnlOpcionesEncabezado.TabIndex = 7;
            // 
            // pnlOpcionesDgv
            // 
            this.pnlOpcionesDgv.Controls.Add(this.lblTituloNumRegistros);
            this.pnlOpcionesDgv.Controls.Add(this.lblNumeroRegistros);
            this.pnlOpcionesDgv.Controls.Add(this.btnPagAnterior);
            this.pnlOpcionesDgv.Controls.Add(this.btnPagSiguiente);
            this.pnlOpcionesDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpcionesDgv.Location = new System.Drawing.Point(0, 466);
            this.pnlOpcionesDgv.Name = "pnlOpcionesDgv";
            this.pnlOpcionesDgv.Size = new System.Drawing.Size(1002, 72);
            this.pnlOpcionesDgv.TabIndex = 8;
            // 
            // pnlDgvClientes
            // 
            this.pnlDgvClientes.Controls.Add(this.dgvCliente);
            this.pnlDgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvClientes.Location = new System.Drawing.Point(0, 62);
            this.pnlDgvClientes.Name = "pnlDgvClientes";
            this.pnlDgvClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlDgvClientes.Size = new System.Drawing.Size(1002, 404);
            this.pnlDgvClientes.TabIndex = 9;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Modificar";
            this.dataGridViewImageColumn1.Image = global::SistemaFacturacion.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 137;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::SistemaFacturacion.Properties.Resources.borrar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 136;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Eliminar";
            this.dataGridViewImageColumn3.Image = global::SistemaFacturacion.Properties.Resources.borrar;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 136;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.HeaderText = "       ";
            this.btnVisualizar.Image = global::SistemaFacturacion.Properties.Resources.visualizar;
            this.btnVisualizar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.ReadOnly = true;
            this.btnVisualizar.Width = 38;
            // 
            // btnModificar
            // 
            this.btnModificar.HeaderText = "       ";
            this.btnModificar.Image = global::SistemaFacturacion.Properties.Resources.editar;
            this.btnModificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ReadOnly = true;
            this.btnModificar.Width = 38;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "       ";
            this.btnEliminar.Image = global::SistemaFacturacion.Properties.Resources.borrar;
            this.btnEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 38;
            // 
            // frmListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.pnlDatosClientes);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "frmListarClientes";
            this.Text = "Lista de clientes";
            this.Load += new System.EventHandler(this.frmListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlDatosClientes.ResumeLayout(false);
            this.pnlOpcionesEncabezado.ResumeLayout(false);
            this.pnlOpcionesEncabezado.PerformLayout();
            this.pnlOpcionesDgv.ResumeLayout(false);
            this.pnlOpcionesDgv.PerformLayout();
            this.pnlDgvClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.Label lblTituloNumRegistros;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlDatosClientes;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNumeroRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombres;
        private System.Windows.Forms.DataGridViewImageColumn btnVisualizar;
        private System.Windows.Forms.DataGridViewImageColumn btnModificar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlOpcionesEncabezado;
        private System.Windows.Forms.Panel pnlDgvClientes;
        private System.Windows.Forms.Panel pnlOpcionesDgv;
    }
}
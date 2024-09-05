
namespace SistemaFacturacion.Vista.FrmEmpleados
{
    partial class frmListarEmpleados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarEmpleados));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatosClientes = new System.Windows.Forms.Panel();
            this.pnlDgvClientes = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOpcionesDgv = new System.Windows.Forms.Panel();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.lblTituloNumRegistros = new System.Windows.Forms.Label();
            this.lblNumeroRegistros = new System.Windows.Forms.Label();
            this.pnlOpcionesEncabezado = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.pnlContenedorBusqueda = new System.Windows.Forms.Panel();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnVisualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnModificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDatosClientes.SuspendLayout();
            this.pnlDgvClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.pnlOpcionesDgv.SuspendLayout();
            this.pnlOpcionesEncabezado.SuspendLayout();
            this.pnlContenedorBusqueda.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(15, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(90, 21);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Empleados";
            // 
            // pnlDatosClientes
            // 
            this.pnlDatosClientes.Controls.Add(this.pnlDgvClientes);
            this.pnlDatosClientes.Controls.Add(this.pnlOpcionesDgv);
            this.pnlDatosClientes.Controls.Add(this.pnlOpcionesEncabezado);
            this.pnlDatosClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosClientes.Location = new System.Drawing.Point(0, 50);
            this.pnlDatosClientes.Name = "pnlDatosClientes";
            this.pnlDatosClientes.Size = new System.Drawing.Size(1002, 542);
            this.pnlDatosClientes.TabIndex = 11;
            // 
            // pnlDgvClientes
            // 
            this.pnlDgvClientes.Controls.Add(this.dgvEmpleados);
            this.pnlDgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvClientes.Location = new System.Drawing.Point(0, 74);
            this.pnlDgvClientes.Name = "pnlDgvClientes";
            this.pnlDgvClientes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlDgvClientes.Size = new System.Drawing.Size(1002, 408);
            this.pnlDgvClientes.TabIndex = 9;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToResizeRows = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeight = 25;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdentificacion,
            this.txtApellidos,
            this.txtNombres,
            this.txtFechaNacimiento,
            this.btnVisualizar,
            this.btnModificar,
            this.btnEliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.EnableHeadersVisualStyles = false;
            this.dgvEmpleados.GridColor = System.Drawing.Color.White;
            this.dgvEmpleados.Location = new System.Drawing.Point(10, 0);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.dgvEmpleados.MultiSelect = false;
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpleados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvEmpleados.Size = new System.Drawing.Size(982, 408);
            this.dgvEmpleados.TabIndex = 1;
            this.dgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtIdentificacion.HeaderText = "Identificación";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtApellidos.HeaderText = "Apellidos";
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNombres.HeaderText = "Nombres";
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtFechaNacimiento.HeaderText = "Fecha. Nac";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.ReadOnly = true;
            this.txtFechaNacimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pnlOpcionesDgv
            // 
            this.pnlOpcionesDgv.Controls.Add(this.btnPagAnterior);
            this.pnlOpcionesDgv.Controls.Add(this.btnPagSiguiente);
            this.pnlOpcionesDgv.Controls.Add(this.lblTituloNumRegistros);
            this.pnlOpcionesDgv.Controls.Add(this.lblNumeroRegistros);
            this.pnlOpcionesDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpcionesDgv.Location = new System.Drawing.Point(0, 482);
            this.pnlOpcionesDgv.Name = "pnlOpcionesDgv";
            this.pnlOpcionesDgv.Size = new System.Drawing.Size(1002, 60);
            this.pnlOpcionesDgv.TabIndex = 8;
            // 
            // btnPagAnterior
            // 
            this.btnPagAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagAnterior.BackColor = System.Drawing.Color.White;
            this.btnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagAnterior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagAnterior.Location = new System.Drawing.Point(765, 14);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(108, 32);
            this.btnPagAnterior.TabIndex = 7;
            this.btnPagAnterior.Text = "<< Anterior";
            this.btnPagAnterior.UseVisualStyleBackColor = false;
            this.btnPagAnterior.Click += new System.EventHandler(this.btnPagAnterior_Click);
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagSiguiente.BackColor = System.Drawing.Color.White;
            this.btnPagSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagSiguiente.Location = new System.Drawing.Point(879, 14);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(111, 32);
            this.btnPagSiguiente.TabIndex = 8;
            this.btnPagSiguiente.Text = "Siguiente >>";
            this.btnPagSiguiente.UseVisualStyleBackColor = false;
            this.btnPagSiguiente.Click += new System.EventHandler(this.btnPagSiguiente_Click);
            // 
            // lblTituloNumRegistros
            // 
            this.lblTituloNumRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloNumRegistros.AutoSize = true;
            this.lblTituloNumRegistros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTituloNumRegistros.Location = new System.Drawing.Point(7, 19);
            this.lblTituloNumRegistros.Name = "lblTituloNumRegistros";
            this.lblTituloNumRegistros.Size = new System.Drawing.Size(80, 19);
            this.lblTituloNumRegistros.TabIndex = 3;
            this.lblTituloNumRegistros.Text = "Mostrando:";
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumeroRegistros.AutoSize = true;
            this.lblNumeroRegistros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumeroRegistros.Location = new System.Drawing.Point(91, 19);
            this.lblNumeroRegistros.Name = "lblNumeroRegistros";
            this.lblNumeroRegistros.Size = new System.Drawing.Size(74, 19);
            this.lblNumeroRegistros.TabIndex = 5;
            this.lblNumeroRegistros.Text = "0 registros";
            // 
            // pnlOpcionesEncabezado
            // 
            this.pnlOpcionesEncabezado.Controls.Add(this.lblBuscar);
            this.pnlOpcionesEncabezado.Controls.Add(this.cmbFiltros);
            this.pnlOpcionesEncabezado.Controls.Add(this.pnlContenedorBusqueda);
            this.pnlOpcionesEncabezado.Controls.Add(this.btnAgregar);
            this.pnlOpcionesEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpcionesEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlOpcionesEncabezado.Name = "pnlOpcionesEncabezado";
            this.pnlOpcionesEncabezado.Size = new System.Drawing.Size(1002, 74);
            this.pnlOpcionesEncabezado.TabIndex = 7;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(18, 6);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(54, 19);
            this.lblBuscar.TabIndex = 25;
            this.lblBuscar.Text = "Buscar:";
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.BackColor = System.Drawing.Color.White;
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Location = new System.Drawing.Point(226, 32);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(142, 25);
            this.cmbFiltros.TabIndex = 24;
            // 
            // pnlContenedorBusqueda
            // 
            this.pnlContenedorBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlContenedorBusqueda.Controls.Add(this.txtTextoBuscar);
            this.pnlContenedorBusqueda.Controls.Add(this.pictureBox1);
            this.pnlContenedorBusqueda.Location = new System.Drawing.Point(19, 32);
            this.pnlContenedorBusqueda.Name = "pnlContenedorBusqueda";
            this.pnlContenedorBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContenedorBusqueda.Size = new System.Drawing.Size(200, 27);
            this.pnlContenedorBusqueda.TabIndex = 11;
            // 
            // txtTextoBuscar
            // 
            this.txtTextoBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTextoBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTextoBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTextoBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoBuscar.Location = new System.Drawing.Point(3, 3);
            this.txtTextoBuscar.Name = "txtTextoBuscar";
            this.txtTextoBuscar.Size = new System.Drawing.Size(164, 20);
            this.txtTextoBuscar.TabIndex = 9;
            this.txtTextoBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTextoBuscar_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(871, 13);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+ Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1002, 50);
            this.pnlEncabezado.TabIndex = 10;
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
            this.btnVisualizar.Width = 37;
            // 
            // btnModificar
            // 
            this.btnModificar.HeaderText = "       ";
            this.btnModificar.Image = global::SistemaFacturacion.Properties.Resources.editar;
            this.btnModificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.ReadOnly = true;
            this.btnModificar.Width = 37;
            // 
            // btnEliminar
            // 
            this.btnEliminar.HeaderText = "       ";
            this.btnEliminar.Image = global::SistemaFacturacion.Properties.Resources.borrar;
            this.btnEliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ReadOnly = true;
            this.btnEliminar.Width = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SistemaFacturacion.Properties.Resources.search_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(167, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 21);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmListarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.pnlDatosClientes);
            this.Controls.Add(this.pnlEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar empleados";
            this.Load += new System.EventHandler(this.frmListarEmpleados_Load);
            this.pnlDatosClientes.ResumeLayout(false);
            this.pnlDgvClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.pnlOpcionesDgv.ResumeLayout(false);
            this.pnlOpcionesDgv.PerformLayout();
            this.pnlOpcionesEncabezado.ResumeLayout(false);
            this.pnlOpcionesEncabezado.PerformLayout();
            this.pnlContenedorBusqueda.ResumeLayout(false);
            this.pnlContenedorBusqueda.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatosClientes;
        private System.Windows.Forms.Panel pnlDgvClientes;
        private System.Windows.Forms.Panel pnlOpcionesDgv;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Label lblTituloNumRegistros;
        private System.Windows.Forms.Label lblNumeroRegistros;
        private System.Windows.Forms.Panel pnlOpcionesEncabezado;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Panel pnlContenedorBusqueda;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFechaNacimiento;
        private System.Windows.Forms.DataGridViewImageColumn btnVisualizar;
        private System.Windows.Forms.DataGridViewImageColumn btnModificar;
        private System.Windows.Forms.DataGridViewImageColumn btnEliminar;
    }
}
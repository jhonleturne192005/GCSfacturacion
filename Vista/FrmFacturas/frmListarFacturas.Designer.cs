
namespace SistemaFacturacion.Vista.Factura
{
    partial class frmListarFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarFacturas));
            this.pnlOpcionesEncabezado = new System.Windows.Forms.Panel();
            this.pnlContenedorBusqueda = new System.Windows.Forms.Panel();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNumeroRegistros = new System.Windows.Forms.Label();
            this.pnlDgvClientes = new System.Windows.Forms.Panel();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.txtIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImpuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVisualizar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlOpcionesDgv = new System.Windows.Forms.Panel();
            this.lblTituloNumRegistros = new System.Windows.Forms.Label();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.pnlDatosClientes = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlOpcionesEncabezado.SuspendLayout();
            this.pnlContenedorBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDgvClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.pnlOpcionesDgv.SuspendLayout();
            this.pnlDatosClientes.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOpcionesEncabezado
            // 
            this.pnlOpcionesEncabezado.Controls.Add(this.pnlContenedorBusqueda);
            this.pnlOpcionesEncabezado.Controls.Add(this.btnAgregar);
            this.pnlOpcionesEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOpcionesEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlOpcionesEncabezado.Name = "pnlOpcionesEncabezado";
            this.pnlOpcionesEncabezado.Size = new System.Drawing.Size(1002, 62);
            this.pnlOpcionesEncabezado.TabIndex = 7;
            // 
            // pnlContenedorBusqueda
            // 
            this.pnlContenedorBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlContenedorBusqueda.Controls.Add(this.txtTextoBuscar);
            this.pnlContenedorBusqueda.Controls.Add(this.pictureBox1);
            this.pnlContenedorBusqueda.Location = new System.Drawing.Point(19, 16);
            this.pnlContenedorBusqueda.Name = "pnlContenedorBusqueda";
            this.pnlContenedorBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContenedorBusqueda.Size = new System.Drawing.Size(200, 27);
            this.pnlContenedorBusqueda.TabIndex = 17;
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
            this.txtTextoBuscar.TextChanged += new System.EventHandler(this.txtTextoBuscar_TextChanged);
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
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "+  Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // pnlDgvClientes
            // 
            this.pnlDgvClientes.Controls.Add(this.dgvFacturas);
            this.pnlDgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvClientes.Location = new System.Drawing.Point(0, 62);
            this.pnlDgvClientes.Name = "pnlDgvClientes";
            this.pnlDgvClientes.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlDgvClientes.Size = new System.Drawing.Size(1002, 420);
            this.pnlDgvClientes.TabIndex = 9;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.White;
            this.dgvFacturas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFacturas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvFacturas.ColumnHeadersHeight = 25;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdentificacion,
            this.txtCliente,
            this.txtSubtotal,
            this.txtImpuestos,
            this.txtTotal,
            this.btnVisualizar,
            this.btnImprimir});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFacturas.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EnableHeadersVisualStyles = false;
            this.dgvFacturas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvFacturas.Location = new System.Drawing.Point(10, 0);
            this.dgvFacturas.Margin = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvFacturas.RowHeadersVisible = false;
            this.dgvFacturas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.dgvFacturas.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvFacturas.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvFacturas.Size = new System.Drawing.Size(982, 420);
            this.dgvFacturas.TabIndex = 0;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.HeaderText = "ID";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            this.txtIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtIdentificacion.Width = 28;
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCliente.HeaderText = "Cliente";
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.HeaderText = "Subtotal";
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.txtSubtotal.Width = 70;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.HeaderText = "Impuestos";
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.ReadOnly = true;
            this.txtImpuestos.Width = 101;
            // 
            // txtTotal
            // 
            this.txtTotal.HeaderText = "Total";
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Width = 65;
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
            // btnImprimir
            // 
            this.btnImprimir.HeaderText = "";
            this.btnImprimir.Image = global::SistemaFacturacion.Properties.Resources.visualizar;
            this.btnImprimir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            this.btnImprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnImprimir.Width = 5;
            // 
            // pnlOpcionesDgv
            // 
            this.pnlOpcionesDgv.Controls.Add(this.lblTituloNumRegistros);
            this.pnlOpcionesDgv.Controls.Add(this.lblNumeroRegistros);
            this.pnlOpcionesDgv.Controls.Add(this.btnPagAnterior);
            this.pnlOpcionesDgv.Controls.Add(this.btnPagSiguiente);
            this.pnlOpcionesDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpcionesDgv.Location = new System.Drawing.Point(0, 482);
            this.pnlOpcionesDgv.Name = "pnlOpcionesDgv";
            this.pnlOpcionesDgv.Size = new System.Drawing.Size(1002, 60);
            this.pnlOpcionesDgv.TabIndex = 8;
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
            // btnPagAnterior
            // 
            this.btnPagAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagAnterior.BackColor = System.Drawing.Color.White;
            this.btnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagAnterior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagAnterior.Location = new System.Drawing.Point(765, 14);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(108, 32);
            this.btnPagAnterior.TabIndex = 1;
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
            this.btnPagSiguiente.TabIndex = 6;
            this.btnPagSiguiente.Text = "Siguiente >>";
            this.btnPagSiguiente.UseVisualStyleBackColor = false;
            this.btnPagSiguiente.Click += new System.EventHandler(this.btnPagSiguiente_Click);
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
            this.pnlDatosClientes.TabIndex = 9;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1002, 50);
            this.pnlEncabezado.TabIndex = 8;
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
            this.lblTitulo.Size = new System.Drawing.Size(69, 21);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Facturas";
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
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Eliminar";
            this.dataGridViewImageColumn3.Image = global::SistemaFacturacion.Properties.Resources.borrar;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Width = 136;
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
            // frmListarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.pnlDatosClientes);
            this.Controls.Add(this.pnlEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de facturas";
            this.Load += new System.EventHandler(this.frmListarFacturas_Load);
            this.pnlOpcionesEncabezado.ResumeLayout(false);
            this.pnlContenedorBusqueda.ResumeLayout(false);
            this.pnlContenedorBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDgvClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.pnlOpcionesDgv.ResumeLayout(false);
            this.pnlOpcionesDgv.PerformLayout();
            this.pnlDatosClientes.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel pnlOpcionesEncabezado;
        private System.Windows.Forms.Label lblNumeroRegistros;
        private System.Windows.Forms.Panel pnlDgvClientes;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Panel pnlOpcionesDgv;
        private System.Windows.Forms.Label lblTituloNumRegistros;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Panel pnlDatosClientes;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotal;
        private System.Windows.Forms.DataGridViewImageColumn btnVisualizar;
        private System.Windows.Forms.DataGridViewImageColumn btnImprimir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlContenedorBusqueda;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
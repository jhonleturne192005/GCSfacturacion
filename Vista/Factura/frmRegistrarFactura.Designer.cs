
namespace SistemaFacturacion.Vista.Factura
{
    partial class frmRegistrarFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlDetalleFactura = new System.Windows.Forms.Panel();
            this.pnlProductosFactura = new System.Windows.Forms.Panel();
            this.dgvProductosFactura = new System.Windows.Forms.DataGridView();
            this.txtCodigoProductoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreProductoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidadProductoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPUFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalProductoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoProductoAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTotalesFactura = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTituloTotal = new System.Windows.Forms.Label();
            this.lblTituloIVA = new System.Windows.Forms.Label();
            this.lblTituloSubtotal = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedulaCliente = new System.Windows.Forms.TextBox();
            this.pnlDatosFactura = new System.Windows.Forms.Panel();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.lblTituloCliente = new System.Windows.Forms.Label();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.pnlDgvProductos = new System.Windows.Forms.Panel();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBuscarProducto = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtProductoBuscar = new System.Windows.Forms.TextBox();
            this.pnlOpcionesProducto = new System.Windows.Forms.Panel();
            this.btnSeleccionarProducto = new System.Windows.Forms.Button();
            this.pnlEncabezadoProductos = new System.Windows.Forms.Panel();
            this.lblTituloProductos = new System.Windows.Forms.Label();
            this.pnlEncabezado.SuspendLayout();
            this.pnlDatos.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.pnlDetalleFactura.SuspendLayout();
            this.pnlProductosFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFactura)).BeginInit();
            this.pnlTotalesFactura.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.pnlDatosFactura.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlDgvProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnlBuscarProducto.SuspendLayout();
            this.pnlOpcionesProducto.SuspendLayout();
            this.pnlEncabezadoProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.btnFacturar);
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1002, 54);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnFacturar.FlatAppearance.BorderSize = 0;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(872, 14);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(118, 30);
            this.btnFacturar.TabIndex = 4;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
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
            this.lblTitulo.Size = new System.Drawing.Size(220, 25);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "REGISTRO DE FACTURA";
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.pnlFactura);
            this.pnlDatos.Controls.Add(this.pnlProductos);
            this.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatos.Location = new System.Drawing.Point(0, 54);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(1002, 538);
            this.pnlDatos.TabIndex = 2;
            // 
            // pnlFactura
            // 
            this.pnlFactura.Controls.Add(this.pnlDetalleFactura);
            this.pnlFactura.Controls.Add(this.pnlDatosFactura);
            this.pnlFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFactura.Location = new System.Drawing.Point(283, 0);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Size = new System.Drawing.Size(719, 538);
            this.pnlFactura.TabIndex = 1;
            // 
            // pnlDetalleFactura
            // 
            this.pnlDetalleFactura.Controls.Add(this.pnlProductosFactura);
            this.pnlDetalleFactura.Controls.Add(this.pnlTotalesFactura);
            this.pnlDetalleFactura.Controls.Add(this.pnlCliente);
            this.pnlDetalleFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetalleFactura.Location = new System.Drawing.Point(0, 46);
            this.pnlDetalleFactura.Name = "pnlDetalleFactura";
            this.pnlDetalleFactura.Size = new System.Drawing.Size(719, 492);
            this.pnlDetalleFactura.TabIndex = 1;
            // 
            // pnlProductosFactura
            // 
            this.pnlProductosFactura.Controls.Add(this.dgvProductosFactura);
            this.pnlProductosFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProductosFactura.Location = new System.Drawing.Point(0, 82);
            this.pnlProductosFactura.Name = "pnlProductosFactura";
            this.pnlProductosFactura.Size = new System.Drawing.Size(719, 328);
            this.pnlProductosFactura.TabIndex = 2;
            // 
            // dgvProductosFactura
            // 
            this.dgvProductosFactura.AllowUserToAddRows = false;
            this.dgvProductosFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductosFactura.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductosFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductosFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosFactura.ColumnHeadersHeight = 25;
            this.dgvProductosFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCodigoProductoFactura,
            this.txtNombreProductoFactura,
            this.txtCantidadProductoFactura,
            this.dgvPUFactura,
            this.txtTotalProductoFactura,
            this.txtIva,
            this.txtCodigoProductoAnterior});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductosFactura.EnableHeadersVisualStyles = false;
            this.dgvProductosFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvProductosFactura.Location = new System.Drawing.Point(0, 0);
            this.dgvProductosFactura.Margin = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.dgvProductosFactura.Name = "dgvProductosFactura";
            this.dgvProductosFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvProductosFactura.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductosFactura.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductosFactura.Size = new System.Drawing.Size(719, 328);
            this.dgvProductosFactura.TabIndex = 2;
            this.dgvProductosFactura.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosFactura_CellEndEdit);
            this.dgvProductosFactura.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductosFactura_RowsRemoved);
            // 
            // txtCodigoProductoFactura
            // 
            this.txtCodigoProductoFactura.HeaderText = "Código";
            this.txtCodigoProductoFactura.Name = "txtCodigoProductoFactura";
            this.txtCodigoProductoFactura.Width = 88;
            // 
            // txtNombreProductoFactura
            // 
            this.txtNombreProductoFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNombreProductoFactura.HeaderText = "Nombre";
            this.txtNombreProductoFactura.Name = "txtNombreProductoFactura";
            this.txtNombreProductoFactura.ReadOnly = true;
            // 
            // txtCantidadProductoFactura
            // 
            this.txtCantidadProductoFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtCantidadProductoFactura.HeaderText = "Cantidad";
            this.txtCantidadProductoFactura.Name = "txtCantidadProductoFactura";
            // 
            // dgvPUFactura
            // 
            this.dgvPUFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvPUFactura.HeaderText = "PU ($)";
            this.dgvPUFactura.Name = "dgvPUFactura";
            this.dgvPUFactura.ReadOnly = true;
            // 
            // txtTotalProductoFactura
            // 
            this.txtTotalProductoFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.txtTotalProductoFactura.HeaderText = "Total";
            this.txtTotalProductoFactura.Name = "txtTotalProductoFactura";
            this.txtTotalProductoFactura.ReadOnly = true;
            this.txtTotalProductoFactura.Width = 71;
            // 
            // txtIva
            // 
            this.txtIva.HeaderText = "iva";
            this.txtIva.Name = "txtIva";
            this.txtIva.Visible = false;
            this.txtIva.Width = 58;
            // 
            // txtCodigoProductoAnterior
            // 
            this.txtCodigoProductoAnterior.HeaderText = "CódigoAnterior";
            this.txtCodigoProductoAnterior.Name = "txtCodigoProductoAnterior";
            this.txtCodigoProductoAnterior.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txtCodigoProductoAnterior.Visible = false;
            this.txtCodigoProductoAnterior.Width = 153;
            // 
            // pnlTotalesFactura
            // 
            this.pnlTotalesFactura.Controls.Add(this.lblTotal);
            this.pnlTotalesFactura.Controls.Add(this.lblIva);
            this.pnlTotalesFactura.Controls.Add(this.lblSubtotal);
            this.pnlTotalesFactura.Controls.Add(this.lblTituloTotal);
            this.pnlTotalesFactura.Controls.Add(this.lblTituloIVA);
            this.pnlTotalesFactura.Controls.Add(this.lblTituloSubtotal);
            this.pnlTotalesFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalesFactura.Location = new System.Drawing.Point(0, 410);
            this.pnlTotalesFactura.Name = "pnlTotalesFactura";
            this.pnlTotalesFactura.Size = new System.Drawing.Size(719, 82);
            this.pnlTotalesFactura.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotal.Location = new System.Drawing.Point(468, 56);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(239, 23);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIva
            // 
            this.lblIva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIva.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIva.Location = new System.Drawing.Point(468, 30);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(239, 23);
            this.lblIva.TabIndex = 13;
            this.lblIva.Text = "$0.00";
            this.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubtotal.Location = new System.Drawing.Point(468, 4);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(239, 23);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "$0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTituloTotal
            // 
            this.lblTituloTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloTotal.AutoSize = true;
            this.lblTituloTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloTotal.Location = new System.Drawing.Point(380, 56);
            this.lblTituloTotal.Name = "lblTituloTotal";
            this.lblTituloTotal.Size = new System.Drawing.Size(48, 20);
            this.lblTituloTotal.TabIndex = 11;
            this.lblTituloTotal.Text = "Total:";
            // 
            // lblTituloIVA
            // 
            this.lblTituloIVA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloIVA.AutoSize = true;
            this.lblTituloIVA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloIVA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloIVA.Location = new System.Drawing.Point(380, 30);
            this.lblTituloIVA.Name = "lblTituloIVA";
            this.lblTituloIVA.Size = new System.Drawing.Size(38, 20);
            this.lblTituloIVA.TabIndex = 10;
            this.lblTituloIVA.Text = "IVA:";
            // 
            // lblTituloSubtotal
            // 
            this.lblTituloSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloSubtotal.AutoSize = true;
            this.lblTituloSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTituloSubtotal.Location = new System.Drawing.Point(380, 4);
            this.lblTituloSubtotal.Name = "lblTituloSubtotal";
            this.lblTituloSubtotal.Size = new System.Drawing.Size(72, 20);
            this.lblTituloSubtotal.TabIndex = 9;
            this.lblTituloSubtotal.Text = "Subtotal:";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.txtNombresCliente);
            this.pnlCliente.Controls.Add(this.lblNombreCliente);
            this.pnlCliente.Controls.Add(this.lblCedula);
            this.pnlCliente.Controls.Add(this.txtCedulaCliente);
            this.pnlCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCliente.Location = new System.Drawing.Point(0, 0);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(719, 82);
            this.pnlCliente.TabIndex = 0;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombresCliente.Enabled = false;
            this.txtNombresCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCliente.Location = new System.Drawing.Point(103, 42);
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(604, 27);
            this.txtNombresCliente.TabIndex = 19;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreCliente.Location = new System.Drawing.Point(23, 46);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(75, 19);
            this.lblNombreCliente.TabIndex = 18;
            this.lblNombreCliente.Text = "Nombres:";
            // 
            // lblCedula
            // 
            this.lblCedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCedula.Location = new System.Drawing.Point(23, 14);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(59, 19);
            this.lblCedula.TabIndex = 17;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtCedulaCliente
            // 
            this.txtCedulaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedulaCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCliente.Location = new System.Drawing.Point(103, 11);
            this.txtCedulaCliente.Name = "txtCedulaCliente";
            this.txtCedulaCliente.Size = new System.Drawing.Size(604, 27);
            this.txtCedulaCliente.TabIndex = 17;
            this.txtCedulaCliente.Leave += new System.EventHandler(this.txtCedulaCliente_Leave);
            // 
            // pnlDatosFactura
            // 
            this.pnlDatosFactura.Controls.Add(this.dtpFechaFactura);
            this.pnlDatosFactura.Controls.Add(this.lblFecha);
            this.pnlDatosFactura.Controls.Add(this.btnSeleccionarCliente);
            this.pnlDatosFactura.Controls.Add(this.lblTituloCliente);
            this.pnlDatosFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosFactura.Location = new System.Drawing.Point(0, 0);
            this.pnlDatosFactura.Name = "pnlDatosFactura";
            this.pnlDatosFactura.Size = new System.Drawing.Size(719, 46);
            this.pnlDatosFactura.TabIndex = 0;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(475, 9);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(232, 27);
            this.dtpFechaFactura.TabIndex = 17;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(393, 8);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 25);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnSeleccionarCliente.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarCliente.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(111, 7);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(101, 30);
            this.btnSeleccionarCliente.TabIndex = 3;
            this.btnSeleccionarCliente.Text = "Seleccionar";
            this.btnSeleccionarCliente.UseVisualStyleBackColor = false;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // lblTituloCliente
            // 
            this.lblTituloCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloCliente.AutoSize = true;
            this.lblTituloCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCliente.ForeColor = System.Drawing.Color.Black;
            this.lblTituloCliente.Location = new System.Drawing.Point(22, 9);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(73, 25);
            this.lblTituloCliente.TabIndex = 7;
            this.lblTituloCliente.Text = "Cliente";
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.pnlDgvProductos);
            this.pnlProductos.Controls.Add(this.pnlBuscarProducto);
            this.pnlProductos.Controls.Add(this.pnlOpcionesProducto);
            this.pnlProductos.Controls.Add(this.pnlEncabezadoProductos);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProductos.Location = new System.Drawing.Point(0, 0);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Size = new System.Drawing.Size(283, 538);
            this.pnlProductos.TabIndex = 0;
            // 
            // pnlDgvProductos
            // 
            this.pnlDgvProductos.Controls.Add(this.dgvProductos);
            this.pnlDgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvProductos.Location = new System.Drawing.Point(0, 95);
            this.pnlDgvProductos.Name = "pnlDgvProductos";
            this.pnlDgvProductos.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.pnlDgvProductos.Size = new System.Drawing.Size(283, 361);
            this.pnlDgvProductos.TabIndex = 5;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductos.ColumnHeadersHeight = 25;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCodigoProducto,
            this.txtNombreProducto,
            this.txtPU});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvProductos.Location = new System.Drawing.Point(10, 0);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProductos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductos.Size = new System.Drawing.Size(268, 361);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.HeaderText = "Código";
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.ReadOnly = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNombreProducto.HeaderText = "Nombre";
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            // 
            // txtPU
            // 
            this.txtPU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPU.HeaderText = "PU ($)";
            this.txtPU.Name = "txtPU";
            this.txtPU.ReadOnly = true;
            // 
            // pnlBuscarProducto
            // 
            this.pnlBuscarProducto.Controls.Add(this.btnBuscar);
            this.pnlBuscarProducto.Controls.Add(this.txtProductoBuscar);
            this.pnlBuscarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBuscarProducto.Location = new System.Drawing.Point(0, 46);
            this.pnlBuscarProducto.Name = "pnlBuscarProducto";
            this.pnlBuscarProducto.Size = new System.Drawing.Size(283, 49);
            this.pnlBuscarProducto.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBuscar.Location = new System.Drawing.Point(11, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 27);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtProductoBuscar
            // 
            this.txtProductoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductoBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoBuscar.Location = new System.Drawing.Point(77, 9);
            this.txtProductoBuscar.Name = "txtProductoBuscar";
            this.txtProductoBuscar.Size = new System.Drawing.Size(196, 27);
            this.txtProductoBuscar.TabIndex = 20;
            this.txtProductoBuscar.TextChanged += new System.EventHandler(this.txtTextoBuscar_TextChanged);
            // 
            // pnlOpcionesProducto
            // 
            this.pnlOpcionesProducto.Controls.Add(this.btnSeleccionarProducto);
            this.pnlOpcionesProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpcionesProducto.Location = new System.Drawing.Point(0, 456);
            this.pnlOpcionesProducto.Name = "pnlOpcionesProducto";
            this.pnlOpcionesProducto.Size = new System.Drawing.Size(283, 82);
            this.pnlOpcionesProducto.TabIndex = 3;
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSeleccionarProducto.BackColor = System.Drawing.Color.White;
            this.btnSeleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionarProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSeleccionarProducto.Location = new System.Drawing.Point(163, 30);
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.Size = new System.Drawing.Size(110, 32);
            this.btnSeleccionarProducto.TabIndex = 9;
            this.btnSeleccionarProducto.Text = "Seleccionar";
            this.btnSeleccionarProducto.UseVisualStyleBackColor = false;
            this.btnSeleccionarProducto.Click += new System.EventHandler(this.btnSeleccionarProducto_Click);
            // 
            // pnlEncabezadoProductos
            // 
            this.pnlEncabezadoProductos.Controls.Add(this.lblTituloProductos);
            this.pnlEncabezadoProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezadoProductos.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezadoProductos.Name = "pnlEncabezadoProductos";
            this.pnlEncabezadoProductos.Size = new System.Drawing.Size(283, 46);
            this.pnlEncabezadoProductos.TabIndex = 0;
            // 
            // lblTituloProductos
            // 
            this.lblTituloProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTituloProductos.AutoSize = true;
            this.lblTituloProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloProductos.ForeColor = System.Drawing.Color.Black;
            this.lblTituloProductos.Location = new System.Drawing.Point(15, 10);
            this.lblTituloProductos.Name = "lblTituloProductos";
            this.lblTituloProductos.Size = new System.Drawing.Size(104, 25);
            this.lblTituloProductos.TabIndex = 8;
            this.lblTituloProductos.Text = "Productos";
            // 
            // frmRegistrarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.pnlDatos);
            this.Controls.Add(this.pnlEncabezado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmRegistrarFactura";
            this.Text = "Registrar factura";
            this.Load += new System.EventHandler(this.frmRegistrarFactura_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlDatos.ResumeLayout(false);
            this.pnlFactura.ResumeLayout(false);
            this.pnlDetalleFactura.ResumeLayout(false);
            this.pnlProductosFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosFactura)).EndInit();
            this.pnlTotalesFactura.ResumeLayout(false);
            this.pnlTotalesFactura.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.pnlDatosFactura.ResumeLayout(false);
            this.pnlDatosFactura.PerformLayout();
            this.pnlProductos.ResumeLayout(false);
            this.pnlDgvProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnlBuscarProducto.ResumeLayout(false);
            this.pnlBuscarProducto.PerformLayout();
            this.pnlOpcionesProducto.ResumeLayout(false);
            this.pnlEncabezadoProductos.ResumeLayout(false);
            this.pnlEncabezadoProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.Panel pnlDetalleFactura;
        private System.Windows.Forms.Panel pnlProductosFactura;
        private System.Windows.Forms.Panel pnlTotalesFactura;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Panel pnlDatosFactura;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Panel pnlEncabezadoProductos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTituloCliente;
        private System.Windows.Forms.Label lblTituloProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridView dgvProductosFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label lblTituloTotal;
        private System.Windows.Forms.Label lblTituloIVA;
        private System.Windows.Forms.Label lblTituloSubtotal;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSeleccionarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPU;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtCedulaCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombresCliente;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Panel pnlOpcionesProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoProductoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreProductoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidadProductoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPUFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotalProductoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoProductoAnterior;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtProductoBuscar;
        private System.Windows.Forms.Panel pnlDgvProductos;
        private System.Windows.Forms.Panel pnlBuscarProducto;
    }
}
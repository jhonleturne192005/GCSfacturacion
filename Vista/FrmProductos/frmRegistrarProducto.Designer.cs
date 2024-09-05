
namespace SistemaFacturacion.Vista.Productofrm
{
    partial class frmRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProducto));
            this.pnlDatosRegistro = new System.Windows.Forms.Panel();
            this.lblCIProveedor = new System.Windows.Forms.Label();
            this.txtCedulaProveedor = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.pbBuscar = new System.Windows.Forms.PictureBox();
            this.pnlDatosRegistro.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.gbProveedor.SuspendLayout();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatosRegistro
            // 
            this.pnlDatosRegistro.Controls.Add(this.gbProducto);
            this.pnlDatosRegistro.Controls.Add(this.gbProveedor);
            this.pnlDatosRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosRegistro.Location = new System.Drawing.Point(0, 46);
            this.pnlDatosRegistro.Name = "pnlDatosRegistro";
            this.pnlDatosRegistro.Size = new System.Drawing.Size(761, 358);
            this.pnlDatosRegistro.TabIndex = 17;
            // 
            // lblCIProveedor
            // 
            this.lblCIProveedor.AutoSize = true;
            this.lblCIProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCIProveedor.Location = new System.Drawing.Point(6, 59);
            this.lblCIProveedor.Name = "lblCIProveedor";
            this.lblCIProveedor.Size = new System.Drawing.Size(113, 20);
            this.lblCIProveedor.TabIndex = 12;
            this.lblCIProveedor.Text = "C.I. Proveedor:";
            this.lblCIProveedor.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCedulaProveedor
            // 
            this.txtCedulaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaProveedor.Location = new System.Drawing.Point(10, 94);
            this.txtCedulaProveedor.Name = "txtCedulaProveedor";
            this.txtCedulaProveedor.ReadOnly = true;
            this.txtCedulaProveedor.Size = new System.Drawing.Size(312, 26);
            this.txtCedulaProveedor.TabIndex = 13;
            this.txtCedulaProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(22, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(22, 145);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(113, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio unitario:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(22, 228);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(40, 20);
            this.lblIva.TabIndex = 5;
            this.lblIva.Text = "IVA:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(26, 260);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(347, 26);
            this.txtIva.TabIndex = 11;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(26, 94);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(347, 26);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(26, 178);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(347, 26);
            this.txtPrecioUnitario.TabIndex = 10;
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
            this.lblTitulo.Size = new System.Drawing.Size(238, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "REGISTRO DE PRODUCTO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(393, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(347, 30);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnAgregar);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 404);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(761, 67);
            this.pnlOpciones.TabIndex = 16;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(761, 46);
            this.pnlEncabezado.TabIndex = 15;
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.pbBuscar);
            this.gbProveedor.Controls.Add(this.txtNombreProveedor);
            this.gbProveedor.Controls.Add(this.lblNombreProveedor);
            this.gbProveedor.Controls.Add(this.txtCedulaProveedor);
            this.gbProveedor.Controls.Add(this.lblCIProveedor);
            this.gbProveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbProveedor.Location = new System.Drawing.Point(393, 0);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(368, 358);
            this.gbProveedor.TabIndex = 15;
            this.gbProveedor.TabStop = false;
            this.gbProveedor.Text = "Proveedor";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.lblNombre);
            this.gbProducto.Controls.Add(this.txtPrecioUnitario);
            this.gbProducto.Controls.Add(this.txtNombreProducto);
            this.gbProducto.Controls.Add(this.lblPrecio);
            this.gbProducto.Controls.Add(this.txtIva);
            this.gbProducto.Controls.Add(this.lblIva);
            this.gbProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProducto.Location = new System.Drawing.Point(0, 0);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(393, 358);
            this.gbProducto.TabIndex = 16;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Datos del producto";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(10, 178);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(347, 26);
            this.txtNombreProveedor.TabIndex = 13;
            // 
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProveedor.Location = new System.Drawing.Point(6, 145);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(152, 20);
            this.lblNombreProveedor.TabIndex = 12;
            this.lblNombreProveedor.Text = "Nombres proveedor:";
            // 
            // pbBuscar
            // 
            this.pbBuscar.BackgroundImage = global::SistemaFacturacion.Properties.Resources.search_icon;
            this.pbBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBuscar.Location = new System.Drawing.Point(328, 94);
            this.pbBuscar.Name = "pbBuscar";
            this.pbBuscar.Size = new System.Drawing.Size(28, 26);
            this.pbBuscar.TabIndex = 15;
            this.pbBuscar.TabStop = false;
            this.pbBuscar.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // frmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 471);
            this.Controls.Add(this.pnlDatosRegistro);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.frmRegistrarProducto_Load);
            this.pnlDatosRegistro.ResumeLayout(false);
            this.pnlOpciones.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatosRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblCIProveedor;
        private System.Windows.Forms.TextBox txtCedulaProveedor;
        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.PictureBox pbBuscar;
    }
}
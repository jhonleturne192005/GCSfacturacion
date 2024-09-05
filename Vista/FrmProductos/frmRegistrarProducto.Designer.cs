
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
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
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
            this.pnlDatosRegistro.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDatosRegistro
            // 
            this.pnlDatosRegistro.Controls.Add(this.btnSeleccionarCliente);
            this.pnlDatosRegistro.Controls.Add(this.label1);
            this.pnlDatosRegistro.Controls.Add(this.txtProveedor);
            this.pnlDatosRegistro.Controls.Add(this.lblNombre);
            this.pnlDatosRegistro.Controls.Add(this.lblPrecio);
            this.pnlDatosRegistro.Controls.Add(this.lblIva);
            this.pnlDatosRegistro.Controls.Add(this.txtIva);
            this.pnlDatosRegistro.Controls.Add(this.txtNombreProducto);
            this.pnlDatosRegistro.Controls.Add(this.txtPrecioUnitario);
            this.pnlDatosRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDatosRegistro.Location = new System.Drawing.Point(0, 46);
            this.pnlDatosRegistro.Name = "pnlDatosRegistro";
            this.pnlDatosRegistro.Size = new System.Drawing.Size(392, 358);
            this.pnlDatosRegistro.TabIndex = 17;
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnSeleccionarCliente.BackgroundImage = global::SistemaFacturacion.Properties.Resources.search_icon;
            this.btnSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionarCliente.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionarCliente.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(342, 309);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(29, 26);
            this.btnSeleccionarCliente.TabIndex = 14;
            this.btnSeleccionarCliente.UseVisualStyleBackColor = false;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Proveedor:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(24, 309);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(303, 26);
            this.txtProveedor.TabIndex = 13;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(20, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(113, 20);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio unitario:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(20, 193);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(40, 20);
            this.lblIva.TabIndex = 5;
            this.lblIva.Text = "IVA:";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(24, 225);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(347, 26);
            this.txtIva.TabIndex = 11;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(24, 59);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(347, 26);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(24, 143);
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
            this.btnAgregar.Location = new System.Drawing.Point(24, 16);
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
            this.pnlOpciones.Size = new System.Drawing.Size(392, 67);
            this.pnlOpciones.TabIndex = 16;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(392, 46);
            this.pnlEncabezado.TabIndex = 15;
            // 
            // frmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 471);
            this.Controls.Add(this.pnlDatosRegistro);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(408, 510);
            this.MinimumSize = new System.Drawing.Size(408, 510);
            this.Name = "frmRegistrarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.frmRegistrarProducto_Load);
            this.pnlDatosRegistro.ResumeLayout(false);
            this.pnlDatosRegistro.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Button btnSeleccionarCliente;
    }
}
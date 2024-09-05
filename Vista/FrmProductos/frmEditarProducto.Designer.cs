
namespace SistemaFacturacion.Vista.Productofrm
{
    partial class frmEditarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProducto));
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.btnSeleccionarCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.pnlContenido.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenido
            // 
            this.pnlContenido.Controls.Add(this.btnSeleccionarCliente);
            this.pnlContenido.Controls.Add(this.label3);
            this.pnlContenido.Controls.Add(this.lblCedula);
            this.pnlContenido.Controls.Add(this.txtProveedor);
            this.pnlContenido.Controls.Add(this.label1);
            this.pnlContenido.Controls.Add(this.label2);
            this.pnlContenido.Controls.Add(this.txtIva);
            this.pnlContenido.Controls.Add(this.txtNombreProducto);
            this.pnlContenido.Controls.Add(this.txtPrecioUnitario);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 46);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(413, 353);
            this.pnlContenido.TabIndex = 20;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(20, 24);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(136, 20);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Nombre producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Precio Unitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "IVA:";
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
            this.lblTitulo.Size = new System.Drawing.Size(235, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "ACTUALIZAR PRODUCTO";
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(45, 16);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(347, 30);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.btnEditar);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOpciones.Location = new System.Drawing.Point(0, 399);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(413, 67);
            this.pnlOpciones.TabIndex = 19;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(413, 46);
            this.pnlEncabezado.TabIndex = 18;
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
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(335, 305);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(36, 30);
            this.btnSeleccionarCliente.TabIndex = 23;
            this.btnSeleccionarCliente.UseVisualStyleBackColor = false;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(26, 305);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(303, 26);
            this.txtProveedor.TabIndex = 22;
            // 
            // frmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(413, 466);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlOpciones);
            this.Controls.Add(this.pnlEncabezado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(429, 505);
            this.MinimumSize = new System.Drawing.Size(429, 505);
            this.Name = "frmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar producto";
            this.Load += new System.EventHandler(this.frmActualizarProducto_Load);
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Button btnSeleccionarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProveedor;
    }
}
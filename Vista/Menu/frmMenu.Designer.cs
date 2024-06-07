
namespace SistemaFacturacion.Vista.Menu
{
    partial class frmMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlMenuIzquierdo = new System.Windows.Forms.Panel();
            this.pnlSubmenus = new System.Windows.Forms.Panel();
            this.pnlSubProductos = new System.Windows.Forms.Panel();
            this.btnRegistrarproductosp = new System.Windows.Forms.Button();
            this.btnListarproductosp = new System.Windows.Forms.Button();
            this.pnlSubFactura = new System.Windows.Forms.Panel();
            this.btnRegistrarfacturasp = new System.Windows.Forms.Button();
            this.btnListarfacturasp = new System.Windows.Forms.Button();
            this.pnlSubClientes = new System.Windows.Forms.Panel();
            this.btnRegistrarclientesp = new System.Windows.Forms.Button();
            this.btnListarclientesp = new System.Windows.Forms.Button();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.btnFactura = new System.Windows.Forms.Button();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlInterfaz = new System.Windows.Forms.Panel();
            this.tpOpciones = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMenuIzquierdo.SuspendLayout();
            this.pnlSubmenus.SuspendLayout();
            this.pnlSubProductos.SuspendLayout();
            this.pnlSubFactura.SuspendLayout();
            this.pnlSubClientes.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuIzquierdo
            // 
            this.pnlMenuIzquierdo.AutoScroll = true;
            this.pnlMenuIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMenuIzquierdo.Controls.Add(this.pnlSubmenus);
            this.pnlMenuIzquierdo.Controls.Add(this.pnlImagen);
            this.pnlMenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuIzquierdo.Name = "pnlMenuIzquierdo";
            this.pnlMenuIzquierdo.Size = new System.Drawing.Size(180, 668);
            this.pnlMenuIzquierdo.TabIndex = 0;
            // 
            // pnlSubmenus
            // 
            this.pnlSubmenus.Controls.Add(this.pnlSubProductos);
            this.pnlSubmenus.Controls.Add(this.pnlSubFactura);
            this.pnlSubmenus.Controls.Add(this.pnlSubClientes);
            this.pnlSubmenus.Controls.Add(this.pnlFactura);
            this.pnlSubmenus.Controls.Add(this.pnlProductos);
            this.pnlSubmenus.Controls.Add(this.pnlClientes);
            this.pnlSubmenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubmenus.Location = new System.Drawing.Point(0, 52);
            this.pnlSubmenus.MinimumSize = new System.Drawing.Size(52, 616);
            this.pnlSubmenus.Name = "pnlSubmenus";
            this.pnlSubmenus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlSubmenus.Size = new System.Drawing.Size(180, 616);
            this.pnlSubmenus.TabIndex = 1;
            // 
            // pnlSubProductos
            // 
            this.pnlSubProductos.Controls.Add(this.btnRegistrarproductosp);
            this.pnlSubProductos.Controls.Add(this.btnListarproductosp);
            this.pnlSubProductos.Location = new System.Drawing.Point(3, 352);
            this.pnlSubProductos.Name = "pnlSubProductos";
            this.pnlSubProductos.Size = new System.Drawing.Size(177, 88);
            this.pnlSubProductos.TabIndex = 8;
            // 
            // btnRegistrarproductosp
            // 
            this.btnRegistrarproductosp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnRegistrarproductosp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarproductosp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarproductosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarproductosp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarproductosp.Image = global::SistemaFacturacion.Properties.Resources.producto_blanco;
            this.btnRegistrarproductosp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarproductosp.Location = new System.Drawing.Point(0, 40);
            this.btnRegistrarproductosp.Name = "btnRegistrarproductosp";
            this.btnRegistrarproductosp.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnRegistrarproductosp.Size = new System.Drawing.Size(177, 40);
            this.btnRegistrarproductosp.TabIndex = 1;
            this.btnRegistrarproductosp.Text = "Registrar Productos";
            this.btnRegistrarproductosp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarproductosp.UseVisualStyleBackColor = false;
            this.btnRegistrarproductosp.Click += new System.EventHandler(this.btnRegistrarproductosp_Click);
            // 
            // btnListarproductosp
            // 
            this.btnListarproductosp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnListarproductosp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarproductosp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarproductosp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarproductosp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarproductosp.Image = global::SistemaFacturacion.Properties.Resources.producto_blanco;
            this.btnListarproductosp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarproductosp.Location = new System.Drawing.Point(0, 0);
            this.btnListarproductosp.Name = "btnListarproductosp";
            this.btnListarproductosp.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.btnListarproductosp.Size = new System.Drawing.Size(177, 40);
            this.btnListarproductosp.TabIndex = 0;
            this.btnListarproductosp.Text = "Listar Productos";
            this.btnListarproductosp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarproductosp.UseVisualStyleBackColor = false;
            this.btnListarproductosp.Click += new System.EventHandler(this.btnListarproductosp_Click);
            // 
            // pnlSubFactura
            // 
            this.pnlSubFactura.Controls.Add(this.btnRegistrarfacturasp);
            this.pnlSubFactura.Controls.Add(this.btnListarfacturasp);
            this.pnlSubFactura.Location = new System.Drawing.Point(3, 206);
            this.pnlSubFactura.Name = "pnlSubFactura";
            this.pnlSubFactura.Size = new System.Drawing.Size(177, 82);
            this.pnlSubFactura.TabIndex = 7;
            // 
            // btnRegistrarfacturasp
            // 
            this.btnRegistrarfacturasp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnRegistrarfacturasp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarfacturasp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarfacturasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarfacturasp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarfacturasp.Image = global::SistemaFacturacion.Properties.Resources.factura_blanco;
            this.btnRegistrarfacturasp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarfacturasp.Location = new System.Drawing.Point(0, 40);
            this.btnRegistrarfacturasp.Name = "btnRegistrarfacturasp";
            this.btnRegistrarfacturasp.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnRegistrarfacturasp.Size = new System.Drawing.Size(177, 40);
            this.btnRegistrarfacturasp.TabIndex = 1;
            this.btnRegistrarfacturasp.Text = "Registrar Facturas";
            this.btnRegistrarfacturasp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarfacturasp.UseVisualStyleBackColor = false;
            this.btnRegistrarfacturasp.Click += new System.EventHandler(this.btnRegistrarfacturasp_Click);
            // 
            // btnListarfacturasp
            // 
            this.btnListarfacturasp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnListarfacturasp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarfacturasp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarfacturasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarfacturasp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarfacturasp.Image = global::SistemaFacturacion.Properties.Resources.factura_blanco;
            this.btnListarfacturasp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarfacturasp.Location = new System.Drawing.Point(0, 0);
            this.btnListarfacturasp.Name = "btnListarfacturasp";
            this.btnListarfacturasp.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.btnListarfacturasp.Size = new System.Drawing.Size(177, 40);
            this.btnListarfacturasp.TabIndex = 0;
            this.btnListarfacturasp.Text = "Listar Facturas";
            this.btnListarfacturasp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarfacturasp.UseVisualStyleBackColor = false;
            // 
            // pnlSubClientes
            // 
            this.pnlSubClientes.Controls.Add(this.btnRegistrarclientesp);
            this.pnlSubClientes.Controls.Add(this.btnListarclientesp);
            this.pnlSubClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubClientes.Location = new System.Drawing.Point(0, 62);
            this.pnlSubClientes.Name = "pnlSubClientes";
            this.pnlSubClientes.Size = new System.Drawing.Size(180, 82);
            this.pnlSubClientes.TabIndex = 6;
            // 
            // btnRegistrarclientesp
            // 
            this.btnRegistrarclientesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnRegistrarclientesp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarclientesp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarclientesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarclientesp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrarclientesp.Image = global::SistemaFacturacion.Properties.Resources.usuarios_blanco2;
            this.btnRegistrarclientesp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarclientesp.Location = new System.Drawing.Point(0, 40);
            this.btnRegistrarclientesp.Name = "btnRegistrarclientesp";
            this.btnRegistrarclientesp.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.btnRegistrarclientesp.Size = new System.Drawing.Size(180, 40);
            this.btnRegistrarclientesp.TabIndex = 1;
            this.btnRegistrarclientesp.Text = "Registrar Clientes";
            this.btnRegistrarclientesp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarclientesp.UseVisualStyleBackColor = false;
            this.btnRegistrarclientesp.Click += new System.EventHandler(this.btnRegistrarclientesp_Click);
            // 
            // btnListarclientesp
            // 
            this.btnListarclientesp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnListarclientesp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarclientesp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarclientesp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarclientesp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarclientesp.Image = global::SistemaFacturacion.Properties.Resources.usuarios_blanco2;
            this.btnListarclientesp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarclientesp.Location = new System.Drawing.Point(0, 0);
            this.btnListarclientesp.Name = "btnListarclientesp";
            this.btnListarclientesp.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.btnListarclientesp.Size = new System.Drawing.Size(180, 40);
            this.btnListarclientesp.TabIndex = 0;
            this.btnListarclientesp.Text = "Listar Clientes";
            this.btnListarclientesp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListarclientesp.UseVisualStyleBackColor = false;
            this.btnListarclientesp.Click += new System.EventHandler(this.btnListarclientesp_Click);
            // 
            // pnlFactura
            // 
            this.pnlFactura.Controls.Add(this.btnFactura);
            this.pnlFactura.Location = new System.Drawing.Point(0, 148);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Padding = new System.Windows.Forms.Padding(12);
            this.pnlFactura.Size = new System.Drawing.Size(180, 52);
            this.pnlFactura.TabIndex = 5;
            // 
            // btnFactura
            // 
            this.btnFactura.BackgroundImage = global::SistemaFacturacion.Properties.Resources.factura_blanco;
            this.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFactura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFactura.FlatAppearance.BorderSize = 0;
            this.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Location = new System.Drawing.Point(12, 12);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(156, 28);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.btnProductos);
            this.pnlProductos.Location = new System.Drawing.Point(3, 294);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Padding = new System.Windows.Forms.Padding(12);
            this.pnlProductos.Size = new System.Drawing.Size(177, 52);
            this.pnlProductos.TabIndex = 4;
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = global::SistemaFacturacion.Properties.Resources.producto_blanco;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Location = new System.Drawing.Point(12, 12);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnProductos.Size = new System.Drawing.Size(153, 28);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.btnClientes);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientes.Location = new System.Drawing.Point(0, 10);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Padding = new System.Windows.Forms.Padding(12);
            this.pnlClientes.Size = new System.Drawing.Size(180, 52);
            this.pnlClientes.TabIndex = 3;
            this.pnlClientes.Click += new System.EventHandler(this.pnlClientes_Click);
            this.pnlClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlClientes_Paint);
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::SistemaFacturacion.Properties.Resources.usuarios_blanco;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(12, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(156, 28);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pnlImagen
            // 
            this.pnlImagen.Controls.Add(this.pbLogo);
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Padding = new System.Windows.Forms.Padding(12);
            this.pnlImagen.Size = new System.Drawing.Size(180, 52);
            this.pnlImagen.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::SistemaFacturacion.Properties.Resources.logo;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(156, 28);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlInterfaz
            // 
            this.pnlInterfaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInterfaz.Location = new System.Drawing.Point(180, 0);
            this.pnlInterfaz.Name = "pnlInterfaz";
            this.pnlInterfaz.Size = new System.Drawing.Size(1103, 668);
            this.pnlInterfaz.TabIndex = 1;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 668);
            this.Controls.Add(this.pnlInterfaz);
            this.Controls.Add(this.pnlMenuIzquierdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Facturación";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenuIzquierdo.ResumeLayout(false);
            this.pnlSubmenus.ResumeLayout(false);
            this.pnlSubProductos.ResumeLayout(false);
            this.pnlSubFactura.ResumeLayout(false);
            this.pnlSubClientes.ResumeLayout(false);
            this.pnlFactura.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuIzquierdo;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Panel pnlInterfaz;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolTip tpOpciones;
        private System.Windows.Forms.Panel pnlSubmenus;
        private System.Windows.Forms.Panel pnlSubFactura;
        private System.Windows.Forms.Panel pnlSubClientes;
        private System.Windows.Forms.Button btnRegistrarclientesp;
        private System.Windows.Forms.Button btnListarclientesp;
        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Panel pnlProductos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnRegistrarfacturasp;
        private System.Windows.Forms.Button btnListarfacturasp;
        private System.Windows.Forms.Panel pnlSubProductos;
        private System.Windows.Forms.Button btnRegistrarproductosp;
        private System.Windows.Forms.Button btnListarproductosp;
    }
}
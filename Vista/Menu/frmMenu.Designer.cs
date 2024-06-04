
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlMenuIzquierdo = new System.Windows.Forms.Panel();
            this.pnlSubmenus = new System.Windows.Forms.Panel();
            this.pnlFactura = new System.Windows.Forms.Panel();
            this.pnlProductos = new System.Windows.Forms.Panel();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.pnlInterfaz = new System.Windows.Forms.Panel();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenuIzquierdo.SuspendLayout();
            this.pnlSubmenus.SuspendLayout();
            this.pnlFactura.SuspendLayout();
            this.pnlProductos.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuIzquierdo
            // 
            this.pnlMenuIzquierdo.BackColor = System.Drawing.Color.Black;
            this.pnlMenuIzquierdo.Controls.Add(this.pnlSubmenus);
            this.pnlMenuIzquierdo.Controls.Add(this.pnlImagen);
            this.pnlMenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuIzquierdo.Name = "pnlMenuIzquierdo";
            this.pnlMenuIzquierdo.Size = new System.Drawing.Size(52, 668);
            this.pnlMenuIzquierdo.TabIndex = 0;
            // 
            // pnlSubmenus
            // 
            this.pnlSubmenus.Controls.Add(this.pnlFactura);
            this.pnlSubmenus.Controls.Add(this.pnlProductos);
            this.pnlSubmenus.Controls.Add(this.pnlClientes);
            this.pnlSubmenus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSubmenus.Location = new System.Drawing.Point(0, 52);
            this.pnlSubmenus.Name = "pnlSubmenus";
            this.pnlSubmenus.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlSubmenus.Size = new System.Drawing.Size(52, 616);
            this.pnlSubmenus.TabIndex = 1;
            // 
            // pnlFactura
            // 
            this.pnlFactura.Controls.Add(this.btnFactura);
            this.pnlFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFactura.Location = new System.Drawing.Point(0, 114);
            this.pnlFactura.Name = "pnlFactura";
            this.pnlFactura.Padding = new System.Windows.Forms.Padding(12);
            this.pnlFactura.Size = new System.Drawing.Size(52, 52);
            this.pnlFactura.TabIndex = 5;
            // 
            // pnlProductos
            // 
            this.pnlProductos.Controls.Add(this.btnProductos);
            this.pnlProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProductos.Location = new System.Drawing.Point(0, 62);
            this.pnlProductos.Name = "pnlProductos";
            this.pnlProductos.Padding = new System.Windows.Forms.Padding(12);
            this.pnlProductos.Size = new System.Drawing.Size(52, 52);
            this.pnlProductos.TabIndex = 4;
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.btnClientes);
            this.pnlClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlClientes.Location = new System.Drawing.Point(0, 10);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Padding = new System.Windows.Forms.Padding(12);
            this.pnlClientes.Size = new System.Drawing.Size(52, 52);
            this.pnlClientes.TabIndex = 3;
            // 
            // pnlImagen
            // 
            this.pnlImagen.Controls.Add(this.pbLogo);
            this.pnlImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Padding = new System.Windows.Forms.Padding(12);
            this.pnlImagen.Size = new System.Drawing.Size(52, 52);
            this.pnlImagen.TabIndex = 0;
            // 
            // pnlInterfaz
            // 
            this.pnlInterfaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInterfaz.Location = new System.Drawing.Point(52, 0);
            this.pnlInterfaz.Name = "pnlInterfaz";
            this.pnlInterfaz.Size = new System.Drawing.Size(1231, 668);
            this.pnlInterfaz.TabIndex = 1;
            // 
            // btnFactura
            // 
            this.btnFactura.BackgroundImage = global::SistemaFacturacion.Properties.Resources.factura_blanco;
            this.btnFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFactura.Location = new System.Drawing.Point(12, 12);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(28, 28);
            this.btnFactura.TabIndex = 2;
            this.btnFactura.UseVisualStyleBackColor = true;
            this.btnFactura.Click += new System.EventHandler(this.btnFactura_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackgroundImage = global::SistemaFacturacion.Properties.Resources.producto_blanco;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Location = new System.Drawing.Point(12, 12);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnProductos.Size = new System.Drawing.Size(28, 28);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::SistemaFacturacion.Properties.Resources.usuarios_blanco;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(12, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(28, 28);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::SistemaFacturacion.Properties.Resources.logo_mejorado4;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(28, 28);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
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
            this.Text = "Sistema de Facturación";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenuIzquierdo.ResumeLayout(false);
            this.pnlSubmenus.ResumeLayout(false);
            this.pnlFactura.ResumeLayout(false);
            this.pnlProductos.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuIzquierdo;
        private System.Windows.Forms.Panel pnlSubmenus;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Panel pnlInterfaz;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Panel pnlFactura;
        private System.Windows.Forms.Panel pnlProductos;
    }
}
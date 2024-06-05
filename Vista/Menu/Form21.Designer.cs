
namespace SistemaFacturacion.Vista.Menu
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Listar clientes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Clientes", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Productos");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Listar facturas");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Facturar");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Facturas", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Reportes");
            this.pnlMenuIzquierdo = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.tvOpciones = new System.Windows.Forms.TreeView();
            this.pnlInterfaz = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenuIzquierdo.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuIzquierdo
            // 
            this.pnlMenuIzquierdo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenuIzquierdo.Controls.Add(this.pnlOpciones);
            this.pnlMenuIzquierdo.Controls.Add(this.pnlLogo);
            this.pnlMenuIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuIzquierdo.Name = "pnlMenuIzquierdo";
            this.pnlMenuIzquierdo.Padding = new System.Windows.Forms.Padding(10);
            this.pnlMenuIzquierdo.Size = new System.Drawing.Size(196, 668);
            this.pnlMenuIzquierdo.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "usuarios_negro.png");
            this.imageList1.Images.SetKeyName(1, "retroceder.png");
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(10, 10);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(5);
            this.pnlLogo.Size = new System.Drawing.Size(176, 84);
            this.pnlLogo.TabIndex = 3;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOpciones.Controls.Add(this.tvOpciones);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOpciones.Location = new System.Drawing.Point(10, 94);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Padding = new System.Windows.Forms.Padding(10);
            this.pnlOpciones.Size = new System.Drawing.Size(176, 564);
            this.pnlOpciones.TabIndex = 4;
            // 
            // tvOpciones
            // 
            this.tvOpciones.BackColor = System.Drawing.SystemColors.Control;
            this.tvOpciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvOpciones.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvOpciones.ForeColor = System.Drawing.SystemColors.Desktop;
            this.tvOpciones.ImageIndex = 0;
            this.tvOpciones.ImageList = this.imageList1;
            this.tvOpciones.Location = new System.Drawing.Point(10, 10);
            this.tvOpciones.Name = "tvOpciones";
            treeNode1.Name = "nListarCliente";
            treeNode1.Tag = "0";
            treeNode1.Text = "Listar clientes";
            treeNode2.ImageKey = "retroceder.png";
            treeNode2.Name = "nClientes";
            treeNode2.Tag = "0";
            treeNode2.Text = "Clientes";
            treeNode3.Name = "nProductos";
            treeNode3.Tag = "0";
            treeNode3.Text = "Productos";
            treeNode4.Name = "nListarFactura";
            treeNode4.Text = "Listar facturas";
            treeNode5.Name = "nFacturar";
            treeNode5.Text = "Facturar";
            treeNode6.Name = "nFactura";
            treeNode6.Text = "Facturas";
            treeNode7.Name = "nReporte";
            treeNode7.Text = "Reportes";
            this.tvOpciones.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode6,
            treeNode7});
            this.tvOpciones.SelectedImageIndex = 0;
            this.tvOpciones.Size = new System.Drawing.Size(156, 544);
            this.tvOpciones.TabIndex = 1;
            this.tvOpciones.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvOpciones_NodeMouseClick);
            // 
            // pnlInterfaz
            // 
            this.pnlInterfaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInterfaz.Location = new System.Drawing.Point(196, 0);
            this.pnlInterfaz.Name = "pnlInterfaz";
            this.pnlInterfaz.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlInterfaz.Size = new System.Drawing.Size(1087, 668);
            this.pnlInterfaz.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::SistemaFacturacion.Properties.Resources.logo_mejorado4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(166, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 668);
            this.Controls.Add(this.pnlInterfaz);
            this.Controls.Add(this.pnlMenuIzquierdo);
            this.Name = "Form21";
            this.Text = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            this.pnlMenuIzquierdo.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenuIzquierdo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.TreeView tvOpciones;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlInterfaz;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace SistemaFacturacion.Vista.FrmLogIn
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogIn = new System.Windows.Forms.Panel();
            this.pnlLogInContenido = new System.Windows.Forms.Panel();
            this.pnlContenedorBusqueda = new System.Windows.Forms.Panel();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.pbContrasenia = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblEtiquetaUsuario = new System.Windows.Forms.Label();
            this.lblEtiquetaContrasenia = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlLogIn.SuspendLayout();
            this.pnlLogInContenido.SuspendLayout();
            this.pnlContenedorBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(117)))), ((int)(((byte)(198)))));
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Padding = new System.Windows.Forms.Padding(50);
            this.pnlLogo.Size = new System.Drawing.Size(523, 474);
            this.pnlLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::SistemaFacturacion.Properties.Resources.logo_mejorado4;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(50, 50);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(423, 374);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlLogIn
            // 
            this.pnlLogIn.Controls.Add(this.pnlLogInContenido);
            this.pnlLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogIn.Location = new System.Drawing.Point(523, 0);
            this.pnlLogIn.Name = "pnlLogIn";
            this.pnlLogIn.Size = new System.Drawing.Size(384, 474);
            this.pnlLogIn.TabIndex = 1;
            // 
            // pnlLogInContenido
            // 
            this.pnlLogInContenido.Controls.Add(this.pnlContenedorBusqueda);
            this.pnlLogInContenido.Controls.Add(this.pictureBox1);
            this.pnlLogInContenido.Controls.Add(this.btnIniciarSesion);
            this.pnlLogInContenido.Controls.Add(this.lblEtiquetaUsuario);
            this.pnlLogInContenido.Controls.Add(this.lblEtiquetaContrasenia);
            this.pnlLogInContenido.Controls.Add(this.txtUsuario);
            this.pnlLogInContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogInContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlLogInContenido.Name = "pnlLogInContenido";
            this.pnlLogInContenido.Size = new System.Drawing.Size(384, 474);
            this.pnlLogInContenido.TabIndex = 1;
            // 
            // pnlContenedorBusqueda
            // 
            this.pnlContenedorBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedorBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlContenedorBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContenedorBusqueda.Controls.Add(this.txtContrasenia);
            this.pnlContenedorBusqueda.Controls.Add(this.pbContrasenia);
            this.pnlContenedorBusqueda.Location = new System.Drawing.Point(140, 335);
            this.pnlContenedorBusqueda.Name = "pnlContenedorBusqueda";
            this.pnlContenedorBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.pnlContenedorBusqueda.Size = new System.Drawing.Size(223, 27);
            this.pnlContenedorBusqueda.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.White;
            this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContrasenia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(3, 3);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(185, 20);
            this.txtContrasenia.TabIndex = 9;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContrasenia_KeyPress);
            // 
            // pbContrasenia
            // 
            this.pbContrasenia.BackgroundImage = global::SistemaFacturacion.Properties.Resources.mostrar;
            this.pbContrasenia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbContrasenia.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbContrasenia.Location = new System.Drawing.Point(188, 3);
            this.pbContrasenia.Name = "pbContrasenia";
            this.pbContrasenia.Size = new System.Drawing.Size(30, 19);
            this.pbContrasenia.TabIndex = 0;
            this.pbContrasenia.TabStop = false;
            this.pbContrasenia.Click += new System.EventHandler(this.pbContrasenia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SistemaFacturacion.Properties.Resources.user;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(32, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 187);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(23, 396);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(340, 30);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // lblEtiquetaUsuario
            // 
            this.lblEtiquetaUsuario.AutoSize = true;
            this.lblEtiquetaUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaUsuario.Location = new System.Drawing.Point(28, 281);
            this.lblEtiquetaUsuario.Name = "lblEtiquetaUsuario";
            this.lblEtiquetaUsuario.Size = new System.Drawing.Size(69, 21);
            this.lblEtiquetaUsuario.TabIndex = 13;
            this.lblEtiquetaUsuario.Text = "Usuario:";
            // 
            // lblEtiquetaContrasenia
            // 
            this.lblEtiquetaContrasenia.AutoSize = true;
            this.lblEtiquetaContrasenia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaContrasenia.Location = new System.Drawing.Point(28, 337);
            this.lblEtiquetaContrasenia.Name = "lblEtiquetaContrasenia";
            this.lblEtiquetaContrasenia.Size = new System.Drawing.Size(96, 21);
            this.lblEtiquetaContrasenia.TabIndex = 14;
            this.lblEtiquetaContrasenia.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(140, 281);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(223, 26);
            this.txtUsuario.TabIndex = 2;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 474);
            this.Controls.Add(this.pnlLogIn);
            this.Controls.Add(this.pnlLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(923, 513);
            this.MinimumSize = new System.Drawing.Size(923, 513);
            this.Name = "frmLogIn";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlLogIn.ResumeLayout(false);
            this.pnlLogInContenido.ResumeLayout(false);
            this.pnlLogInContenido.PerformLayout();
            this.pnlContenedorBusqueda.ResumeLayout(false);
            this.pnlContenedorBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlLogIn;
        private System.Windows.Forms.Panel pnlLogInContenido;
        private System.Windows.Forms.Label lblEtiquetaUsuario;
        private System.Windows.Forms.Label lblEtiquetaContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlContenedorBusqueda;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.PictureBox pbContrasenia;
    }
}
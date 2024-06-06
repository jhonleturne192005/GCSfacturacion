
namespace SistemaFacturacion.Vista.Clientes
{
    partial class frmSeleccionarCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlDgvDatos = new System.Windows.Forms.Panel();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNumeroRegistros = new System.Windows.Forms.Label();
            this.lblTituloNumRegistros = new System.Windows.Forms.Label();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.btnPagAnterior = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPagSiguiente = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.pnlDgvDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1002, 54);
            this.pnlEncabezado.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.lblTitulo.Location = new System.Drawing.Point(15, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 25);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "SELECCIONAR CLIENTE";
            // 
            // pnlDgvDatos
            // 
            this.pnlDgvDatos.Controls.Add(this.btnSeleccionar);
            this.pnlDgvDatos.Controls.Add(this.button1);
            this.pnlDgvDatos.Controls.Add(this.lblNumeroRegistros);
            this.pnlDgvDatos.Controls.Add(this.lblTituloNumRegistros);
            this.pnlDgvDatos.Controls.Add(this.txtTextoBuscar);
            this.pnlDgvDatos.Controls.Add(this.btnPagAnterior);
            this.pnlDgvDatos.Controls.Add(this.dgvCliente);
            this.pnlDgvDatos.Controls.Add(this.btnPagSiguiente);
            this.pnlDgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDgvDatos.Location = new System.Drawing.Point(0, 54);
            this.pnlDgvDatos.Name = "pnlDgvDatos";
            this.pnlDgvDatos.Size = new System.Drawing.Size(1002, 538);
            this.pnlDgvDatos.TabIndex = 8;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(82)))), ((int)(((byte)(183)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(870, 19);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(112, 30);
            this.btnSeleccionar.TabIndex = 7;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SistemaFacturacion.Properties.Resources.buscar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.Location = new System.Drawing.Point(20, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 43);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblNumeroRegistros
            // 
            this.lblNumeroRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumeroRegistros.AutoSize = true;
            this.lblNumeroRegistros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumeroRegistros.Location = new System.Drawing.Point(96, 486);
            this.lblNumeroRegistros.Name = "lblNumeroRegistros";
            this.lblNumeroRegistros.Size = new System.Drawing.Size(74, 19);
            this.lblNumeroRegistros.TabIndex = 5;
            this.lblNumeroRegistros.Text = "0 registros";
            // 
            // lblTituloNumRegistros
            // 
            this.lblTituloNumRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloNumRegistros.AutoSize = true;
            this.lblTituloNumRegistros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTituloNumRegistros.Location = new System.Drawing.Point(12, 486);
            this.lblTituloNumRegistros.Name = "lblTituloNumRegistros";
            this.lblTituloNumRegistros.Size = new System.Drawing.Size(80, 19);
            this.lblTituloNumRegistros.TabIndex = 3;
            this.lblTituloNumRegistros.Text = "Mostrando:";
            // 
            // txtTextoBuscar
            // 
            this.txtTextoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextoBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoBuscar.Location = new System.Drawing.Point(68, 19);
            this.txtTextoBuscar.Multiline = true;
            this.txtTextoBuscar.Name = "txtTextoBuscar";
            this.txtTextoBuscar.Size = new System.Drawing.Size(703, 30);
            this.txtTextoBuscar.TabIndex = 1;
            this.txtTextoBuscar.Text = "Escriba un cliente a buscar..";
            // 
            // btnPagAnterior
            // 
            this.btnPagAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagAnterior.BackColor = System.Drawing.Color.White;
            this.btnPagAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagAnterior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagAnterior.Location = new System.Drawing.Point(807, 478);
            this.btnPagAnterior.Name = "btnPagAnterior";
            this.btnPagAnterior.Size = new System.Drawing.Size(83, 32);
            this.btnPagAnterior.TabIndex = 1;
            this.btnPagAnterior.Text = "Anterior";
            this.btnPagAnterior.UseVisualStyleBackColor = false;
            this.btnPagAnterior.Click += new System.EventHandler(this.btnPagAnterior_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCliente.ColumnHeadersHeight = 25;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdentificacion,
            this.txtApellidos,
            this.txtNombres});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCliente.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvCliente.Location = new System.Drawing.Point(16, 62);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(10, 10, 100, 10);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvCliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCliente.Size = new System.Drawing.Size(974, 373);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellEnter);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtIdentificacion.HeaderText = "Identificación";
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.ReadOnly = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtApellidos.HeaderText = "Apellidos";
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtNombres.HeaderText = "Nombres";
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            // 
            // btnPagSiguiente
            // 
            this.btnPagSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagSiguiente.BackColor = System.Drawing.Color.White;
            this.btnPagSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPagSiguiente.Location = new System.Drawing.Point(896, 478);
            this.btnPagSiguiente.Name = "btnPagSiguiente";
            this.btnPagSiguiente.Size = new System.Drawing.Size(86, 32);
            this.btnPagSiguiente.TabIndex = 6;
            this.btnPagSiguiente.Text = "Siguiente";
            this.btnPagSiguiente.UseVisualStyleBackColor = false;
            this.btnPagSiguiente.Click += new System.EventHandler(this.btnPagSiguiente_Click);
            // 
            // frmSeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 592);
            this.Controls.Add(this.pnlDgvDatos);
            this.Controls.Add(this.pnlEncabezado);
            this.Name = "frmSeleccionarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar cliente";
            this.Load += new System.EventHandler(this.frmSeleccionarCliente_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.pnlDgvDatos.ResumeLayout(false);
            this.pnlDgvDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDgvDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumeroRegistros;
        private System.Windows.Forms.Label lblTituloNumRegistros;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.Button btnPagAnterior;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnPagSiguiente;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombres;
    }
}
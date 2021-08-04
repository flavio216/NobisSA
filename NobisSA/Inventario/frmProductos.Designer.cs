
namespace NobisSA
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Listado = new System.Windows.Forms.TabPage();
            this.dtgProductoConStock = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCantidadConStock = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.txtBuscarStock = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.Mantenimiento = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecioText = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreText = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoText = new System.Windows.Forms.Label();
            this.SinStock = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkEliminarSinStock = new System.Windows.Forms.CheckBox();
            this.dtgProductoSinStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCantidadSinStock = new System.Windows.Forms.Label();
            this.txtBuscarSinStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Listado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductoConStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.Mantenimiento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SinStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductoSinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Listado);
            this.tabControl1.Controls.Add(this.Mantenimiento);
            this.tabControl1.Controls.Add(this.SinStock);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(23, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 515);
            this.tabControl1.TabIndex = 1;
            // 
            // Listado
            // 
            this.Listado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.Listado.Controls.Add(this.dtgProductoConStock);
            this.Listado.Controls.Add(this.lblCantidadConStock);
            this.Listado.Controls.Add(this.chkEliminar);
            this.Listado.Controls.Add(this.btnImprimir);
            this.Listado.Controls.Add(this.btnEliminar);
            this.Listado.Controls.Add(this.btnBuscar);
            this.Listado.Controls.Add(this.txtBuscarStock);
            this.Listado.Controls.Add(this.lblNombre);
            this.Listado.Location = new System.Drawing.Point(4, 26);
            this.Listado.Margin = new System.Windows.Forms.Padding(2);
            this.Listado.Name = "Listado";
            this.Listado.Padding = new System.Windows.Forms.Padding(2);
            this.Listado.Size = new System.Drawing.Size(895, 485);
            this.Listado.TabIndex = 0;
            this.Listado.Text = "Listado";
            // 
            // dtgProductoConStock
            // 
            this.dtgProductoConStock.AllowUserToAddRows = false;
            this.dtgProductoConStock.AllowUserToDeleteRows = false;
            this.dtgProductoConStock.AllowUserToOrderColumns = true;
            this.dtgProductoConStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductoConStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.dtgProductoConStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductoConStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dtgProductoConStock.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgProductoConStock.Location = new System.Drawing.Point(14, 98);
            this.dtgProductoConStock.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProductoConStock.MultiSelect = false;
            this.dtgProductoConStock.Name = "dtgProductoConStock";
            this.dtgProductoConStock.ReadOnly = true;
            this.dtgProductoConStock.RowHeadersWidth = 51;
            this.dtgProductoConStock.RowTemplate.Height = 24;
            this.dtgProductoConStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductoConStock.Size = new System.Drawing.Size(879, 384);
            this.dtgProductoConStock.TabIndex = 7;
            this.dtgProductoConStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductoConStock_CellContentClick);
            this.dtgProductoConStock.DoubleClick += new System.EventHandler(this.dtgProductoConStock_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // lblCantidadConStock
            // 
            this.lblCantidadConStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadConStock.AutoSize = true;
            this.lblCantidadConStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConStock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantidadConStock.Location = new System.Drawing.Point(687, 66);
            this.lblCantidadConStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadConStock.Name = "lblCantidadConStock";
            this.lblCantidadConStock.Size = new System.Drawing.Size(185, 19);
            this.lblCantidadConStock.TabIndex = 6;
            this.lblCantidadConStock.Text = "Cantidad de Registros: ";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEliminar.Location = new System.Drawing.Point(20, 66);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(90, 23);
            this.chkEliminar.TabIndex = 5;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnImprimir.Location = new System.Drawing.Point(757, 18);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(86, 27);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(631, 18);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 27);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(282, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 32);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.TabStop = false;
            // 
            // txtBuscarStock
            // 
            this.txtBuscarStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarStock.Location = new System.Drawing.Point(94, 22);
            this.txtBuscarStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarStock.Name = "txtBuscarStock";
            this.txtBuscarStock.Size = new System.Drawing.Size(226, 27);
            this.txtBuscarStock.TabIndex = 1;
            this.txtBuscarStock.TextChanged += new System.EventHandler(this.txtBuscarStock_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblNombre.Location = new System.Drawing.Point(17, 22);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // Mantenimiento
            // 
            this.Mantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.Mantenimiento.Controls.Add(this.groupBox1);
            this.Mantenimiento.Location = new System.Drawing.Point(4, 26);
            this.Mantenimiento.Margin = new System.Windows.Forms.Padding(2);
            this.Mantenimiento.Name = "Mantenimiento";
            this.Mantenimiento.Padding = new System.Windows.Forms.Padding(2);
            this.Mantenimiento.Size = new System.Drawing.Size(895, 485);
            this.Mantenimiento.TabIndex = 1;
            this.Mantenimiento.Text = "Mantenimiento";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.lblPrecioText);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombreText);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblCodigoText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(891, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(340, 312);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 88);
            this.btnCargar.TabIndex = 88;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(560, 312);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(108, 88);
            this.btnVolver.TabIndex = 87;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(448, 312);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(108, 88);
            this.btnBorrar.TabIndex = 86;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(232, 312);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 88);
            this.btnNuevo.TabIndex = 84;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Location = new System.Drawing.Point(278, 228);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(47, 23);
            this.txtStock.TabIndex = 45;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(196, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Stock:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Location = new System.Drawing.Point(279, 186);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(63, 23);
            this.txtPrecio.TabIndex = 44;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblPrecioText
            // 
            this.lblPrecioText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrecioText.AutoSize = true;
            this.lblPrecioText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrecioText.Location = new System.Drawing.Point(190, 186);
            this.lblPrecioText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioText.Name = "lblPrecioText";
            this.lblPrecioText.Size = new System.Drawing.Size(90, 19);
            this.lblPrecioText.TabIndex = 43;
            this.lblPrecioText.Text = "Precio:     $";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(278, 144);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(213, 23);
            this.txtNombre.TabIndex = 42;
            // 
            // lblNombreText
            // 
            this.lblNombreText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNombreText.AutoSize = true;
            this.lblNombreText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreText.Location = new System.Drawing.Point(173, 144);
            this.lblNombreText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreText.Name = "lblNombreText";
            this.lblNombreText.Size = new System.Drawing.Size(77, 19);
            this.lblNombreText.TabIndex = 41;
            this.lblNombreText.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.Location = new System.Drawing.Point(278, 102);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 23);
            this.txtCodigo.TabIndex = 40;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // lblCodigoText
            // 
            this.lblCodigoText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigoText.AutoSize = true;
            this.lblCodigoText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoText.Location = new System.Drawing.Point(179, 102);
            this.lblCodigoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoText.Name = "lblCodigoText";
            this.lblCodigoText.Size = new System.Drawing.Size(71, 19);
            this.lblCodigoText.TabIndex = 39;
            this.lblCodigoText.Text = "Codigo:";
            // 
            // SinStock
            // 
            this.SinStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.SinStock.Controls.Add(this.button2);
            this.SinStock.Controls.Add(this.button1);
            this.SinStock.Controls.Add(this.chkEliminarSinStock);
            this.SinStock.Controls.Add(this.dtgProductoSinStock);
            this.SinStock.Controls.Add(this.lblCantidadSinStock);
            this.SinStock.Controls.Add(this.txtBuscarSinStock);
            this.SinStock.Controls.Add(this.label3);
            this.SinStock.Controls.Add(this.pictureBox3);
            this.SinStock.Location = new System.Drawing.Point(4, 26);
            this.SinStock.Margin = new System.Windows.Forms.Padding(2);
            this.SinStock.Name = "SinStock";
            this.SinStock.Padding = new System.Windows.Forms.Padding(2);
            this.SinStock.Size = new System.Drawing.Size(895, 485);
            this.SinStock.TabIndex = 2;
            this.SinStock.Text = "Sin Stock";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(589, 17);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 27);
            this.button2.TabIndex = 18;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(703, 17);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkEliminarSinStock
            // 
            this.chkEliminarSinStock.AutoSize = true;
            this.chkEliminarSinStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminarSinStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEliminarSinStock.Location = new System.Drawing.Point(16, 61);
            this.chkEliminarSinStock.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminarSinStock.Name = "chkEliminarSinStock";
            this.chkEliminarSinStock.Size = new System.Drawing.Size(90, 23);
            this.chkEliminarSinStock.TabIndex = 16;
            this.chkEliminarSinStock.Text = "Eliminar";
            this.chkEliminarSinStock.UseVisualStyleBackColor = true;
            this.chkEliminarSinStock.CheckedChanged += new System.EventHandler(this.chkEliminarSinStock_CheckedChanged);
            // 
            // dtgProductoSinStock
            // 
            this.dtgProductoSinStock.AllowUserToAddRows = false;
            this.dtgProductoSinStock.AllowUserToDeleteRows = false;
            this.dtgProductoSinStock.AllowUserToOrderColumns = true;
            this.dtgProductoSinStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProductoSinStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.dtgProductoSinStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductoSinStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dtgProductoSinStock.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgProductoSinStock.Location = new System.Drawing.Point(12, 97);
            this.dtgProductoSinStock.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProductoSinStock.MultiSelect = false;
            this.dtgProductoSinStock.Name = "dtgProductoSinStock";
            this.dtgProductoSinStock.ReadOnly = true;
            this.dtgProductoSinStock.RowHeadersWidth = 51;
            this.dtgProductoSinStock.RowTemplate.Height = 24;
            this.dtgProductoSinStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProductoSinStock.Size = new System.Drawing.Size(879, 384);
            this.dtgProductoSinStock.TabIndex = 15;
            this.dtgProductoSinStock.DoubleClick += new System.EventHandler(this.dtgProductoSinStock_DoubleClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // lblCantidadSinStock
            // 
            this.lblCantidadSinStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadSinStock.AutoSize = true;
            this.lblCantidadSinStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadSinStock.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantidadSinStock.Location = new System.Drawing.Point(475, 65);
            this.lblCantidadSinStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadSinStock.Name = "lblCantidadSinStock";
            this.lblCantidadSinStock.Size = new System.Drawing.Size(185, 19);
            this.lblCantidadSinStock.TabIndex = 14;
            this.lblCantidadSinStock.Text = "Cantidad de Registros: ";
            // 
            // txtBuscarSinStock
            // 
            this.txtBuscarSinStock.Location = new System.Drawing.Point(90, 17);
            this.txtBuscarSinStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarSinStock.Name = "txtBuscarSinStock";
            this.txtBuscarSinStock.Size = new System.Drawing.Size(194, 23);
            this.txtBuscarSinStock.TabIndex = 9;
            this.txtBuscarSinStock.TextChanged += new System.EventHandler(this.txtBuscarSinStock_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(22, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(288, 10);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(955, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmProductos";
            this.Text = "frmInventario";
            this.tabControl1.ResumeLayout(false);
            this.Listado.ResumeLayout(false);
            this.Listado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductoConStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.Mantenimiento.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SinStock.ResumeLayout(false);
            this.SinStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductoSinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Listado;
        private System.Windows.Forms.DataGridView dtgProductoConStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblCantidadConStock;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarStock;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage Mantenimiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecioText;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreText;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoText;
        private System.Windows.Forms.TabPage SinStock;
        private System.Windows.Forms.Label lblCantidadSinStock;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBuscarSinStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkEliminarSinStock;
        private System.Windows.Forms.DataGridView dtgProductoSinStock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
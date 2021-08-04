
namespace NobisSA.Envios
{
    partial class frmEnvios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvios));
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBorrarLista = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgvEnvios = new System.Windows.Forms.DataGridView();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.lblCodigoText = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCantidadRegistros = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.dtgEnvioSucu = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCantidaddeRegistros = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblEnvios = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEnvios)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnvioSucu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.lblSubTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubTotal.Location = new System.Drawing.Point(90, 491);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(124, 25);
            this.lblSubTotal.TabIndex = 97;
            this.lblSubTotal.Text = "#######";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 96;
            this.label1.Text = "Total:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 549);
            this.tabControl1.TabIndex = 105;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.cmbSucursal);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbl);
            this.tabPage2.Controls.Add(this.btnEnviar);
            this.tabPage2.Controls.Add(this.btnQuitar);
            this.tabPage2.Controls.Add(this.btnBorrarLista);
            this.tabPage2.Controls.Add(this.btnLimpiar);
            this.tabPage2.Controls.Add(this.btnAgregar);
            this.tabPage2.Controls.Add(this.txtCantidad);
            this.tabPage2.Controls.Add(this.txtID);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.dtpFechaEnvio);
            this.tabPage2.Controls.Add(this.lblCodigoText);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(918, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cargar Envios";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(195, 119);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 188;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(198, 149);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(162, 27);
            this.cmbSucursal.TabIndex = 187;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(97, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 186;
            this.label2.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(102, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 185;
            this.label4.Text = "Sucursal:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(105, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 184;
            this.label3.Text = "Nombre:";
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl.Location = new System.Drawing.Point(64, 81);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(108, 16);
            this.lbl.TabIndex = 183;
            this.lbl.Text = "Buscar codigo:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 15.25F);
            this.btnEnviar.Location = new System.Drawing.Point(554, 62);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(215, 167);
            this.btnEnviar.TabIndex = 181;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnQuitar.Location = new System.Drawing.Point(714, 253);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(136, 34);
            this.btnQuitar.TabIndex = 180;
            this.btnQuitar.Text = "Quitar Item";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnBorrarLista
            // 
            this.btnBorrarLista.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnBorrarLista.Location = new System.Drawing.Point(714, 393);
            this.btnBorrarLista.Name = "btnBorrarLista";
            this.btnBorrarLista.Size = new System.Drawing.Size(134, 34);
            this.btnBorrarLista.TabIndex = 179;
            this.btnBorrarLista.Text = "Borrar Lista";
            this.btnBorrarLista.UseVisualStyleBackColor = true;
            this.btnBorrarLista.Click += new System.EventHandler(this.btnBorrarLista_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(417, 171);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(61, 56);
            this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLimpiar.TabIndex = 178;
            this.btnLimpiar.TabStop = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(417, 80);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(61, 56);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAgregar.TabIndex = 177;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(198, 189);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 27);
            this.txtCantidad.TabIndex = 176;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(198, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 27);
            this.txtID.TabIndex = 175;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgvEnvios);
            this.panel4.Location = new System.Drawing.Point(44, 253);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(643, 174);
            this.panel4.TabIndex = 182;
            // 
            // dtgvEnvios
            // 
            this.dtgvEnvios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEnvios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.dtgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEnvios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvEnvios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.dtgvEnvios.Location = new System.Drawing.Point(0, 0);
            this.dtgvEnvios.Name = "dtgvEnvios";
            this.dtgvEnvios.RowHeadersWidth = 51;
            this.dtgvEnvios.Size = new System.Drawing.Size(643, 174);
            this.dtgvEnvios.TabIndex = 7;
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.Location = new System.Drawing.Point(611, 17);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(212, 27);
            this.dtpFechaEnvio.TabIndex = 174;
            // 
            // lblCodigoText
            // 
            this.lblCodigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodigoText.AutoSize = true;
            this.lblCodigoText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoText.Location = new System.Drawing.Point(540, 23);
            this.lblCodigoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoText.Name = "lblCodigoText";
            this.lblCodigoText.Size = new System.Drawing.Size(66, 19);
            this.lblCodigoText.TabIndex = 163;
            this.lblCodigoText.Text = "Fecha: ";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.tabPage1.Controls.Add(this.lblCantidadRegistros);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.dtgEnvioSucu);
            this.tabPage1.Controls.Add(this.lblCantidaddeRegistros);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lblEnvios);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(918, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Envios";
            // 
            // lblCantidadRegistros
            // 
            this.lblCantidadRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidadRegistros.AutoSize = true;
            this.lblCantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCantidadRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantidadRegistros.Location = new System.Drawing.Point(617, 104);
            this.lblCantidadRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidadRegistros.Name = "lblCantidadRegistros";
            this.lblCantidadRegistros.Size = new System.Drawing.Size(179, 17);
            this.lblCantidadRegistros.TabIndex = 64;
            this.lblCantidadRegistros.Text = "Cantidad de Registros: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBuscar.Location = new System.Drawing.Point(132, 50);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(209, 23);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscarTramite_TextChanged);
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEliminar.Location = new System.Drawing.Point(20, 98);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(90, 23);
            this.chkEliminar.TabIndex = 17;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // dtgEnvioSucu
            // 
            this.dtgEnvioSucu.AllowUserToAddRows = false;
            this.dtgEnvioSucu.AllowUserToDeleteRows = false;
            this.dtgEnvioSucu.AllowUserToOrderColumns = true;
            this.dtgEnvioSucu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgEnvioSucu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.dtgEnvioSucu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEnvioSucu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dtgEnvioSucu.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgEnvioSucu.Location = new System.Drawing.Point(14, 123);
            this.dtgEnvioSucu.Margin = new System.Windows.Forms.Padding(2);
            this.dtgEnvioSucu.MultiSelect = false;
            this.dtgEnvioSucu.Name = "dtgEnvioSucu";
            this.dtgEnvioSucu.ReadOnly = true;
            this.dtgEnvioSucu.RowHeadersWidth = 51;
            this.dtgEnvioSucu.RowTemplate.Height = 24;
            this.dtgEnvioSucu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEnvioSucu.Size = new System.Drawing.Size(874, 352);
            this.dtgEnvioSucu.TabIndex = 15;
            this.dtgEnvioSucu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEnvioSucu_CellContentClick);
            this.dtgEnvioSucu.DoubleClick += new System.EventHandler(this.dtgEnvioSucu_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // lblCantidaddeRegistros
            // 
            this.lblCantidaddeRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidaddeRegistros.AutoSize = true;
            this.lblCantidaddeRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCantidaddeRegistros.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCantidaddeRegistros.Location = new System.Drawing.Point(-271, 496);
            this.lblCantidaddeRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidaddeRegistros.Name = "lblCantidaddeRegistros";
            this.lblCantidaddeRegistros.Size = new System.Drawing.Size(179, 17);
            this.lblCantidaddeRegistros.TabIndex = 14;
            this.lblCantidaddeRegistros.Text = "Cantidad de Registros: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(719, 48);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 38);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(345, 33);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(41, 44);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.TabStop = false;
            // 
            // lblEnvios
            // 
            this.lblEnvios.AutoSize = true;
            this.lblEnvios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvios.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblEnvios.Location = new System.Drawing.Point(17, 48);
            this.lblEnvios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEnvios.Name = "lblEnvios";
            this.lblEnvios.Size = new System.Drawing.Size(111, 19);
            this.lblEnvios.TabIndex = 8;
            this.lblEnvios.Text = "Buscar envio:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(117, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 38);
            this.label5.TabIndex = 189;
            this.label5.Text = "PRODUCTOS";
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(955, 578);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmEnvios";
            this.Text = "frmEnvios";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEnvios)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEnvioSucu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrarLista;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgvEnvios;
        private System.Windows.Forms.DateTimePicker dtpFechaEnvio;
        private System.Windows.Forms.Label lblCodigoText;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.DataGridView dtgEnvioSucu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblCantidaddeRegistros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblEnvios;
        private System.Windows.Forms.Label lblCantidadRegistros;
        private System.Windows.Forms.Label label5;
    }
}
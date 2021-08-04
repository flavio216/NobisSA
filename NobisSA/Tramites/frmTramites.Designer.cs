
namespace NobisSA
{
    partial class frmTramites
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTramites));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.btnBuscarPDFs = new System.Windows.Forms.Button();
            this.btnAbrirPdfs = new System.Windows.Forms.Button();
            this.txtPdf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtNroTramite = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.cmbTipoTramite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.pbAgente = new System.Windows.Forms.PictureBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaAuditado = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaActual = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoText = new System.Windows.Forms.Label();
            this.pbSucursales = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCarga = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscarTramite = new System.Windows.Forms.TextBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.dtgTramite = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCantidaddeRegistros = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblApellidoBuscar = new System.Windows.Forms.Label();
            this.OFDpdf = new System.Windows.Forms.OpenFileDialog();
            this.errorCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEnviarMail = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSucursales)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 541);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.tabPage2.Controls.Add(this.lblNombres);
            this.tabPage2.Controls.Add(this.lblApellidos);
            this.tabPage2.Controls.Add(this.btnBuscarPDFs);
            this.tabPage2.Controls.Add(this.btnAbrirPdfs);
            this.tabPage2.Controls.Add(this.txtPdf);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnRechazar);
            this.tabPage2.Controls.Add(this.btnBorrar);
            this.tabPage2.Controls.Add(this.txtNroTramite);
            this.tabPage2.Controls.Add(this.cmbTipoPago);
            this.tabPage2.Controls.Add(this.btnAutorizar);
            this.tabPage2.Controls.Add(this.cmbTipoTramite);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbAgente);
            this.tabPage2.Controls.Add(this.cmbSucursal);
            this.tabPage2.Controls.Add(this.pbAgente);
            this.tabPage2.Controls.Add(this.txtObservacion);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtpFechaAuditado);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dtpFechaActual);
            this.tabPage2.Controls.Add(this.txtDescripcion);
            this.tabPage2.Controls.Add(this.lblTelefono);
            this.tabPage2.Controls.Add(this.lblLocalidad);
            this.tabPage2.Controls.Add(this.lblDireccion);
            this.tabPage2.Controls.Add(this.Documento);
            this.tabPage2.Controls.Add(this.txtDocumento);
            this.tabPage2.Controls.Add(this.lblApellido);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.lblCodigoText);
            this.tabPage2.Controls.Add(this.pbSucursales);
            this.tabPage2.Controls.Add(this.btnSalir);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnCarga);
            this.tabPage2.Controls.Add(this.txtEstado);
            this.tabPage2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(911, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cargar Tramite";
            // 
            // lblNombres
            // 
            this.lblNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombres.Location = new System.Drawing.Point(163, 139);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(73, 19);
            this.lblNombres.TabIndex = 196;
            this.lblNombres.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellidos.Location = new System.Drawing.Point(163, 188);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(75, 19);
            this.lblApellidos.TabIndex = 195;
            this.lblApellidos.Text = "Apellido";
            // 
            // btnBuscarPDFs
            // 
            this.btnBuscarPDFs.Location = new System.Drawing.Point(812, 420);
            this.btnBuscarPDFs.Name = "btnBuscarPDFs";
            this.btnBuscarPDFs.Size = new System.Drawing.Size(28, 21);
            this.btnBuscarPDFs.TabIndex = 194;
            this.btnBuscarPDFs.Text = "...";
            this.btnBuscarPDFs.UseVisualStyleBackColor = true;
            this.btnBuscarPDFs.Click += new System.EventHandler(this.btnBuscarPDFs_Click);
            // 
            // btnAbrirPdfs
            // 
            this.btnAbrirPdfs.Location = new System.Drawing.Point(564, 447);
            this.btnAbrirPdfs.Name = "btnAbrirPdfs";
            this.btnAbrirPdfs.Size = new System.Drawing.Size(243, 27);
            this.btnAbrirPdfs.TabIndex = 193;
            this.btnAbrirPdfs.Text = "Abrir PDF";
            this.btnAbrirPdfs.UseVisualStyleBackColor = true;
            this.btnAbrirPdfs.Click += new System.EventHandler(this.btnAbrirPdfs_Click);
            // 
            // txtPdf
            // 
            this.txtPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPdf.Location = new System.Drawing.Point(581, 411);
            this.txtPdf.Margin = new System.Windows.Forms.Padding(2);
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.Size = new System.Drawing.Size(210, 27);
            this.txtPdf.TabIndex = 192;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(54, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 19);
            this.label5.TabIndex = 191;
            this.label5.Text = "Nro Tramite:";
            // 
            // btnRechazar
            // 
            this.btnRechazar.BackColor = System.Drawing.Color.Red;
            this.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRechazar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRechazar.Location = new System.Drawing.Point(574, 345);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(197, 61);
            this.btnRechazar.TabIndex = 190;
            this.btnRechazar.Text = "RECHAZADO";
            this.btnRechazar.UseVisualStyleBackColor = false;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(304, 383);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBorrar.Size = new System.Drawing.Size(108, 88);
            this.btnBorrar.TabIndex = 189;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtNroTramite
            // 
            this.txtNroTramite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNroTramite.Location = new System.Drawing.Point(167, 37);
            this.txtNroTramite.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroTramite.Name = "txtNroTramite";
            this.txtNroTramite.Size = new System.Drawing.Size(120, 27);
            this.txtNroTramite.TabIndex = 187;
            this.txtNroTramite.TextChanged += new System.EventHandler(this.txtNroTramite_TextChanged);
            this.txtNroTramite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTramite_KeyPress);
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(167, 277);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(209, 27);
            this.cmbTipoPago.TabIndex = 186;
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.BackColor = System.Drawing.Color.Lime;
            this.btnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutorizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutorizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAutorizar.Location = new System.Drawing.Point(573, 345);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(190, 61);
            this.btnAutorizar.TabIndex = 185;
            this.btnAutorizar.Text = "AUTORIZADO";
            this.btnAutorizar.UseVisualStyleBackColor = false;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // cmbTipoTramite
            // 
            this.cmbTipoTramite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoTramite.FormattingEnabled = true;
            this.cmbTipoTramite.Location = new System.Drawing.Point(167, 229);
            this.cmbTipoTramite.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoTramite.Name = "cmbTipoTramite";
            this.cmbTipoTramite.Size = new System.Drawing.Size(209, 27);
            this.cmbTipoTramite.TabIndex = 184;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(52, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 183;
            this.label2.Text = "Tipo tramite:";
            // 
            // cmbAgente
            // 
            this.cmbAgente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(599, 136);
            this.cmbAgente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(209, 27);
            this.cmbAgente.TabIndex = 182;
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(599, 91);
            this.cmbSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(209, 27);
            this.cmbSucursal.TabIndex = 181;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged_1);
            // 
            // pbAgente
            // 
            this.pbAgente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgente.Image = ((System.Drawing.Image)(resources.GetObject("pbAgente.Image")));
            this.pbAgente.Location = new System.Drawing.Point(812, 126);
            this.pbAgente.Margin = new System.Windows.Forms.Padding(2);
            this.pbAgente.Name = "pbAgente";
            this.pbAgente.Size = new System.Drawing.Size(56, 37);
            this.pbAgente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgente.TabIndex = 180;
            this.pbAgente.TabStop = false;
            this.pbAgente.Click += new System.EventHandler(this.pbAgente_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtObservacion.Location = new System.Drawing.Point(598, 281);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(210, 35);
            this.txtObservacion.TabIndex = 178;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(467, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 179;
            this.label4.Text = "Observacion:";
            // 
            // dtpFechaAuditado
            // 
            this.dtpFechaAuditado.Location = new System.Drawing.Point(599, 229);
            this.dtpFechaAuditado.Name = "dtpFechaAuditado";
            this.dtpFechaAuditado.Size = new System.Drawing.Size(212, 27);
            this.dtpFechaAuditado.TabIndex = 177;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(442, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 176;
            this.label3.Text = "Fecha Auditado:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(511, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 175;
            this.label1.Text = "Agente:";
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Location = new System.Drawing.Point(599, 17);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(212, 27);
            this.dtpFechaActual.TabIndex = 174;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcion.Location = new System.Drawing.Point(167, 326);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 27);
            this.txtDescripcion.TabIndex = 162;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefono.Location = new System.Drawing.Point(85, 326);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 19);
            this.lblTelefono.TabIndex = 173;
            this.lblTelefono.Text = "Tramite:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocalidad.Location = new System.Drawing.Point(504, 94);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(77, 19);
            this.lblLocalidad.TabIndex = 171;
            this.lblLocalidad.Text = "Sucursal:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(22, 276);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(133, 19);
            this.lblDireccion.TabIndex = 170;
            this.lblDireccion.Text = "Forma de Pago:";
            // 
            // Documento
            // 
            this.Documento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Documento.AutoSize = true;
            this.Documento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Documento.Location = new System.Drawing.Point(115, 91);
            this.Documento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(40, 19);
            this.Documento.TabIndex = 169;
            this.Documento.Text = "DNI:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDocumento.Location = new System.Drawing.Point(167, 89);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(209, 27);
            this.txtDocumento.TabIndex = 161;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(76, 188);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(83, 19);
            this.lblApellido.TabIndex = 165;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(78, 136);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 164;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigoText
            // 
            this.lblCodigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodigoText.AutoSize = true;
            this.lblCodigoText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoText.Location = new System.Drawing.Point(536, 23);
            this.lblCodigoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoText.Name = "lblCodigoText";
            this.lblCodigoText.Size = new System.Drawing.Size(58, 19);
            this.lblCodigoText.TabIndex = 163;
            this.lblCodigoText.Text = "Fecha";
            // 
            // pbSucursales
            // 
            this.pbSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSucursales.Image = ((System.Drawing.Image)(resources.GetObject("pbSucursales.Image")));
            this.pbSucursales.Location = new System.Drawing.Point(812, 80);
            this.pbSucursales.Margin = new System.Windows.Forms.Padding(2);
            this.pbSucursales.Name = "pbSucursales";
            this.pbSucursales.Size = new System.Drawing.Size(56, 38);
            this.pbSucursales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSucursales.TabIndex = 172;
            this.pbSucursales.TabStop = false;
            this.pbSucursales.Click += new System.EventHandler(this.pbSucursales_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(448, 383);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 88);
            this.btnSalir.TabIndex = 168;
            this.btnSalir.Text = "Volver";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(16, 383);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 88);
            this.btnNuevo.TabIndex = 167;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCarga
            // 
            this.btnCarga.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCarga.FlatAppearance.BorderSize = 0;
            this.btnCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarga.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarga.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCarga.Image = ((System.Drawing.Image)(resources.GetObject("btnCarga.Image")));
            this.btnCarga.Location = new System.Drawing.Point(160, 383);
            this.btnCarga.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarga.Name = "btnCarga";
            this.btnCarga.Size = new System.Drawing.Size(108, 88);
            this.btnCarga.TabIndex = 166;
            this.btnCarga.Text = "Cargar";
            this.btnCarga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCarga.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCarga.UseVisualStyleBackColor = true;
            this.btnCarga.Click += new System.EventHandler(this.btnCarga_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(839, 293);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(38, 27);
            this.txtEstado.TabIndex = 158;
            this.txtEstado.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.tabPage1.Controls.Add(this.btnEnviarMail);
            this.tabPage1.Controls.Add(this.txtBuscarTramite);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.dtgTramite);
            this.tabPage1.Controls.Add(this.lblCantidaddeRegistros);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lblApellidoBuscar);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(911, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar Tramite";
            // 
            // txtBuscarTramite
            // 
            this.txtBuscarTramite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBuscarTramite.Location = new System.Drawing.Point(108, 48);
            this.txtBuscarTramite.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarTramite.Name = "txtBuscarTramite";
            this.txtBuscarTramite.Size = new System.Drawing.Size(209, 23);
            this.txtBuscarTramite.TabIndex = 18;
            this.txtBuscarTramite.TextChanged += new System.EventHandler(this.txtBuscarTramite_TextChanged);
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEliminar.Location = new System.Drawing.Point(20, 98);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(120, 23);
            this.chkEliminar.TabIndex = 17;
            this.chkEliminar.Text = "Seleccionar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // dtgTramite
            // 
            this.dtgTramite.AllowUserToAddRows = false;
            this.dtgTramite.AllowUserToDeleteRows = false;
            this.dtgTramite.AllowUserToOrderColumns = true;
            this.dtgTramite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTramite.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.dtgTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTramite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dtgTramite.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgTramite.Location = new System.Drawing.Point(14, 123);
            this.dtgTramite.Margin = new System.Windows.Forms.Padding(2);
            this.dtgTramite.MultiSelect = false;
            this.dtgTramite.Name = "dtgTramite";
            this.dtgTramite.ReadOnly = true;
            this.dtgTramite.RowHeadersWidth = 51;
            this.dtgTramite.RowTemplate.Height = 24;
            this.dtgTramite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTramite.Size = new System.Drawing.Size(874, 351);
            this.dtgTramite.TabIndex = 15;
            this.dtgTramite.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgTramite_CellContentClick);
            this.dtgTramite.DoubleClick += new System.EventHandler(this.dtgTramite_DoubleClick);
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
            this.btnBuscar.Location = new System.Drawing.Point(321, 48);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(36, 29);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblApellidoBuscar
            // 
            this.lblApellidoBuscar.AutoSize = true;
            this.lblApellidoBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellidoBuscar.Location = new System.Drawing.Point(17, 48);
            this.lblApellidoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoBuscar.Name = "lblApellidoBuscar";
            this.lblApellidoBuscar.Size = new System.Drawing.Size(70, 19);
            this.lblApellidoBuscar.TabIndex = 8;
            this.lblApellidoBuscar.Text = "Tramite:";
            this.lblApellidoBuscar.Click += new System.EventHandler(this.lblApellidoBuscar_Click);
            // 
            // OFDpdf
            // 
            this.OFDpdf.FileName = "OFD_pdf";
            // 
            // errorCliente
            // 
            this.errorCliente.ContainerControl = this;
            // 
            // btnEnviarMail
            // 
            this.btnEnviarMail.Location = new System.Drawing.Point(615, 50);
            this.btnEnviarMail.Name = "btnEnviarMail";
            this.btnEnviarMail.Size = new System.Drawing.Size(99, 38);
            this.btnEnviarMail.TabIndex = 20;
            this.btnEnviarMail.Text = "Enviar Mail";
            this.btnEnviarMail.UseVisualStyleBackColor = true;
            this.btnEnviarMail.Click += new System.EventHandler(this.btnEnviarMail_Click);
            // 
            // frmTramites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(955, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTramites";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTramites_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSucursales)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgTramite;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblCantidaddeRegistros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblApellidoBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.TextBox txtBuscarTramite;
        private System.Windows.Forms.OpenFileDialog OFDpdf;
        private System.Windows.Forms.Button btnBuscarPDFs;
        private System.Windows.Forms.Button btnAbrirPdfs;
        private System.Windows.Forms.TextBox txtPdf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRechazar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtNroTramite;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.ComboBox cmbTipoTramite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAgente;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.PictureBox pbAgente;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaAuditado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label Documento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoText;
        private System.Windows.Forms.PictureBox pbSucursales;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCarga;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.ErrorProvider errorCliente;
        private System.Windows.Forms.Button btnEnviarMail;
    }
}


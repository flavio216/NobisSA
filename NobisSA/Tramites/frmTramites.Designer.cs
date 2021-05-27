
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTramites));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNroTramite = new System.Windows.Forms.TextBox();
            this.cmbTipoPago = new System.Windows.Forms.ComboBox();
            this.btnRechazado = new System.Windows.Forms.Button();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTipoTramite = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAgente = new System.Windows.Forms.ComboBox();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.pbAgentes = new System.Windows.Forms.PictureBox();
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigoText = new System.Windows.Forms.Label();
            this.pbSucursal = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscarTramite = new System.Windows.Forms.TextBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.dtgTramite = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCantidaddeRegistros = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.lblApellidoBuscar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSucursal)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1186, 541);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tabPage2.Controls.Add(this.txtEstado);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.txtNroTramite);
            this.tabPage2.Controls.Add(this.cmbTipoPago);
            this.tabPage2.Controls.Add(this.btnRechazado);
            this.tabPage2.Controls.Add(this.btnAutorizar);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cmbTipoTramite);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cmbAgente);
            this.tabPage2.Controls.Add(this.cmbSucursal);
            this.tabPage2.Controls.Add(this.pbAgentes);
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
            this.tabPage2.Controls.Add(this.txtApellido);
            this.tabPage2.Controls.Add(this.lblApellido);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.lblNombre);
            this.tabPage2.Controls.Add(this.lblCodigoText);
            this.tabPage2.Controls.Add(this.pbSucursal);
            this.tabPage2.Controls.Add(this.btnBorrar);
            this.tabPage2.Controls.Add(this.btnSalir);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.btnVolver);
            this.tabPage2.Controls.Add(this.btnCargar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1178, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cargar Tramite";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEstado.Location = new System.Drawing.Point(950, 141);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(209, 20);
            this.txtEstado.TabIndex = 116;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(437, 408);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 88);
            this.button2.TabIndex = 115;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(155, 414);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(65, 82);
            this.btnEditar.TabIndex = 114;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNroTramite
            // 
            this.txtNroTramite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNroTramite.Location = new System.Drawing.Point(142, 24);
            this.txtNroTramite.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroTramite.Name = "txtNroTramite";
            this.txtNroTramite.Size = new System.Drawing.Size(209, 20);
            this.txtNroTramite.TabIndex = 113;
            // 
            // cmbTipoPago
            // 
            this.cmbTipoPago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoPago.FormattingEnabled = true;
            this.cmbTipoPago.Location = new System.Drawing.Point(143, 289);
            this.cmbTipoPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoPago.Name = "cmbTipoPago";
            this.cmbTipoPago.Size = new System.Drawing.Size(209, 21);
            this.cmbTipoPago.TabIndex = 112;
            // 
            // btnRechazado
            // 
            this.btnRechazado.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnRechazado.Image = ((System.Drawing.Image)(resources.GetObject("btnRechazado.Image")));
            this.btnRechazado.Location = new System.Drawing.Point(489, 322);
            this.btnRechazado.Name = "btnRechazado";
            this.btnRechazado.Size = new System.Drawing.Size(174, 47);
            this.btnRechazado.TabIndex = 111;
            this.btnRechazado.Text = "Rechazar";
            this.btnRechazado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRechazado.UseVisualStyleBackColor = true;
            this.btnRechazado.Click += new System.EventHandler(this.btnRechazado_Click);
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAutorizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAutorizar.Image")));
            this.btnAutorizar.Location = new System.Drawing.Point(489, 322);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(174, 47);
            this.btnAutorizar.TabIndex = 110;
            this.btnAutorizar.Text = "Autorizado";
            this.btnAutorizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutorizar.UseVisualStyleBackColor = true;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 66);
            this.button1.TabIndex = 109;
            this.button1.Text = "Descargar PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoTramite
            // 
            this.cmbTipoTramite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoTramite.FormattingEnabled = true;
            this.cmbTipoTramite.Location = new System.Drawing.Point(143, 228);
            this.cmbTipoTramite.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoTramite.Name = "cmbTipoTramite";
            this.cmbTipoTramite.Size = new System.Drawing.Size(209, 21);
            this.cmbTipoTramite.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Tipo tramite:";
            // 
            // cmbAgente
            // 
            this.cmbAgente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAgente.FormattingEnabled = true;
            this.cmbAgente.Location = new System.Drawing.Point(531, 156);
            this.cmbAgente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAgente.Name = "cmbAgente";
            this.cmbAgente.Size = new System.Drawing.Size(209, 21);
            this.cmbAgente.TabIndex = 106;
            this.cmbAgente.SelectedIndexChanged += new System.EventHandler(this.cmbAgente_SelectedIndexChanged);
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(531, 95);
            this.cmbSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(209, 21);
            this.cmbSucursal.TabIndex = 105;
            this.cmbSucursal.SelectedIndexChanged += new System.EventHandler(this.cmbSucursal_SelectedIndexChanged);
            // 
            // pbAgentes
            // 
            this.pbAgentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAgentes.Image = ((System.Drawing.Image)(resources.GetObject("pbAgentes.Image")));
            this.pbAgentes.Location = new System.Drawing.Point(743, 136);
            this.pbAgentes.Margin = new System.Windows.Forms.Padding(2);
            this.pbAgentes.Name = "pbAgentes";
            this.pbAgentes.Size = new System.Drawing.Size(57, 59);
            this.pbAgentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAgentes.TabIndex = 101;
            this.pbAgentes.TabStop = false;
            this.pbAgentes.Click += new System.EventHandler(this.pbAgentes_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtObservacion.Location = new System.Drawing.Point(530, 285);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(210, 20);
            this.txtObservacion.TabIndex = 99;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(421, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 100;
            this.label4.Text = "Observacion:";
            // 
            // dtpFechaAuditado
            // 
            this.dtpFechaAuditado.Location = new System.Drawing.Point(528, 225);
            this.dtpFechaAuditado.Name = "dtpFechaAuditado";
            this.dtpFechaAuditado.Size = new System.Drawing.Size(212, 20);
            this.dtpFechaAuditado.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(396, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 97;
            this.label3.Text = "Fecha Auditado:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(457, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Agente:";
            // 
            // dtpFechaActual
            // 
            this.dtpFechaActual.Location = new System.Drawing.Point(585, 21);
            this.dtpFechaActual.Name = "dtpFechaActual";
            this.dtpFechaActual.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaActual.TabIndex = 91;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDescripcion.Location = new System.Drawing.Point(142, 331);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefono.Location = new System.Drawing.Point(56, 333);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 16);
            this.lblTelefono.TabIndex = 90;
            this.lblTelefono.Text = "Tramite:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblLocalidad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLocalidad.Location = new System.Drawing.Point(447, 102);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(70, 16);
            this.lblLocalidad.TabIndex = 85;
            this.lblLocalidad.Text = "Sucursal:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDireccion.Location = new System.Drawing.Point(10, 289);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(116, 16);
            this.lblDireccion.TabIndex = 79;
            this.lblDireccion.Text = "Forma de Pago:";
            // 
            // Documento
            // 
            this.Documento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Documento.AutoSize = true;
            this.Documento.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.Documento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Documento.Location = new System.Drawing.Point(82, 100);
            this.Documento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(44, 16);
            this.Documento.TabIndex = 71;
            this.Documento.Text = "DNI:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDocumento.Location = new System.Drawing.Point(143, 96);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(209, 20);
            this.txtDocumento.TabIndex = 5;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtApellido.Location = new System.Drawing.Point(143, 179);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(56, 179);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(76, 16);
            this.lblApellido.TabIndex = 58;
            this.lblApellido.Text = "Apellido: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Location = new System.Drawing.Point(143, 141);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(59, 141);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 16);
            this.lblNombre.TabIndex = 56;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigoText
            // 
            this.lblCodigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCodigoText.AutoSize = true;
            this.lblCodigoText.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.lblCodigoText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoText.Location = new System.Drawing.Point(527, 21);
            this.lblCodigoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoText.Name = "lblCodigoText";
            this.lblCodigoText.Size = new System.Drawing.Size(48, 16);
            this.lblCodigoText.TabIndex = 54;
            this.lblCodigoText.Text = "Fecha";
            // 
            // pbSucursal
            // 
            this.pbSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSucursal.Image = ((System.Drawing.Image)(resources.GetObject("pbSucursal.Image")));
            this.pbSucursal.Location = new System.Drawing.Point(743, 78);
            this.pbSucursal.Margin = new System.Windows.Forms.Padding(2);
            this.pbSucursal.Name = "pbSucursal";
            this.pbSucursal.Size = new System.Drawing.Size(57, 59);
            this.pbSucursal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSucursal.TabIndex = 86;
            this.pbSucursal.TabStop = false;
            this.pbSucursal.Click += new System.EventHandler(this.pbSucursal_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(328, 408);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(105, 88);
            this.btnBorrar.TabIndex = 67;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(531, 408);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 80);
            this.btnSalir.TabIndex = 66;
            this.btnSalir.Text = "Volver";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(49, 414);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 80);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(18, 5);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(52, 49);
            this.btnVolver.TabIndex = 62;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(240, 408);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(97, 88);
            this.btnCargar.TabIndex = 60;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.tabPage1.Controls.Add(this.txtBuscarTramite);
            this.tabPage1.Controls.Add(this.chkEliminar);
            this.tabPage1.Controls.Add(this.dtgTramite);
            this.tabPage1.Controls.Add(this.lblCantidaddeRegistros);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.lblApellidoBuscar);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1178, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buscar Tramite";
            // 
            // txtBuscarTramite
            // 
            this.txtBuscarTramite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBuscarTramite.Location = new System.Drawing.Point(91, 51);
            this.txtBuscarTramite.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarTramite.Name = "txtBuscarTramite";
            this.txtBuscarTramite.Size = new System.Drawing.Size(209, 20);
            this.txtBuscarTramite.TabIndex = 18;
            this.txtBuscarTramite.TextChanged += new System.EventHandler(this.txtBuscarTramite_TextChanged);
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.chkEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEliminar.Location = new System.Drawing.Point(20, 98);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(85, 21);
            this.chkEliminar.TabIndex = 17;
            this.chkEliminar.Text = "Eliminar";
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
            this.dtgTramite.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.dtgTramite.Size = new System.Drawing.Size(839, 355);
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
            this.lblCantidaddeRegistros.Location = new System.Drawing.Point(14, 496);
            this.lblCantidaddeRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidaddeRegistros.Name = "lblCantidaddeRegistros";
            this.lblCantidaddeRegistros.Size = new System.Drawing.Size(179, 17);
            this.lblCantidaddeRegistros.TabIndex = 14;
            this.lblCantidaddeRegistros.Text = "Cantidad de Registros: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(659, 27);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 38);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(282, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 32);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.TabStop = false;
            // 
            // lblApellidoBuscar
            // 
            this.lblApellidoBuscar.AutoSize = true;
            this.lblApellidoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblApellidoBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellidoBuscar.Location = new System.Drawing.Point(17, 48);
            this.lblApellidoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoBuscar.Name = "lblApellidoBuscar";
            this.lblApellidoBuscar.Size = new System.Drawing.Size(68, 17);
            this.lblApellidoBuscar.TabIndex = 8;
            this.lblApellidoBuscar.Text = "Tramite:";
            // 
            // frmTramites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmTramites";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmTramites_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAgentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSucursal)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
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
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label Documento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigoText;
        private System.Windows.Forms.PictureBox pbSucursal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox pbAgentes;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaAuditado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaActual;
        private System.Windows.Forms.ComboBox cmbAgente;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.ComboBox cmbTipoTramite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRechazado;
        private System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.TextBox txtBuscarTramite;
        private System.Windows.Forms.ComboBox cmbTipoPago;
        private System.Windows.Forms.TextBox txtNroTramite;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEstado;
    }
}


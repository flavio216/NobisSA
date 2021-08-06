
namespace NobisSA
{
    partial class frmAfiliados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAfiliados));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbPlan = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbTipoSexo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.cmbCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.Documento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBuscarAfiliado = new System.Windows.Forms.TextBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.dtgAfiliados = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblCantidaddeRegistros = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblApellidoBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.errorCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSucursal = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAfiliados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(29, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.tabPage1.Controls.Add(this.lblSucursal);
            this.tabPage1.Controls.Add(this.cmbPlan);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtMail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtDomicilio);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.cmbEstadoCivil);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cmbTipoSexo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbLocalidad);
            this.tabPage1.Controls.Add(this.cmbCiudad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtpFechaNac);
            this.tabPage1.Controls.Add(this.lblCiudad);
            this.tabPage1.Controls.Add(this.lblEstadoCivil);
            this.tabPage1.Controls.Add(this.Documento);
            this.tabPage1.Controls.Add(this.txtDocumento);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblFechaNac);
            this.tabPage1.Controls.Add(this.btnBorrar);
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.btnCargar);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(934, 476);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Afiliados";
            // 
            // cmbPlan
            // 
            this.cmbPlan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPlan.FormattingEnabled = true;
            this.cmbPlan.Location = new System.Drawing.Point(596, 310);
            this.cmbPlan.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPlan.Name = "cmbPlan";
            this.cmbPlan.Size = new System.Drawing.Size(117, 27);
            this.cmbPlan.TabIndex = 158;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(524, 313);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 157;
            this.label6.Text = "Plan:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(508, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 156;
            this.label5.Text = "E-mail:";
            // 
            // txtMail
            // 
            this.txtMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtMail.Location = new System.Drawing.Point(596, 256);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(209, 27);
            this.txtMail.TabIndex = 155;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(498, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 154;
            this.label4.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTelefono.Location = new System.Drawing.Point(596, 206);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(209, 27);
            this.txtTelefono.TabIndex = 153;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(489, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 152;
            this.label3.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDomicilio.Location = new System.Drawing.Point(596, 155);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(209, 27);
            this.txtDomicilio.TabIndex = 151;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(490, 356);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 88);
            this.button2.TabIndex = 150;
            this.button2.Text = "Cancelar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(196, 305);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(144, 27);
            this.cmbEstadoCivil.TabIndex = 147;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 66);
            this.button1.TabIndex = 144;
            this.button1.Text = "Descargar PDF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbTipoSexo
            // 
            this.cmbTipoSexo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoSexo.FormattingEnabled = true;
            this.cmbTipoSexo.Location = new System.Drawing.Point(196, 251);
            this.cmbTipoSexo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoSexo.Name = "cmbTipoSexo";
            this.cmbTipoSexo.Size = new System.Drawing.Size(129, 27);
            this.cmbTipoSexo.TabIndex = 143;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(127, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 142;
            this.label2.Text = "Sexo:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(596, 106);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(209, 27);
            this.cmbLocalidad.TabIndex = 141;
            // 
            // cmbCiudad
            // 
            this.cmbCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCiudad.FormattingEnabled = true;
            this.cmbCiudad.Location = new System.Drawing.Point(596, 57);
            this.cmbCiudad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCiudad.Name = "cmbCiudad";
            this.cmbCiudad.Size = new System.Drawing.Size(209, 27);
            this.cmbCiudad.TabIndex = 140;
            this.cmbCiudad.SelectedIndexChanged += new System.EventHandler(this.cmbCiudad_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(483, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 134;
            this.label1.Text = "Localidad:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(196, 202);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(218, 27);
            this.dtpFechaNac.TabIndex = 133;
            // 
            // lblCiudad
            // 
            this.lblCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCiudad.Location = new System.Drawing.Point(499, 61);
            this.lblCiudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(72, 19);
            this.lblCiudad.TabIndex = 130;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEstadoCivil.Location = new System.Drawing.Point(81, 305);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(96, 19);
            this.lblEstadoCivil.TabIndex = 129;
            this.lblEstadoCivil.Text = "EstadoCivil:";
            // 
            // Documento
            // 
            this.Documento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Documento.AutoSize = true;
            this.Documento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Documento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Documento.Location = new System.Drawing.Point(137, 61);
            this.Documento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Documento.Name = "Documento";
            this.Documento.Size = new System.Drawing.Size(40, 19);
            this.Documento.TabIndex = 128;
            this.Documento.Text = "DNI:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDocumento.Location = new System.Drawing.Point(196, 57);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(209, 27);
            this.txtDocumento.TabIndex = 118;
            this.txtDocumento.TextChanged += new System.EventHandler(this.txtDocumento_TextChanged);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtApellido.Location = new System.Drawing.Point(196, 153);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(209, 27);
            this.txtApellido.TabIndex = 117;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellido.Location = new System.Drawing.Point(94, 156);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(83, 19);
            this.lblApellido.TabIndex = 122;
            this.lblApellido.Text = "Apellido: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNombre.Location = new System.Drawing.Point(196, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 27);
            this.txtNombre.TabIndex = 116;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(103, 102);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(77, 19);
            this.lblNombre.TabIndex = 121;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaNac.Location = new System.Drawing.Point(20, 202);
            this.lblFechaNac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(157, 19);
            this.lblFechaNac.TabIndex = 120;
            this.lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(355, 356);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(108, 88);
            this.btnBorrar.TabIndex = 127;
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
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(625, 356);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 88);
            this.btnSalir.TabIndex = 126;
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
            this.btnNuevo.Font = new System.Drawing.Font("Imprint MT Shadow", 14F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(85, 358);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 88);
            this.btnNuevo.TabIndex = 125;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(220, 356);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 88);
            this.btnCargar.TabIndex = 123;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.txtBuscarAfiliado);
            this.tabPage2.Controls.Add(this.chkEliminar);
            this.tabPage2.Controls.Add(this.dtgAfiliados);
            this.tabPage2.Controls.Add(this.lblCantidaddeRegistros);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.lblApellidoBuscar);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 476);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(760, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 38);
            this.button3.TabIndex = 26;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBuscarAfiliado
            // 
            this.txtBuscarAfiliado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBuscarAfiliado.Location = new System.Drawing.Point(125, 21);
            this.txtBuscarAfiliado.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarAfiliado.Name = "txtBuscarAfiliado";
            this.txtBuscarAfiliado.Size = new System.Drawing.Size(209, 23);
            this.txtBuscarAfiliado.TabIndex = 25;
            this.txtBuscarAfiliado.TextChanged += new System.EventHandler(this.txtBuscarTramite_TextChanged);
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.chkEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkEliminar.Location = new System.Drawing.Point(62, 68);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(85, 21);
            this.chkEliminar.TabIndex = 24;
            this.chkEliminar.Text = "Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // dtgAfiliados
            // 
            this.dtgAfiliados.AllowUserToAddRows = false;
            this.dtgAfiliados.AllowUserToDeleteRows = false;
            this.dtgAfiliados.AllowUserToOrderColumns = true;
            this.dtgAfiliados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAfiliados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.dtgAfiliados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAfiliados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dtgAfiliados.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgAfiliados.Location = new System.Drawing.Point(56, 93);
            this.dtgAfiliados.Margin = new System.Windows.Forms.Padding(2);
            this.dtgAfiliados.MultiSelect = false;
            this.dtgAfiliados.Name = "dtgAfiliados";
            this.dtgAfiliados.ReadOnly = true;
            this.dtgAfiliados.RowHeadersWidth = 51;
            this.dtgAfiliados.RowTemplate.Height = 24;
            this.dtgAfiliados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAfiliados.Size = new System.Drawing.Size(822, 351);
            this.dtgAfiliados.TabIndex = 23;
            this.dtgAfiliados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAfiliados_CellContentClick);
            this.dtgAfiliados.DoubleClick += new System.EventHandler(this.dtgTramite_DoubleClick);
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
            this.lblCantidaddeRegistros.Location = new System.Drawing.Point(39, 466);
            this.lblCantidaddeRegistros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidaddeRegistros.Name = "lblCantidaddeRegistros";
            this.lblCantidaddeRegistros.Size = new System.Drawing.Size(179, 17);
            this.lblCantidaddeRegistros.TabIndex = 22;
            this.lblCantidaddeRegistros.Text = "Cantidad de Registros: ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(658, 18);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 38);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblApellidoBuscar
            // 
            this.lblApellidoBuscar.AutoSize = true;
            this.lblApellidoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblApellidoBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApellidoBuscar.Location = new System.Drawing.Point(59, 18);
            this.lblApellidoBuscar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoBuscar.Name = "lblApellidoBuscar";
            this.lblApellidoBuscar.Size = new System.Drawing.Size(68, 17);
            this.lblApellidoBuscar.TabIndex = 19;
            this.lblApellidoBuscar.Text = "Tramite:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(338, 18);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(38, 32);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.TabStop = false;
            // 
            // errorCliente
            // 
            this.errorCliente.ContainerControl = this;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSucursal.Location = new System.Drawing.Point(374, 0);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(135, 36);
            this.lblSucursal.TabIndex = 159;
            this.lblSucursal.Text = "Afiliados";
            // 
            // frmAfiliados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(983, 530);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAfiliados";
            this.Text = "frmAfiliados";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAfiliados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTipoSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.ComboBox cmbCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label Documento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtBuscarAfiliado;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.DataGridView dtgAfiliados;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblCantidaddeRegistros;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label lblApellidoBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorCliente;
        private System.Windows.Forms.Label lblSucursal;
    }
}
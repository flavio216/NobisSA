
namespace NobisSA
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ptbLogo = new System.Windows.Forms.PictureBox();
            this.btnTramites = new System.Windows.Forms.Button();
            this.btnAFiliados = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.panelFormHijo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.ptbLogo);
            this.panel1.Controls.Add(this.btnTramites);
            this.panel1.Controls.Add(this.btnAFiliados);
            this.panel1.Controls.Add(this.btnInventario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 554);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(0, 523);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(200, 31);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(200, 91);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbLogo.TabIndex = 15;
            this.ptbLogo.TabStop = false;
            // 
            // btnTramites
            // 
            this.btnTramites.FlatAppearance.BorderSize = 0;
            this.btnTramites.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnTramites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTramites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTramites.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTramites.Image = ((System.Drawing.Image)(resources.GetObject("btnTramites.Image")));
            this.btnTramites.Location = new System.Drawing.Point(3, 84);
            this.btnTramites.Name = "btnTramites";
            this.btnTramites.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnTramites.Size = new System.Drawing.Size(197, 81);
            this.btnTramites.TabIndex = 18;
            this.btnTramites.Text = "Tramites";
            this.btnTramites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTramites.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTramites.UseVisualStyleBackColor = true;
            this.btnTramites.Click += new System.EventHandler(this.btnTramites_Click);
            // 
            // btnAFiliados
            // 
            this.btnAFiliados.FlatAppearance.BorderSize = 0;
            this.btnAFiliados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnAFiliados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAFiliados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAFiliados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAFiliados.Image = ((System.Drawing.Image)(resources.GetObject("btnAFiliados.Image")));
            this.btnAFiliados.Location = new System.Drawing.Point(0, 171);
            this.btnAFiliados.Name = "btnAFiliados";
            this.btnAFiliados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAFiliados.Size = new System.Drawing.Size(200, 77);
            this.btnAFiliados.TabIndex = 17;
            this.btnAFiliados.Text = "Afiliados";
            this.btnAFiliados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAFiliados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAFiliados.UseVisualStyleBackColor = true;
            this.btnAFiliados.Click += new System.EventHandler(this.btnAFiliados_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkViolet;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.Location = new System.Drawing.Point(3, 254);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(200, 74);
            this.btnInventario.TabIndex = 16;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = true;
            // 
            // panelFormHijo
            // 
            this.panelFormHijo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelFormHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormHijo.Location = new System.Drawing.Point(200, 0);
            this.panelFormHijo.Name = "panelFormHijo";
            this.panelFormHijo.Size = new System.Drawing.Size(915, 554);
            this.panelFormHijo.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 554);
            this.Controls.Add(this.panelFormHijo);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox ptbLogo;
        private System.Windows.Forms.Button btnTramites;
        private System.Windows.Forms.Button btnAFiliados;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Panel panelFormHijo;
    }
}
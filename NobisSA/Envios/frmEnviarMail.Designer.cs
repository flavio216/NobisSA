
namespace NobisSA.Tramites
{
    partial class frmEnviarMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnviarMail));
            this.label3 = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCuerpo = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(70, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 91;
            this.label3.Text = "Para:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(126, 56);
            this.txtPara.Margin = new System.Windows.Forms.Padding(2);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(199, 20);
            this.txtPara.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(378, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "Cc:";
            // 
            // txtCc
            // 
            this.txtCc.Location = new System.Drawing.Point(422, 58);
            this.txtCc.Margin = new System.Windows.Forms.Padding(2);
            this.txtCc.Name = "txtCc";
            this.txtCc.Size = new System.Drawing.Size(199, 20);
            this.txtCc.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(52, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 95;
            this.label2.Text = "Asunto:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(126, 109);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(2);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(199, 20);
            this.txtAsunto.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(52, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 97;
            this.label4.Text = "Cuerpo:";
            // 
            // txtCuerpo
            // 
            this.txtCuerpo.Location = new System.Drawing.Point(126, 160);
            this.txtCuerpo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuerpo.Name = "txtCuerpo";
            this.txtCuerpo.Size = new System.Drawing.Size(199, 20);
            this.txtCuerpo.TabIndex = 96;
            // 
            // btnEnviar
            // 
            this.btnEnviar.FlatAppearance.BorderSize = 0;
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnviar.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviar.Image")));
            this.btnEnviar.Location = new System.Drawing.Point(449, 96);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(103, 96);
            this.btnEnviar.TabIndex = 98;
            this.btnEnviar.Text = "Enviar Mail";
            this.btnEnviar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmEnviarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(165)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(643, 242);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCuerpo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPara);
            this.Name = "frmEnviarMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnviarMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCc;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCuerpo;
        private System.Windows.Forms.Button btnEnviar;
    }
}
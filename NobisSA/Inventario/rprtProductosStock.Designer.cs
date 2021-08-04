
namespace NobisSA
{
    partial class RprtProductosStock
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtsPrincipal = new NobisSA.dtsPrincipal();
            this.productosConStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosConStockTableAdapter = new NobisSA.dtsPrincipalTableAdapters.ProductosConStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtsPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosConStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.productosConStockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "NobisSA.Inventario.infProductosStock.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dtsPrincipal
            // 
            this.dtsPrincipal.DataSetName = "dtsPrincipal";
            this.dtsPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productosConStockBindingSource
            // 
            this.productosConStockBindingSource.DataMember = "ProductosConStock";
            this.productosConStockBindingSource.DataSource = this.dtsPrincipal;
            // 
            // productosConStockTableAdapter
            // 
            this.productosConStockTableAdapter.ClearBeforeFill = true;
            // 
            // RprtProductosStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RprtProductosStock";
            this.Text = "RprtProductosStock";
            this.Load += new System.EventHandler(this.RprtProductosStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosConStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dtsPrincipal dtsPrincipal;
        private System.Windows.Forms.BindingSource productosConStockBindingSource;
        private dtsPrincipalTableAdapters.ProductosConStockTableAdapter productosConStockTableAdapter;
    }
}
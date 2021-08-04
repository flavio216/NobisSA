using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA
{
    public partial class RprtProductosStock : Form
    {
        public RprtProductosStock()
        {
            InitializeComponent();
        }

        private void RprtProductosStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsPrincipal.ProductosConStock' Puede moverla o quitarla según sea necesario.
            this.productosConStockTableAdapter.Fill(this.dtsPrincipal.ProductosConStock);

            this.reportViewer1.RefreshReport();
        }
    }
}

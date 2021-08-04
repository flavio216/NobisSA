using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA.Inventario
{
    public partial class rprtProductosSinStock : Form
    {
        public rprtProductosSinStock()
        {
            InitializeComponent();
        }

        private void rprtProductosSinStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsPrincipal.ProductosSinStock' Puede moverla o quitarla según sea necesario.
            this.productosSinStockTableAdapter.Fill(this.dtsPrincipal.ProductosSinStock);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA.Afiliados
{
    public partial class rprtAfiliados : Form
    {
        public rprtAfiliados()
        {
            InitializeComponent();
        }

        private void rprtAfiliados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dtsPrincipal.Afiliados' Puede moverla o quitarla según sea necesario.
            this.afiliadosTableAdapter.Fill(this.dtsPrincipal.Afiliados);

            this.reportViewer1.RefreshReport();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA.Envios
{
    public partial class rprtEnvios : Form
    {
        int idenvio;
        public rprtEnvios(int idenvio)
        {
            InitializeComponent();
            this.idenvio = idenvio;
        }

        private void rprtEnvios_Load(object sender, EventArgs e)
        {
            try
            {
                this.enviosTableAdapter.Fill(this.dtsPrincipal.Envios, idenvio);
            }
            catch (Exception)
            {

            }

            this.reportViewer1.RefreshReport();
        }
    }
}

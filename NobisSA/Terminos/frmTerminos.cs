using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA.Terminos
{
    public partial class frmTerminos : Form
    {
        public frmTerminos()
        {
            InitializeComponent();
           
           
        }

        private void lblPreguntas_Click(object sender, EventArgs e)
        {
            frmContacto frm = new frmContacto();
            frm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmContacto frm = new frmContacto();
            frm.Show();
        }
    }
}

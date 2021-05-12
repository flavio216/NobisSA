using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio.Clases;
using CapaNegocio.Gestores;

namespace NobisSA
{
    public partial class frmSucursales : Form
    {
        List<clsSucursales> sucursales = new List<clsSucursales>();
        public frmSucursales()
        {
            InitializeComponent();
            cargarLista();
        }
        private void cargarLista()
        {
            lstSucursal.Items.Clear();
            sucursales.Clear();

            //ConexionesBD.ConexionBD conex = new ConexionesBD.ConexionBD();
            bdSucursales gestor = new bdSucursales();

            DataTable dt = gestor.consultarSucursales();



            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clsSucursales r = new clsSucursales();
               // r.pId = Convert.ToInt32(dt.Rows[i]["idRubro"]);
                r.pSucursal = dt.Rows[i]["sucursal"].ToString();
              //  r.pEstado = Convert.ToInt32(dt.Rows[i]["Estado"]);

                sucursales.Add(r);
                lstSucursal.Items.Add(r);
            }
            lstSucursal.SelectedIndex = -1;

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}

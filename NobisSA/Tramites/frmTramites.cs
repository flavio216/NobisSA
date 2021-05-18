using CapaNegocio;
using NobisSA.Tramites;
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
    public partial class frmTramites : Form
    {
        public frmTramites()
        {
            InitializeComponent();
            CargarSucursales(cmbSucursal);
        }
        private void CargarSucursales(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            bdSucursales gestorRubro = new bdSucursales();
            dt = gestorRubro.consultarSucursales();
            cmb.DataSource = dt;
            cmb.ValueMember = dt.Columns[0].ColumnName;
            cmb.DisplayMember = dt.Columns[1].ColumnName;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarCategorias(cmbAgente, Convert.ToInt32(cmb.SelectedValue));
        }
            private void CargarCategorias(ComboBox cmb, int index)
        {
            DataTable dt = new DataTable();
            bdAgentes gestor = new bdAgentes();
            dt = gestor.ConsultarTablaAgentes(index);
            cmb.DataSource = dt;
            cmb.ValueMember = dt.Columns[0].ColumnName;
            cmb.DisplayMember = dt.Columns[1].ColumnName;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void pbLocalidad_Click(object sender, EventArgs e)
        {
            frmSucursales frm = new frmSucursales();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAgentes frm = new frmAgentes();
            frm.Show();
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idsucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
                CargarCategorias(cmbAgente, idsucursal);
            }
            catch (Exception)
            {

                int idsucursal = -1;
                CargarCategorias(cmbAgente, idsucursal);
            }
        }
    }
}

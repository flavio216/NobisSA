using CapaDato;
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
        bool nuevo;
        public frmTramites()
        {
            InitializeComponent();

            //Permisos
            pbSucursal.Enabled = clsLogin.reg_sucursales;
            pbAgentes.Enabled = clsLogin.reg_sucursales;
            RellenarDTGtramites();
            btnAutorizar.Visible = false;
            btnRechazado.Visible = false;
            dtgTramite.Columns[0].Visible = false;
            cargarCombo(cmbTipoPago, "tipopagos");
            cargarCombo(cmbTipoTramite, "tipotramites");
            CargarSucursales(cmbSucursal);
            lblCantidaddeRegistros.Text = "Cantidad de registros:" + dtgTramite.Rows.Count.ToString();
        }
        private void cargarCombo(ComboBox combo, string tabla)
        {
            AccesoDatos BD = new AccesoDatos();
            DataTable dt = new DataTable();
            dt = BD.consultarTabla(tabla);
            combo.DataSource = dt;
            combo.ValueMember = dt.Columns[0].ColumnName;
            combo.DisplayMember = dt.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
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
            CargarAgentes(cmbAgente, Convert.ToInt32(cmb.SelectedValue));
        }
    
        private void CargarAgentes(ComboBox cmb, int index)
        {
            DataTable dt = new DataTable();
            bdAgentes gestor = new bdAgentes();
            dt = gestor.ConsultarTablaAgentes(index);
            cmb.DataSource = dt;
            cmb.ValueMember = dt.Columns[0].ColumnName;
            cmb.DisplayMember = dt.Columns[1].ColumnName;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }
      

      
        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idsucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
                CargarAgentes(cmbAgente, idsucursal);
            }
            catch (Exception)
            {

                int idsucursal = -1;
                CargarAgentes(cmbAgente, idsucursal);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
           
            int dni = int.Parse(txtDocumento.Text);
            int tipoTramite = Convert.ToInt32(cmbTipoTramite.SelectedValue);
            int idtipopago = Convert.ToInt32(cmbTipoPago.SelectedValue);
            string descripcion = txtDescripcion.Text;
            int idagente = Convert.ToInt32(cmbAgente.SelectedValue);
            DateTime fecha = dtpFechaActual.Value;
            
            clsTramites tramite = new clsTramites(0, tipoTramite, fecha, dni, idtipopago, descripcion, idagente, true );
           // clsTramites tramite2 = new clsTramites(nrotramite, tipoTramite, fecha, dni, idtipopago, descripcion, idagente);
            bdTramites gestor = new bdTramites();
            if (nuevo)
            {

                bool resultado = gestor.InsertarTramite(tramite);

                    if (resultado)
                    {
                        MessageBox.Show("El agente se ha cargado con exito.", "Insertar Agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblCantidaddeRegistros.Text = "Cantidad de registros:" + dtgTramite.Rows.Count.ToString();
                        RellenarDTGtramites();
                        LimpiarAfiliado();
                        tabControl1.SelectedIndex = 1;

                }
                    else
                    {
                        MessageBox.Show("Error al cargar el agente...");

                    }

            }
            
          else
            {
                int nrotramite = int.Parse(txtNroTramite.Text);
                clsTramites tramite2 = new clsTramites(nrotramite, tipoTramite, fecha, dni, idtipopago, descripcion, idagente,Convert.ToBoolean(txtEstado.Text));
                bool resultado2 = gestor.EditarTramite(tramite2);
                if (resultado2)
                {
                    MessageBox.Show("El agente se ha editado con exito.", "Editar agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RellenarDTGtramites();
                    LimpiarAfiliado();
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar el agente" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                RellenarDTGtramites();
           /* int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
            cargarLista(idRubro);
            Habilitar(false);
           */
        
            }
        }

        private void cmbAgente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            int codigo;
            try
            {
                codigo = int.Parse(txtDocumento.Text);
                string sql = "SELECT nombre, apellido FROM afiliados WHERE dni = " + codigo;
                buscarProducto(sql);
            }
            catch (Exception)
            {
                LimpiarAfiliado();

            }
        }

        private void LimpiarAfiliado()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDocumento.Text = "";
            cmbAgente.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;
            cmbTipoPago.SelectedIndex = -1;
            cmbTipoTramite.SelectedIndex = -1;
            txtObservacion.Text = "";
            txtNroTramite.Text = "";
            txtDescripcion.Text = "";
            dtpFechaActual.Value = DateTime.Today;
            dtpFechaAuditado.Value = DateTime.Today;
        }
        private void buscarProducto(string sql)
        {
            DataTable dt = new DataTable();
            AccesoDatos bd = new AccesoDatos();
            dt = bd.buscarTabla(sql);
            try
            {
                txtNombre.Text = dt.Rows[0]["nombre"].ToString();
                txtApellido.Text = dt.Rows[0]["apellido"].ToString();

            }
            catch (Exception)
            {

                txtNombre.Clear();
                txtApellido.Clear();
            }

        }
        private void RellenarDTGtramites()
        {
            DataTable dt = new DataTable();
            bdTramites gestor = new bdTramites();
            dt = gestor.ConsultarTramites();
            dtgTramite.DataSource = dt;
            dtgTramite.ReadOnly = true;
        }
      
        private void dtgTramite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgTramite.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dtgTramite.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked == true)
            {
                dtgTramite.Columns[0].Visible = true;
            }
            else
            {
                dtgTramite.Columns[0].Visible = false;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea eliminar los registros?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                string codigo;
                string sql;
                AccesoDatos bd = new AccesoDatos();
                foreach (DataGridViewRow row in dtgTramite.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        sql = "delete from tramites where idtramite =" + codigo;
                        bd.actualizarBD(sql);
                    }
                }

            }
            RellenarDTGtramites();
            lblCantidaddeRegistros.Text = "Cantidad de registros:" + dtgTramite.Rows.Count.ToString();
        }

    
        private void frmTramites_Load(object sender, EventArgs e)
        {
            cmbTipoPago.SelectedIndex = -1;
            cmbTipoTramite.SelectedIndex = -1;
            
        }

  

       
          private void btnAutorizar_Click(object sender, EventArgs e)
          {
              bdTramites gestor = new bdTramites();

           gestor.CambiarEstado(true, int.Parse(txtNroTramite.Text), txtObservacion.Text, DateTime.Today);
            btnAutorizar.Visible = false;
            btnRechazado.Visible = true;
            btnRechazado.Enabled = true;
            RellenarDTGtramites();
            tabControl1.SelectedIndex = 1;
        }

        private void btnRechazado_Click(object sender, EventArgs e)
        {
            bdTramites gestor = new bdTramites();

            gestor.CambiarEstado(false, int.Parse(txtNroTramite.Text),txtObservacion.Text,DateTime.Today);
            btnRechazado.Visible = false;
            btnAutorizar.Visible = true;
            btnAutorizar.Enabled = true;
            RellenarDTGtramites();
            tabControl1.SelectedIndex = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        private void Habilitar(bool x)
        {
            txtDocumento.Enabled = x;
            txtNombre.Enabled = x;
            btnCargar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnBorrar.Enabled = x;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Habilitar(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
          //  Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void dtgTramite_DoubleClick(object sender, EventArgs e)
        {
            txtNroTramite.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[1].Value);
            cmbTipoTramite.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[2].Value);
            dtpFechaActual.Value = Convert.ToDateTime(dtgTramite.CurrentRow.Cells[3].Value);
            txtDocumento.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[4].Value);
            cmbTipoPago.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[7].Value);
            txtDescripcion.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[8].Value);
            cmbAgente.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[9].Value);
            txtObservacion.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[11].Value);
            //  cmbTipoTramite.S electedValue = dtgTramite.CurrentRow.Cells["Tramite"].Value.ToString();
            txtEstado.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[12].Value);
            if (Convert.ToBoolean(txtEstado.Text))
            {
                btnRechazado.Visible = true;
                btnRechazado.Enabled = true;
                btnAutorizar.Visible = false;
                btnAutorizar.Enabled = false;

            }

            if (!Convert.ToBoolean(txtEstado.Text))
            {
                btnRechazado.Visible = false;
                btnRechazado.Enabled = false;
                btnAutorizar.Enabled = true;
                btnAutorizar.Visible = true;

            }

            btnCargar.Enabled = false;
            cmbTipoPago.Enabled = true;
            tabControl1.SelectedIndex = 0;
        }

        private void txtBuscarTramite_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select t.idtramite,tt.tramite,fecha, t.dni,af.nombre,af.apellido,formapago,descripcion,ag.agente,fechaauditado,observacion,estado from tramites t
                            inner join tipotramites tt on t.idTipoTramite = tt.idTipoTramite
                            inner join afiliados af on af.dni = t.dni
                            inner join tipopagos tp on tp.idtipopago = t.idtipopago
                            inner join agentes ag on ag.idagente = t.idagente WHERE t.dni LIKE '" + txtBuscarTramite.Text + "%' or tt.tramite LIKE '" + txtBuscarTramite.Text + "%'";
            Buscar(sql, dtgTramite);
        }
        public void Buscar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            AccesoDatos gestor = new AccesoDatos();
            dt = gestor.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidaddeRegistros.Text = "Cantidad de registros: " + dtgTramite.Rows.Count.ToString();

        }

        private void pbAgentes_Click(object sender, EventArgs e)
        {
            frmAgentes frm = new frmAgentes();
            frm.Show();
        }

        private void pbSucursal_Click(object sender, EventArgs e)
        {
            frmSucursales frm = new frmSucursales();
            frm.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}

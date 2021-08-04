using CapaDato;
using CapaNegocio;
using NobisSA.Tramites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;


namespace NobisSA
{
    public partial class frmTramites : Form
    {
        bool nuevo;
        int c;
        List<clsTramites> tramites = new List<clsTramites>();
        public frmTramites()
        {
            InitializeComponent();
            btnEnviarMail.Enabled = true;
            //txtNroTramite.Visible = false;

            txtNroTramite.Text = "0";
            //Permisos Sucursales

            dtpFechaAuditado.Enabled = clsLogin.reg_sucursales;
            txtObservacion.Enabled = clsLogin.reg_sucursales;
            btnAutorizar.Enabled = clsLogin.reg_sucursales;
            btnRechazar.Enabled = clsLogin.reg_sucursales;
            btnEnviarMail.Enabled = clsLogin.reg_sucursales;

            btnRechazar.Enabled = clsLogin.reg_auditoria;
            btnAutorizar.Enabled = clsLogin.reg_auditoria;
            txtObservacion.Enabled = clsLogin.reg_auditoria;
            dtpFechaAuditado.Enabled = clsLogin.reg_auditoria;

            pbAgente.Visible = clsLogin.reg_admin;
            pbSucursales.Visible = clsLogin.reg_admin;

            // Permisos Auditoria
            /*  txtDocumento.Enabled = clsLogin.reg_auditoria;
              cmbAgente.Enabled = clsLogin.reg_auditoria;
              cmbSucursal.Enabled = clsLogin.reg_auditoria;
              cmbTipoPago.Enabled = clsLogin.reg_auditoria;
              cmbTipoTramite.Enabled = clsLogin.reg_auditoria;
              txtObservacion.Enabled = clsLogin.reg_auditoria;
              txtNroTramite.Enabled = clsLogin.reg_auditoria;
              txtDescripcion.Enabled = clsLogin.reg_auditoria;
              dtpFechaActual.Enabled = clsLogin.reg_auditoria;
              pbAgente.Enabled = clsLogin.reg_auditoria;
              pbSucursales.Enabled = clsLogin.reg_auditoria;*/

            RellenarDTGtramites();
            // Habilitar(false);
            nuevo = true;
            btnAutorizar.Visible = false;
            btnRechazar.Visible = false;
            dtgTramite.Columns[0].Visible = false;
            cargarCombo(cmbTipoPago, "tipopagos");
            cargarCombo(cmbTipoTramite, "tipotramites");
            CargarSucursales(cmbSucursal);
            cmbAgente.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;

            lblNombres.Text = "";
            lblApellidos.Text = "";

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


        
        private void buscarDocumento(string sql)
        {
            DataTable dt = new DataTable();
            AccesoDatos bd = new AccesoDatos();
            dt = bd.buscarTabla(sql);
            try
            {
                lblNombres.Text = dt.Rows[0]["nombre"].ToString();
                lblApellidos.Text = dt.Rows[0]["apellido"].ToString();

            }
            catch (Exception)
            {

                lblNombres.Text = "";
                lblApellidos.Text = "";
            }

        }
        private void LimpiarTramite()
        {
            lblNombres.Text = "";
            lblApellidos.Text = "";
            txtDocumento.Text = "";
            cmbAgente.SelectedIndex = -1;
            cmbSucursal.SelectedIndex = -1;
            cmbTipoPago.SelectedIndex = -1;
            cmbTipoTramite.SelectedIndex = -1;
            txtObservacion.Text = "";
            txtNroTramite.Text = "0";
            txtDescripcion.Text = "";
            dtpFechaActual.Value = DateTime.Today;
            dtpFechaAuditado.Value = DateTime.Today;
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


        /*   private void Habilitar(bool x)
           {
               btnCarga.Enabled = x;
               btnNuevo.Enabled = !x;
               btnEditar.Enabled = x;
           }*/


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
                btnRechazar.Visible = true;
                btnRechazar.Enabled = true;
                btnAutorizar.Visible = false;
                btnAutorizar.Enabled = false;

            }

            if (!Convert.ToBoolean(txtEstado.Text))
            {
                btnRechazar.Visible = false;
                btnRechazar.Enabled = false;
                btnAutorizar.Enabled = true;
                btnAutorizar.Visible = true;

            }
            txtPdf.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[13].Value);
            //  txtPara.Text = Convert.ToString(dtgTramite.CurrentRow.Cells[14].Value);
            // btnCarga.Enabled = false;
            txtNroTramite.Enabled = false;
            cmbTipoPago.Enabled = true;
            tabControl1.SelectedIndex = 0;
            txtNroTramite.Enabled = false;
            nuevo = false;
            //Habilitar(true);
        }


        public void Buscar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            AccesoDatos gestor = new AccesoDatos();
            dt = gestor.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidaddeRegistros.Text = "Cantidad de registros: " + dtgTramite.Rows.Count.ToString();

        }



        private void txtDocumento_TextChanged_1(object sender, EventArgs e)
        {
            int codigo;
            try
            {
                codigo = int.Parse(txtDocumento.Text);
                string sql = "SELECT nombre, apellido FROM afiliados WHERE dni = " + codigo;
                buscarDocumento(sql);
            }
            catch (Exception)
            {
                LimpiarTramite();

            }
        }

        private void txtBuscarTramite_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select t.idtramite,tt.tramite,fecha, t.dni,af.nombre,af.apellido,formapago,descripcion,ag.agente,fechaauditado,observacion,estado from tramites t
                            inner join tipotramites tt on t.idTipoTramite = tt.idTipoTramite
                            inner join afiliados af on af.dni = t.dni
                            inner join tipopagos tp on tp.idtipopago = t.idtipopago
                            inner join agentes ag on ag.idagente = t.idagente WHERE t.dni LIKE '" + txtBuscarTramite.Text + "%' or t.idtramite LIKE '" + txtBuscarTramite.Text + "%' or tt.tramite LIKE '" + txtBuscarTramite.Text + "%'";
            Buscar(sql, dtgTramite);
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            bdTramites gestor = new bdTramites();

            gestor.CambiarEstado(true, int.Parse(txtNroTramite.Text), txtObservacion.Text, DateTime.Today);
            btnAutorizar.Visible = false;
            btnRechazar.Visible = true;
            btnRechazar.Enabled = true;
            RellenarDTGtramites();
            tabControl1.SelectedIndex = 1;
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            bdTramites gestor = new bdTramites();

            gestor.CambiarEstado(false, int.Parse(txtNroTramite.Text), txtObservacion.Text, DateTime.Today);
            btnRechazar.Visible = false;
            btnAutorizar.Visible = true;
            btnAutorizar.Enabled = true;
            RellenarDTGtramites();
            tabControl1.SelectedIndex = 1;
        }

        private void btnBuscarPDFs_Click(object sender, EventArgs e)
        {
            OFDpdf.Filter = "Todos los archivos (*.*)|*.*";
            OFDpdf.InitialDirectory = "c:\\";
            OFDpdf.Title = "Seleccionar imagen para el producto.";
            OFDpdf.FilterIndex = 1;
            OFDpdf.RestoreDirectory = false;
            if (OFDpdf.ShowDialog() == DialogResult.OK)
            {
                txtPdf.Text = OFDpdf.FileName;
            }
        }

        private void btnAbrirPdfs_Click(object sender, EventArgs e)
        {
            Process.Start(txtPdf.Text);
        }

        private void pbAgente_Click(object sender, EventArgs e)
        {
            frmAgentes frm = new frmAgentes();
            frm.Show();
        }

        private void pbSucursales_Click(object sender, EventArgs e)
        {
            frmSucursales frm = new frmSucursales();
            frm.Show();
        }

        private void cmbSucursal_SelectedIndexChanged_1(object sender, EventArgs e)
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
        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (tramites[i].pId == pk)
                {
                    return true;
                }
            }
            return false;
        }
        private bool validarCampos()
        {
            bool ok = true;

            if (txtNroTramite.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nro de tramite...");
                txtNroTramite.Focus();
                ok = false;
                errorCliente.SetError(txtNroTramite, "Ingrese un nro de tramite");
                return false;
            }
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI...");
                txtDocumento.Focus();
                ok = false;
                errorCliente.SetError(txtDocumento, "Ingrese DNI");
                return false;
            }
            if (cmbTipoTramite.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de tramite...");
                cmbTipoTramite.Focus();
                ok = false;
                errorCliente.SetError(cmbTipoTramite, "Ingrese un Tipo de tramite");
                return false;
            }
            if (cmbTipoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de pago...");
                cmbTipoPago.Focus();
                ok = false;
                errorCliente.SetError(cmbTipoPago, "Ingrese un Tipo de pago");
                return false;
            }
            if (cmbSucursal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una sucursal...");
                cmbSucursal.Focus();
                ok = false;
                errorCliente.SetError(cmbSucursal, "Ingrese una sucursal");
                return false;
            }
            if (cmbAgente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Agente...");
                cmbAgente.Focus();
                ok = false;
                errorCliente.SetError(cmbAgente, "Ingrese un Agente");
                return false;
            }
            if (txtPdf.Text == "")
            {
                MessageBox.Show("Debe cargar un pdf...");
                txtPdf.Focus();
                ok = false;
                errorCliente.SetError(txtPdf, "Cargue un pdf");
                return false;
            }
           

            return true;
        }
        private void btnCarga_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
            int tramite2 = int.Parse(txtNroTramite.Text) + 1;
            int dni = int.Parse(txtDocumento.Text);
            int tipoTramite = Convert.ToInt32(cmbTipoTramite.SelectedValue);
            int idtipopago = Convert.ToInt32(cmbTipoPago.SelectedValue);
            string descripcion = txtDescripcion.Text;
            int idagente = Convert.ToInt32(cmbAgente.SelectedValue);
            DateTime fecha = dtpFechaActual.Value;
            string url = txtPdf.Text;
           /// byte[] file = null;
            string linkpdf;
            /*   Stream myStream = OFDpdf.OpenFile();

               using (MemoryStream ms = new MemoryStream())

               {
                   myStream.CopyTo(ms);
                   file = ms.ToArray();
               }
           */
            MemoryStream ms = new MemoryStream();
            if (OFDpdf.FileName == "OFD_pdf")
            {
                linkpdf = "Sin pdf";
            }

            else
            {
                linkpdf = OFDpdf.FileName;
            }
                var bytes = File.ReadAllBytes(linkpdf);
                byte[] aByte = ms.ToArray();

            bdTramites gestor = new bdTramites();
            if (nuevo)
            {
                if (!validarPK(tramite2))
                {

                    clsTramites tramite = new clsTramites(tramite2, tipoTramite, fecha, dni, idtipopago, descripcion, idagente, true, bytes, url);


                    bool resultado = gestor.InsertarTramite(tramite);

                    if (resultado)
                    {
                        MessageBox.Show("El tramite se ha cargado con exito.", "Insertar Tramite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        lblCantidaddeRegistros.Text = "Cantidad de registros:" + dtgTramite.Rows.Count.ToString();
                        RellenarDTGtramites();
                        LimpiarTramite();
                        //  Habilitar(false);
                        tabControl1.SelectedIndex = 1;
                        nuevo = false;
                    }
                    else
                    {
                        MessageBox.Show("El tramite ya existe...");

                    }

                }
                 
            }

            else
            {
                int nrotramite = int.Parse(txtNroTramite.Text);
                clsTramites tramite3 = new clsTramites(nrotramite, tipoTramite, fecha, dni, idtipopago, descripcion, idagente, Convert.ToBoolean(txtEstado.Text), url);
                bool resultado2 = gestor.EditarTramite(tramite3);
                if (resultado2)
                {
                    MessageBox.Show("El agente se ha editado con exito.", "Editar agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RellenarDTGtramites();
                    LimpiarTramite();
                    //    Habilitar(false);
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar el agente" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                RellenarDTGtramites();


            }
        }
    }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            //  Habilitar(false);
            btnCarga.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Habilitar(true);
            nuevo = true;
            txtNroTramite.Enabled = true;
            LimpiarTramite();
        }

       

       
        private void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            RellenarDTGtramites();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void lblApellidoBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtNroTramite.Text);
            bdTramites gestor = new bdTramites();


            bool resultado = gestor.EliminarTramite(codigo);

            if (resultado)
            {
                MessageBox.Show("El tramite  se ha eliminado con exito.", "Elimiar Tramite", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarTramite();
                tabControl1.SelectedIndex = 1;
                RellenarDTGtramites();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar Elimiar el tramite" +
                    ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNroTramite_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            int codigo;
            try
            {
                codigo = int.Parse(txtDocumento.Text);
                string sql = "SELECT nombre, apellido FROM afiliados WHERE dni = " + codigo;
                buscarDocumento(sql);
            }
            catch (Exception)
            {
                LimpiarTramite();

            }
        }

        private void txtNroTramite_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void btnEnviarMail_Click(object sender, EventArgs e)
        {
            frmEnviarMail frm = new frmEnviarMail();
            frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);

            if (dtgTramite.SelectedRows.Count > 0 || dtgTramite.SelectedCells.Count > 0)
            {

                frm.txtPara.Text = dtgTramite.CurrentRow.Cells["mail"].Value.ToString();
                frm.txtAsunto.Text = dtgTramite.CurrentRow.Cells["dni"].Value.ToString() + ' ' + dtgTramite.CurrentRow.Cells["nombre"].Value.ToString() + ' ' + dtgTramite.CurrentRow.Cells["apellido"].Value.ToString();
                frm.txtCuerpo.Text = dtgTramite.CurrentRow.Cells["observacion"].Value.ToString();




                frm.ShowDialog();
            }
            else
                MessageBox.Show("Debe seleccionar un tramite...");
        }
    }
}

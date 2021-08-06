using CapaDato;
using CapaNegocio;
using NobisSA.Afiliados;
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
    public partial class frmAfiliados : Form
    {
        List<clsAfiliados> afiliados = new List<clsAfiliados>();
        bool nuevo;
        int c;
        public frmAfiliados()
        {
            InitializeComponent();
            dtgAfiliados.Columns[0].Visible = false;
            CargarCiudades(cmbCiudad);
            cargarCombo(cmbPlan,"Planes");
            cargarCombo(cmbTipoSexo, "Tiposexos");
            cargarCombo(cmbEstadoCivil, "TipoEstadoCivil");
            RellenarDTGafiliados();
            cmbCiudad.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbPlan.SelectedIndex = -1;
            cmbTipoSexo.SelectedIndex = -1;
            nuevo = true;

        }

        private void CargarCiudades(ComboBox cmb)
        {
            DataTable dt = new DataTable();
            bdAfiliados gestorRubro = new bdAfiliados();
            dt = gestorRubro.ConsultarCiudades();
            cmb.DataSource = dt;
            cmb.ValueMember = dt.Columns[0].ColumnName;
            cmb.DisplayMember = dt.Columns[1].ColumnName;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            CargarLocalidades(cmbLocalidad, Convert.ToInt32(cmb.SelectedValue));
        }

        private void CargarLocalidades(ComboBox cmb, int index)
        {
            DataTable dt = new DataTable();
            bdAfiliados gestor = new bdAfiliados();
            dt = gestor.ConsultarTablaLocalidades(index);
            cmb.DataSource = dt;
            cmb.ValueMember = dt.Columns[0].ColumnName;
            cmb.DisplayMember = dt.Columns[1].ColumnName;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void RellenarDTGafiliados()
        {
            DataTable dt = new DataTable();
            bdAfiliados gestor = new bdAfiliados();
            dt = gestor.ConsultarAfiliados();
            dtgAfiliados.DataSource = dt;
            dtgAfiliados.ReadOnly = true;
        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);
                CargarLocalidades(cmbLocalidad, idCiudad);
            }
            catch (Exception)
            {

                int idCiudad = -1;
                CargarLocalidades(cmbLocalidad, idCiudad);
            }
        }

        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (afiliados[i].pDni == pk)
                {
                    return true;
                }
            }
            return false;
        }
        private bool validarCampos()
        {
            bool ok = true;

            
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI...");
                txtDocumento.Focus();
                ok = false;
                errorCliente.SetError(txtDocumento, "Ingrese DNI");
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un Nombre...");
                txtNombre.Focus();
                ok = false;
                errorCliente.SetError(txtNombre, "Ingrese un Nombre");
                return false;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe ingresar un Apellido...");
                txtApellido.Focus();
                ok = false;
                errorCliente.SetError(txtApellido, "Ingrese un Apellido");
                return false;
            }
            if (cmbTipoSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de Sexo...");
                cmbTipoSexo.Focus();
                ok = false;
                errorCliente.SetError(cmbTipoSexo, "Ingrese un Tipo de Sexo");
                return false;
            }
            if (cmbEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de Estado Civil...");
                cmbEstadoCivil.Focus();
                ok = false;
                errorCliente.SetError(cmbEstadoCivil, "Ingrese un Estado Civil");
                return false;
            }
            if (cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una Ciudad...");
                cmbCiudad.Focus();
                ok = false;
                errorCliente.SetError(cmbCiudad, "Ingrese una Ciudad");
                return false;
            }
            if (cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una Localidad...");
                cmbLocalidad.Focus();
                ok = false;
                errorCliente.SetError(cmbLocalidad, "Ingrese una Localidad");
                return false;
            }
            if (txtDomicilio.Text == "")
            {
                MessageBox.Show("Debe ingresar un Domicilio...");
                txtDomicilio.Focus();
                ok = false;
                errorCliente.SetError(txtDomicilio, "Ingrese un Domicilio");
                return false;
            }
            if(txtTelefono.Text == "")
            {
                MessageBox.Show("Debe ingresar un Telefono...");
                txtDomicilio.Focus();
                ok = false;
                errorCliente.SetError(txtDomicilio, "Ingrese un Telefono");
                return false;
            }
            if(txtMail.Text == "")
            {
                MessageBox.Show("Debe ingresar un Mail...");
                txtDomicilio.Focus();
                ok = false;
                errorCliente.SetError(txtDomicilio, "Ingrese un Mail");
                return false;
            }
            if (cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar el Plan...");
                cmbPlan.Focus();
                ok = false;
                errorCliente.SetError(cmbPlan, "Ingrese el Plan");
                return false;
            }


            return true;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {

            int dni = int.Parse(txtDocumento.Text);
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fechaNac = dtpFechaNac.Value;
            int tipoSexo = Convert.ToInt32(cmbTipoSexo.SelectedValue);
            int estadoCivil = Convert.ToInt32(cmbEstadoCivil.SelectedValue);
            int localidad = Convert.ToInt32(cmbLocalidad.SelectedValue);
            string domicilio = txtDomicilio.Text;
            string telefono = txtTelefono.Text;
            string mail = txtMail.Text;
            int plan = Convert.ToInt32(cmbPlan.SelectedValue);

            clsAfiliados tramite = new clsAfiliados(dni, nombre, apellido, fechaNac, tipoSexo, estadoCivil, localidad, domicilio, telefono, mail, plan);
            // clsTramites tramite2 = new clsTramites(nrotramite, tipoTramite, fecha, dni, idtipopago, descripcion, idagente);
            bdAfiliados gestor = new bdAfiliados();
            if (nuevo)
            {
                
                if (!validarPK(dni))

                {
                  bool resultado = gestor.InsertarAfiliados(tramite);

                if (resultado)
                {
                    MessageBox.Show("El Afiliado se ha cargado con exito.", "Insertar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCantidaddeRegistros.Text = "Cantidad de registros:" + dtgAfiliados.Rows.Count.ToString();
                    RellenarDTGafiliados();
                    Limpiar();
                    tabControl1.SelectedIndex = 1;
                    nuevo = false;

                }
                else
                {
                    MessageBox.Show("Error al cargar el afiliado...");

                }
               }
            }
          
            else
            {
                
                bool resultado = gestor.EditarAfiliados(tramite);
                if (resultado)
                {
                    MessageBox.Show("El agente se ha editado con exito.", "Editar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RellenarDTGafiliados();
                    Limpiar();
                    tabControl1.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar el afiliado" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }              

                /* RellenarDTGtramites();
                 int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
                  cargarLista(idRubro);
                  Habilitar(false);
                 */

            }
            }
        }
        private void Limpiar()
        {
            txtDocumento.Text = "";
            txtDomicilio.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbCiudad.SelectedIndex = -1;
            cmbEstadoCivil.SelectedIndex = -1;
            cmbTipoSexo.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbPlan.SelectedIndex = -1;
            txtDomicilio.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";


        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
           // Habilitar(true);
        }
      /*  private void Habilitar(bool x)
        {
            txtDocumento.Enabled = x;
            txtNombre.Enabled = x;
            btnCargar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnBorrar.Enabled = x;
        }*/

        private void btnNuevo_Click(object sender, EventArgs e)
        {
           // Habilitar(true);
            nuevo = true;
            Limpiar();
            btnNuevo.Enabled = false;
            txtDocumento.Enabled = true;
        }

        private void dtgTramite_DoubleClick(object sender, EventArgs e)
        {
            txtDocumento.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[1].Value);
            txtNombre.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[2].Value);
            txtApellido.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[3].Value);
            dtpFechaNac.Value = Convert.ToDateTime(dtgAfiliados.CurrentRow.Cells[4].Value);
            cmbTipoSexo.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[5].Value);
            cmbEstadoCivil.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[6].Value);
            cmbLocalidad.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[7].Value);
            cmbCiudad.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[8].Value);
            txtDomicilio.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[9].Value);
            txtTelefono.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[10].Value);
            txtMail.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[11].Value);
            cmbPlan.Text = Convert.ToString(dtgAfiliados.CurrentRow.Cells[12].Value);


            txtDocumento.Enabled = false;
            nuevo = false;
            btnNuevo.Enabled = true;
            tabControl1.SelectedIndex = 0;
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked == true)
            {
                dtgAfiliados.Columns[0].Visible = true;
            }
            else
            {
                dtgAfiliados.Columns[0].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea eliminar los registros?", "Afiliados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                int dni;
                string sql;
                AccesoDatos bd = new AccesoDatos();
                foreach (DataGridViewRow row in dtgAfiliados.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        dni = Convert.ToInt32(row.Cells[1].Value);
                        sql = "update afiliados set estado = 0 where  dni =" + dni;
                        bd.actualizarBD(sql);
                        tabControl1.SelectedIndex = 1;
                    }
                }

            }
            RellenarDTGafiliados();
            lblCantidaddeRegistros.Text = "Cantidad de registros:" + dtgAfiliados.Rows.Count.ToString();
        }

        private void dtgAfiliados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgAfiliados.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dtgAfiliados.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtDocumento.Text);
            bdAfiliados gestor = new bdAfiliados();


            bool resultado = gestor.EliminarAfiliado(codigo);

            if (resultado)
            {
                MessageBox.Show("El afiliado  se ha eliminado con exito.", "Elimiar Afiliado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                RellenarDTGafiliados();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar Elimiar el afiliado" +
                    ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            rprtAfiliados rprt = new rprtAfiliados();
            rprt.Show();
        }

        private void txtBuscarTramite_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select dni,nombre,apellido,fechanac,ts.sexo,te.estadoCivil,l.localidad,c.ciudad,domicilio,telefono,mail,p.nombrePlan from Afiliados a
                                                inner join tiposexos ts on a.idTiposexo = ts.idtiposexo
                                                inner join TipoEstadoCivil te on a.idEstadoCivil = te.IdTipoEstadoCivil
                                                inner join localidades l on l.idlocalidad=a.idLocalidad
                                                inner join planes p on p.idPlan=a.idPlan
                                                inner join ciudades c on l.idCiudad=c.idCiudad WHERE dni LIKE '" + txtBuscarAfiliado.Text + "%'  or apellido LIKE '" + txtBuscarAfiliado.Text + "%'";
            Buscar(sql, dtgAfiliados);
        }
        public void Buscar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            AccesoDatos gestor = new AccesoDatos();
            dt = gestor.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidaddeRegistros.Text = "Cantidad de registros: " + dtgAfiliados.Rows.Count.ToString();

        }

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }
    }
}


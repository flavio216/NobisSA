using CapaDato;
using CapaNegocio;
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
    public partial class frmAfiliados : Form
    {
        bool nuevo;
        public frmAfiliados()
        {
            InitializeComponent();
            CargarCiudades(cmbCiudad);
            cargarCombo(cmbPlan,"Planes");
            cargarCombo(cmbTipoSexo, "Tiposexos");
            cargarCombo(cmbEstadoCivil, "TipoEstadoCivil");
            RellenarDTGafiliados();

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

        private void btnCargar_Click(object sender, EventArgs e)
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

                bool resultado = gestor.InsertarAfiliados(tramite);

                if (resultado)
                {
                    MessageBox.Show("El agente se ha cargado con exito.", "Insertar Agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   /* lblCantidaddeRegistros.Text = "Cantidad de registros:" + dtgTramite.Rows.Count.ToString();
                    RellenarDTGtramites();
                    LimpiarAfiliado();
                    tabControl1.SelectedIndex = 1;*/

                }
                else
                {
                    MessageBox.Show("Error al cargar el agente...");

                }

            }

            else
            {
                
                bool resultado = gestor.EditarAfiliados(tramite);
                if (resultado)
                {
                    MessageBox.Show("El agente se ha editado con exito.", "Editar agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   /* RellenarDTGtramites();
                    LimpiarAfiliado();
                    tabControl1.SelectedIndex = 1;*/
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar el agente" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


               /* RellenarDTGtramites();
                int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
                 cargarLista(idRubro);
                 Habilitar(false);
                */
           
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            Habilitar(true);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(true);
            nuevo = true;
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

            btnCargar.Enabled = false;
            tabControl1.SelectedIndex = 0;
        }
    }
}


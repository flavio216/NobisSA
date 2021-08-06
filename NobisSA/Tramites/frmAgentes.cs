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

namespace NobisSA.Tramites
{
    public partial class frmAgentes : Form
    {
        List<clsAgentes> agentes = new List<clsAgentes>();
        bool nuevo;
        int c;
       
        public frmAgentes()
        {
            InitializeComponent();
            cargarCombo();
            nuevo = true;
            btnCargar.Enabled = false;
            btnBorrar.Enabled = false;
            lstAgente.Items.Clear();
            //txtcodigo.Enabled = false;

        }
        private void cargarCombo()
        {
            DataTable dt = new DataTable();
            bdSucursales gestor = new bdSucursales();
            dt = gestor.consultarSucursales();
            cmbSucursales.DataSource = dt;
            cmbSucursales.ValueMember = dt.Columns[0].ColumnName;
            cmbSucursales.DisplayMember = dt.Columns[1].ColumnName;
            cmbSucursales.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSucursales.SelectedIndex = -1;
            nuevo = true;
        }
        private void cargarLista(int id)
        {
            lstAgente.Items.Clear();
            agentes.Clear();

            bdAgentes gestor = new bdAgentes();

            DataTable dt = gestor.ConsultarTablaAgentes(id);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clsAgentes r = new clsAgentes();
                r.pId = Convert.ToInt32(dt.Rows[i]["idagente"]);
                r.pIdsucursal = Convert.ToInt32(dt.Rows[i]["idsucursal"]);
                r.pNombre = dt.Rows[i]["agente"].ToString();
                r.pMail = dt.Rows[i]["mail"].ToString();
                r.pContrasena = dt.Rows[i]["contrasena"].ToString();
                 nuevo = false;
               
                //  r.pEstado = Convert.ToInt32(dt.Rows[i]["Estado"]);

                agentes.Add(r);
                lstAgente.Items.Add(r);
            }
            lstAgente.SelectedIndex = -1;

        }
        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (agentes[i].pId == pk)
                {
                    return true;
                }
            }
            return false;
        }
        private bool arregloCompleto(int contador, int tamanio)
        {
            if (contador != tamanio)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool validarCampos()
        {
            bool ok = true;

            if (cmbSucursales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar una Sucursal...");
                cmbSucursales.Focus();
                ok = false;
                errorCliente.SetError(cmbSucursales, "Ingrese una sucursal");
                return false;
            }
            if (txtDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar el DNI...");
                txtDNI.Focus();
                ok = false;
                errorCliente.SetError(txtDNI, "Ingrese DNI");
                return false;
            }
            if (txtAgente.Text == "")
            {
                MessageBox.Show("Debe ingresar un Agente...");
                txtAgente.Focus();
                ok = false;
                errorCliente.SetError(txtAgente, "Ingrese un Agente");
                return false;
            }
            if (txtMail.Text == "")
            {
                MessageBox.Show("Debe ingresar un Correo...");
                txtMail.Focus();
                ok = false;
                errorCliente.SetError(txtMail, "Ingrese un Correo");
                return false;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña...");
                txtPass.Focus();
                ok = false;
                errorCliente.SetError(txtPass, "Ingrese una contraseña");
                return false;
            }

            return true;
        }
        private void Limpiar()
        {
            //cmbSucursales.SelectedIndex = -1;
            txtAgente.Text = "";
            txtDNI.Text = "";
            txtMail.Text = "";
            txtPass.Text = "";
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            

            if(validarCampos())
            {
                int idsucursal = Convert.ToInt32(cmbSucursales.SelectedValue);
                int codigo = int.Parse(txtDNI.Text);
                string agente = txtAgente.Text;
                string mail = txtMail.Text;
                string contrasena = txtPass.Text;
                
                bdAgentes gestor = new bdAgentes();
                if (nuevo)
            {
                
                if (!validarPK(codigo))

                {
                    bool resultado = gestor.Insertaragente(codigo, agente, idsucursal,mail, contrasena);

                    if (resultado)
                    {
                        MessageBox.Show("El agente se ha cargado con exito.", "Insertar Agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cargarLista(idsucursal);
                        Limpiar();
                        nuevo = true;
                            btnNuevo.Enabled = true;
                            btnCargar.Enabled = false;
                            //this.Close();
                        }
                    else
                    {
                        MessageBox.Show("Error al cargar el agente...");
                            nuevo = true;
                    }

                }
            }
            else
            {
               
                bool resultado2 = gestor.EditarAgente(agente, codigo,mail,contrasena);
                if (resultado2)
                {
                    MessageBox.Show("El agente se ha editado con exito.", "Editar agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar el agente" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }


            int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
            cargarLista(idRubro); 
         //   Habilitar(false);
        
        }

        private void lstAgente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = lstAgente.SelectedIndex;
                txtAgente.Text = agentes[pos].pNombre;
                txtDNI.Text = (agentes[pos].pId).ToString();
                txtMail.Text = agentes[pos].pMail;
                txtPass.Text = agentes[pos].pContrasena;
                btnNuevo.Enabled = true;
                btnBorrar.Enabled = true;
                btnCargar.Enabled = true;
                nuevo = false;
                txtDNI.Enabled = false;
            }

            catch (Exception)
            {

                MessageBox.Show("Por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           // cargarLista();
        }
       /* private void Habilitar(bool x)
        {
            txtAgente.Enabled = x;
            btnCargar.Enabled = x;
            btnNuevo.Enabled = !x;
            lstAgente.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnNuevo.Enabled = !x;

        }*/

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
           // Habilitar(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDNI.Text = "";
            txtAgente.Text = "";
            txtPass.Text = "";
            txtMail.Text = "";
           // cmbSucursales.SelectedIndex = -1;
            nuevo = true;
            btnNuevo.Enabled = false;
            btnCargar.Enabled = true;
            txtDNI.Enabled = true;
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            int codigo = int.Parse(txtDNI.Text);
            bdAgentes gestor = new bdAgentes();


            bool resultado = gestor.EliminarAgente(codigo);

            if (resultado)
            {
                MessageBox.Show("El agente se ha eliminado con exito.", "Elimiar agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Limpiar();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar Elimiar el agente" +
                    ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
            cargarLista(idRubro);
        }


        private void cmbAgentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
                cargarLista(idRubro);
                txtAgente.Text = "";
                txtDNI.Text = "";
                

            }
            catch (Exception)
            {

                int idRubro = -1;
                cargarLista(idRubro);
            }
        }

        private void frmAgentes_Load(object sender, EventArgs e)
        {
        //    Habilitar(false);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }

        private void txtAgente_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }
    }
}

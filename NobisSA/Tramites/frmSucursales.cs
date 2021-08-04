using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace NobisSA
{
    public partial class frmSucursales : Form
    {
        List<clsSucursales> sucursales = new List<clsSucursales>();
        bool nuevo;
        int c;

        public frmSucursales()
        {
            InitializeComponent();
            nuevo = false;
            cargarLista();
            btnCargar.Enabled = false;
            btnBorrar.Enabled = false;
        }
         private void cargarLista()
         {
             lstSucursales.Items.Clear();
             sucursales.Clear();

             bdSucursales gestor = new bdSucursales();

             DataTable dt = gestor.consultarSucursales();

             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 clsSucursales r = new clsSucursales();
                 r.pId = Convert.ToInt32(dt.Rows[i]["idSucursal"]);
                 r.pSucursal = dt.Rows[i]["sucursal"].ToString();
               //  r.pEstado = Convert.ToInt32(dt.Rows[i]["Estado"]);

                 sucursales.Add(r);
                lstSucursales.Items.Add(r);
             }
             lstSucursales.SelectedIndex = -1;

         }
        private bool validarCampos()
        {
            bool ok = true;

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un Codigo Postal...");
                txtCodigo.Focus();
                ok = false;
                errorCliente.SetError(txtCodigo, "Ingrese un Codigo Postal");
                return false;
            }
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la sucursal...");
                txtNombre.Focus();
                ok = false;
                errorCliente.SetError(txtNombre, "Ingrese Sucursal");
                return false;
            }


            return true;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if(validarCampos())
            {
                
                int codigo = int.Parse(txtCodigo.Text);
                string sucursal = txtNombre.Text;
                bdSucursales gestor = new bdSucursales();
           
           if(nuevo)
            {
                if (!validarPK(codigo))

                {
                bool resultado = gestor.InsertarSucursal(codigo,sucursal);

                    if (resultado)
                    {
                        MessageBox.Show("La sucursal se ha cargado con exito.", "Insertar Sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        nuevo = false;
                        txtCodigo.Text = "";
                        txtNombre.Text = "";
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una sucursal con este codigo...");
                        txtCodigo.Focus();
                    }

                }
            }
            else
            {
                bool resultado2 = gestor.EditarSucursal(sucursal, codigo);
                if (resultado2)
                {
                    MessageBox.Show("La sucursal se ha editado con exito.", "Editar sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar una sucursal" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }


            cargarLista();
            //Habilitar(false);
        }
    

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            //Habilitar(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Habilitar(true);
            btnBorrar.Enabled = false;
            btnCargar.Enabled = true;
            btnNuevo.Enabled = false;
            txtCodigo.Enabled = true;
            nuevo = true;
            Limpiar();
        }
        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (sucursales[i].pId == pk)
                {
                    return true;
                }
            }
            return false;
        }
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
           // Habilitar(false);
        }

        private void lstSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = lstSucursales.SelectedIndex;
                txtNombre.Text = sucursales[pos].pSucursal;
                txtCodigo.Text = (sucursales[pos].pId).ToString();
                txtCodigo.Enabled = false;
                btnNuevo.Enabled = true;
                btnBorrar.Enabled = true;
                btnCargar.Enabled = true;
                nuevo = false;
            }

            catch (Exception)
            {

                MessageBox.Show("Por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargarLista();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            bdSucursales gestor = new bdSucursales();


            bool resultado = gestor.EliminarSucursal(codigo);

            if (resultado)
            {
                MessageBox.Show("La sucursal se ha eliminado con exito.", "Elimiar sucursal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar Elimiar una sucursal" +
                    ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargarLista();
        }
       /* private void Habilitar(bool x)
        {
            txtCodigo.Enabled = x;
            txtNombre.Enabled = x;
            btnCargar.Enabled = x;
            btnNuevo.Enabled = !x;
            lstSucursales.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnCancelar.Enabled = x;
        }*/

        private void frmSucursales_Load(object sender, EventArgs e)
        {
            // Habilitar(false);
          //  this.reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }
    }
    }


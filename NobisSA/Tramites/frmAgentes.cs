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
            lstAgente.Items.Clear();

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
        private void btnCargar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtcodigo.Text);
            string agente = txtAgente.Text;
            int idsucursal = Convert.ToInt32(cmbSucursales.SelectedValue);
            bdAgentes gestor = new bdAgentes();

            if (nuevo)
            {
                
                if (!validarPK(codigo))

                {
                    bool resultado = gestor.Insertaragente(codigo, agente, idsucursal);

                    if (resultado)
                    {
                        MessageBox.Show("El agente se ha cargado con exito.", "Insertar Agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      //  cargarLista();
                        txtAgente.Text = "";
                        //this.Close();
                 }
                    else
                    {
                        MessageBox.Show("Error al cargar el agente...");
                      
                    }

                }
            }
            else
            {
               
                bool resultado2 = gestor.EditarAgente(agente, codigo);
                if (resultado2)
                {
                    MessageBox.Show("El agente se ha editado con exito.", "Editar agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar el agente" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
            cargarLista(idRubro); 
            Habilitar(false);
        
        }

        private void lstAgente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int pos = lstAgente.SelectedIndex;
                txtAgente.Text = agentes[pos].pNombre;
                txtcodigo.Text = (agentes[pos].pId).ToString();
            }

            catch (Exception)
            {

                MessageBox.Show("Por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           // cargarLista();
        }
        private void Habilitar(bool x)
        {
            txtAgente.Enabled = x;
            btnCargar.Enabled = x;
            btnNuevo.Enabled = !x;
            lstAgente.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnEditar.Enabled = !x;
            btnNuevo.Enabled = !x;
            btnCancelar.Enabled = x;
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
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            int codigo = int.Parse(txtcodigo.Text);
            bdAgentes gestor = new bdAgentes();


            bool resultado = gestor.EliminarAgente(codigo);

            if (resultado)
            {
                MessageBox.Show("El agente se ha eliminado con exito.", "Elimiar agente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar Elimiar el agente" +
                    ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         //   cargarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
        }

        private void cmbAgentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
                cargarLista(idRubro);
                
            }
            catch (Exception)
            {

                int idRubro = -1;
                cargarLista(idRubro);
            }
        }

        private void frmAgentes_Load(object sender, EventArgs e)
        {
            Habilitar(false);
        }
    }
}

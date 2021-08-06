using CapaDato;
using CapaNegocio;
using CapaNegocio.Envios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobisSA.Envios
{
    public partial class frmEnvios : Form
    {
        List<DTOEnvios> Listado = new List<DTOEnvios>();
        public frmEnvios()
        {
            InitializeComponent();
            RellenarDTGEnvios();
            btnAgregar.Enabled = false;
            lblNombre.Text = "";
            
            CargarSucursales(cmbSucursal);
            cmbSucursal.SelectedIndex = -1;
            dtgEnvioSucu.Columns[0].Visible = false;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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
            
        }
        private void Buscar(string sql)
        {
            DataTable dt = new DataTable();
            AccesoDatos gestor = new AccesoDatos();
            dt = gestor.buscarTabla(sql);
            try
            {
                lblNombre.Text = dt.Rows[0]["Nombre"].ToString();
              //  MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Imagen"]);
              //  Bitmap bm = new Bitmap(ms);
              //  pbProducto.Image = bm;
                btnAgregar.Enabled = true;
            }
            catch (Exception)
            {
                lblNombre.Text = "";
               // txtCantidad.Clear();
              //  pbProducto.Image = null;
                btnAgregar.Enabled = false;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dtgvEnvios.SelectedRows)
            {
                if (!row.IsNewRow)
                    dtgvEnvios.Rows.Remove(row);
            }
        }

        private void btnBorrarLista_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la lista?, esta acción no se puede deshacer.", "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dtgvEnvios.Rows.Clear();
                Limpiar();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    
        public void Limpiar()
        {
            txtID.Clear();
            lblNombre.Text = "";
            txtCantidad.Clear();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtID.Text);
            string nombre = lblNombre.Text;
            int cantidad = int.Parse(txtCantidad.Text);
            DateTime fechaEnvio = DateTime.Today;
            bool existe = false;

            foreach (var item in Listado)
            {
                if (item.pCodigo == codigo)
                {
                    item.pCantidad += cantidad;
                    existe = true;
                }
            }

            if (!existe)
            {
                DTOEnvios prod = new DTOEnvios(codigo, nombre, cantidad,fechaEnvio);

                Listado.Add(prod);
            }

            var list = new BindingList<DTOEnvios>(Listado);
            dtgvEnvios.DataSource = list;
            dtgvEnvios.Columns[0].HeaderText = "Codigo";
            dtgvEnvios.Columns[1].HeaderText = "Nombre";
            dtgvEnvios.Columns[2].HeaderText = "Cantidad";
            dtgvEnvios.Columns[3].HeaderText = "Fecha Envio";
            //Limpiar();

            /*   foreach (var producto in Listado)
               {
                   total += producto.pCantidad * producto.pPrecio;
               }
               lblSubTotal.Text = total.ToString();*/
            btnAgregar.Enabled = false;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            int codigo;
            int cantidad;
            try
            {
                codigo = int.Parse(txtID.Text);
                cantidad = int.Parse(txtCantidad.Text);
                string sql = "SELECT Nombre FROM Productos WHERE idcodigo = " + codigo + " AND stock >= " + cantidad;



                Buscar(sql);
                //txtCantidad.Text = "1";
            }
            catch (Exception)
            {
                txtCantidad.Text = "0";

            }
        }
        private void RellenarDTGEnvios()
        {
            DataTable dt = new DataTable();
            bdEnvios gestor = new bdEnvios();
            dt = gestor.ConsultarEnvios();
            dtgEnvioSucu.DataSource = dt;
            dtgEnvioSucu.ReadOnly = true;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            int codigo;
            try
            {
                codigo = int.Parse(txtID.Text);
                string sql = "SELECT Nombre FROM Productos WHERE idcodigo = " + codigo + " AND Estado = 1";

                Buscar(sql);
                txtCantidad.Text = "1";
            }
            catch (Exception)
            {
                // txtCantidad.Text = "0";

            }
        }
      
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtID.Text);
            DateTime fechaEnvio = DateTime.Today;
            int idsucursal = Convert.ToInt32(cmbSucursal.SelectedValue);
            
           

            clsEnvios envios = new clsEnvios(idsucursal,fechaEnvio);
            bdEnvios gestor = new bdEnvios();
            int  id = gestor.InsertarEnvios(envios);

            foreach (DataGridViewRow row in dtgvEnvios.Rows)
            {
                if (!(row.Cells[0].Value == null))
                {
                    codigo = Convert.ToInt32(row.Cells[0].Value.ToString());


                    clsDetalleEnvios dv = new clsDetalleEnvios(0, codigo,id);
                    gestor.InsertarDetalle(dv);
                }

            }

            DialogResult opcion;
            opcion = MessageBox.Show("Desea imprimir el listado de envio?", "Envios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                rprtEnvios rprt = new rprtEnvios(id);
                rprt.ShowDialog();
            }
            else

            
            MessageBox.Show("Se envio con exito a la sucursal");
            RellenarDTGEnvios();
            tabControl1.SelectedIndex = 1;
            
          /*  else
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
                }*/
            }

        private void dtgEnvioSucu_DoubleClick(object sender, EventArgs e)
        {
            /*txtID.Text = Convert.ToString(dtgvEnvios.CurrentRow.Cells[0].Value);
            cmbSucursal.Text = Convert.ToString(dtgvEnvios.CurrentRow.Cells[2].Value);
            dtpFechaEnvio.Value = Convert.ToDateTime(dtgvEnvios.CurrentRow.Cells[3].Value);
            
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
           */
            }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked == true)
            {
                dtgEnvioSucu.Columns[0].Visible = true;
            }
            else
            {
                dtgEnvioSucu.Columns[0].Visible = false;
            }
        }

        private void dtgEnvioSucu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgEnvioSucu.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dtgEnvioSucu.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
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
                foreach (DataGridViewRow row in dtgEnvioSucu.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToString(row.Cells[1].Value);
                        sql = "delete from detalleenvios where idenvio =" + codigo;
                        bd.actualizarBD(sql);
                        RellenarDTGEnvios();
                    }
                }

            }
            RellenarDTGEnvios();
            lblCantidadRegistros.Text = "Cantidad de registros:" + dtgEnvioSucu.Rows.Count.ToString();
        }

        private void txtBuscarTramite_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = @"select de.idEnvio,de.idCodigo,p.nombre,sucursal,fechaEnvio from DetalleEnvios de
                                            inner join envios e on e.idEnvio = de.idEnvio
                                            inner join sucursales s on s.idSucursal = e.idSucursal
                                            inner join productos p on p.idCodigo = de.idCodigo WHERE s.sucursal LIKE '" + txtBuscar.Text + "%' or de.idenvio LIKE '" + txtBuscar.Text + "%' or p.nombre LIKE '" + txtBuscar.Text + "%' or de.idcodigo LIKE '" + txtBuscar.Text + "%'";
                Buscar(sql, dtgEnvioSucu);
            }
            catch (Exception)
            {

                Limpiar();
            }
        }

        public void Buscar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            AccesoDatos bd = new AccesoDatos();
            dt = bd.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidadRegistros.Text = "Cantidad de registros:" + dtgEnvioSucu.Rows.Count.ToString();


        }
    }
    }
    


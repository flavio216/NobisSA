using CapaDato;
using CapaNegocio;
using NobisSA.Inventario;
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
    public partial class frmProductos : Form
    {
        const int tam = 150;
        bool nuevo;
        clsProductos[] P = new clsProductos[tam];
        int c;
        public frmProductos()
        {
            InitializeComponent();
            nuevo = true;
            RellenarDTGproductosConStock();
            RellenarDTGproductosSinStock();
            dtgProductoConStock.Columns[0].Visible = false;
            dtgProductoSinStock.Columns[0].Visible = false;
            lblCantidadConStock.Text = "Cantidad de registros:" + dtgProductoConStock.Rows.Count.ToString();
            lblCantidadSinStock.Text = "Cantidad de registros:" + dtgProductoSinStock.Rows.Count.ToString();

        }
        private void RellenarDTGproductosConStock()
        {
            DataTable dt = new DataTable();
            bdProductos gestor = new bdProductos();
            dt = gestor.ConsultarProductosConStock();
            dtgProductoConStock.DataSource = dt;
            dtgProductoConStock.ReadOnly = true;
        }
        private void RellenarDTGproductosSinStock()
        {
            DataTable dt = new DataTable();
            bdProductos gestor = new bdProductos();
            dt = gestor.ConsultarProductosSinStock();
            dtgProductoSinStock.DataSource = dt;
            dtgProductoSinStock.ReadOnly = true;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            bool estado;
            int codigo = int.Parse(txtCodigo.Text);
            string nombre = txtNombre.Text;
            double precio = double.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);
            if (stock > 0)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }
            clsProductos producto = new clsProductos(codigo, nombre, stock, precio, estado);
            bdProductos gestor = new bdProductos();

            if (nuevo)
           {

                if (!validarPK(codigo))

                {
                    bool resultado = gestor.InsertarProductos(producto);

                    if (resultado)
                    {
                        MessageBox.Show("El producto se ha cargado con exito.", "Insertar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        if (estado)
                        {
                            tabControl1.SelectedIndex = 0;
                        }
                        else
                        {
                            tabControl1.SelectedIndex = 2;
                        }


                        RellenarDTGproductosConStock();
                        RellenarDTGproductosSinStock();
                        lblCantidadConStock.Text = "Cantidad de registros:" + dtgProductoConStock.Rows.Count.ToString();
                        lblCantidadSinStock.Text = "Cantidad de registros:" + dtgProductoSinStock.Rows.Count.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar el producto...");

                    }

                }
            }
            else
            {

                bool resultado2 = gestor.EditarProductos(producto);
                if (resultado2)
                {
                    MessageBox.Show("El producto se ha editado con exito.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (estado)
                    {
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                    {
                        tabControl1.SelectedIndex = 2;
                    }
                   
                    
                    RellenarDTGproductosConStock();
                    RellenarDTGproductosSinStock();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar editar el producto" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

/*
            int idRubro = Convert.ToInt32(cmbSucursales.SelectedValue);
            cargarLista(idRubro);
            Habilitar(false);*/

        }
        private bool validarPK(int pk)
        {
            for (int i = 0; i < c; i++)
            {
                if (P[i].pCodigo == pk)
                {
                    return true;
                }
            }
            return false;
        }


        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked == true)
            {
                dtgProductoConStock.Columns[0].Visible = true;
            }
            else
            {
                dtgProductoConStock.Columns[0].Visible = false;
            }
        }

        private void chkEliminarSinStock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminarSinStock.Checked == true)
            {
                dtgProductoSinStock.Columns[0].Visible = true;
            }
            else
            {
                dtgProductoSinStock.Columns[0].Visible = false;
            }
        }

        private void dtgProductoConStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgProductoConStock.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dtgProductoConStock.Rows[e.RowIndex].Cells["Eliminar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nuevo = false;
           // Habilitar(true);
        }
       /* private void Habilitar(bool x)
        {
            btnCargar.Enabled = x;
            btnNuevo.Enabled = !x;
            btnEditar.Enabled = !x;
        }*/
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            nuevo = true;
            txtCodigo.Enabled = true;
        }

        private void dtgProductoConStock_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dtgProductoConStock.CurrentRow.Cells[1].Value);
            txtNombre.Text = Convert.ToString(dtgProductoConStock.CurrentRow.Cells[2].Value);
            txtStock.Text = Convert.ToString(dtgProductoConStock.CurrentRow.Cells[3].Value);
            txtPrecio.Text = Convert.ToString(dtgProductoConStock.CurrentRow.Cells[4].Value);

            txtCodigo.Enabled = false;
            nuevo = false;
            tabControl1.SelectedIndex = 1;
           // Habilitar(true);
        }

        private void dtgProductoSinStock_DoubleClick(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(dtgProductoSinStock.CurrentRow.Cells[1].Value);
            txtNombre.Text = Convert.ToString(dtgProductoSinStock.CurrentRow.Cells[2].Value);
            txtStock.Text = Convert.ToString(dtgProductoSinStock.CurrentRow.Cells[3].Value);
            txtPrecio.Text = Convert.ToString(dtgProductoSinStock.CurrentRow.Cells[4].Value);

            txtCodigo.Enabled = false;
            nuevo = false;
            tabControl1.SelectedIndex = 1;
           // Habilitar(false);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            DialogResult opcion;
            opcion = MessageBox.Show("Desea eliminar los registros?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                int codigo = int.Parse(txtCodigo.Text);
                bdProductos gestor = new bdProductos();


                bool resultado = gestor.EliminarProducto(codigo);

                if (resultado)
                {
                    MessageBox.Show("El producto se ha eliminado con exito.", "Elimiar producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblCantidadConStock.Text = "Cantidad de registros:" + dtgProductoConStock.Rows.Count.ToString();
                    lblCantidadSinStock.Text = "Cantidad de registros:" + dtgProductoSinStock.Rows.Count.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al intentar Elimiar el producto" +
                        ", por favor contacte al Administrador del sistema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           // Habilitar(false);
        }
        public void Buscar(string sql, DataGridView dtgv)
        {
            DataTable dt = new DataTable();
            AccesoDatos gestor = new AccesoDatos();
            dt = gestor.buscarTabla(sql);
            dtgv.DataSource = dt;
            lblCantidadConStock.Text = "Cantidad de registros: " + dtgProductoConStock.Rows.Count.ToString();
            lblCantidadSinStock.Text = "Cantidad de registros: " + dtgProductoSinStock.Rows.Count.ToString();
        }
        private void txtBuscarStock_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from productos WHERE estado = 1 and idcodigo LIKE '" + txtBuscarStock.Text + "%' or nombre LIKE '" + txtBuscarStock.Text + "%' ";
            Buscar(sql, dtgProductoConStock);
        }

        private void txtBuscarSinStock_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select * from productos WHERE estado = 0 and idcodigo LIKE '" + txtBuscarStock.Text + "%' or nombre LIKE '" + txtBuscarStock.Text + "%'";
            Buscar(sql, dtgProductoSinStock);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            RprtProductosStock rprt = new RprtProductosStock();
            rprt.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea eliminar los registros?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                int codigo;
                string sql;
                AccesoDatos bd = new AccesoDatos();
                foreach (DataGridViewRow row in dtgProductoConStock.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        sql = "update productos set estado = 0 where idcodigo =" + codigo;
                        bd.actualizarBD(sql);
                    }
                }

            }
            RellenarDTGproductosConStock();
            lblCantidadConStock.Text = "Cantidad de registros:" + dtgProductoConStock.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rprtProductosSinStock rprt = new rprtProductosSinStock();
            rprt.Show();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }

 
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloDecimales(e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea eliminar los registros?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                int codigo;
                string sql;
                AccesoDatos bd = new AccesoDatos();
                foreach (DataGridViewRow row in dtgProductoConStock.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        codigo = Convert.ToInt32(row.Cells[1].Value);
                        sql = "update productos set estado = 0 where idcodigo =" + codigo;
                        bd.actualizarBD(sql);
                    }
                }

            }
            RellenarDTGproductosConStock();
            lblCantidadSinStock.Text = "Cantidad de registros:" + dtgProductoConStock.Rows.Count.ToString();
        }
    }
}


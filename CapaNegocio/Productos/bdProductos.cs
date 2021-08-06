using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class bdProductos
    {
        public bool InsertarProductos(clsProductos p)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "INSERT INTO productos (idcodigo,nombre,stock,preciocompra,estado) VALUES (@idcodigo,@nombre,@stock,@preciocompra,@estado)";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcodigo", p.pCodigo);
                cmd.Parameters.AddWithValue("@nombre", p.pProducto);
                cmd.Parameters.AddWithValue("@stock", p.pStock);
                cmd.Parameters.AddWithValue("@preciocompra", p.pPrecioCompra);
                cmd.Parameters.AddWithValue("@estado", p.pEstado);
                /*cmd.Parameters.AddWithValue("@estado", p.pest);
                if (p.pStock > 0)
                {
                    p.pEstado = true;
                }
                else
                {
                    p.pEstado = false;
                }
                */



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conex.Conectar();
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show(

                    "No se ha podido insertar.",
                    "Aviso");
            }
            finally
            {
                conex.Desconectar();
            }

            return resultado;
        }
        public DataTable ConsultarProductosConStock()
        {
            DataTable dt = new DataTable();
            AccesoDatos conex = new AccesoDatos();
            try
            {

                conex.Conectar();
                conex.pComando.CommandText = @"select idcodigo,nombre,stock,preciocompra from productos where estado = 1";
                dt.Load(conex.pComando.ExecuteReader());

            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("No se podido establecer conexión con la base de datos, por favor contacte al administrador" +
                    "del sistema.");
                return dt;
            }

            finally
            {
                conex.Desconectar();
            }
            return dt;
        }
        public bool EditarProductos(clsProductos a)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = @"UPDATE productos SET 
                    nombre = @nombre,
                    stock = @stock,
                    preciocompra = @preciocompra,
                    estado = @estado
                     WHERE idcodigo = @idcodigo";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcodigo", a.pCodigo);
                cmd.Parameters.AddWithValue("@nombre", a.pProducto);
                cmd.Parameters.AddWithValue("@stock", a.pStock);
                cmd.Parameters.AddWithValue("@preciocompra", a.pPrecioCompra);
                cmd.Parameters.AddWithValue("@estado", a.pEstado);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conex.Conectar();
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show(

                    "No se ha podido actualizar.",
                    "Aviso");
            }
            finally
            {
                conex.Desconectar();
            }

            return resultado;
        }
        public DataTable ConsultarProductosSinStock()
        {
            DataTable dt = new DataTable();
            AccesoDatos conex = new AccesoDatos();
            try
            {

                conex.Conectar();
                conex.pComando.CommandText = @"select idcodigo,nombre,stock,preciocompra from productos where estado = 0 and stock=0";
                dt.Load(conex.pComando.ExecuteReader());

            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("No se podido establecer conexión con la base de datos, por favor contacte al administrador" +
                    "del sistema.");
                return dt;
            }

            finally
            {
                conex.Desconectar();
            }
            return dt;
        }
        public bool EliminarProducto(int id)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "update productos set estado = 0 WHERE idcodigo = @idcodigo";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idcodigo", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conex.Conectar();
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show(

                    "No se ha podido eliminar.",
                    "Aviso");
            }
            finally
            {
                conex.Desconectar();
            }

            return resultado;
        }
    }
}

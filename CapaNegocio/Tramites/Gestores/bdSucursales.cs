using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;

namespace CapaNegocio
{
    public class bdSucursales
    {
        public bool InsertarSucursal(int idsucursal, string nombre)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "INSERT INTO sucursales (idsucursal, sucursal) VALUES (@idsucursal,@sucursal)";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idsucursal", idsucursal);
                cmd.Parameters.AddWithValue("@sucursal", nombre);

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
        
        public DataTable consultarSucursales()
        {
            AccesoDatos conex = new AccesoDatos();
            DataTable dt = new DataTable();
            conex.Conectar();
            conex.pComando.CommandText = "SELECT idsucursal, sucursal FROM sucursales ORDER BY 1";
            dt.Load(conex.pComando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }
        
        public bool EditarSucursal(string nombre, int id)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "UPDATE sucursales SET " +
                    "sucursal = @sucursal" +
                    " WHERE idSucursal = @idSucursal";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idSucursal", id);
                cmd.Parameters.AddWithValue("@sucursal", nombre);

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
        public bool EliminarSucursal(int id)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "delete from sucursales WHERE idSucursal = @idSucursal";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idSucursal", id);

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

        public DataTable ConsultarSucursales()
        {
            AccesoDatos conex = new AccesoDatos();
            DataTable dt = new DataTable();
            conex.Conectar();
            conex.pComando.CommandText = "SELECT idsucursal, sucursal FROM sucursales";
            dt.Load(conex.pComando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }
        public DataTable consultarTabla(string tabla)
        {
            AccesoDatos conex = new AccesoDatos();
            DataTable dt = new DataTable();
            conex.Conectar();
            conex.comando.CommandText = "SELECT * FROM " + tabla + " ORDER BY 2";
            dt.Load(conex.comando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }
    }
}

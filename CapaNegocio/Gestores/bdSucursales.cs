using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDato;

namespace CapaNegocio.Gestores
{
    public class bdSucursales
    {
        public bool InsertarRubro(string nombre)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "INSERT INTO sucursales (sucursal) VALUES (@sucursal)";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
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
            conex.pComando.CommandText = "SELECT sucursal FROM sucursales ORDER BY 1";
            dt.Load(conex.pComando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }
        /*
        public bool EditarRubro(string nombre, int id)
        {
            bool resultado = false;

            ConexionesBD.ConexionBD conex = new ConexionesBD.ConexionBD();

            try
            {
                string consulta = "UPDATE Rubros SET " +
                    "Nombre = @Nombre" +
                    " WHERE idRubro = @idRubro";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idRubro", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conex.Conectar();
                //cmd.Connection = conex.conexion;
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
        }*/
    }
}

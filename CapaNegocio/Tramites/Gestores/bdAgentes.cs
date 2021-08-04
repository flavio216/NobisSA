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
    public class bdAgentes
    {
        public bool Insertaragente(int id,string agente, int idsucursal,string mail, string pass)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "INSERT INTO agentes (idagente,agente, idsucursal,mail,contrasena) VALUES (@idagente,@agente,@idsucursal,@mail,@pass)";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idagente", id);
                cmd.Parameters.AddWithValue("@agente", agente);
                cmd.Parameters.AddWithValue("@idsucursal", idsucursal);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@pass", pass);


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
        public bool EditarAgente(string nombre, int id, string mail, string contrasena)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "UPDATE agentes SET " +
                    "agente = @agente," +
                    " idagente = @idcambiar," +
                    "mail = @mail," +
                    "contrasena = @contrasena" + 
                    " WHERE idagente = @idagente";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idagente", id);
                cmd.Parameters.AddWithValue("@idcambiar", id);
                cmd.Parameters.AddWithValue("@agente", nombre);
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@contrasena", contrasena);

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

        public bool EliminarAgente(int id)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "delete from agentes WHERE idagente = @idagente";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idagente", id);

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

        /* public DataTable consultarAgentes()
         {
             AccesoDatos conex = new AccesoDatos();
             DataTable dt = new DataTable();
             conex.Conectar();
             conex.pComando.CommandText = "SELECT agente, idsucursal FROM agentes ORDER BY 1";
             dt.Load(conex.pComando.ExecuteReader());
             conex.Desconectar();
             return dt;
         }*/
        public DataTable ConsultarTablaAgentes(int id)
        {
            AccesoDatos conex = new AccesoDatos();
            DataTable dt = new DataTable();
            conex.Conectar();
            conex.pComando.CommandText = "SELECT idagente, agente, idsucursal,mail,contrasena FROM agentes WHERE idsucursal=" + id + " ORDER BY 2";
            dt.Load(conex.pComando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }

    }
}

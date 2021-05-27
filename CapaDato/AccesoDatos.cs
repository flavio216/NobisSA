using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDato
{
    public class AccesoDatos
    {
         
        public SqlConnection conexion;
        public SqlCommand comando;
        private SqlDataReader lector;
        private string cadenaConexion;


        public AccesoDatos()
        {
            try
            {
                conexion = new SqlConnection();
                comando = new SqlCommand();
                lector = null;
                cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["BD"].ToString();
            }
            catch
            {
                MessageBox.Show("ERROR EN LA CONEXIÓN CON LA BASE DE DATOS");
            }
        }

        public SqlDataReader pLector { get => lector; set => lector = value; }
        public SqlCommand pComando { get => comando; set => comando = value; }

        public void Conectar()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
            }
            catch
            {

            }

        }

        public void Desconectar()
        {
            conexion.Close();
            conexion.Dispose();
        }


        public DataTable consultarTabla(string tabla)
        {
            DataTable dt = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + tabla;
            dt.Load(comando.ExecuteReader());
            Desconectar();
            return dt;
        }
        public DataTable buscarTabla(string sql)
        {
            AccesoDatos conex = new AccesoDatos();
            DataTable dt = new DataTable();
            conex.Conectar();
            conex.comando.CommandText = sql;
            dt.Load(conex.comando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }
        public void actualizarBD(string sql)
        {
            Conectar();
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            Desconectar();
        }
    }
}


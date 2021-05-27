using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class bdLogin
    {
        public bool IngresarLogin(string user, string pass)
        {


            AccesoDatos conex = new AccesoDatos();

            conex.Conectar();
            string consulta = @" select * from agentes a 
                                inner join usuarios u on u.idusuario= a.idusuario  where usuario ='" + user + "'  and contrasenia = '" + pass + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conex.conexion);

            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                clsLogin.nombreusuario = dt.Rows[0]["agente"].ToString();
                clsLogin.reg_sucursales = bool.Parse(dt.Rows[0]["reg_sucursales"].ToString());
                return true;

            }
            else
                return false;
            conex.Desconectar();
        }
    }
}

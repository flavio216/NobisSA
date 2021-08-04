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
            string consulta = @" select * from agentes
                                 where mail ='" + user + "'  and contrasena = '" + pass + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conex.conexion);

            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                clsLogin.nombreusuario = dt.Rows[0]["agente"].ToString();
                clsLogin.reg_sucursales = bool.Parse(dt.Rows[0]["reg_sucursales"].ToString());
                clsLogin.reg_auditoria = bool.Parse(dt.Rows[0]["reg_auditoria"].ToString());
                clsLogin.reg_inventario = bool.Parse(dt.Rows[0]["reg_inventario"].ToString());
                clsLogin.reg_envios = bool.Parse(dt.Rows[0]["reg_envios"].ToString());
                clsLogin.reg_tramites = bool.Parse(dt.Rows[0]["reg_tramites"].ToString());
                clsLogin.reg_afiliados = bool.Parse(dt.Rows[0]["reg_afiliados"].ToString());
                clsLogin.reg_admin = bool.Parse(dt.Rows[0]["reg_admin"].ToString());
                return true;

            }
            else
                return false;
            conex.Desconectar();
        }
    }
}

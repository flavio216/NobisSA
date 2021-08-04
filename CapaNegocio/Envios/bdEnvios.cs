using CapaDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio.Envios
{
    public class bdEnvios
    {
        public int InsertarEnvios(clsEnvios a)
        {
            int MaxId = 0;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "insert into envios (idsucursal,fechaenvio) values (@idsucursal,@fechaenvio)";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idsucursal", a.pSucursal);
                cmd.Parameters.AddWithValue("@fechaenvio", a.pFechaEnvio);
        //        cmd.Parameters.AddWithValue("@idcodigo", a.pCodigo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conex.Conectar();
                cmd.ExecuteNonQuery();


                SqlCommand id = new SqlCommand("select @@identity from envios", conex.conexion);

                MaxId = Convert.ToInt32(id.ExecuteScalar());

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

            return MaxId;
        }
        public bool InsertarDetalle(clsDetalleEnvios de)
        {
            bool resultado = false;
            AccesoDatos conex = new AccesoDatos();

            try
            {
                string sql = " insert into detalleEnvios (idcodigo,idenvio) values (@idCodigo, @idenvio)";
                SqlCommand cmd = new SqlCommand(sql, conex.conexion);

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idCodigo", de.pCodigo);
                cmd.Parameters.AddWithValue("@idenvio", de.pIdEnvio);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;

                conex.Conectar();
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se ha podido insertar.",
                    "Aviso");
                MessageBox.Show(ex.Message, "MENSAJE DE ERROR");
                resultado = false;
            }
            finally
            {
                conex.Desconectar();
            }

            return resultado;
        }


    
    public DataTable ConsultarEnvios()
    {
        DataTable dt = new DataTable();
        AccesoDatos conex = new AccesoDatos();
        try
        {

            conex.Conectar();
            conex.pComando.CommandText = @"select de.idEnvio,de.idCodigo,p.nombre,sucursal,fechaEnvio from DetalleEnvios de
                                            inner join envios e on e.idEnvio=de.idEnvio
                                            inner join sucursales s on s.idSucursal=e.idSucursal
                                            inner join productos p on p.idCodigo=de.idCodigo ";

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
}
}
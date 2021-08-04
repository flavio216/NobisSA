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
    public class bdTramites
    {
        public bool InsertarTramite(clsTramites t)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "insert into tramites ( idTipoTramite,fecha,dni,idtipopago,descripcion,idagente,estado,pdf,url) values ( @idtipotramite, @fecha,@dni,@idtipopago,@descripcion, @idagente,@estado,@pdf,@url)";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtipotramite", t.pIdTipoTramite);
                cmd.Parameters.AddWithValue("@fecha", t.pFecha);
                cmd.Parameters.AddWithValue("@dni", t.pDni);
                cmd.Parameters.AddWithValue("@idtipopago", t.pIdTipoPago);               
                cmd.Parameters.AddWithValue("@descripcion", t.pDescripcion);
                cmd.Parameters.AddWithValue("@idagente", t.pIdagente);               
                cmd.Parameters.AddWithValue("@estado", true);
                cmd.Parameters.AddWithValue("@pdf", t.Pdf);
                cmd.Parameters.AddWithValue("@url", t.pUrl);




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
        public bool EditarTramite(clsTramites t)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = @" UPDATE Tramites
                                    SET idtipotramite = @idtipotramite,
                                    fecha = @fecha,
                                    dni = @dni,
                                    idTipoPago = @idtipopago,
                                    descripcion = @descripcion,
                                    idagente = @idagente,
                                    estado = @estado,
                                    url = @url
                                      WHERE idtramite = @idtramite";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtramite", t.pId);
                cmd.Parameters.AddWithValue("@idtipotramite", t.pIdTipoTramite);
                cmd.Parameters.AddWithValue("@fecha", t.pFecha);
                cmd.Parameters.AddWithValue("@dni", t.pDni);
                cmd.Parameters.AddWithValue("@idtipopago", t.pIdTipoPago);
                cmd.Parameters.AddWithValue("@descripcion", t.pDescripcion);
                cmd.Parameters.AddWithValue("@idagente", t.pIdagente);
                cmd.Parameters.AddWithValue("@estado", t.pEstado);
                cmd.Parameters.AddWithValue("@url", t.pUrl);

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
        public DataTable ConsultarProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                AccesoDatos bd = new AccesoDatos();
                bd.Conectar();
                bd.pComando.CommandText = " select id,nombre,precio,categoria from productos ";
                dt.Load(bd.pComando.ExecuteReader());
                bd.Desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se podido establecer conexión con la base de datos, por favor contacte al administrador" +
                    "del sistema." + ex);
                return dt;
            }

        }
        public bool CambiarEstado(bool modo, int id,string observacion, DateTime fechaauditado)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();
            try
            {
                string consulta = "UPDATE tramites SET " +
                "estado = @estado," +
                "observacion = @observacion," +
                "fechaauditado = @fechaauditado" +
                " WHERE idtramite = @idtramite";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtramite", id);
                cmd.Parameters.AddWithValue("@observacion", observacion);
                cmd.Parameters.AddWithValue("@fechaauditado", fechaauditado);
                if (modo)
                    cmd.Parameters.AddWithValue("@estado", 1);
                else
                    cmd.Parameters.AddWithValue("@estado", 0);

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
        public DataTable ConsultarTramites()
        {
            DataTable dt = new DataTable();
            AccesoDatos conex = new AccesoDatos();
            try
            {
                
                conex.Conectar();
                conex.pComando.CommandText = @"select t.idtramite,tt.tramite 'Tramite',Fecha, t.dni 'DNI',af.Nombre,af.Apellido,formapago 'Forma de Pago',descripcion ' Tamite                                                             ',ag.Agente,FechaAuditado,Observacion,Estado,url, ag.mail from tramites t 
                                                inner join tipotramites tt on t.idTipoTramite = tt.idTipoTramite
                                                inner join afiliados af on af.dni = t.dni
                                                inner join tipopagos tp on tp.idtipopago = t.idtipopago
                                                inner join agentes ag on ag.idagente = t.idagente
                                                ";
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
        public bool EliminarTramite(int id)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "delete from tramites WHERE idtramite = @idtramite";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idtramite", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                conex.Conectar();
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show(

                    "No se ha podido Eliminar.",
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

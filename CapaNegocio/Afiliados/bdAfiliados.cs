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
    public class bdAfiliados
    {
        public DataTable ConsultarTablaLocalidades(int id)
        {
            AccesoDatos conex = new AccesoDatos();
            DataTable dt = new DataTable();
            conex.Conectar();
            conex.pComando.CommandText = "SELECT idlocalidad, localidad, idciudad FROM localidades WHERE idciudad=" + id + " ORDER BY 2";
            dt.Load(conex.pComando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }
        public DataTable ConsultarCiudades()
        {
            AccesoDatos conex = new AccesoDatos();
            DataTable dt = new DataTable();
            conex.Conectar();
            conex.pComando.CommandText = "SELECT idciudad, ciudad FROM ciudades ORDER BY 1";
            dt.Load(conex.pComando.ExecuteReader());
            conex.Desconectar();
            return dt;
        }
        public DataTable ConsultarAfiliados()
        {
            DataTable dt = new DataTable();
            AccesoDatos conex = new AccesoDatos();
            try
            {

                conex.Conectar();
                conex.pComando.CommandText = @"select dni,nombre,apellido,fechanac,ts.sexo,te.estadoCivil,l.localidad,c.ciudad,domicilio,telefono,mail,p.nombrePlan from Afiliados a
                                                inner join tiposexos ts on a.idTiposexo = ts.idtiposexo
                                                inner join TipoEstadoCivil te on a.idEstadoCivil = te.IdTipoEstadoCivil
                                                inner join localidades l on l.idlocalidad=a.idLocalidad
                                                inner join planes p on p.idPlan=a.idPlan
                                                inner join ciudades c on l.idCiudad=c.idCiudad";
                                                
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
        public bool InsertarAfiliados(clsAfiliados a)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "INSERT INTO Afiliados (dni,nombre,apellido,fechanac,idtiposexo,idestadocivil,idlocalidad,domicilio,telefono,mail,idplan) VALUES         (@dni,@nombre,@apellido,@fechanac,@idtiposexo,@idestadocivil,@idlocalidad,@domicilio,@telefono,@mail,@plan)";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", a.pDni);
                cmd.Parameters.AddWithValue("@nombre", a.pNombre);
                cmd.Parameters.AddWithValue("@apellido", a.pApellido);
                cmd.Parameters.AddWithValue("@fechanac", a.pFechaNac);
                cmd.Parameters.AddWithValue("@idtiposexo", a.pIdTipoSexo);
                cmd.Parameters.AddWithValue("@idestadocivil", a.pIdEstadoCivil);
                cmd.Parameters.AddWithValue("@idlocalidad", a.pIdLocalidad);
                cmd.Parameters.AddWithValue("@domicilio", a.pDomicilio);
                cmd.Parameters.AddWithValue("@telefono", a.pTelefono);
                cmd.Parameters.AddWithValue("@mail", a.pMail);
                cmd.Parameters.AddWithValue("@plan", a.pIdPlan);




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

        public bool EditarAfiliados(clsAfiliados a)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = @"UPDATE afiliados SET 
                    nombre = @nombre,
                    apellido = @apellido,
                    fechaNac = @fechaNac,
                    idTiposexo = @idTiposexo,
                    idestadocivil = @idestadocivil,
                    idlocalidad = @idlocalidad,
                    domicilio = @domicilio,
                    telefono = @telefono,
                    mail = @mail,
                    idplan = @plan
                     WHERE dni = @dni";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", a.pDni);
                cmd.Parameters.AddWithValue("@nombre", a.pNombre);
                cmd.Parameters.AddWithValue("@apellido", a.pApellido);
                cmd.Parameters.AddWithValue("@fechaNac", a.pFechaNac);
                cmd.Parameters.AddWithValue("@idTiposexo", a.pIdTipoSexo);
                cmd.Parameters.AddWithValue("@idestadocivil", a.pIdEstadoCivil);
                cmd.Parameters.AddWithValue("@idlocalidad", a.pIdLocalidad);
                cmd.Parameters.AddWithValue("@domicilio", a.pDomicilio);
                cmd.Parameters.AddWithValue("@telefono", a.pTelefono);
                cmd.Parameters.AddWithValue("@mail", a.pMail);
                cmd.Parameters.AddWithValue("@plan", a.pIdPlan);
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
        public bool EliminarAfiliado(int id)
        {
            bool resultado = false;

            AccesoDatos conex = new AccesoDatos();

            try
            {
                string consulta = "delete from afiliados WHERE dni = @dni";
                SqlCommand cmd = new SqlCommand(consulta, conex.conexion);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", id);

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

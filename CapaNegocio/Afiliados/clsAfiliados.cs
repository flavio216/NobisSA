using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsAfiliados
    {
        private int dni;
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private int idTipoSexo;
        private int idEstadoCivil;
        private int idLocalidad;
        private string domicilio;
        private string telefono;
        private string mail;
        private int idPlan;

        public clsAfiliados(int dni, string nombre, string apellido, DateTime fechaNac, int idTipoSexo, int idEstadoCivil, int idLocalidad, string domicilio, string telefono, string mail, int idPlan)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.idTipoSexo = idTipoSexo;
            this.idEstadoCivil = idEstadoCivil;
            this.idLocalidad = idLocalidad;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.mail = mail;
            this.idPlan = idPlan;
        }

        public int pDni { get => dni; set => dni = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public string pApellido { get => apellido; set => apellido = value; }
        public DateTime pFechaNac { get => fechaNac; set => fechaNac = value; }
        public int pIdTipoSexo { get => idTipoSexo; set => idTipoSexo = value; }
        public int pIdEstadoCivil { get => idEstadoCivil; set => idEstadoCivil = value; }
        public int pIdLocalidad { get => idLocalidad; set => idLocalidad = value; }
        public string pDomicilio { get => domicilio; set => domicilio = value; }
        public string pTelefono { get => telefono; set => telefono = value; }
        public string pMail { get => mail; set => mail = value; }
        public int pIdPlan { get => idPlan; set => idPlan = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsAgentes
    {
        private int id;
        private string nombre;
        private int idsucursal;
        private string mail;
        private string contrasena;

        public clsAgentes(int id, string nombre, int idsucursal,string mail, string contrasena)
        {
            this.id = id;
            this.nombre = nombre;
            this.idsucursal = idsucursal;
            this.mail = mail;
            this.contrasena = contrasena;
        }
        public clsAgentes()
        {
            this.id = 0;
            this.nombre = "";
            this.idsucursal = 0;
            this.mail = "";
            this.contrasena = "";


        }

        public int pId { get => id; set => id = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public int pIdsucursal { get => idsucursal; set => idsucursal = value; }
        public string pMail { get => mail; set => mail = value; }
        public string pContrasena { get => contrasena; set => contrasena = value; }


        override
    public string ToString()
    {
        return pNombre;
    }
    }

}

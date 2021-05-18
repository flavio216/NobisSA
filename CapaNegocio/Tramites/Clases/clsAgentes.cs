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

        public clsAgentes(int id, string nombre, int idsucursal)
        {
            this.id = id;
            this.nombre = nombre;
            this.idsucursal = idsucursal;
        }
        public clsAgentes()
        {
            this.id = 0;
            this.nombre = "";
            this.idsucursal = 0;
        }

        public int pId { get => id; set => id = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public int pIdsucursal { get => idsucursal; set => idsucursal = value; }
    

    override
    public string ToString()
    {
        return pNombre;
    }
    }

}

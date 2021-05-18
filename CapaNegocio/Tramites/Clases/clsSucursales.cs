using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsSucursales
    {
        private int id;
        private string sucursal;

        public clsSucursales(int id, string sucursal)
        {
            this.id = id;
            this.sucursal = sucursal;
        }
        public clsSucursales()
        {
            id = 0;
            sucursal = "";
           
        }
        public int pId { get => id; set => id = value; }
        public string pSucursal { get => sucursal; set => sucursal = value; }

        override
        public string ToString()
        {
            return pSucursal;
        }
    }
}

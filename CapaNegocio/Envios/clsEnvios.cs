using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Envios
{
    public class clsEnvios
    {

        //private int codigo;
        private int sucursal;
        private DateTime fechaEnvio;

        public clsEnvios(  int sucursal, DateTime fechaEnvio)
        {
            
            this.sucursal = sucursal;
            this.fechaEnvio = fechaEnvio;
        }

   //     public int pCodigo { get => codigo; set => codigo = value; }
        public int pSucursal { get => sucursal; set => sucursal = value; }
        public DateTime pFechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
    }
}

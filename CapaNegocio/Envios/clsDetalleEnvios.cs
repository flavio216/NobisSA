using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Envios
{
    public class clsDetalleEnvios
    {
        private int id;
        private int Codigo;
        private int idEnvio;

        public clsDetalleEnvios(int id, int codigo, int idEnvio)
        {
            this.id = id;
            this.Codigo = codigo;
            this.idEnvio = idEnvio;
        }

        public int pCodigo { get => Codigo; set => Codigo = value; }
        public int pIdEnvio { get => idEnvio; set => idEnvio = value; }
        public int pId { get => id; set => id = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Envios
{
    public class DTOEnvios
    {
        private int codigo;
        private string nombre;
        private int cantidad;
        private DateTime fechaActual;

        public DTOEnvios(int codigo, string nombre, int cantidad, DateTime fechaActual)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.fechaActual = fechaActual;
        }

        public int pCodigo { get => codigo; set => codigo = value; }
        public string pNombre { get => nombre; set => nombre = value; }
        public int pCantidad { get => cantidad; set => cantidad = value; }
        public DateTime pFechaActual { get => fechaActual; set => fechaActual = value; }
    }
}

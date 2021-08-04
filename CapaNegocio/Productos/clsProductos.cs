using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsProductos
    {
        private int codigo;
        private string producto;
        private int stock;
        private double precioCompra;
        private bool estado;

        public clsProductos(int codigo, string producto, int stock, double precioCompra, bool estado)
        {
            this.codigo = codigo;
            this.producto = producto;
            this.stock = stock;
            this.precioCompra = precioCompra;
          this.estado = estado;
        }

        public int pCodigo { get => codigo; set => codigo = value; }
        public string pProducto { get => producto; set => producto = value; }
        public int pStock { get => stock; set => stock = value; }
        public double pPrecioCompra { get => precioCompra; set => precioCompra = value; }
        public bool pEstado { get => estado; set => estado = value; }
    }
}

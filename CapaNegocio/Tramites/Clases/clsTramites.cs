using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class clsTramites
    {
        private int id;
        private int idTipoTramite;
        private DateTime fecha;
        private int dni;
        private int idTipoPago;
        private string descripcion;
        private int idagente;
        private bool estado;
        private byte[] pdf;
        private string url;
        private string observacion;
        public clsTramites(int id, int idTipoTramite, DateTime fecha, int dni, int idTipoPago, string descripcion, int idagente, bool estado, byte[] pdf, string url,string observacion)
        {
            this.id = id;
            this.idTipoTramite = idTipoTramite;
            this.fecha = fecha;
            this.dni = dni;
            this.idTipoPago = idTipoPago;
            this.descripcion = descripcion;
            this.idagente = idagente;
            this.estado = estado;
            this.pdf = pdf;
            this.url = url;
            this.observacion = observacion;
        }
        public clsTramites(int id, int idTipoTramite, DateTime fecha, int dni, int idTipoPago, string descripcion, int idagente, bool estado, string url, string observacion)
        {
            this.id = id;
            this.idTipoTramite = idTipoTramite;
            this.fecha = fecha;
            this.dni = dni;
            this.idTipoPago = idTipoPago;
            this.descripcion = descripcion;
            this.idagente = idagente;
            this.estado = estado;          
            this.url = url;
            this.observacion = observacion;
        }

        public int pId { get => id; set => id = value; }
        public int pIdTipoTramite { get => idTipoTramite; set => idTipoTramite = value; }
        public DateTime pFecha { get => fecha; set => fecha = value; }
        public int pDni { get => dni; set => dni = value; }
        public int pIdTipoPago { get => idTipoPago; set => idTipoPago = value; }
        public string pDescripcion { get => descripcion; set => descripcion = value; }
        public int pIdagente { get => idagente; set => idagente = value; }
        public bool pEstado { get => estado; set => estado = value; }
        public byte[] Pdf { get => pdf; set => pdf = value; }
        public string pUrl { get => url; set => url = value; }
        public string pObservacion { get => observacion; set => observacion = value; }
    }
}

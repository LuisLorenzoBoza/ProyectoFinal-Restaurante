using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.Entidades
{
    public class Factura
    {
        [Key]
        public int FacturaId { get; set; }
        public decimal Monto { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteID { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public decimal Devuelta { get; set; }
        public decimal EfectivoRecibido { get; set; }

        public virtual List<FacturaDetalle> Detalle { get; set; }

        public Factura(int idFactura, decimal monto, int usuarioId, int clienteId, DateTime fecha, string descripcion, decimal devuelta, decimal efectivoRecibido, List<FacturaDetalle> Detalle)
        {
            this.FacturaId = idFactura;
            this.Monto = monto;
            this.UsuarioId = usuarioId;
            this.ClienteID = clienteId;
            this.Fecha = fecha;
            this.Descripcion = descripcion;
            this.Devuelta = devuelta;
            this.EfectivoRecibido = efectivoRecibido;
            this.Detalle = Detalle;
        }
        public Factura()
        {
            this.FacturaId = 0;
            this.Monto = 0;
            this.UsuarioId = 0;
            this.ClienteID = 0;
            this.Fecha = DateTime.Now;
            this.Descripcion = string.Empty;
            this.Devuelta = 0;
            this.EfectivoRecibido = 0;
            Detalle = new List<FacturaDetalle>();
        }
    }
}

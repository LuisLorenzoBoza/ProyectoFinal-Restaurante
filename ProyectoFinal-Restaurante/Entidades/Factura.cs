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
        public int FactutaID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaDeFactura { get; set; }
        public int  ClienteID { get; set; }
        // public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        // public int Cantidad { get; set; }
        // public decimal SubTotal { get; set; }
        // public decimal Iterbis { get; set; }
        public decimal  Devuelta { get; set; }
        public decimal ToTal { get; set; }
        public decimal  EfectivoRecibido { get; set; }

        public virtual List<FacturaDetalle> Detalle { get; set; }

        public Factura()
        {
            FactutaID = 0;
            UsuarioID = 0;
            ClienteID = 0;
            //ProductoID = 0;
            Descripcion = string.Empty;
           // Cantidad = 0;
           // SubTotal = 0;
           // Iterbis = 0;
            Devuelta = 0;
            EfectivoRecibido = 0;
            ToTal = 0;
            FechaDeFactura = DateTime.Now;
            Detalle = new List<FacturaDetalle>();
        }

    }
}

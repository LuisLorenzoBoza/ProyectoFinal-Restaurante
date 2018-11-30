using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.Entidades
{
    public class FacturaDetalle
    {
        [Key]
        public int FacturaDetalleID { get; set; }
        //public decimal iterbis { get; set; }
        public int facturaID { get; set; }
       // public int UsuarioID { get; set; }
       // public DateTime FechaDeFactura { get; set; }
        public int ProductoID { get; set; }
        //public string Productos { get; set; }
        public int Cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal Importe { get; set; }

        public FacturaDetalle()
        {
            FacturaDetalleID = 0;
           // iterbis = 0;
            facturaID = 0;
           // UsuarioID = 0;
           // FechaDeFactura = DateTime.Now;
            ProductoID = 0;
           // Productos = string.Empty;
            Cantidad = 0;
            precio = 0;
            Importe = 0;
        }

        public FacturaDetalle(int facturaDetalleID, decimal iterbis, int facturaID, int usuarioID, DateTime fechaDeFactura, int productoID, string productos, int cantidad, decimal precio, decimal importe)
        {
            FacturaDetalleID = facturaDetalleID;
           // this.iterbis = iterbis;
            this.facturaID = facturaID;
           // UsuarioID = usuarioID;
          //  FechaDeFactura = fechaDeFactura;
            ProductoID = productoID;
          //  Productos = productos;
            Cantidad = cantidad;
            this.precio = precio;
            Importe = importe;
        }
    }
}

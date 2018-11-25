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
        private int facturaID { get; set; }
        private float iterbis { get; set; }
        public int FacturaDetalleID { get; set; }
        public int FacturaID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaDeFactura { get; set; }
        public int ProductoID { get; set; }
        public string Productos { get; set; }
        public int Cantidad { get; set; }
        public int precio { get; set; }
        public int Importe { get; set; }



        [ForeignKey("ProductoID")]
        public virtual Producto Producto { get; set; }




        public FacturaDetalle()
        {
            FacturaID = 0;
            FacturaDetalleID = 0;

        }



        public FacturaDetalle(int facturaDetalleID, int factutaID, int iDArticulos, string Articulos, int cantidad, int precio)
        {
            FacturaDetalleID = facturaDetalleID;
            this.facturaID = factutaID;
            ProductoID = iDArticulos;
            Producto = Producto;
            Cantidad = cantidad;
            this.precio = precio;
        }
    }
}

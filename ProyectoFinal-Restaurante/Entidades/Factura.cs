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
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float SubTotal { get; set; }
        public decimal Iterbis { get; set; }
        public decimal ToTal { get; set; }

        public virtual ICollection<FacturaDetalle> Detalle { get; set; }


        public Factura()
        {
            this.Detalle = new List<FacturaDetalle>();
            FechaDeFactura = DateTime.Now;
        }


        public void AgregarDetalle(int FacturaDetalleID, int FacturaID, int ProductoID, string Productos, int Cantidad, int precio, int v)
        {
            Detalle.Add(new FacturaDetalle(FacturaDetalleID, FactutaID, ProductoID, Productos, Cantidad, precio));
        }
    }
}

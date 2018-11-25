using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Iterbis { get; set; }
        public DateTime FechaDeRegistro { get; set; }


        public Producto()
        {
            ProductoID = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Iterbis = 0;
            FechaDeRegistro = DateTime.Now;
        }



        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}

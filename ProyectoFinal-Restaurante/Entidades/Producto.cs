using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
    public class Articulos
    {
        [Key]
        public int IDArticulos { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Itebis { get; set; }
        public float Costo { get; set; }
        public float Ganancia { get; set; }
        public DateTime FechaDevencimineto { get; set; }


        public Articulos()
        {
            IDArticulos = 0;
            Descripcion = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Itebis = 0;
            Costo = 0;
            Ganancia = 0;
            FechaDevencimineto = DateTime.Now;
        }
    }
}

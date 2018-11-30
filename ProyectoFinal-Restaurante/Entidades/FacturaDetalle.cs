﻿using System;
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
        public int Id { get; set; }
        public int FacturaID { get; set; }
        public int ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        [NotMapped]
        public decimal Importe { get; set; }

        public FacturaDetalle(int id, int facturaId, int productoId, int cantidad, decimal precio, string descripcion, decimal importe)
        {
            this.Id = id;
            this.FacturaID = facturaId;
            this.ProductoID = productoId;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Importe = importe;
        }

        public FacturaDetalle()
        {

            this.Id = 0;
            this.FacturaID = 0;
            this.ProductoID = 0;
            this.Cantidad = 0;
            this.Precio = 0;
            this.Descripcion = string.Empty;
            this.Importe = 0;
        }
    }
}

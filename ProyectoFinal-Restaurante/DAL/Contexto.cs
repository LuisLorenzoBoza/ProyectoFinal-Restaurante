using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usario { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Factura { get; set; }



        public Contexto() : base("ConStr")
        {

        }
    }

}

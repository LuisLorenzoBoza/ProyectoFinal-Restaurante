using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Clave { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public decimal TotalVendido { get; set; }
        public bool Pocision { get; set; }

        public Usuario()
        {
            UsuarioID = 0;
            Clave = string.Empty;
            Contraseña = string.Empty;
            Nombre = string.Empty;
            Pocision = false;
        }
    }
}

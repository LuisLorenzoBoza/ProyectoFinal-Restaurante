using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.Entidades
{
    public class Usuario
    {
        [Key]
        public int IDUsuario { get; set; }
        public string Cuenta { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public bool Pocision { get; set; }

        public Usuario()
        {
            IDUsuario = 0;
            Cuenta = string.Empty;
            Clave = string.Empty;
            Nombre = string.Empty;
            Pocision = false;
        }
    }
}

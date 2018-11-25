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
        public int UsuarioID { get; set; }
        public string Contraseña { get; set; }
        public string Nombre { get; set; }
        public string CuentaUsua { get; set; }
        public decimal TotalVendido { get; set; }
        public bool Pocision { get; set; }

        public Usuario()
        {
            UsuarioID = 0;
            Contraseña = string.Empty;
            Nombre = string.Empty;
            CuentaUsua = string.Empty;
            Pocision = false;
        }

        public Usuario(int UsuarioID, string Contraseña, string Nombre, string CuentaUsua, decimal TotalVendido, bool Posicion)
        {
            this.UsuarioID = UsuarioID;
            this.Contraseña = Contraseña;
            this.Nombre = Nombre;
            this.CuentaUsua = CuentaUsua;
            this.TotalVendido = TotalVendido;
            this.Pocision = Pocision;
        }
    }
}

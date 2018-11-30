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
        public DateTime Fecha { get; set; }
        //public string CuentaUsua { get; set; }
        //public decimal TotalVendido { get; set; }
        //public bool Pocision { get; set; }

        public Usuario(int UsuarioID, string Contraseña, string Nombre, DateTime Fecha)
        {
            this.UsuarioID = 0;
            this.Contraseña = string.Empty;
            this.Nombre = string.Empty;
            this.Fecha = DateTime.Now;
            //CuentaUsua = string.Empty;
            //Pocision = false;
        }

        public Usuario()
        {
            this.UsuarioID = UsuarioID;
            this.Contraseña = Contraseña;
            this.Nombre = Nombre;
            this.Fecha = Fecha;
            //this.CuentaUsua = CuentaUsua;
            //this.TotalVendido = TotalVendido;
            //this.Pocision = Pocision;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Restaurante.Entidades
{
    public class Cliente
    {
        [Key]
        public int ClieteID { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        

        public Cliente(int ClienteID, string Nombre, string Email, string Telefono)
        {
            this.ClieteID = ClienteID;
            this.Nombre = Nombre;
            this.Email = Email;
            
            
        }

        public Cliente()
        {
            ClieteID = 0;
            Nombre = string.Empty;
            Email = string.Empty;
            Telefono = string.Empty;
           

        }

    }
}

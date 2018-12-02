using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using ProyectoFinal_Restaurante.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante
{
    public partial class Login : Form
    {
        public static string user;
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string usuario = UsariotextBox.Text;
            string contraseña = ContraseñatextBox.Text;
            RepositoryBase<Usuario> repositorio = new RepositoryBase<Usuario>();
            List<Usuario> lista = repositorio.GetList(x => true);
            if (lista.Count==0)
            {
                Usuario usuarios = new Usuario();
                usuarios.Nombre = "Admin";
                usuarios.Contraseña = "1234";
                //usuarios.CuentaUsua = "root";
                RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>();
                repository.Guardar(usuarios);
            }
            lista = repositorio.GetList(x => true);
            foreach (var item in lista)
            {
                
                if (usuario == item.CuentaUsua && contraseña == item.Contraseña)
                {
                    new MainForm().Show();
                    Program.usuario = item;
                    this.Visible = false;
                    MessageBox.Show("Bienvenido ", item.Nombre);
                    user = item.Nombre;
                }
                else
                {
                    MessageBox.Show("usuario o password incorrectos ");
                }
            }
        }
    }
}

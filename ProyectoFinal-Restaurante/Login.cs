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
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string usuario = UsariotextBox.Text;
            string contraseña = ContraseñatextBox.Text;
            RepositoryBase<Usuario> repositorio = new RepositoryBase<Usuario>(new BLL.Contexto());
            List<Usuario> lista = repositorio.GetList(x => true);
            foreach (var item in lista)
            {
                if (usuario == item.CuentaUsua && contraseña == item.Contraseña)
                {
                    new MainForm().Show();
                    Program.usuario = item;
                    this.Visible = false;
                    MessageBox.Show("Bienbenido ", item.Nombre);
                }
                else
                {
                    MessageBox.Show("usuario o password incorrectos ");
                }
            }




        }
    }
}

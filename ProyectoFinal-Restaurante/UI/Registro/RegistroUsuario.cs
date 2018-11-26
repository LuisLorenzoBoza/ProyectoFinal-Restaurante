using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Registro
{
    public partial class RegistroUsuario : Form
    {
        
        public RegistroUsuario()
        {
            InitializeComponent();
            AdminitradorradioButton.Checked = true;
        }


        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            UsuariotextBox.Text = string.Empty;
            ContraseñatextBox.Text = string.Empty;
            NombretextBox.Text = string.Empty;
            //PosicionnumericUpDown.Value = 0;
            AdminitradorradioButton.Checked = false;
        }


        public Usuario LlenarClase()
        {
            Usuario usuario = new Usuario();
            usuario.UsuarioID = Convert.ToInt32(IDnumericUpDown.Value);
            usuario.Nombre = NombretextBox.Text;
            usuario.Contraseña = ContraseñatextBox.Text;
            usuario.Pocision = true;
            return usuario;
        }




        public void LlenarCampo(Usuario usuario)
        {
            IDnumericUpDown.Value = usuario.UsuarioID;
            NombretextBox.Text = usuario.Nombre;
            ContraseñatextBox.Text = usuario.Contraseña;
            //PosicionnumericUpDown.Value = Convert.ToInt32(usuario.Pocision);
        }





        public bool Validar()
        {
            bool paso = true;
            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                errorProvider1.SetError(UsuariotextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider1.SetError(NombretextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ContraseñatextBox.Text))
            {
                errorProvider1.SetError(ContraseñatextBox, "Campo Vacio ");
                paso = false;
            }
            
            return paso;
        }





        public bool ExiteEnLaDb()
        {
            RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>();
            Usuario usuario = repository.Buscar((int)IDnumericUpDown.Value);
            return (usuario != null);
        }




        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }






        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>();
            bool paso = false;
            Usuario usuario;
            if (!Validar())
                return;
            usuario = LlenarClase();
            if (IDnumericUpDown.Value == 0)
            {
                paso = repository.Guardar(usuario);
            }
            else
            {
                if (!ExiteEnLaDb())
                {
                    MessageBox.Show("No Se Puede Modificar No Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repository.Modificar(usuario);
            }
            if (paso)
            {
                MessageBox.Show("Guardado con Exito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Se Puede Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExiteEnLaDb())
            {
                errorProvider1.SetError(IDnumericUpDown, "Este Usuario No Exite");
                IDnumericUpDown.Focus();
                return;
            }
            if (repository.Eliminar(id))
            {
                MessageBox.Show("Usuario Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se Pudo Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }





        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>();
            int id;
            Usuario usuario = new Usuario();
            int.TryParse(IDnumericUpDown.Text, out id);
            usuario = repository.Buscar(id);

            if (usuario != null)
            {
                MessageBox.Show("Usuario Econtrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampo(usuario);
            }
            else
            {
                MessageBox.Show("Usuario no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

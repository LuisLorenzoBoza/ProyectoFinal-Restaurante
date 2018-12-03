using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using ProyectoFinal_Restaurante.Reportes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Consulta
{
    
    public partial class ConsultaUsuario : Form
    {
        List<Usuario> usuario = new List<Usuario>();
        Expression<Func<Usuario, bool>> filtro = x => true;
        public ConsultaUsuario()
        {
            InitializeComponent();
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Usuario> repository = new RepositoryBase<Usuario>();
            var listado = new List<Usuario>();
           if (CriteriotextBox.Text.Trim().Length > 0)
           {
            switch (FiltrocomboBox.SelectedIndex)
                  {
                    case 0://Todo
                        listado = repository.GetList(p => true);
                        break;
                    case 1://Id
                        {
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = repository.GetList(p => p.UsuarioID == id);
                            
                            if (repository.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Este id de usuario no Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }
                    case 2://Nombre
                        {
                            listado = repository.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                            if (repository.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Nombre no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }
                    case 3://Contraseña
                        {
                            listado = repository.GetList(p => p.Contraseña.Contains(CriteriotextBox.Text));
                            if (repository.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Contraseña no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;                    
                }
            }
            else
            {
                listado = repository.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
            usuario = listado;
            CriteriotextBox.Clear();
        }
        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (usuario.Count == 0)
            {
                MessageBox.Show("No encontrado","Fallo");
                return;
            }
            UsuarioReview usuarioReview = new UsuarioReview(usuario);
            usuarioReview.Show();

        }
    }
}

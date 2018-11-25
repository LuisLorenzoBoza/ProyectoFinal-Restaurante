using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Consulta
{
    public partial class ConsultaUsuario : Form
    {
        RepositoryBase<Usuario> repositoryBase;
        Expression<Func<Usuario, bool>> filtro = x => true;
        public ConsultaUsuario()
        {
            InitializeComponent();
            repositoryBase = new RepositoryBase<Usuario>(new DAL.Contexto());
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Usuario>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {


                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Id


                        {
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = repositoryBase.GetList(p => p.UsuarioID == id);

                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Este Articulo no Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }

                    case 1://nombre


                        {
                            listado = repositoryBase.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Nombre no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;
                        }
                    case 2: //Cuenta

                        {
                            listado = repositoryBase.GetList(p => p.Clave.Contains(CriteriotextBox.Text));
                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Cuenta no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;


                        }
                    case 3://Clave

                        {
                            listado = repositoryBase.GetList(p => p.Contraseña.Contains(CriteriotextBox.Text));
                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {

                                MessageBox.Show("Clave no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;






                    case 4://todo
                        filtro = x => true;
                        break;
                }
            }
            else
            {
                listado = repositoryBase.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
            CriteriotextBox.Clear();
           
        }
    }
}

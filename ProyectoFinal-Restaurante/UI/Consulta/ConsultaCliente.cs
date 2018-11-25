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
    public partial class ConsultaCliente : Form
    {
        Expression<Func<Cliente, bool>> filtro = x => true;
        RepositoryBase<Cliente> repositoryBase;
        public ConsultaCliente()
        {
            InitializeComponent();
            repositoryBase = new RepositoryBase<Cliente>(new DAL.Contexto());
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Cliente>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {


                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Id


                        {
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = repositoryBase.GetList(p => p.ClienteID == id);

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
                    case 2: //Cedula

                        {
                            listado = repositoryBase.GetList(p => p.Cedula.Contains(CriteriotextBox.Text));
                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Cedula no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            break;


                        }
                    case 3://Direccion

                        {
                            listado = repositoryBase.GetList(p => p.Email.Contains(CriteriotextBox.Text));
                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {

                                MessageBox.Show("Direccion no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;

                    case 4://Telefono                     
                        {
                            listado = repositoryBase.GetList(p => p.Telefono.Contains(CriteriotextBox.Text));

                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {

                                MessageBox.Show("Telefono no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;

                    case 5: //Telefono 2

                        {
                            listado = repositoryBase.GetList(p => p.Telefono2.Contains(CriteriotextBox.Text));
                            if (repositoryBase.GetList(filtro).Count() == 0)
                            {

                                MessageBox.Show("Telefono 2 no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;


                    case 7://todo
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

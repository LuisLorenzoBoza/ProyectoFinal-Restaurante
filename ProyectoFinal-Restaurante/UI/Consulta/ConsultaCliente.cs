using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using ProyectoFinal_Restaurante.Reportes;
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
        List<Cliente> cliente = new List<Cliente>();
        Expression<Func<Cliente, bool>> filtro = x => true;
        RepositoryBase<Cliente> repository;
        private object repositoryBase;

        public ConsultaCliente()
        {
            InitializeComponent();
            repositoryBase = new RepositoryBase<Usuario>();
        }

        public object RepositoryBase { get; private set; }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repository = new RepositoryBase<Cliente>();
            var listado = new List<Cliente>();
            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                        filtro = x => true;
                        listado = repository.GetList(filtro);
                        break;
                    case 1://Id
                        {
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = repository.GetList(p => p.ClienteID == id);
                            if (repository.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Este cliente no Exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    case 3://Email
                        {
                            listado = repository.GetList(p => p.Email.Contains(CriteriotextBox.Text));
                            if (repository.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Email no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;
                    case 4://Telefono                     
                        {
                            listado = repository.GetList(p => p.Telefono.Contains(CriteriotextBox.Text));
                            if (repository.GetList(filtro).Count() == 0)
                            {
                                MessageBox.Show("Telefono no exite", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        break;
                }
            }
           

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
            CriteriotextBox.Clear();
            cliente = listado;
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            if (cliente.Count == 0)
            {
                MessageBox.Show("No encontrado");
                return;
            }
            ClienteReview clienteReview = new ClienteReview(cliente);
            clienteReview.Show();
        
        }
    }
}

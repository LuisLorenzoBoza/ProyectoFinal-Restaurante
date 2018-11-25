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
    public partial class ConsultaProducto : Form
    {
        private List<Producto> producto = new List<Producto>();
        Expression<Func<Producto, bool>> filtro = x => true;
        private RepositoryBase<Producto> repositoryBase;
        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Producto> repository;
            repository = new RepositoryBase<Producto>();
            var listado = new List<Producto>();
            if (CriteriotextBox.Text.Trim().Length >= 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositoryBase.GetList(p => true);
                        break;
                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositoryBase.GetList(p => p.ProductoID == id);
                        break;
                    case 2://Descripcion
                        listado = repositoryBase.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;
                    case 3://Cantidad
                        float cantidad = Convert.ToSingle(CriteriotextBox.Text);
                        listado = repositoryBase.GetList(p => p.Cantidad == cantidad);
                        break;
                    case 4://Precio
                        float precio = Convert.ToSingle(CriteriotextBox.Text);
                        listado = repositoryBase.GetList(p => p.Precio == precio);
                        break;
                    case 5://Todo
                        filtro = x => true;
                        break;
                }
                listado = listado.Where(c => c.FechaDeRegistro >= DesdedateTimePicker.Value.Date && c.FechaDeRegistro <= HastadateTimePicker.Value.Date).ToList();
            }




            else
            {
                listado = repositoryBase.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
        }
    }
}
            
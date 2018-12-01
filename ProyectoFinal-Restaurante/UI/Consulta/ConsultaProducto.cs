using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using ProyectoFinal_Restaurante.Reportes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Consulta
{
    public partial class ConsultaProducto : Form
    {
        private List<Producto> producto = new List<Producto>();
        Expression<Func<Producto, bool>> filtro = x => true;
        
        public ConsultaProducto()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Producto> repository = new RepositoryBase<Producto>();
            var listado = new List<Producto>();
            
            if (CriteriotextBox.Text.Trim().Length >= 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = repository.GetList(p => true);
                        break;
                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.ProductoID == id);
                        break;
                    case 2://Descripcion
                        listado = repository.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;
                    case 3://Cantidad
                        decimal cantidad = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.Cantidad == cantidad);
                        break;
                    case 4://Precio
                        decimal precio = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.Precio == precio);
                        break;
                   
                }
                listado = listado.Where(c => c.FechaDeRegistro.Date >= DesdedateTimePicker.Value.Date && c.FechaDeRegistro.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repository.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (producto.Count == 0)
            {
                MessageBox.Show("No encontrado");
                return;
            }
            ProductoReview clienteReview = new ProductoReview(producto);
            clienteReview.Show();
        }
    }
}
            
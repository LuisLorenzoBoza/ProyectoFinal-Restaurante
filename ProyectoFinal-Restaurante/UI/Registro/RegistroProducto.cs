using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using System;

using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Registro
{
    public partial class RegistroProducto : Form
    {
        RepositoryBase<Producto> repository;
        public RegistroProducto()
        {
            InitializeComponent();
            repository = new RepositoryBase<Producto>();
        }
        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            FechaRegistrodateTimePicker.Value = DateTime.Now;
        }

        private Producto LlenarClase()
        {
            Producto producto = new Producto();
            producto.ProductoID = Convert.ToInt32(IDnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            producto.Precio = Convert.ToInt32(PrecionumericUpDown.Value);
            producto.Fecha = FechaRegistrodateTimePicker.Value;
            return producto;
        }

        private void LlenarCampo(Producto articulos)
        {
            IDnumericUpDown.Value = articulos.ProductoID;
            DescripciontextBox.Text = articulos.Descripcion;
            CantidadnumericUpDown.Value = articulos.Cantidad;
            PrecionumericUpDown.Value = Convert.ToDecimal(articulos.Precio);
            FechaRegistrodateTimePicker.Value = articulos.Fecha;  
        }
        public bool Validar(int error)
        {
            errorProvider1.Clear();
            bool paso = false;
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Campo Vacio");
                paso = true;
            }
            if (error == 2 && PrecionumericUpDown.Value == 0)
            {
                errorProvider1.SetError(PrecionumericUpDown, "Precio en 0");
                paso = true;
            }

            if (error == 2 && CantidadnumericUpDown.Value == 0)
            {
                errorProvider1.SetError(CantidadnumericUpDown, "Cantidad En 0");
                paso = true;
            }
            if (error == 2 && FechaRegistrodateTimePicker.Value < DateTime.Now)
            {
                errorProvider1.SetError(FechaRegistrodateTimePicker, "Fecha Fuera De Rango");
                paso = true;
            } 
            return paso;
        }
        public bool ExiteEnLaDb()
        {
            repository = new RepositoryBase<Producto>();
            Producto producto = new Producto();
            producto = repository.Buscar((int)IDnumericUpDown.Value);
            return (producto != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            repository = new RepositoryBase<Producto>();

            Producto producto;

            if (!Validar(2))
                return;
            producto = LlenarClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repository.Guardar(producto);

            }
            else
            {
                 var productos = LlenarClase();
               
                if (productos != null)
                {
                    paso = repository.Modificar(productos);
                }
                else
                {
                    MessageBox.Show("Id no Encotrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (paso)
            {
                MessageBox.Show("Guardo con Exito", "Exite", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se Guardo!!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            repository = new RepositoryBase<Producto>();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExiteEnLaDb())
            {
                errorProvider1.SetError(IDnumericUpDown, "El producto no Exite");
                IDnumericUpDown.Focus();
                return;
            }
            if (repository.Eliminar(id))
            {
                MessageBox.Show("Eliminado con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Exite No se puede Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repository = new RepositoryBase<Producto>();
            int id;
            Producto articulos = new Producto();

            int.TryParse(IDnumericUpDown.Text, out id);
            articulos = repository.Buscar(id);

            if (articulos != null)
            {
                MessageBox.Show("Producto Encotrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampo(articulos);
            }
            else
            {
                MessageBox.Show("Producto no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

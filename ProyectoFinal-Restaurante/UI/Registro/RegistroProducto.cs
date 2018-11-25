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
            FechadateTimePicker.Value = DateTime.Now;
            ItbnumericUpDown.Value = 0;
        }

        private Producto LlenarClase()
        {
            Producto articulos = new Producto();
            articulos.ProductoID = Convert.ToInt32(IDnumericUpDown.Value);
            articulos.Descripcion = DescripciontextBox.Text;
            articulos.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            articulos.Precio = Convert.ToSingle(PrecionumericUpDown.Value);
            articulos.FechaDeRegistro = FechadateTimePicker.Value;
           // articulos.Iterbis = Convert.ToSingle(ItbnumericUpDown.Value);
      
            return articulos;
        }




        private void LlenarCampo(Producto articulos)
        {
            IDnumericUpDown.Value = articulos.ProductoID;
            DescripciontextBox.Text = articulos.Descripcion;
            CantidadnumericUpDown.Value = articulos.Cantidad;
            PrecionumericUpDown.Value = Convert.ToDecimal(articulos.Precio);
            FechadateTimePicker.Value = articulos.FechaDeRegistro;
            //ItbnumericUpDown.Value = Convert.ToDecimal(articulos.Iterbis);
        }




        public bool Validar(int error)
        {
            bool paso = false;



            if (error == 2 && FechadateTimePicker.Value == DateTime.Now || FechadateTimePicker.Value < DateTime.Now)
            {
                errorProvider1.SetError(FechadateTimePicker, "Fecha Fuera De Rango");
                paso = true;
            }
            if (error == 2 && GanancianumericUpDown.Value == 0)
            {
                errorProvider1.SetError(GanancianumericUpDown, "Ganancia en 0");
                paso = true;
            }

            if (error == 2 && CostonumericUpDown.Value == 0)
            {
                errorProvider1.SetError(CostonumericUpDown, "Costo en 0");
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

            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider1.SetError(DescripciontextBox, "Campo Vacio");
                paso = true;
            }
            return paso;
        }





        public bool ExiteEnLaDb()
        {
            repository = new RepositoryBase<Producto>();
            Producto articulos = new Producto();
            articulos = repository.Buscar((int)IDnumericUpDown.Value);
            return (articulos != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            repository = new RepositoryBase<Producto>();

            Producto articulos;

            if (!Validar(2))
                return;
            articulos = LlenarClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repository.Guardar(articulos);

            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);
                var articulo = repository.Buscar(id);
                if (articulo != null)
                {
                    paso = repository.Modificar(articulo);
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
                errorProvider1.SetError(IDnumericUpDown, "Artuculo no Exite");
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
            repository.Buscar(id);

            if (articulos != null)
            {
                MessageBox.Show("Articulos Encotrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampo(articulos);
            }
            else
            {
                MessageBox.Show("Cliente no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

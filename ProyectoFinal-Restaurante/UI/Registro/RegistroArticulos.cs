using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registro
{
    public partial class RegistroArticulos : Form
    {
        RepositoryBase<Articulos> repository;
        public RegistroArticulos()
        {
            InitializeComponent();
            repository = new RepositoryBase<Articulos>();
        }


        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            ItbnumericUpDown.Value = 0;
            CostonumericUpDown.Value = 0;
            GanancianumericUpDown.Value = 0;
        }

        private Articulos LlenarClase()
        {
            Articulos articulos = new Articulos();
            articulos.IDArticulos = Convert.ToInt32(IDnumericUpDown.Value);
            articulos.Descripcion = DescripciontextBox.Text;
            articulos.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            articulos.Precio = Convert.ToSingle(PrecionumericUpDown.Value);
            articulos.FechaDevencimineto = FechadateTimePicker.Value;
            articulos.Itebis = Convert.ToSingle(ItbnumericUpDown.Value);
            articulos.Costo = Convert.ToSingle(CostonumericUpDown.Value);
            articulos.Ganancia = Convert.ToSingle(GanancianumericUpDown.Value);

            return articulos;
        }
        private void LlenarCampo(Articulos articulos)
        {
            IDnumericUpDown.Value = articulos.IDArticulos;
            DescripciontextBox.Text = articulos.Descripcion;
            CantidadnumericUpDown.Value = articulos.Cantidad;
            PrecionumericUpDown.Value = Convert.ToDecimal(articulos.Precio);
            FechadateTimePicker.Value = articulos.FechaDevencimineto;
            ItbnumericUpDown.Value = Convert.ToDecimal(articulos.Itebis);
            CostonumericUpDown.Value = Convert.ToDecimal(articulos.Costo);
            GanancianumericUpDown.Value = Convert.ToDecimal(articulos.Ganancia);

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
            repository = new RepositoryBase<Articulos>();
            Articulos articulos = new Articulos();
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
            repository = new RepositoryBase<Articulos>();

            Articulos articulos;

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
            repository = new RepositoryBase<Articulos>();
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
            repository = new RepositoryBase<Articulos>();
            int id;
            Articulos articulos = new Articulos();

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

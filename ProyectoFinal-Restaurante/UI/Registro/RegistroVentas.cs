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
    public partial class RegistroVentas : Form
    {
        List<FacturaDetalle> detalles;
        public RepositoryBase<Producto> repository;
        public RegistroVentas()
        {
            InitializeComponent();
            LlenarImporte();
            repository = new RepositoryBase<Producto>();
           LlenarCombo();
            detalles = new List<FacturaDetalle>();
            //ProductocomboBox.SelectedIndex = 0;
        }
        decimal itebis = 0;
        decimal total = 0;

        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadnumericUpDown.Value = 0;
            SubTotaltextBox.Text = 0.ToString();
            ITBtextBox.Text = 0.ToString();
            TotaltextBox.Text = 0.ToString();
            PreciotextBox.Text = 0.ToString();
            CantidadnumericUpDown.Value = 0;
            itebis = 0;
            ImportetextBox.Text = 0.ToString();

        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);
            return retorno;
        }

        public void LlenarImporte()
        {
            int precio, cantidad;
            precio = ToInt(PreciotextBox.Text);
            cantidad = ToInt(CantidadnumericUpDown.Value);

            ImportetextBox.Text = FacturacionBLL.CacularImporte(precio, cantidad).ToString();

        }

        private Facturacion LlenarClase()
        {
            Facturacion factura = new Facturacion();
            factura.FactutaID = Convert.ToInt32(IDnumericUpDown.Value);
            factura.UsuarioID = Convert.ToInt32((UsuariocomboBox.SelectedValue));
            factura.FechaDeFactura = FechadateTimePicker.Value;
            factura.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            factura.SubTotal = Convert.ToSingle(SubTotaltextBox.Text);
            factura.Iterbis = Convert.ToDecimal(ITBtextBox.Text);
            factura.ToTal = Convert.ToDecimal(TotaltextBox.Text);

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                factura.AgregarDetalle
                 (
                 ToInt(item.Cells["FacturaDetalleID"].Value),
                 factura.FactutaID,
                 ToInt(item.Cells["ProductoID"].Value),
                 Convert.ToString(item.Cells["Productos"].Value),
                 ToInt(item.Cells["Cantidad"].Value),
                 ToInt(item.Cells["Precio"].Value),
                 ToInt(item.Cells["Importe"].Value)
                 );

            }
            return factura;
        }

        private void Llenarcampo(Facturacion factura)
        {
            IDnumericUpDown.Value = factura.FactutaID;
            FechadateTimePicker.Value = factura.FechaDeFactura;
            SubTotaltextBox.Text = factura.SubTotal.ToString();
            ITBtextBox.Text = factura.Iterbis.ToString();
            TotaltextBox.Text = factura.ToTal.ToString();
            dataGridView1.DataSource = factura.Detalle;
        }

        private void LlenarCombo()
        {
            RepositoryBase<Usuario> repositoryBase = new RepositoryBase<Usuario>();
            UsuariocomboBox.DataSource = repositoryBase.GetList(c => true);
            UsuariocomboBox.ValueMember = "UsuarioID";
            UsuariocomboBox.DisplayMember = "Nombre";

            RepositoryBase<Producto> repositoryBaseA = new RepositoryBase<Producto>();
            ProductocomboBox.DataSource = repositoryBaseA.GetList(x => true);
            ProductocomboBox.ValueMember = "ProductoID";
            ProductocomboBox.DisplayMember = "Descripcion";
        }

        public void QuitarCulumnas()
        {
            dataGridView1.Columns["Producto"].Visible = false;
            dataGridView1.Columns["FacturaID"].Visible = false;
            dataGridView1.Columns["FacturaDetalleID"].Visible = false;

        }

        public static string RetornarDescripcion(string nombre)
        {

            RepositoryBase<Producto> repositoryBase = new RepositoryBase<Producto>();
            string descripcion = string.Empty;
            var lista = repositoryBase.GetList(x => x.Descripcion.Equals(nombre));
            foreach (var item in lista)
            {
                descripcion = item.Descripcion;
            }

            return descripcion;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            FacturaDetalle facturaDetalle = new FacturaDetalle();
            facturaDetalle.ProductoID = ProductocomboBox.SelectedIndex;
            facturaDetalle.Cantidad = (int)CantidadnumericUpDown.Value;
            facturaDetalle.FacturaID = (int)IDnumericUpDown.Value;
            facturaDetalle.Importe = Convert.ToInt32(ImportetextBox.Text);
            facturaDetalle.precio = Convert.ToInt32(PreciotextBox.Text);

            detalles.Add(facturaDetalle);

            dataGridView1.DataSource = detalles.ToList();

            decimal subtotal = 0;
            foreach (var item in detalles)
            {
                subtotal += item.Importe;
            }
            SubTotaltextBox.Text = subtotal.ToString();
            itebis = FacturacionBLL.CacularItebis(Convert.ToDecimal(SubTotaltextBox.Text));
            ITBtextBox.Text = itebis.ToString();
            total = FacturacionBLL.CarcularTotal(Convert.ToDecimal(SubTotaltextBox.Text), Convert.ToDecimal(ITBtextBox.Text));
            TotaltextBox.Text = total.ToString();
        }

        private void ProductocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepositoryBase<Producto> repository = new RepositoryBase<Producto>();
            foreach (var item in repository.GetList(x => x.Descripcion == ProductocomboBox.Text))
            {
                PreciotextBox.Text = item.Precio.ToString();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Facturacion> repository = new RepositoryBase<Facturacion>();
            bool paso;
            Facturacion facturacion = LlenarClase();
            if (IDnumericUpDown.Value == 0)
                paso = repository.Guardar(facturacion);
            else
            {
                paso = repository.Modificar(facturacion);
                if (paso)
                {
                    MessageBox.Show("Modificado");
                    
                }
                else
                    MessageBox.Show("No Modificado");
                return;
            }
            if (paso)
                MessageBox.Show("Guardar!!");
            else
                MessageBox.Show("No Guardado");

                
        }

        private void RegistroVentas_Load(object sender, EventArgs e)
        {

        }

        private void ProductocomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RepositoryBase<Producto> repository = new RepositoryBase<Producto>();
            Producto p =repository.Buscar(Convert.ToInt32(1));
            PreciotextBox.Text = p.Precio.ToString();
        }
    }
}

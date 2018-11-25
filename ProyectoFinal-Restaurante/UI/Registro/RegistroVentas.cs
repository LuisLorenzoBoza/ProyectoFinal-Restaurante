using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.DAL;
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
            repository = new RepositoryBase<Producto>(new Contexto());
            LlenarCombo();
            detalles = new List<FacturaDetalle>();
        }
        decimal itebis = 0;
        decimal total = 0;
    


        public void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            // DescripciontextBox.Clear();
            CantidadnumericUpDown.Value = 0;
            SubTotaltextBox.Text = 0.ToString();
            ITBtextBox.Text = 0.ToString();
            TotaltextBox.Text = 0.ToString();
            PreciotextBox.Text = 0.ToString();
            CantidadnumericUpDown.Value = 0;

            importetextBox.Text = 0.ToString();

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

            importetextBox.Text = FacturacionBLL.CacularImporte(precio, cantidad).ToString();

        }
        private Factura LlenarClase()
        {
            Factura factura = new Factura();
            factura.FactutaID = Convert.ToInt32(IDnumericUpDown.Value);
            factura.UsuarioID = Convert.ToInt32((UsuariocomboBox.Text));
            factura.FechaDeFactura = FechadateTimePicker.Value;
            factura.ProductoID = Convert.ToInt32(IDProductonumericUpDown.Value);
            // factura.Descripcion = DescripciontextBox.Text;
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
                 ToInt(item.Cells["IDArticulo"].Value),
                 Convert.ToString(item.Cells["Articulos"].Value),
                 ToInt(item.Cells["Cantidad"].Value),
                 ToInt(item.Cells["Precio"].Value),
                 ToInt(item.Cells["Importe"].Value)
                 );

            }
            return factura;
        }



        private void Llenarcampo(Factura factura)
        {
            IDnumericUpDown.Value = factura.FactutaID;
            FechadateTimePicker.Value = factura.FechaDeFactura;
            DescripciontextBox.Text = factura.Descripcion;
            SubTotaltextBox.Text = factura.SubTotal.ToString();
            ITBtextBox.Text = factura.Iterbis.ToString();
            TotaltextBox.Text = factura.ToTal.ToString();
            dataGridView1.DataSource = factura.Detalle;

        }



        private void LlenarCombo()
        {
            RepositoryBase<Usuario> repositoryBase = new RepositoryBase<Usuario>(new Contexto());
            UsuariocomboBox.DataSource = repositoryBase.GetList(c => true);
            UsuariocomboBox.ValueMember = "IDUsuario";
            UsuariocomboBox.DisplayMember = "Nombre";

            RepositoryBase<Producto> repositoryBaseA = new RepositoryBase<Producto>();
            ArticuloscomboBox.ValueMember = "IDArticulos";
            ArticuloscomboBox.DisplayMember = "Descripcion";
        }




        public void QuitarCulumnas()
        {
            dataGridView1.Columns["Articulos"].Visible = false;
            dataGridView1.Columns["FacturaID"].Visible = false;
            dataGridView1.Columns["IDFacturaDetalle"].Visible = false;

        }



        public static string RetornarDescripcion(string nombre)
        {

            RepositoryBase<Producto> repositoryBase = new RepositoryBase<Producto>(new Contexto());
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
            facturaDetalle.ProductoID = ArticuloscomboBox.SelectedIndex;
            facturaDetalle.Cantidad = (int)CantidadnumericUpDown.Value;
            facturaDetalle.FacturaID = (int)IDnumericUpDown.Value;
            facturaDetalle.Importe = Convert.ToInt32(importetextBox.Text);
            //facturaDetalle.precio = Convert.ToInt32(PreciotextBox.Text);

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

        private void ArticuloscomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RepositoryBase<Producto> repository = new RepositoryBase<Producto>();
            foreach (var item in repository.GetList(x => x.Descripcion == ArticuloscomboBox.Text))
            {
                PreciotextBox.Text = item.Precio.ToString();
            }

        }
    }
}

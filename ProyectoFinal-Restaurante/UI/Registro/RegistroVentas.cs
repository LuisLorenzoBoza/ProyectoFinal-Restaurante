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
        Factura facturaGlobal = new Factura();
        List<FacturaDetalle> Detalle = new List<FacturaDetalle>(); 
        public RepositoryBase<Producto> repository;
        public int index { get; set; }
        public bool Eliminar = false;
        public RegistroVentas()
        {
            InitializeComponent();
            LlenarImporte();
            repository = new RepositoryBase<Producto>();
            LlenarCombo();
            ProductocomboBox.SelectedIndex = 0;
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
            IdDetallenumericUpDown.Value = 0;
            facturaGlobal.Detalle = new List<FacturaDetalle>();
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

        private Factura LlenarClase()
        {
            Factura factura = new Factura();
            factura.FactutaID = Convert.ToInt32(IDnumericUpDown.Value);
            factura.UsuarioID = Convert.ToInt32((UsuariocomboBox.SelectedValue));
            factura.FechaDeFactura = FechadateTimePicker.Value;
            factura.Cantidad = Convert.ToInt32(CantidadnumericUpDown.Value);
            factura.SubTotal = Convert.ToSingle(SubTotaltextBox.Text);
            factura.Iterbis = Convert.ToDecimal(ITBtextBox.Text);
            factura.ToTal = Convert.ToDecimal(TotaltextBox.Text);
            factura.Detalle = facturaGlobal.Detalle;
            
           
            return factura;
        }

        private void Llenarcampo(Factura factura)
        {
            IDnumericUpDown.Value = factura.FactutaID;
            FechadateTimePicker.Value = factura.FechaDeFactura;
            SubTotaltextBox.Text = factura.SubTotal.ToString();
            ITBtextBox.Text = factura.Iterbis.ToString();
            TotaltextBox.Text = factura.ToTal.ToString();
            DetalledataGridView.DataSource = factura.Detalle;
        }
        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = Detalle;
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
            DetalledataGridView.Columns["Producto"].Visible = false;
            DetalledataGridView.Columns["FacturaID"].Visible = false;
            DetalledataGridView.Columns["FacturaDetalleID"].Visible = false;

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
            facturaDetalle.ProductoID = (int)IDProductonumericUpDown.Value;
            facturaDetalle.Productos = ProductocomboBox.Text;
            facturaDetalle.Cantidad = (int)CantidadnumericUpDown.Value;
            facturaDetalle.facturaID = (int)IDnumericUpDown.Value;
            facturaDetalle.Importe = Convert.ToInt32(ImportetextBox.Text);
            facturaDetalle.precio = Convert.ToInt32(PreciotextBox.Text);
            facturaDetalle.FacturaDetalleID = (int)IdDetallenumericUpDown.Value;
            if(IdDetallenumericUpDown.Value == 0)
            {
                facturaGlobal.Detalle.Add(new FacturaDetalle(0,0.0f,(int)IDnumericUpDown.Value,1,DateTime.Now,(int)IDProductonumericUpDown.Value
                    ,ProductocomboBox.Text,(int)CantidadnumericUpDown.Value,Convert.ToInt32(PreciotextBox.Text),Convert.ToInt32(ImportetextBox.Text)));
            }
            else
            {
                //facturaGlobal.Detalle.Add(facturaDetalle);
            }


            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = facturaGlobal.Detalle;
            decimal subtotal = 0;
            foreach (var item in Detalle)
            {
                subtotal += item.Importe;
            }
            SubTotaltextBox.Text = subtotal.ToString();
            itebis = FacturacionBLL.CacularItebis(Convert.ToDecimal(SubTotaltextBox.Text));
            ITBtextBox.Text = itebis.ToString();
            total = FacturacionBLL.CarcularTotal(Convert.ToDecimal(SubTotaltextBox.Text), Convert.ToDecimal(ITBtextBox.Text));
            TotaltextBox.Text = total.ToString();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Factura> repository = new RepositoryBase<Factura>();
            bool paso;
            Factura facturacion = LlenarClase();
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
      
        private void ProductocomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            RepositoryBase<Producto> repository = new RepositoryBase<Producto>();
            foreach (var item in repository.GetList(x => x.Descripcion == ProductocomboBox.Text))
            {
                PreciotextBox.Text = item.Precio.ToString();
                IDProductonumericUpDown.Value = item.ProductoID;
            }
        }

        private void DetalledataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (index >= 0)
            {
                Eliminar = true;
                FacturaDetalle detalle = facturaGlobal.Detalle.ElementAt(index);
                
                Detalle.Add(new FacturaDetalle(detalle.FacturaDetalleID, detalle.iterbis, detalle.facturaID, detalle.UsuarioID, detalle.FechaDeFactura, detalle.ProductoID
                    , detalle.Productos, detalle.Cantidad, detalle.precio, detalle.precio));
                facturaGlobal.Detalle.RemoveAt(index);
                
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = facturaGlobal.Detalle;

                index = -1;
                MessageBox.Show("Eliminado", "Carne", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (DetalledataGridView.Rows.Count == 0)
                    MessageBox.Show("No Hay Detalle Seleccionado", "Carne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

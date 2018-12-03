using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using ProyectoFinal_Restaurante.Reportes;
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
        decimal Monto = 0;
        bool paso = true, Arreglar = false;
        Factura facturas = new Factura();
        List<FacturaDetalle> Detalle = new List<FacturaDetalle>();
        public RepositoryBase<Producto> repository;
        public int RowSelected { get; set; }
        public RegistroVentas()
        {
            InitializeComponent();
            LlenarComboBox();
            UsuariotextBox.Text = FacturacionBLL.returnUsuario().Nombre;
            //UsuariotextBox.Text = Login.user;
        }
        private void LlenarComboBox()
        {
            RepositoryBase<Factura> repositoryBase = new RepositoryBase<Factura>();
            DevueltatextBox.Text = "0";
            IDcomboBox.Items.Clear();
            CLienteIDcomboBox.Items.Clear();
            ProductoIdcomboBox.Items.Clear();
            //CLienteIDcomboBox.DataSource = repositoryBase.GetList(c => true);
            foreach (var item in repositoryBase.GetList(c => true))
            {
                CLienteIDcomboBox.Items.Add(item.ClienteId);
            }
            RepositoryBase<Producto> repositoryBaseA = new RepositoryBase<Producto>();
            foreach (var item in repositoryBaseA.GetList(c => true))
            {
                ProductoIdcomboBox.Items.Add(item.ProductoID);
            }
            foreach (var item in FacturacionBLL.GetList(x => true))
            {
                IDcomboBox.Items.Add(item.FacturaId);
            }
            
        }
        private void LimpiarProvider()
        {
            IDerrorProvider.Clear();
            DemaserrorProvider.Clear();
            ProductoerrorProvider.Clear();
        }
        private bool SetError(int error)
        {
            bool paso = false;
            if (error == 1 && IDcomboBox.Text == string.Empty)
            {
                IDerrorProvider.SetError(IDcomboBox, "Llenar Id");
                paso = true;
            }
            if (error == 2 && CLienteIDcomboBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(CLienteIDcomboBox, "Llenar Cliente Id");
                paso = true;
            }
            if (error == 2 && DescripciponFacturatextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(DescripciponFacturatextBox, "Llenar descripcion");
                paso = true;
            }
            if (error == 2 && DescripciponFacturatextBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(DescripciponFacturatextBox, "Llenar descripcion");
                paso = true;
            }
            if (error == 3 && ProductoIdcomboBox.Text == string.Empty)
            {
                ProductoerrorProvider.SetError(ProductoIdcomboBox, " Llenar id producto");
                paso = true;
            }
            if (error == 4 && DetallecomboBox.Text == string.Empty)
            {
                ProductoerrorProvider.SetError(DetallecomboBox, " Llenar id producto");
                paso = true;
            }
            if (error == 5 && Convert.ToDecimal(DevueltatextBox.Text) < 0)
            {
                DemaserrorProvider.SetError(DevueltatextBox, "Arreglar efectivo recibido");
                paso = true;
            }
            if (error == 6 && ProductoIdcomboBox.Text == string.Empty)
            {
                DemaserrorProvider.SetError(ProductoIdcomboBox, "Debe de buscar antes de agregar!");
                paso = true;
            }
            if (error == 7 && CantidadnumericUpDown.Value == 0)
            {
                DemaserrorProvider.SetError(CantidadnumericUpDown, "Debe de agregar una cantidad andes de agregar!");
                paso = true;
            }
            return paso;
        }
        private void LimpiarProducto()
        {
            LimpiarProvider();
            CantidadnumericUpDown.Value = 0;
            DescripcionProductotextBox.Clear();
            ProductoIdcomboBox.Text = string.Empty;
            PreciotextBox.Clear();
            ImportetextBox.Clear();
            DetallecomboBox.Text = string.Empty;
        }
        private Factura LlenaClase()
        {
            Factura factura = new Factura();
            if (IDcomboBox.Text == string.Empty)
            {
                factura.FacturaId = 0;
            }
            else
            {
                factura.FacturaId = Convert.ToInt32(IDcomboBox.Text);
            }
            factura.ClienteId = Convert.ToInt32(CLienteIDcomboBox.Text);
            factura.UsuarioId = BLL.FacturacionBLL.returnUsuario().UsuarioID;
            factura.Fecha = FechadateTimePicker.Value;
            factura.Descripcion = DescripciponFacturatextBox.Text;
            factura.EfectivoRecibido = EfectivonumericUpDown.Value;
            factura.Monto = Convert.ToDecimal(MontotextBox.Text);
            factura.Devuelta = Convert.ToDecimal(DevueltatextBox.Text);
            factura.Detalle = facturas.Detalle;
            return factura;
        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Clean();
        }
        private void Clean()
        {
            IDcomboBox.Text = string.Empty;
            CLienteIDcomboBox.Text = string.Empty;
            DescripciponFacturatextBox.Clear();
            LimpiarProducto();
            NombreCLientetextBox.Text = string.Empty;
            EfectivonumericUpDown.Value = 0;
            DevueltatextBox.Text = "0";
            MontotextBox.Text = "0";
            LimpiarProvider();
            FacturadataGridView.DataSource = null;
            facturas.Detalle = new List<FacturaDetalle>();
            Monto = 0;
            DetallecomboBox.Text = string.Empty;
            DetallecomboBox.Enabled = false;
            EliminarDetalle.Enabled = false;
            FechadateTimePicker.Value = DateTime.Now;
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(1))
            {
                MessageBox.Show("Llenar campos Vacios");
                return;
            }
            var result = MessageBox.Show("Seguro de  Eliminar?", " ",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FacturacionBLL.ArreglarProducto(FacturacionBLL.Buscar(Convert.ToInt32(IDcomboBox.Text)));
                if (FacturacionBLL.Eliminar(Convert.ToInt32(IDcomboBox.Text)))
                {
                    MessageBox.Show("Eliminado");
                    IDcomboBox.DataSource = null;
                    LlenarComboBox();
                    Clean();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
        }
        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(6))
            {
                MessageBox.Show("Debe Buscar Antes de poner una cantidad");
                CantidadnumericUpDown.Value = 0;
                return;
            }
            ImportetextBox.Text = FacturacionBLL.Importedemas(CantidadnumericUpDown.Value, Convert.ToDecimal(PreciotextBox.Text)).ToString();
        }
        private void EfectivonumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AsignarDevuelta();
        }
        private void AsignarDevuelta()
        {
            DevueltatextBox.Text = FacturacionBLL.RetornarDevuelta(EfectivonumericUpDown.Value, Convert.ToDecimal(MontotextBox.Text)).ToString();
        }
        private void DetallecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID, id;
            id = Convert.ToInt32(IDcomboBox.Text);
            ID = Convert.ToInt32(DetallecomboBox.Text);
            if (facturas.Detalle.Count() == 0)
            {
                facturas.Detalle = FacturaDetalleBLL.GetList(x => x.FacturaId == id);
            }
            foreach (var item in facturas.Detalle)
            {
                if (item.Id == ID)
                {
                    DescripcionProductotextBox.Text = item.Descripcion;
                    PreciotextBox.Text = item.Precio.ToString();
                    ProductoIdcomboBox.Text = item.ProductoId.ToString();
                    CantidadnumericUpDown.Value = item.Cantidad;
                }
            }
        }
        private void ProductoIdcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            RepositoryBase<Producto> repositoryBase = new RepositoryBase<Producto>();
            CantidadnumericUpDown.Value = 0;
            ImportetextBox.Clear();
            int id = Convert.ToInt32(ProductoIdcomboBox.Text);
            foreach (var item in repositoryBase.GetList(c => c.ProductoID == id))
            {
                DescripcionProductotextBox.Text = item.Descripcion;
                PreciotextBox.Text = item.Precio.ToString();
            }
        }
        private void IDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            int idfactura = Convert.ToInt32(IDcomboBox.Text);
            facturas = FacturacionBLL.Buscar(Convert.ToInt32(IDcomboBox.Text));
            CLienteIDcomboBox.Text = facturas.ClienteId.ToString();
            DescripciponFacturatextBox.Text = facturas.Descripcion;
            DevueltatextBox.Text = facturas.Devuelta.ToString();
            MontotextBox.Text = facturas.Monto.ToString();
            Monto = facturas.Monto;
            FechadateTimePicker.Value = facturas.Fecha;
            EfectivonumericUpDown.Value = facturas.EfectivoRecibido;
            facturas.Detalle = FacturaDetalleBLL.GetList(x => x.FacturaId == idfactura);
            LlenarDetalleComboBox();
            DetallecomboBox.Enabled = true;
            EliminarDetalle.Enabled = true;
            foreach (var item in facturas.Detalle)
            {
                item.Importe = FacturacionBLL.Importedemas(item.Cantidad, item.Precio);
            }
            FacturadataGridView.DataSource = facturas.Detalle;
            Detalle = new List<FacturaDetalle>();
        }
        private void LlenarDetalleComboBox()
        {
            DetallecomboBox.Items.Clear();
            foreach (var item in facturas.Detalle)
            {
                DetallecomboBox.Items.Add(item.Id);
            }
        }
        private void CLienteIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarProvider();
            RepositoryBase<Cliente> repositoryBase = new RepositoryBase<Cliente>();
            NombreCLientetextBox.Text = repositoryBase.Buscar(Convert.ToInt32(CLienteIDcomboBox.Text)).Nombre;
        }
        private void EliminarDetalle_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Eliminar el detalle seleccionado?", " ",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RowSelected >= 0)
                {
                    Monto -= FacturacionBLL.RecalcularImporte(facturas.Detalle, RowSelected);
                    MontotextBox.Text = Monto.ToString();
                    Arreglar = true;
                    FacturaDetalle factura = facturas.Detalle.ElementAt(RowSelected);
                    Detalle.Add(new FacturaDetalle(factura.Id, factura.FacturaId, factura.ProductoId, factura.Cantidad, factura.Precio, factura.Descripcion, factura.Importe));
                    facturas.Detalle.RemoveAt(RowSelected);
                    FacturadataGridView.DataSource = null;
                    FacturadataGridView.DataSource = facturas.Detalle;
                    RowSelected = -1;
                    if (paso)
                    {
                        AsignarDevuelta();
                    }
                    MessageBox.Show("Eliminado!");
                }
            }
        }
        private void Guardarbutton_Click_1(object sender, EventArgs e)
        {
            LimpiarProvider();
            if (SetError(2))
            {
                MessageBox.Show("Llenar Campos vacios");
                return;
            }
            Factura factura = LlenaClase();
            if (IDcomboBox.Text == string.Empty)
            {
                if (FacturacionBLL.Guardar(factura))
                {
                    MessageBox.Show("Guardado!!");
                    LlenarComboBox();
                    FacturacionBLL.DescontarProductos(facturas.Detalle);
                    var result = MessageBox.Show("Desea Imprimir un recibo?", " ",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RepositoryBase<Cliente> repositorio = new RepositoryBase<Cliente>();
                        var usuario = repositorio.Buscar(factura.ClienteId);
                        DetalleReporte reporte = new DetalleReporte(facturas.Detalle, UsuariotextBox.Text, usuario.Nombre);
                        reporte.Show();
                    }
                    Clean();
                }
                else
                {
                    MessageBox.Show("No se pudo Guardar!!");
                }
            }
            else
            {
                var result = MessageBox.Show("Seguro de Modificar?", " ",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (FacturacionBLL.Modificar(LlenaClase()))
                    {
                        MessageBox.Show("Modificado !");
                        if (Detalle.Count != 0)
                        {
                            foreach (var item in Detalle)
                            {
                                FacturaDetalleBLL.Eliminar(item.Id);
                            }
                        }
                        if (Arreglar)
                        {
                            FacturacionBLL.ArreglarProductoList(Detalle);
                            Arreglar = false;
                        }
                        var resultado = MessageBox.Show("Desea Imprimir un recibo?", " ",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Factura facturas = LlenaClase();
                            RepositoryBase<Cliente> repositorio = new RepositoryBase<Cliente>();
                            var usuario = repositorio.Buscar(factura.ClienteId);
                            DetalleReporte reporte = new DetalleReporte(facturas.Detalle, UsuariotextBox.Text, usuario.Nombre);
                            reporte.Show();
                        }
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar!");
                    }
                }
            }

        }
        private void Agregarbutton_Click_1(object sender, EventArgs e)
        {
            LimpiarProvider();
            RepositoryBase<Producto> repositoryBase = new RepositoryBase<Producto>();
            if (SetError(6) || SetError(7))
            {
                MessageBox.Show("Debe de completar los campos marcados");
                return;
            }
            if (repositoryBase.Buscar(Convert.ToInt32(ProductoIdcomboBox.Text)).Cantidad - Convert.ToInt32(CantidadnumericUpDown.Value) < 0)
            {
                MessageBox.Show("Cantidad insuficiente del producto solicitado");
                MessageBox.Show("Disponibles " + repositoryBase.Buscar(Convert.ToInt32(ProductoIdcomboBox.Text)).Cantidad.ToString());
                return;
            }
            if (IDcomboBox.Text == string.Empty)
            {
                facturas.Detalle.Add(new FacturaDetalle(0, facturas.FacturaId, Convert.ToInt32(ProductoIdcomboBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));
            }
            else
            {
                int idfactura = Convert.ToInt32(IDcomboBox.Text);
                if (facturas.Detalle.Count == 0)
                {
                    facturas.Detalle = FacturaDetalleBLL.GetList(x => x.FacturaId == idfactura);
                }
                if (DetallecomboBox.Text == string.Empty)
                {
                    var Idproducto = Convert.ToInt32(ProductoIdcomboBox.Text);
                    if (facturas.Detalle.Exists(x => x.ProductoId == Idproducto))
                    {
                        foreach (var item in facturas.Detalle)
                        {
                            if (item.ProductoId == Idproducto)
                            {
                                item.Cantidad += Convert.ToInt32(CantidadnumericUpDown.Value);
                            }
                        }
                    }
                    else
                    {
                        facturas.Detalle.Add(new FacturaDetalle(0, Convert.ToInt32(IDcomboBox.Text), Convert.ToInt32(ProductoIdcomboBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));
                    }
                }
                else
                {
                    Monto -= FacturacionBLL.DescontarImporte(facturas.Detalle, Convert.ToInt32(DetallecomboBox.Text));

                    foreach (var item in facturas.Detalle)
                    {
                        item.Importe = FacturacionBLL.Importe(item.Cantidad, CantidadnumericUpDown.Value, item.Precio, Convert.ToInt32(ProductoIdcomboBox.Text), item.ProductoId);
                    }
                    facturas.Detalle = FacturacionBLL.Editar(facturas.Detalle, new FacturaDetalle(Convert.ToInt32(DetallecomboBox.Text), Convert.ToInt32(IDcomboBox.Text), Convert.ToInt32(ProductoIdcomboBox.Text), Convert.ToInt32(CantidadnumericUpDown.Value), Convert.ToDecimal(PreciotextBox.Text), DescripcionProductotextBox.Text, Convert.ToDecimal(ImportetextBox.Text)));
                }
            }
            Monto += FacturacionBLL.CalcularMonto(Convert.ToDecimal(ImportetextBox.Text));
            MontotextBox.Text = Monto.ToString();
            if (paso)
            {
                AsignarDevuelta();
            }
            FacturadataGridView.DataSource = null;
            FacturadataGridView.DataSource = facturas.Detalle;
            LimpiarProducto();
            LlenarDetalleComboBox();
            EliminarDetalle.Enabled = true;
        }
        private void FacturadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowSelected = e.RowIndex;
        }
    }
}

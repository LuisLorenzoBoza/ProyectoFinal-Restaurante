using ProyectoFinal_Restaurante.BLL;
using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.UI.Consulta
{
    public partial class ConsultaFactura : Form
    {
        private List<Factura> Factura = new List<Factura>();
        Expression<Func<Factura, bool>> filtro = x => true;

        public ConsultaFactura()
        {
            InitializeComponent();            
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositoryBase<Factura> repository = new RepositoryBase<Factura>();
            var listado = new List<Factura>();

            if (CriteriotextBox.Text.Trim().Length >= 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = repository.GetList(p => true);
                        break;
                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.FacturaId == id);
                        break;
                    case 2://Monto
                        decimal monto = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.Monto == monto);
                        break;
                    case 3://UsuarioId
                        int usuarioId = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.UsuarioId == usuarioId);
                        break;
                    case 4://ClienteId
                        int clienteId = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.ClienteID == clienteId);
                        break;
                    case 5://Descripcion
                        listado = repository.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;
                    case 6://Devuelta
                        decimal devuelta = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.Devuelta == devuelta);
                        break;
                    case 7://Efectivo Recibido
                        decimal efectivoRecibido = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repository.GetList(p => p.EfectivoRecibido == efectivoRecibido);
                        break;

                }
                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repository.GetList(p => true);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
            CriteriotextBox.Clear();
            Factura = listado;
        }

        /*private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            if (Entidades.Factura.Count == 0)
            {
                MessageBox.Show("No encontrado");
                return;
            }
            ReporteDeFacturasReview reporteDeFacturasReview = new ReporteDeFacturasReview(Factura);
            reporteDeFacturasReview.Show();
        }  */      
    }
}

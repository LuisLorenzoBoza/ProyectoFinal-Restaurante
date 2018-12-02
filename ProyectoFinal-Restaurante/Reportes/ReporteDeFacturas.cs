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

namespace ProyectoFinal_Restaurante.Reportes
{
    public partial class ReporteDeFacturas : Form
    {
        List<Factura> lista = new List<Factura>();
        public ReporteDeFacturas(List<Factura> factura)
        {
            InitializeComponent();
            lista = factura;
        }

        private void FacturacrystalReportViewer_Load(object sender, EventArgs e)
        {
            ReporteDeFactura reporte = new ReporteDeFactura();
            reporte.SetDataSource(lista);
            FacturacrystalReportViewer.ReportSource = reporte;
            FacturacrystalReportViewer.Refresh();


        }
    }
}

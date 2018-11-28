using ProyectoFinal_Restaurante.Entidades;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

 namespace ProyectoFinal_Restaurante.Reportes
{
    public partial class ProductoReview : Form
    {
        public List<Producto> producto;
        public ProductoReview(List<Producto> pr)
        {
            InitializeComponent();
            this.producto = pr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ProductoCrystalReport productoCrystalReporte = new ProductoCrystalReport();
            productoCrystalReporte.SetDataSource(producto);
            ProductocrystalReportViewer.ReportSource = productoCrystalReporte;
            productoCrystalReporte.Refresh();
        }
    }
}

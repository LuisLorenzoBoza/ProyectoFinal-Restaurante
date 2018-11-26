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
    private List<Producto> producto = new List<Producto>();
    public partial class ProductoReview : Form
    {
        public ProductoReview()
        {
            InitializeComponent();
            this.producto = pr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ProductoCrystalReporte productoCrystalReporte = new ProductoCrystalReporte();
            productoCrystalReporte.SetDataSource(producto);
            ProductocrystalReportViewer.ReportSource = productoCrystalReporte;
            productoCrystalReporte.Refresh();
        }
    }
}

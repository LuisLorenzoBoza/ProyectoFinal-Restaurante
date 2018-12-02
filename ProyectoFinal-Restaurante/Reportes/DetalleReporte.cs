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
    public partial class DetalleReporte : Form
    {
        List<FacturaDetalle> detalle = new List<FacturaDetalle>();
        String usuario;
        String Cliente;
        public DetalleReporte(List<FacturaDetalle> det,String user,String clie)
        {
            InitializeComponent();
            detalle = det;
            usuario = user;
            Cliente = clie;
        }

        private void DetallecrystalReportViewer_Load(object sender, EventArgs e)
        {
            DetalleCrystalReport details = new DetalleCrystalReport();
            details.SetDataSource(detalle);
            details.SetParameterValue("Cliente", Cliente);
            details.SetParameterValue("NombreUsuario", usuario);
            DetallecrystalReportViewer.ReportSource =details;
            DetallecrystalReportViewer.Refresh();
        }
    }
}

using ProyectoFinal_Restaurante.Entidades;
using ProyectoFinal_Restaurante.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante.Reportes
{
    public partial class ClienteReview : Form
    {
        private List<Cliente> cliente = new List<Cliente>();
        public ClienteReview(List<Cliente> cl)
        {
            InitializeComponent();
            this.cliente = cl;
        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ClienteCrystalReport clienteCrystalReporte = new ClienteCrystalReport();
            clienteCrystalReporte.SetDataSource(cliente);
            ClientecrystalReportViewer.ReportSource = clienteCrystalReporte;
            clienteCrystalReporte.Refresh();
        }

        }
    }


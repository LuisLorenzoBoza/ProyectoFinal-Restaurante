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
            ClienteCrystalReporte clienteCrystalReporte = new ClienteCrystalReporte();
            clienteCrystalReporte.SetDataSource(cliente);
            ClientecrystalReportViewer.ReportSource = clienteCrystalReporte;
            clienteCrystalReporte.Refresh();
        }

        }
    }


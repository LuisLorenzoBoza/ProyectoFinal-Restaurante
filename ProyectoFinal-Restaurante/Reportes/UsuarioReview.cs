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
    public partial class UsuarioReview : Form
    {
        private List<Usuario> usuario = new List<Usuario>();
        public UsuarioReview(List<Usuario> us)
        {
            InitializeComponent();
            this.usuario = us;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            UsuarioCrystalReportr usuarioCrystalReportr = new UsuarioCrystalReportr();
            usuarioCrystalReportr.SetDataSource(usuario);
            UsuariocrystalReportViewer.ReportSource = usuarioCrystalReportr;
            usuarioCrystalReportr.Refresh();
    
    }
    }
}

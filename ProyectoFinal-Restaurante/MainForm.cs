using ProyectoFinal_Restaurante.UI.Consulta;
using ProyectoFinal_Restaurante.UI.Registro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_Restaurante
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
            registroUsuario.MdiParent = this;
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCliente registroCliente = new RegistroCliente();
            registroCliente.Show();
            registroCliente.MdiParent = this;
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroProducto registroProducto = new RegistroProducto();
            registroProducto.Show();
            registroProducto.MdiParent = this;
        }

        private void consultaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuario consultaUsuario = new ConsultaUsuario();
            consultaUsuario.Show();
            consultaUsuario.MdiParent = this;
        }

        private void consultaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.Show();
            consultaCliente.MdiParent = this;
        }

        private void consultaDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProducto consultaProducto = new ConsultaProducto();
            consultaProducto.Show();
            consultaProducto.MdiParent = this;
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVentas registroVentas = new RegistroVentas();
            registroVentas.Show();
            registroVentas.MdiParent = this;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultaDeFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFactura consultaFactura = new ConsultaFactura();
            consultaFactura.Show();
            consultaFactura.MdiParent = this;
        }
    }
}

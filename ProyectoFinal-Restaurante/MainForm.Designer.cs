namespace ProyectoFinal_Restaurante
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcioesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despacharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcioesToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.despacharToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcioesToolStripMenuItem
            // 
            this.opcioesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuarioToolStripMenuItem,
            this.crearClienteToolStripMenuItem});
            this.opcioesToolStripMenuItem.Name = "opcioesToolStripMenuItem";
            this.opcioesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.opcioesToolStripMenuItem.Text = "Opcioes";
            // 
            // crearUsuarioToolStripMenuItem
            // 
            this.crearUsuarioToolStripMenuItem.Name = "crearUsuarioToolStripMenuItem";
            this.crearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.crearUsuarioToolStripMenuItem.Text = "Crear Usuario";
            this.crearUsuarioToolStripMenuItem.Click += new System.EventHandler(this.crearUsuarioToolStripMenuItem_Click);
            // 
            // crearClienteToolStripMenuItem
            // 
            this.crearClienteToolStripMenuItem.Name = "crearClienteToolStripMenuItem";
            this.crearClienteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.crearClienteToolStripMenuItem.Text = "Crear Cliente";
            this.crearClienteToolStripMenuItem.Click += new System.EventHandler(this.crearClienteToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarProductoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // editarProductoToolStripMenuItem
            // 
            this.editarProductoToolStripMenuItem.Name = "editarProductoToolStripMenuItem";
            this.editarProductoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editarProductoToolStripMenuItem.Text = "Editar Producto";
            this.editarProductoToolStripMenuItem.Click += new System.EventHandler(this.editarProductoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuarioToolStripMenuItem,
            this.consultaDeClienteToolStripMenuItem,
            this.consultaDeProductoToolStripMenuItem,
            this.consultaDeFacturaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeUsuarioToolStripMenuItem
            // 
            this.consultaDeUsuarioToolStripMenuItem.Name = "consultaDeUsuarioToolStripMenuItem";
            this.consultaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultaDeUsuarioToolStripMenuItem.Text = "Consulta de Usuario";
            this.consultaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuarioToolStripMenuItem_Click);
            // 
            // consultaDeClienteToolStripMenuItem
            // 
            this.consultaDeClienteToolStripMenuItem.Name = "consultaDeClienteToolStripMenuItem";
            this.consultaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultaDeClienteToolStripMenuItem.Text = "Consulta de Cliente";
            this.consultaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.consultaDeClienteToolStripMenuItem_Click);
            // 
            // consultaDeProductoToolStripMenuItem
            // 
            this.consultaDeProductoToolStripMenuItem.Name = "consultaDeProductoToolStripMenuItem";
            this.consultaDeProductoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultaDeProductoToolStripMenuItem.Text = "Consulta de Producto";
            this.consultaDeProductoToolStripMenuItem.Click += new System.EventHandler(this.consultaDeProductoToolStripMenuItem_Click);
            // 
            // despacharToolStripMenuItem
            // 
            this.despacharToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem});
            this.despacharToolStripMenuItem.Name = "despacharToolStripMenuItem";
            this.despacharToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.despacharToolStripMenuItem.Text = "Despachar";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.ventaToolStripMenuItem.Text = "Ventas";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultaDeFacturaToolStripMenuItem
            // 
            this.consultaDeFacturaToolStripMenuItem.Name = "consultaDeFacturaToolStripMenuItem";
            this.consultaDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.consultaDeFacturaToolStripMenuItem.Text = "Consulta  de Factura";
            this.consultaDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.consultaDeFacturaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ProyectoFinal_Restaurante.Properties.Resources.PcJ_Buffet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 308);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Las Costillas De Jesus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcioesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despacharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeFacturaToolStripMenuItem;
    }
}


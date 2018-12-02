namespace ProyectoFinal_Restaurante.Reportes
{
    partial class DetalleReporte
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
            this.DetallecrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // DetallecrystalReportViewer
            // 
            this.DetallecrystalReportViewer.ActiveViewIndex = -1;
            this.DetallecrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DetallecrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DetallecrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetallecrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.DetallecrystalReportViewer.Name = "DetallecrystalReportViewer";
            this.DetallecrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.DetallecrystalReportViewer.TabIndex = 0;
            this.DetallecrystalReportViewer.Load += new System.EventHandler(this.DetallecrystalReportViewer_Load);
            // 
            // DetalleReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetallecrystalReportViewer);
            this.Name = "DetalleReporte";
            this.Text = "DetalleReporte";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer DetallecrystalReportViewer;
    }
}
namespace ProyectoFinal_Restaurante.Reportes
{
    partial class ProductoReview
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
            this.ProductocrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ProductocrystalReportViewer
            // 
            this.ProductocrystalReportViewer.ActiveViewIndex = -1;
            this.ProductocrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductocrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ProductocrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductocrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ProductocrystalReportViewer.Name = "ProductocrystalReportViewer";
            this.ProductocrystalReportViewer.Size = new System.Drawing.Size(800, 450);
            this.ProductocrystalReportViewer.TabIndex = 0;
            this.ProductocrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // ProductoReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductocrystalReportViewer);
            this.Name = "ProductoReview";
            this.Text = "VentasReview";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ProductocrystalReportViewer;
    }
}
namespace ElectroJochy.Reportes
{
    partial class ReporteArticulos
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
            this.ArticulosCrystalReport1 = new ElectroJochy.Reportes.ArticulosCrystalReport();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ArticulosCrystalReport2 = new ElectroJochy.Reportes.ArticulosCrystalReport();
            this.ArticulosCrystalReport3 = new ElectroJochy.Reportes.ArticulosCrystalReport();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.ArticulosCrystalReport3;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1189, 627);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // ReporteArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 627);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "ReporteArticulos";
            this.Text = "Reporte de Articulos";
            this.ResumeLayout(false);

        }

        #endregion

        private ArticulosCrystalReport ArticulosCrystalReport1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private ArticulosCrystalReport ArticulosCrystalReport3;
        private ArticulosCrystalReport ArticulosCrystalReport2;
    }
}
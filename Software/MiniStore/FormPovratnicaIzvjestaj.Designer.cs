namespace MiniStore
{
    partial class FormPovratnicaIzvjestaj
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
            this.reportViewerPovratnica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerPovratnica
            // 
            this.reportViewerPovratnica.LocalReport.ReportEmbeddedResource = "MiniStore.PovratnicaReport.rdlc";
            this.reportViewerPovratnica.Location = new System.Drawing.Point(12, 12);
            this.reportViewerPovratnica.Name = "reportViewerPovratnica";
            this.reportViewerPovratnica.ServerReport.BearerToken = null;
            this.reportViewerPovratnica.Size = new System.Drawing.Size(776, 426);
            this.reportViewerPovratnica.TabIndex = 0;
            // 
            // FormPovratnicaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerPovratnica);
            this.Name = "FormPovratnicaIzvjestaj";
            this.Text = "Izvještaj o povratnici";
            this.Load += new System.EventHandler(this.FormPovratnicaIzvjestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPovratnica;
    }
}
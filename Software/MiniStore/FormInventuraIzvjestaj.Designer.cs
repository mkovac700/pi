namespace MiniStore
{
    partial class FormInventuraIzvjestaj
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
            this.reportViewerInventura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerInventura
            // 
            this.reportViewerInventura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewerInventura.LocalReport.ReportEmbeddedResource = "MiniStore.InventuraReport.rdlc";
            this.reportViewerInventura.Location = new System.Drawing.Point(0, 0);
            this.reportViewerInventura.Name = "reportViewerInventura";
            this.reportViewerInventura.ServerReport.BearerToken = null;
            this.reportViewerInventura.Size = new System.Drawing.Size(952, 556);
            this.reportViewerInventura.TabIndex = 0;
            // 
            // FormInventuraIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 556);
            this.Controls.Add(this.reportViewerInventura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormInventuraIzvjestaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaj o inventuri";
            this.Load += new System.EventHandler(this.FormInventuraIzvjestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerInventura;
    }
}
namespace MiniStore
{
    partial class FormStatistikaProdajeUkupnoPoslovanjeIzvjestaj
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
            this.rvIzvjestaj = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvIzvjestaj
            // 
            this.rvIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvIzvjestaj.LocalReport.ReportEmbeddedResource = "MiniStore.StatistikaProdajeUkupnoReport.rdlc";
            this.rvIzvjestaj.Location = new System.Drawing.Point(0, 0);
            this.rvIzvjestaj.Name = "rvIzvjestaj";
            this.rvIzvjestaj.ServerReport.BearerToken = null;
            this.rvIzvjestaj.Size = new System.Drawing.Size(800, 450);
            this.rvIzvjestaj.TabIndex = 0;
            // 
            // FormStatistikaProdajeUkupnoPoslovanjeIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvIzvjestaj);
            this.Name = "FormStatistikaProdajeUkupnoPoslovanjeIzvjestaj";
            this.Text = "Statistika prodaje - Ukupno poslovanje";
            this.Load += new System.EventHandler(this.FormStatistikaProdajeSviArtikliIzvjestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvIzvjestaj;
    }
}
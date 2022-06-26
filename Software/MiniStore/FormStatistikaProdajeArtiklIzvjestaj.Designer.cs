namespace MiniStore
{
    partial class FormStatistikaProdajeArtiklIzvjestaj
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
            this.rvIzvjesce = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvIzvjesce
            // 
            this.rvIzvjesce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvIzvjesce.LocalReport.ReportEmbeddedResource = "MiniStore.StatistikaProdajeArtikalaReport.rdlc";
            this.rvIzvjesce.Location = new System.Drawing.Point(0, 0);
            this.rvIzvjesce.Name = "rvIzvjesce";
            this.rvIzvjesce.ServerReport.BearerToken = null;
            this.rvIzvjesce.Size = new System.Drawing.Size(800, 450);
            this.rvIzvjesce.TabIndex = 0;
            // 
            // FormStatistikaProdajeArtiklIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvIzvjesce);
            this.Name = "FormStatistikaProdajeArtiklIzvjestaj";
            this.Text = "Statistika prodaje - Artikl";
            this.Load += new System.EventHandler(this.FormStatistikaProdajeIzvjestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvIzvjesce;
    }
}
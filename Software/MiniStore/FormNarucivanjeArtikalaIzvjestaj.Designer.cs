namespace MiniStore
{
    partial class FormNarucivanjeArtikalaIzvjestaj
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
            this.rvNarudzbenica = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvNarudzbenica
            // 
            this.rvNarudzbenica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvNarudzbenica.LocalReport.ReportEmbeddedResource = "MiniStore.NarudzbenicaReport.rdlc";
            this.rvNarudzbenica.Location = new System.Drawing.Point(0, 0);
            this.rvNarudzbenica.Name = "rvNarudzbenica";
            this.rvNarudzbenica.ServerReport.BearerToken = null;
            this.rvNarudzbenica.Size = new System.Drawing.Size(800, 450);
            this.rvNarudzbenica.TabIndex = 0;
            // 
            // FormNarucivanjeArtikalaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvNarudzbenica);
            this.Name = "FormNarucivanjeArtikalaIzvjestaj";
            this.Text = "Narudzbenica";
            this.Load += new System.EventHandler(this.FormNarucivanjeArtikalaIzvjestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvNarudzbenica;
    }
}
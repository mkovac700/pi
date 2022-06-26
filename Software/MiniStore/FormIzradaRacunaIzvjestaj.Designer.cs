namespace MiniStore
{
    partial class FormIzradaRacunaIzvjestaj
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
            this.rvRacun = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvRacun
            // 
            this.rvRacun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvRacun.LocalReport.ReportEmbeddedResource = "MiniStore.RacunIzvjestaj.rdlc";
            this.rvRacun.Location = new System.Drawing.Point(0, 0);
            this.rvRacun.Name = "rvRacun";
            this.rvRacun.ServerReport.BearerToken = null;
            this.rvRacun.Size = new System.Drawing.Size(800, 450);
            this.rvRacun.TabIndex = 0;
            // 
            // FormIzradaRacunaIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rvRacun);
            this.Name = "FormIzradaRacunaIzvjestaj";
            this.Text = "Račun";
            this.Load += new System.EventHandler(this.FormIzradaRacunaIzvjestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvRacun;
    }
}
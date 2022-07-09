namespace MiniStore
{
    partial class FormPostavke
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
            this.tlpGumbovi = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.pnlGlavni = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnPostavkeSucelja = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.tlpGumbovi.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGumbovi
            // 
            this.tlpGumbovi.ColumnCount = 1;
            this.tlpGumbovi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGumbovi.Controls.Add(this.btnAbout, 0, 2);
            this.tlpGumbovi.Controls.Add(this.btnPostavkeSucelja, 0, 1);
            this.tlpGumbovi.Controls.Add(this.btnRegistracija, 0, 0);
            this.tlpGumbovi.Location = new System.Drawing.Point(6, 4);
            this.tlpGumbovi.Name = "tlpGumbovi";
            this.tlpGumbovi.RowCount = 3;
            this.tlpGumbovi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGumbovi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGumbovi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpGumbovi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGumbovi.Size = new System.Drawing.Size(98, 199);
            this.tlpGumbovi.TabIndex = 0;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(3, 3);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(92, 60);
            this.btnRegistracija.TabIndex = 0;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // pnlGlavni
            // 
            this.pnlGlavni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGlavni.Location = new System.Drawing.Point(126, 10);
            this.pnlGlavni.Name = "pnlGlavni";
            this.pnlGlavni.Size = new System.Drawing.Size(675, 405);
            this.pnlGlavni.TabIndex = 1;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.tlpGumbovi);
            this.pnlSidebar.Location = new System.Drawing.Point(7, 10);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(113, 405);
            this.pnlSidebar.TabIndex = 2;
            // 
            // btnPostavkeSucelja
            // 
            this.btnPostavkeSucelja.Location = new System.Drawing.Point(3, 69);
            this.btnPostavkeSucelja.Name = "btnPostavkeSucelja";
            this.btnPostavkeSucelja.Size = new System.Drawing.Size(92, 60);
            this.btnPostavkeSucelja.TabIndex = 1;
            this.btnPostavkeSucelja.Text = "Postavke sučelja";
            this.btnPostavkeSucelja.UseVisualStyleBackColor = true;
            this.btnPostavkeSucelja.Click += new System.EventHandler(this.btnPostavkeSucelja_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(3, 135);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(92, 60);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "O aplikaciji";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FormPostavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 429);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlGlavni);
            this.Name = "FormPostavke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postavke";
            this.Load += new System.EventHandler(this.FormPostavke_Load);
            this.tlpGumbovi.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGumbovi;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnPostavkeSucelja;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Panel pnlGlavni;
        private System.Windows.Forms.Panel pnlSidebar;
    }
}
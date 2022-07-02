﻿namespace MiniStore
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            this.tbpGumbi = new System.Windows.Forms.TableLayoutPanel();
            this.btnIzradaPovratnice = new System.Windows.Forms.Button();
            this.btnUpravljanjeSatnicom = new System.Windows.Forms.Button();
            this.btnStatistikaProdaje = new System.Windows.Forms.Button();
            this.btnInventura = new System.Windows.Forms.Button();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnNarucivanjeArtikala = new System.Windows.Forms.Button();
            this.btnZaprimanjeArtikala = new System.Windows.Forms.Button();
            this.btnUpravljanjeArtiklima = new System.Windows.Forms.Button();
            this.lblPoslovnica = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblVrijeme = new System.Windows.Forms.Label();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.timerTrenutnoVrijeme = new System.Windows.Forms.Timer(this.components);
            this.btnPostavke = new System.Windows.Forms.Button();
            this.tbpGumbi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpGumbi
            // 
            this.tbpGumbi.AutoSize = true;
            this.tbpGumbi.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbpGumbi.ColumnCount = 3;
            this.tbpGumbi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpGumbi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpGumbi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpGumbi.Controls.Add(this.btnPostavke, 2, 2);
            this.tbpGumbi.Controls.Add(this.btnIzradaPovratnice, 7, 0);
            this.tbpGumbi.Controls.Add(this.btnUpravljanjeSatnicom, 6, 0);
            this.tbpGumbi.Controls.Add(this.btnStatistikaProdaje, 5, 0);
            this.tbpGumbi.Controls.Add(this.btnInventura, 4, 0);
            this.tbpGumbi.Controls.Add(this.btnRacun, 3, 0);
            this.tbpGumbi.Controls.Add(this.btnNarucivanjeArtikala, 2, 0);
            this.tbpGumbi.Controls.Add(this.btnZaprimanjeArtikala, 1, 0);
            this.tbpGumbi.Controls.Add(this.btnUpravljanjeArtiklima, 0, 0);
            this.tbpGumbi.Location = new System.Drawing.Point(26, 70);
            this.tbpGumbi.Name = "tbpGumbi";
            this.tbpGumbi.RowCount = 3;
            this.tbpGumbi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpGumbi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpGumbi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbpGumbi.Size = new System.Drawing.Size(502, 220);
            this.tbpGumbi.TabIndex = 0;
            // 
            // btnIzradaPovratnice
            // 
            this.btnIzradaPovratnice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzradaPovratnice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIzradaPovratnice.Location = new System.Drawing.Point(171, 150);
            this.btnIzradaPovratnice.Name = "btnIzradaPovratnice";
            this.btnIzradaPovratnice.Size = new System.Drawing.Size(160, 66);
            this.btnIzradaPovratnice.TabIndex = 7;
            this.btnIzradaPovratnice.Text = "Izrada povratnice";
            this.btnIzradaPovratnice.UseVisualStyleBackColor = true;
            this.btnIzradaPovratnice.Click += new System.EventHandler(this.btnIzradaPovratnice_Click);
            // 
            // btnUpravljanjeSatnicom
            // 
            this.btnUpravljanjeSatnicom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpravljanjeSatnicom.Location = new System.Drawing.Point(4, 150);
            this.btnUpravljanjeSatnicom.Name = "btnUpravljanjeSatnicom";
            this.btnUpravljanjeSatnicom.Size = new System.Drawing.Size(160, 66);
            this.btnUpravljanjeSatnicom.TabIndex = 6;
            this.btnUpravljanjeSatnicom.Text = "Upravljanje satnicom";
            this.btnUpravljanjeSatnicom.UseVisualStyleBackColor = true;
            this.btnUpravljanjeSatnicom.Click += new System.EventHandler(this.btnUpravljanjeSatnicom_Click);
            // 
            // btnStatistikaProdaje
            // 
            this.btnStatistikaProdaje.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatistikaProdaje.Location = new System.Drawing.Point(338, 77);
            this.btnStatistikaProdaje.Name = "btnStatistikaProdaje";
            this.btnStatistikaProdaje.Size = new System.Drawing.Size(160, 66);
            this.btnStatistikaProdaje.TabIndex = 5;
            this.btnStatistikaProdaje.Text = "Statistika prodaje";
            this.btnStatistikaProdaje.UseVisualStyleBackColor = true;
            this.btnStatistikaProdaje.Click += new System.EventHandler(this.btnStatistikaProdaje_Click);
            // 
            // btnInventura
            // 
            this.btnInventura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventura.Location = new System.Drawing.Point(171, 77);
            this.btnInventura.Name = "btnInventura";
            this.btnInventura.Size = new System.Drawing.Size(160, 66);
            this.btnInventura.TabIndex = 4;
            this.btnInventura.Text = "Inventura";
            this.btnInventura.UseVisualStyleBackColor = true;
            this.btnInventura.Click += new System.EventHandler(this.btnInventura_Click);
            // 
            // btnRacun
            // 
            this.btnRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRacun.Location = new System.Drawing.Point(4, 77);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(160, 66);
            this.btnRacun.TabIndex = 3;
            this.btnRacun.Text = "Račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnNarucivanjeArtikala
            // 
            this.btnNarucivanjeArtikala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNarucivanjeArtikala.Location = new System.Drawing.Point(338, 4);
            this.btnNarucivanjeArtikala.Name = "btnNarucivanjeArtikala";
            this.btnNarucivanjeArtikala.Size = new System.Drawing.Size(160, 66);
            this.btnNarucivanjeArtikala.TabIndex = 2;
            this.btnNarucivanjeArtikala.Text = "Naručivanje artikala";
            this.btnNarucivanjeArtikala.UseVisualStyleBackColor = true;
            this.btnNarucivanjeArtikala.Click += new System.EventHandler(this.btnNarucivanjeArtikala_Click);
            // 
            // btnZaprimanjeArtikala
            // 
            this.btnZaprimanjeArtikala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZaprimanjeArtikala.Location = new System.Drawing.Point(171, 4);
            this.btnZaprimanjeArtikala.Name = "btnZaprimanjeArtikala";
            this.btnZaprimanjeArtikala.Size = new System.Drawing.Size(160, 66);
            this.btnZaprimanjeArtikala.TabIndex = 1;
            this.btnZaprimanjeArtikala.Text = "Zaprimanje artikala";
            this.btnZaprimanjeArtikala.UseVisualStyleBackColor = true;
            this.btnZaprimanjeArtikala.Click += new System.EventHandler(this.btnZaprimanjeArtikala_Click);
            // 
            // btnUpravljanjeArtiklima
            // 
            this.btnUpravljanjeArtiklima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpravljanjeArtiklima.Location = new System.Drawing.Point(4, 4);
            this.btnUpravljanjeArtiklima.Name = "btnUpravljanjeArtiklima";
            this.btnUpravljanjeArtiklima.Size = new System.Drawing.Size(160, 66);
            this.btnUpravljanjeArtiklima.TabIndex = 0;
            this.btnUpravljanjeArtiklima.Text = "Upravljanje artiklima";
            this.btnUpravljanjeArtiklima.UseVisualStyleBackColor = true;
            this.btnUpravljanjeArtiklima.Click += new System.EventHandler(this.btnUpravljanjeArtiklima_Click);
            // 
            // lblPoslovnica
            // 
            this.lblPoslovnica.AutoSize = true;
            this.lblPoslovnica.Location = new System.Drawing.Point(27, 41);
            this.lblPoslovnica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoslovnica.Name = "lblPoslovnica";
            this.lblPoslovnica.Size = new System.Drawing.Size(62, 13);
            this.lblPoslovnica.TabIndex = 2;
            this.lblPoslovnica.Text = "Poslovnica:";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(27, 19);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(47, 13);
            this.lblKorisnik.TabIndex = 3;
            this.lblKorisnik.Text = "Korisnik:";
            // 
            // lblVrijeme
            // 
            this.lblVrijeme.Location = new System.Drawing.Point(290, 19);
            this.lblVrijeme.Name = "lblVrijeme";
            this.lblVrijeme.Size = new System.Drawing.Size(234, 13);
            this.lblVrijeme.TabIndex = 4;
            this.lblVrijeme.Text = "Dohvacam vrijeme...";
            this.lblVrijeme.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnOdjava
            // 
            this.btnOdjava.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOdjava.Location = new System.Drawing.Point(453, 314);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // timerTrenutnoVrijeme
            // 
            this.timerTrenutnoVrijeme.Enabled = true;
            this.timerTrenutnoVrijeme.Interval = 1000;
            this.timerTrenutnoVrijeme.Tick += new System.EventHandler(this.timerTrenutnoVrijeme_Tick);
            // 
            // btnPostavke
            // 
            this.btnPostavke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPostavke.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPostavke.Location = new System.Drawing.Point(338, 150);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(160, 66);
            this.btnPostavke.TabIndex = 8;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.UseVisualStyleBackColor = true;
            this.btnPostavke.Click += new System.EventHandler(this.btnPostavke_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 349);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.lblVrijeme);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.lblPoslovnica);
            this.Controls.Add(this.tbpGumbi);
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniStore";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.tbpGumbi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpGumbi;
        private System.Windows.Forms.Button btnUpravljanjeArtiklima;
        private System.Windows.Forms.Button btnIzradaPovratnice;
        private System.Windows.Forms.Button btnUpravljanjeSatnicom;
        private System.Windows.Forms.Button btnStatistikaProdaje;
        private System.Windows.Forms.Button btnInventura;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnNarucivanjeArtikala;
        private System.Windows.Forms.Button btnZaprimanjeArtikala;
        private System.Windows.Forms.Label lblPoslovnica;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblVrijeme;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Timer timerTrenutnoVrijeme;
        private System.Windows.Forms.Button btnPostavke;
    }
}
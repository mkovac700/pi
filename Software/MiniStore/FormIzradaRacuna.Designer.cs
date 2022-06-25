namespace MiniStore
{
    partial class FormIzradaRacuna
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbSifraArtikla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.dgvStavkeRacuna = new System.Windows.Forms.DataGridView();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.btnIzdajRacun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIznos = new System.Windows.Forms.Label();
            this.lbNacinPlacanja = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šifra artikla:";
            // 
            // tbSifraArtikla
            // 
            this.tbSifraArtikla.Location = new System.Drawing.Point(104, 49);
            this.tbSifraArtikla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSifraArtikla.Name = "tbSifraArtikla";
            this.tbSifraArtikla.Size = new System.Drawing.Size(216, 22);
            this.tbSifraArtikla.TabIndex = 1;
            this.tbSifraArtikla.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSifraArtikla_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Količina:";
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(104, 19);
            this.tbKolicina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(132, 22);
            this.tbKolicina.TabIndex = 3;
            // 
            // dgvStavkeRacuna
            // 
            this.dgvStavkeRacuna.AllowUserToAddRows = false;
            this.dgvStavkeRacuna.AllowUserToDeleteRows = false;
            this.dgvStavkeRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStavkeRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRacuna.Location = new System.Drawing.Point(13, 107);
            this.dgvStavkeRacuna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStavkeRacuna.Name = "dgvStavkeRacuna";
            this.dgvStavkeRacuna.ReadOnly = true;
            this.dgvStavkeRacuna.RowHeadersWidth = 51;
            this.dgvStavkeRacuna.Size = new System.Drawing.Size(948, 517);
            this.dgvStavkeRacuna.TabIndex = 4;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStorniraj.Location = new System.Drawing.Point(988, 502);
            this.btnStorniraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(144, 57);
            this.btnStorniraj.TabIndex = 5;
            this.btnStorniraj.Text = "Storniraj račun";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            // 
            // btnIzdajRacun
            // 
            this.btnIzdajRacun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzdajRacun.Location = new System.Drawing.Point(988, 567);
            this.btnIzdajRacun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzdajRacun.Name = "btnIzdajRacun";
            this.btnIzdajRacun.Size = new System.Drawing.Size(144, 57);
            this.btnIzdajRacun.TabIndex = 6;
            this.btnIzdajRacun.Text = "Izdaj račun";
            this.btnIzdajRacun.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1062, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "IZNOS";
            // 
            // lblIznos
            // 
            this.lblIznos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIznos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIznos.Location = new System.Drawing.Point(709, 36);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(423, 58);
            this.lblIznos.TabIndex = 8;
            this.lblIznos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbNacinPlacanja
            // 
            this.lbNacinPlacanja.FormattingEnabled = true;
            this.lbNacinPlacanja.ItemHeight = 16;
            this.lbNacinPlacanja.Items.AddRange(new object[] {
            "Gotovina",
            "Kartica",
            "Kriptovalute"});
            this.lbNacinPlacanja.Location = new System.Drawing.Point(988, 413);
            this.lbNacinPlacanja.Name = "lbNacinPlacanja";
            this.lbNacinPlacanja.Size = new System.Drawing.Size(144, 68);
            this.lbNacinPlacanja.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(985, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Način plaćanja:";
            // 
            // FormIzradaRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 637);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbNacinPlacanja);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIzdajRacun);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.dgvStavkeRacuna);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSifraArtikla);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIzradaRacuna";
            this.Text = "Izrada računa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRacuna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSifraArtikla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.DataGridView dgvStavkeRacuna;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.Button btnIzdajRacun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.ListBox lbNacinPlacanja;
        private System.Windows.Forms.Label label4;
    }
}
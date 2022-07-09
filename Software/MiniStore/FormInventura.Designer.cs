namespace MiniStore
{
    partial class FormInventura
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
            this.dtpDatumInventure = new System.Windows.Forms.DateTimePicker();
            this.dgvPopisArtikala = new System.Windows.Forms.DataGridView();
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKnjigCijena = new System.Windows.Forms.TextBox();
            this.tbKnjigKolicina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbStvCijena = new System.Windows.Forms.TextBox();
            this.btnDohvati = new System.Windows.Forms.Button();
            this.tbStvKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbJedinicnaCijena = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.tbStanje = new System.Windows.Forms.TextBox();
            this.tbRazlika = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPovijest = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum inventure:";
            // 
            // dtpDatumInventure
            // 
            this.dtpDatumInventure.Location = new System.Drawing.Point(106, 12);
            this.dtpDatumInventure.Name = "dtpDatumInventure";
            this.dtpDatumInventure.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumInventure.TabIndex = 1;
            // 
            // dgvPopisArtikala
            // 
            this.dgvPopisArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisArtikala.Location = new System.Drawing.Point(15, 51);
            this.dgvPopisArtikala.Name = "dgvPopisArtikala";
            this.dgvPopisArtikala.Size = new System.Drawing.Size(531, 190);
            this.dgvPopisArtikala.TabIndex = 2;
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(252, 22);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(103, 50);
            this.btnUcitaj.TabIndex = 3;
            this.btnUcitaj.Text = "Učitaj knjigovodstveno stanje";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.btnUcitaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbKnjigCijena);
            this.groupBox1.Controls.Add(this.btnUcitaj);
            this.groupBox1.Controls.Add(this.tbKnjigKolicina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(15, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Knjigovodstveno stanje";
            // 
            // tbKnjigCijena
            // 
            this.tbKnjigCijena.Location = new System.Drawing.Point(59, 52);
            this.tbKnjigCijena.Name = "tbKnjigCijena";
            this.tbKnjigCijena.ReadOnly = true;
            this.tbKnjigCijena.Size = new System.Drawing.Size(153, 20);
            this.tbKnjigCijena.TabIndex = 3;
            // 
            // tbKnjigKolicina
            // 
            this.tbKnjigKolicina.Location = new System.Drawing.Point(59, 24);
            this.tbKnjigKolicina.Name = "tbKnjigKolicina";
            this.tbKnjigKolicina.ReadOnly = true;
            this.tbKnjigKolicina.Size = new System.Drawing.Size(153, 20);
            this.tbKnjigKolicina.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cijena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Količina:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbStvCijena);
            this.groupBox2.Controls.Add(this.btnDohvati);
            this.groupBox2.Controls.Add(this.tbStvKolicina);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(15, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 85);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stvarno stanje";
            // 
            // tbStvCijena
            // 
            this.tbStvCijena.Location = new System.Drawing.Point(59, 52);
            this.tbStvCijena.Name = "tbStvCijena";
            this.tbStvCijena.ReadOnly = true;
            this.tbStvCijena.Size = new System.Drawing.Size(153, 20);
            this.tbStvCijena.TabIndex = 3;
            // 
            // btnDohvati
            // 
            this.btnDohvati.Location = new System.Drawing.Point(252, 22);
            this.btnDohvati.Name = "btnDohvati";
            this.btnDohvati.Size = new System.Drawing.Size(103, 50);
            this.btnDohvati.TabIndex = 3;
            this.btnDohvati.Text = "Dohvati stvarno stanje";
            this.btnDohvati.UseVisualStyleBackColor = true;
            this.btnDohvati.Click += new System.EventHandler(this.btnDohvati_Click);
            // 
            // tbStvKolicina
            // 
            this.tbStvKolicina.Location = new System.Drawing.Point(59, 24);
            this.tbStvKolicina.Name = "tbStvKolicina";
            this.tbStvKolicina.ReadOnly = true;
            this.tbStvKolicina.Size = new System.Drawing.Size(153, 20);
            this.tbStvKolicina.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cijena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Količina:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatus);
            this.groupBox3.Controls.Add(this.btnUkloni);
            this.groupBox3.Controls.Add(this.btnDodaj);
            this.groupBox3.Controls.Add(this.tbKolicina);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbJedinicnaCijena);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbSifra);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(561, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 190);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Unos artikala";
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(109, 152);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(75, 23);
            this.btnUkloni.TabIndex = 7;
            this.btnUkloni.Text = "Ukloni artikl";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(17, 152);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj artikl";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(98, 116);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(96, 20);
            this.tbKolicina.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Količina:";
            // 
            // tbJedinicnaCijena
            // 
            this.tbJedinicnaCijena.Location = new System.Drawing.Point(98, 70);
            this.tbJedinicnaCijena.Name = "tbJedinicnaCijena";
            this.tbJedinicnaCijena.ReadOnly = true;
            this.tbJedinicnaCijena.Size = new System.Drawing.Size(96, 20);
            this.tbJedinicnaCijena.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Jedinična cijena:";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(74, 24);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(120, 20);
            this.tbSifra.TabIndex = 1;
            this.tbSifra.TextChanged += new System.EventHandler(this.tbSifra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Šifra artikla:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnIzracunaj);
            this.groupBox4.Controls.Add(this.btnPohrani);
            this.groupBox4.Controls.Add(this.btnIspis);
            this.groupBox4.Controls.Add(this.tbStanje);
            this.groupBox4.Controls.Add(this.tbRazlika);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(394, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 185);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inventurno stanje";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(114, 136);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 36);
            this.btnIzracunaj.TabIndex = 6;
            this.btnIzracunaj.Text = "Izračunaj razliku";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(195, 136);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(75, 36);
            this.btnPohrani.TabIndex = 5;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(276, 136);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(75, 36);
            this.btnIspis.TabIndex = 4;
            this.btnIspis.Text = "Ispis izvješća";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // tbStanje
            // 
            this.tbStanje.Location = new System.Drawing.Point(120, 56);
            this.tbStanje.Name = "tbStanje";
            this.tbStanje.ReadOnly = true;
            this.tbStanje.Size = new System.Drawing.Size(100, 20);
            this.tbStanje.TabIndex = 3;
            // 
            // tbRazlika
            // 
            this.tbRazlika.Location = new System.Drawing.Point(120, 24);
            this.tbRazlika.Name = "tbRazlika";
            this.tbRazlika.ReadOnly = true;
            this.tbRazlika.Size = new System.Drawing.Size(100, 20);
            this.tbRazlika.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Stanje:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Inventurna razlika:";
            // 
            // btnPovijest
            // 
            this.btnPovijest.Location = new System.Drawing.Point(618, 12);
            this.btnPovijest.Name = "btnPovijest";
            this.btnPovijest.Size = new System.Drawing.Size(143, 30);
            this.btnPovijest.TabIndex = 8;
            this.btnPovijest.Text = "Prikaži povijest inventura";
            this.btnPovijest.UseVisualStyleBackColor = true;
            this.btnPovijest.Click += new System.EventHandler(this.btnPovijest_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(74, 44);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 23);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormInventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 471);
            this.Controls.Add(this.btnPovijest);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvPopisArtikala);
            this.Controls.Add(this.dtpDatumInventure);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormInventura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventura";
            this.Load += new System.EventHandler(this.FormInventura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatumInventure;
        private System.Windows.Forms.DataGridView dgvPopisArtikala;
        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbKnjigCijena;
        private System.Windows.Forms.TextBox tbKnjigKolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbStvCijena;
        private System.Windows.Forms.Button btnDohvati;
        private System.Windows.Forms.TextBox tbStvKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbJedinicnaCijena;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.TextBox tbStanje;
        private System.Windows.Forms.TextBox tbRazlika;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPovijest;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Label lblStatus;
    }
}
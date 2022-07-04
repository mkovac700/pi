namespace MiniStore
{
    partial class FormUpravljanjeSatnicom
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
            this.dgvSatnica = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpMjesec = new System.Windows.Forms.DateTimePicker();
            this.rbMjeseci = new System.Windows.Forms.RadioButton();
            this.rbSve = new System.Windows.Forms.RadioButton();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKorisnik = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPoslovnica = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatnica)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSatnica
            // 
            this.dgvSatnica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatnica.Location = new System.Drawing.Point(12, 132);
            this.dgvSatnica.Name = "dgvSatnica";
            this.dgvSatnica.Size = new System.Drawing.Size(458, 238);
            this.dgvSatnica.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpMjesec);
            this.groupBox1.Controls.Add(this.rbMjeseci);
            this.groupBox1.Controls.Add(this.rbSve);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prikaz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberi mjesec:";
            // 
            // dtpMjesec
            // 
            this.dtpMjesec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMjesec.Location = new System.Drawing.Point(299, 19);
            this.dtpMjesec.Name = "dtpMjesec";
            this.dtpMjesec.Size = new System.Drawing.Size(139, 20);
            this.dtpMjesec.TabIndex = 2;
            this.dtpMjesec.ValueChanged += new System.EventHandler(this.dtpMjesec_ValueChanged);
            // 
            // rbMjeseci
            // 
            this.rbMjeseci.AutoSize = true;
            this.rbMjeseci.Location = new System.Drawing.Point(71, 19);
            this.rbMjeseci.Name = "rbMjeseci";
            this.rbMjeseci.Size = new System.Drawing.Size(90, 17);
            this.rbMjeseci.TabIndex = 1;
            this.rbMjeseci.TabStop = true;
            this.rbMjeseci.Text = "Po mjesecima";
            this.rbMjeseci.UseVisualStyleBackColor = true;
            this.rbMjeseci.CheckedChanged += new System.EventHandler(this.rbMjeseci_CheckedChanged);
            // 
            // rbSve
            // 
            this.rbSve.AutoSize = true;
            this.rbSve.Location = new System.Drawing.Point(6, 19);
            this.rbSve.Name = "rbSve";
            this.rbSve.Size = new System.Drawing.Size(44, 17);
            this.rbSve.TabIndex = 0;
            this.rbSve.TabStop = true;
            this.rbSve.Text = "Sve";
            this.rbSve.UseVisualStyleBackColor = true;
            this.rbSve.CheckedChanged += new System.EventHandler(this.rbSve_CheckedChanged);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(128, 376);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(110, 46);
            this.btnUredi.TabIndex = 6;
            this.btnUredi.Text = "Uredi odabrani zapis";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 376);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(110, 46);
            this.btnDodaj.TabIndex = 7;
            this.btnDodaj.Text = "Dodaj novi zapis";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(244, 376);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(110, 46);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obriši odabrani zapis";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(360, 376);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(110, 46);
            this.btnIspis.TabIndex = 9;
            this.btnIspis.Text = "Ispis izvješća";
            this.btnIspis.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Korisnik:";
            // 
            // cbKorisnik
            // 
            this.cbKorisnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKorisnik.FormattingEnabled = true;
            this.cbKorisnik.Location = new System.Drawing.Point(258, 16);
            this.cbKorisnik.Name = "cbKorisnik";
            this.cbKorisnik.Size = new System.Drawing.Size(180, 21);
            this.cbKorisnik.TabIndex = 11;
            this.cbKorisnik.SelectedIndexChanged += new System.EventHandler(this.cbKorisnik_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPoslovnica);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbKorisnik);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 48);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // cbPoslovnica
            // 
            this.cbPoslovnica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoslovnica.FormattingEnabled = true;
            this.cbPoslovnica.Location = new System.Drawing.Point(71, 16);
            this.cbPoslovnica.Name = "cbPoslovnica";
            this.cbPoslovnica.Size = new System.Drawing.Size(121, 21);
            this.cbPoslovnica.TabIndex = 13;
            this.cbPoslovnica.SelectedIndexChanged += new System.EventHandler(this.cbPoslovnica_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Poslovnica:";
            // 
            // FormUpravljanjeSatnicom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSatnica);
            this.Name = "FormUpravljanjeSatnicom";
            this.Text = "Upravljanje satnicom";
            this.Load += new System.EventHandler(this.FormUpravljanjeSatnicom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatnica)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSatnica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpMjesec;
        private System.Windows.Forms.RadioButton rbMjeseci;
        private System.Windows.Forms.RadioButton rbSve;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKorisnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPoslovnica;
        private System.Windows.Forms.Label label3;
    }
}
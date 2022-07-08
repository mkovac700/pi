namespace MiniStore
{
    partial class FormArtikl
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
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numCijena = new System.Windows.Forms.NumericUpDown();
            this.btnGenerirajSifru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobavljač:";
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(88, 50);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(213, 21);
            this.cbDobavljac.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Šifra:";
            // 
            // tbSifra
            // 
            this.tbSifra.Enabled = false;
            this.tbSifra.Location = new System.Drawing.Point(88, 17);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.ReadOnly = true;
            this.tbSifra.Size = new System.Drawing.Size(110, 20);
            this.tbSifra.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Naziv:";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(88, 86);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(213, 20);
            this.tbNaziv.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategorija:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(88, 119);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(213, 21);
            this.cbKategorija.TabIndex = 8;
            // 
            // btnSpremi
            // 
            this.btnSpremi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSpremi.Location = new System.Drawing.Point(145, 192);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnZatvori.Location = new System.Drawing.Point(226, 192);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 23);
            this.btnZatvori.TabIndex = 10;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cijena:";
            // 
            // numCijena
            // 
            this.numCijena.DecimalPlaces = 2;
            this.numCijena.Location = new System.Drawing.Point(88, 153);
            this.numCijena.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCijena.Name = "numCijena";
            this.numCijena.Size = new System.Drawing.Size(110, 20);
            this.numCijena.TabIndex = 12;
            this.numCijena.ThousandsSeparator = true;
            // 
            // btnGenerirajSifru
            // 
            this.btnGenerirajSifru.Location = new System.Drawing.Point(213, 15);
            this.btnGenerirajSifru.Name = "btnGenerirajSifru";
            this.btnGenerirajSifru.Size = new System.Drawing.Size(88, 23);
            this.btnGenerirajSifru.TabIndex = 13;
            this.btnGenerirajSifru.Text = "Generiraj";
            this.btnGenerirajSifru.UseVisualStyleBackColor = true;
            this.btnGenerirajSifru.Click += new System.EventHandler(this.btnGenerirajSifru_Click);
            // 
            // FormArtikl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 227);
            this.Controls.Add(this.btnGenerirajSifru);
            this.Controls.Add(this.numCijena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.cbKategorija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.label1);
            this.Name = "FormArtikl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artikl";
            this.Load += new System.EventHandler(this.FormArtikl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCijena;
        private System.Windows.Forms.Button btnGenerirajSifru;
    }
}
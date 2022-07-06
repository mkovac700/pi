namespace MiniStore
{
    partial class FormIzradaPovratnice
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
            this.dgvArtikliPovratnice = new System.Windows.Forms.DataGridView();
            this.btnGenerirajPovratnicu = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSifraArtikla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvArtikliDobavljaca = new System.Windows.Forms.DataGridView();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliPovratnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliDobavljaca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikliPovratnice
            // 
            this.dgvArtikliPovratnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliPovratnice.Location = new System.Drawing.Point(497, 84);
            this.dgvArtikliPovratnice.Name = "dgvArtikliPovratnice";
            this.dgvArtikliPovratnice.Size = new System.Drawing.Size(430, 300);
            this.dgvArtikliPovratnice.TabIndex = 26;
            // 
            // btnGenerirajPovratnicu
            // 
            this.btnGenerirajPovratnicu.Location = new System.Drawing.Point(809, 404);
            this.btnGenerirajPovratnicu.Name = "btnGenerirajPovratnicu";
            this.btnGenerirajPovratnicu.Size = new System.Drawing.Size(118, 48);
            this.btnGenerirajPovratnicu.TabIndex = 25;
            this.btnGenerirajPovratnicu.Text = "Generiraj povratnicu";
            this.btnGenerirajPovratnicu.UseVisualStyleBackColor = true;
            this.btnGenerirajPovratnicu.Click += new System.EventHandler(this.btnGenerirajPovratnicu_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(685, 404);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(118, 48);
            this.btnUkloni.TabIndex = 24;
            this.btnUkloni.Text = "Ukloni odabranu stavku";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(350, 404);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 48);
            this.btnDodaj.TabIndex = 23;
            this.btnDodaj.Text = "Dodaj u povratnicu";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Količina za povrat:";
            // 
            // tbSifraArtikla
            // 
            this.tbSifraArtikla.Location = new System.Drawing.Point(129, 404);
            this.tbSifraArtikla.Name = "tbSifraArtikla";
            this.tbSifraArtikla.Size = new System.Drawing.Size(190, 20);
            this.tbSifraArtikla.TabIndex = 20;
            this.tbSifraArtikla.TextChanged += new System.EventHandler(this.tbSifraArtikla_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Šifra artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(636, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Stavke povratnice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(164, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Popis artikala";
            // 
            // dgvArtikliDobavljaca
            // 
            this.dgvArtikliDobavljaca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliDobavljaca.Location = new System.Drawing.Point(18, 84);
            this.dgvArtikliDobavljaca.Name = "dgvArtikliDobavljaca";
            this.dgvArtikliDobavljaca.Size = new System.Drawing.Size(430, 300);
            this.dgvArtikliDobavljaca.TabIndex = 16;
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(123, 15);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(198, 21);
            this.cbDobavljac.TabIndex = 15;
            this.cbDobavljac.SelectedValueChanged += new System.EventHandler(this.cbDobavljac_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Odaberi dobavljača:";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(129, 431);
            this.numKolicina.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(62, 20);
            this.numKolicina.TabIndex = 27;
            this.numKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormIzradaPovratnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 479);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.dgvArtikliPovratnice);
            this.Controls.Add(this.btnGenerirajPovratnicu);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSifraArtikla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvArtikliDobavljaca);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.label1);
            this.Name = "FormIzradaPovratnice";
            this.Text = "Izrada povratnice";
            this.Load += new System.EventHandler(this.FormIzradaPovratnice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliPovratnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliDobavljaca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikliPovratnice;
        private System.Windows.Forms.Button btnGenerirajPovratnicu;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSifraArtikla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvArtikliDobavljaca;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numKolicina;
    }
}
namespace MiniStore
{
    partial class FormStatistikaProdaje
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
            this.cbArtikli = new System.Windows.Forms.ComboBox();
            this.Kategorija = new System.Windows.Forms.Label();
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIzvjesceArtikl = new System.Windows.Forms.Button();
            this.gbPrikazArtikala = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIzvjestajKategorije = new System.Windows.Forms.Button();
            this.btnIzvjesceUkupnogPoslovanja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbPrikazArtikala.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artikl:";
            // 
            // cbArtikli
            // 
            this.cbArtikli.FormattingEnabled = true;
            this.cbArtikli.Location = new System.Drawing.Point(7, 47);
            this.cbArtikli.Margin = new System.Windows.Forms.Padding(4);
            this.cbArtikli.Name = "cbArtikli";
            this.cbArtikli.Size = new System.Drawing.Size(265, 24);
            this.cbArtikli.TabIndex = 2;
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSize = true;
            this.Kategorija.Location = new System.Drawing.Point(7, 30);
            this.Kategorija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(71, 16);
            this.Kategorija.TabIndex = 3;
            this.Kategorija.Text = "Kategorija:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(10, 50);
            this.cbKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(270, 24);
            this.cbKategorija.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzvjesceUkupnogPoslovanja);
            this.groupBox1.Location = new System.Drawing.Point(26, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 97);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promet ";
            // 
            // btnIzvjesceArtikl
            // 
            this.btnIzvjesceArtikl.Location = new System.Drawing.Point(144, 79);
            this.btnIzvjesceArtikl.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzvjesceArtikl.Name = "btnIzvjesceArtikl";
            this.btnIzvjesceArtikl.Size = new System.Drawing.Size(128, 28);
            this.btnIzvjesceArtikl.TabIndex = 6;
            this.btnIzvjesceArtikl.Text = "Izvješće artikl";
            this.btnIzvjesceArtikl.UseVisualStyleBackColor = true;
            this.btnIzvjesceArtikl.Click += new System.EventHandler(this.btnIzvjesceArtikl_Click);
            // 
            // gbPrikazArtikala
            // 
            this.gbPrikazArtikala.Controls.Add(this.label1);
            this.gbPrikazArtikala.Controls.Add(this.cbArtikli);
            this.gbPrikazArtikala.Controls.Add(this.btnIzvjesceArtikl);
            this.gbPrikazArtikala.Location = new System.Drawing.Point(27, 79);
            this.gbPrikazArtikala.Name = "gbPrikazArtikala";
            this.gbPrikazArtikala.Size = new System.Drawing.Size(287, 140);
            this.gbPrikazArtikala.TabIndex = 7;
            this.gbPrikazArtikala.TabStop = false;
            this.gbPrikazArtikala.Text = "Analitika prodaje artikla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Statistika";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIzvjestajKategorije);
            this.groupBox2.Controls.Add(this.Kategorija);
            this.groupBox2.Controls.Add(this.cbKategorija);
            this.groupBox2.Location = new System.Drawing.Point(362, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 134);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analitika prodaje kategorija";
            // 
            // btnIzvjestajKategorije
            // 
            this.btnIzvjestajKategorije.Location = new System.Drawing.Point(152, 82);
            this.btnIzvjestajKategorije.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzvjestajKategorije.Name = "btnIzvjestajKategorije";
            this.btnIzvjestajKategorije.Size = new System.Drawing.Size(128, 28);
            this.btnIzvjestajKategorije.TabIndex = 13;
            this.btnIzvjestajKategorije.Text = "Izvješće kategorija";
            this.btnIzvjestajKategorije.UseVisualStyleBackColor = true;
            this.btnIzvjestajKategorije.Click += new System.EventHandler(this.btnIzvjestajKategorije_Click);
            // 
            // btnIzvjesceUkupnogPoslovanja
            // 
            this.btnIzvjesceUkupnogPoslovanja.Location = new System.Drawing.Point(7, 38);
            this.btnIzvjesceUkupnogPoslovanja.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzvjesceUkupnogPoslovanja.Name = "btnIzvjesceUkupnogPoslovanja";
            this.btnIzvjesceUkupnogPoslovanja.Size = new System.Drawing.Size(273, 44);
            this.btnIzvjesceUkupnogPoslovanja.TabIndex = 12;
            this.btnIzvjesceUkupnogPoslovanja.Text = "Izvješće ukupnog poslovanja";
            this.btnIzvjesceUkupnogPoslovanja.UseVisualStyleBackColor = true;
            this.btnIzvjesceUkupnogPoslovanja.Click += new System.EventHandler(this.btnIzvjesceUkupnogPoslovanja_Click);
            // 
            // FormStatistikaProdaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbPrikazArtikala);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStatistikaProdaje";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FormStatistikaProdaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbPrikazArtikala.ResumeLayout(false);
            this.gbPrikazArtikala.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArtikli;
        private System.Windows.Forms.Label Kategorija;
        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIzvjesceArtikl;
        private System.Windows.Forms.GroupBox gbPrikazArtikala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIzvjestajKategorije;
        private System.Windows.Forms.Button btnIzvjesceUkupnogPoslovanja;
    }
}
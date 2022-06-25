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
            this.tbZaradaMjesec = new System.Windows.Forms.TextBox();
            this.tbZaradaTjedan = new System.Windows.Forms.TextBox();
            this.tbZaradaDan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzvjesceArtikl = new System.Windows.Forms.Button();
            this.gbPrikazArtikala = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIzvjesceArtiklKategorija = new System.Windows.Forms.Button();
            this.btnIzvješćeKategorija = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbPrikazArtikala.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artikl:";
            // 
            // cbArtikli
            // 
            this.cbArtikli.FormattingEnabled = true;
            this.cbArtikli.Location = new System.Drawing.Point(73, 24);
            this.cbArtikli.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbArtikli.Name = "cbArtikli";
            this.cbArtikli.Size = new System.Drawing.Size(160, 24);
            this.cbArtikli.TabIndex = 2;
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSize = true;
            this.Kategorija.Location = new System.Drawing.Point(16, 38);
            this.Kategorija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.Size = new System.Drawing.Size(71, 16);
            this.Kategorija.TabIndex = 3;
            this.Kategorija.Text = "Kategorija:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(95, 35);
            this.cbKategorija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(160, 24);
            this.cbKategorija.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbZaradaMjesec);
            this.groupBox1.Controls.Add(this.tbZaradaTjedan);
            this.groupBox1.Controls.Add(this.tbZaradaDan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(27, 347);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(288, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarada";
            // 
            // tbZaradaMjesec
            // 
            this.tbZaradaMjesec.Location = new System.Drawing.Point(89, 92);
            this.tbZaradaMjesec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbZaradaMjesec.Name = "tbZaradaMjesec";
            this.tbZaradaMjesec.ReadOnly = true;
            this.tbZaradaMjesec.Size = new System.Drawing.Size(132, 22);
            this.tbZaradaMjesec.TabIndex = 5;
            // 
            // tbZaradaTjedan
            // 
            this.tbZaradaTjedan.Location = new System.Drawing.Point(89, 59);
            this.tbZaradaTjedan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbZaradaTjedan.Name = "tbZaradaTjedan";
            this.tbZaradaTjedan.ReadOnly = true;
            this.tbZaradaTjedan.Size = new System.Drawing.Size(132, 22);
            this.tbZaradaTjedan.TabIndex = 4;
            // 
            // tbZaradaDan
            // 
            this.tbZaradaDan.Location = new System.Drawing.Point(89, 27);
            this.tbZaradaDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbZaradaDan.Name = "tbZaradaDan";
            this.tbZaradaDan.ReadOnly = true;
            this.tbZaradaDan.Size = new System.Drawing.Size(132, 22);
            this.tbZaradaDan.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tjedna:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mjesečna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Današnja:";
            // 
            // btnIzvjesceArtikl
            // 
            this.btnIzvjesceArtikl.Location = new System.Drawing.Point(27, 226);
            this.btnIzvjesceArtikl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIzvjesceArtikl.Name = "btnIzvjesceArtikl";
            this.btnIzvjesceArtikl.Size = new System.Drawing.Size(128, 28);
            this.btnIzvjesceArtikl.TabIndex = 6;
            this.btnIzvjesceArtikl.Text = "Izvješće artikl";
            this.btnIzvjesceArtikl.UseVisualStyleBackColor = true;
            // 
            // gbPrikazArtikala
            // 
            this.gbPrikazArtikala.Controls.Add(this.label1);
            this.gbPrikazArtikala.Controls.Add(this.cbArtikli);
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
            this.label2.Text = "Statistike";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Kategorija);
            this.groupBox2.Controls.Add(this.cbKategorija);
            this.groupBox2.Location = new System.Drawing.Point(362, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 134);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analitika prodaje kategorija";
            // 
            // btnIzvjesceArtiklKategorija
            // 
            this.btnIzvjesceArtiklKategorija.Location = new System.Drawing.Point(280, 226);
            this.btnIzvjesceArtiklKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzvjesceArtiklKategorija.Name = "btnIzvjesceArtiklKategorija";
            this.btnIzvjesceArtiklKategorija.Size = new System.Drawing.Size(128, 28);
            this.btnIzvjesceArtiklKategorija.TabIndex = 10;
            this.btnIzvjesceArtiklKategorija.Text = "Izvješće kat./art.";
            this.btnIzvjesceArtiklKategorija.UseVisualStyleBackColor = true;
            // 
            // btnIzvješćeKategorija
            // 
            this.btnIzvješćeKategorija.Location = new System.Drawing.Point(514, 226);
            this.btnIzvješćeKategorija.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzvješćeKategorija.Name = "btnIzvješćeKategorija";
            this.btnIzvješćeKategorija.Size = new System.Drawing.Size(128, 28);
            this.btnIzvješćeKategorija.TabIndex = 11;
            this.btnIzvješćeKategorija.Text = "Izvješće kategorija";
            this.btnIzvješćeKategorija.UseVisualStyleBackColor = true;
            // 
            // FormStatistikaProdaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 512);
            this.Controls.Add(this.btnIzvješćeKategorija);
            this.Controls.Add(this.btnIzvjesceArtiklKategorija);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbPrikazArtikala);
            this.Controls.Add(this.btnIzvjesceArtikl);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStatistikaProdaje";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FormStatistikaProdaje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox tbZaradaMjesec;
        private System.Windows.Forms.TextBox tbZaradaTjedan;
        private System.Windows.Forms.TextBox tbZaradaDan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzvjesceArtikl;
        private System.Windows.Forms.GroupBox gbPrikazArtikala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIzvjesceArtiklKategorija;
        private System.Windows.Forms.Button btnIzvješćeKategorija;
    }
}
namespace MiniStore
{
    partial class FormUpravljanjeArtiklima
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
            this.dgvArtikli = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSkladiste = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSkladiste = new System.Windows.Forms.RadioButton();
            this.rbSvi = new System.Windows.Forms.RadioButton();
            this.barcodeData = new MiniStore.BarcodeData();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArtikli
            // 
            this.dgvArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikli.Location = new System.Drawing.Point(12, 66);
            this.dgvArtikli.Name = "dgvArtikli";
            this.dgvArtikli.Size = new System.Drawing.Size(601, 329);
            this.dgvArtikli.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnIspisi, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDodaj, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUredi, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 401);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 55);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(403, 3);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(195, 49);
            this.btnIspisi.TabIndex = 2;
            this.btnIspisi.Text = "Ispiši etikete";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(3, 3);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(194, 49);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj novi artikl";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(203, 3);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(194, 49);
            this.btnUredi.TabIndex = 1;
            this.btnUredi.Text = "Uredi odabrani artikl";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Odaberi opciju:";
            // 
            // cbSkladiste
            // 
            this.cbSkladiste.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkladiste.FormattingEnabled = true;
            this.cbSkladiste.Location = new System.Drawing.Point(294, 19);
            this.cbSkladiste.Name = "cbSkladiste";
            this.cbSkladiste.Size = new System.Drawing.Size(148, 21);
            this.cbSkladiste.TabIndex = 5;
            this.cbSkladiste.SelectedValueChanged += new System.EventHandler(this.cbSkladiste_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSkladiste);
            this.groupBox1.Controls.Add(this.rbSvi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSkladiste);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 51);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mogućnosti";
            // 
            // rbSkladiste
            // 
            this.rbSkladiste.AutoSize = true;
            this.rbSkladiste.Location = new System.Drawing.Point(176, 20);
            this.rbSkladiste.Name = "rbSkladiste";
            this.rbSkladiste.Size = new System.Drawing.Size(112, 17);
            this.rbSkladiste.TabIndex = 7;
            this.rbSkladiste.TabStop = true;
            this.rbSkladiste.Text = "Artikli na skladištu:";
            this.rbSkladiste.UseVisualStyleBackColor = true;
            this.rbSkladiste.CheckedChanged += new System.EventHandler(this.rbSkladiste_CheckedChanged);
            // 
            // rbSvi
            // 
            this.rbSvi.AutoSize = true;
            this.rbSvi.Location = new System.Drawing.Point(90, 20);
            this.rbSvi.Name = "rbSvi";
            this.rbSvi.Size = new System.Drawing.Size(67, 17);
            this.rbSvi.TabIndex = 6;
            this.rbSvi.TabStop = true;
            this.rbSvi.Text = "Svi artikli";
            this.rbSvi.UseVisualStyleBackColor = true;
            this.rbSvi.CheckedChanged += new System.EventHandler(this.rbSvi_CheckedChanged);
            // 
            // barcodeData
            // 
            this.barcodeData.DataSetName = "BarcodeData";
            this.barcodeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormUpravljanjeArtiklima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvArtikli);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpravljanjeArtiklima";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upravljanje artiklima";
            this.Load += new System.EventHandler(this.FormUpravljanjeArtiklima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikli)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtikli;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSkladiste;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSkladiste;
        private System.Windows.Forms.RadioButton rbSvi;
        private BarcodeData barcodeData;
    }
}
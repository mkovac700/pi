namespace MiniStore
{
    partial class FormNarucivanjeArtikala
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDobavljac = new System.Windows.Forms.ComboBox();
            this.dgvPopisArtikala = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSifraArtikla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.artiklBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklCijenasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklNarudzbenicasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklPovratnicasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklPrimkasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklSkladistesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunArtiklsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi dobavljača:";
            // 
            // cbDobavljac
            // 
            this.cbDobavljac.FormattingEnabled = true;
            this.cbDobavljac.Location = new System.Drawing.Point(160, 21);
            this.cbDobavljac.Margin = new System.Windows.Forms.Padding(4);
            this.cbDobavljac.Name = "cbDobavljac";
            this.cbDobavljac.Size = new System.Drawing.Size(263, 24);
            this.cbDobavljac.TabIndex = 1;
            this.cbDobavljac.SelectedIndexChanged += new System.EventHandler(this.cbDobavljac_SelectedIndexChanged);
            // 
            // dgvPopisArtikala
            // 
            this.dgvPopisArtikala.AutoGenerateColumns = false;
            this.dgvPopisArtikala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisArtikala.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.kategorijaDataGridViewTextBoxColumn,
            this.dobavljacIdDataGridViewTextBoxColumn,
            this.dobavljacDataGridViewTextBoxColumn,
            this.artiklCijenasDataGridViewTextBoxColumn,
            this.artiklNarudzbenicasDataGridViewTextBoxColumn,
            this.artiklPovratnicasDataGridViewTextBoxColumn,
            this.artiklPrimkasDataGridViewTextBoxColumn,
            this.artiklSkladistesDataGridViewTextBoxColumn,
            this.racunArtiklsDataGridViewTextBoxColumn});
            this.dgvPopisArtikala.DataSource = this.artiklBindingSource;
            this.dgvPopisArtikala.Location = new System.Drawing.Point(20, 106);
            this.dgvPopisArtikala.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPopisArtikala.Name = "dgvPopisArtikala";
            this.dgvPopisArtikala.RowHeadersWidth = 51;
            this.dgvPopisArtikala.Size = new System.Drawing.Size(573, 369);
            this.dgvPopisArtikala.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(215, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Popis artikala";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(803, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stavke narudžbenice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 503);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Šifra artikla:";
            // 
            // tbSifraArtikla
            // 
            this.tbSifraArtikla.Location = new System.Drawing.Point(168, 500);
            this.tbSifraArtikla.Margin = new System.Windows.Forms.Padding(4);
            this.tbSifraArtikla.Name = "tbSifraArtikla";
            this.tbSifraArtikla.Size = new System.Drawing.Size(252, 22);
            this.tbSifraArtikla.TabIndex = 7;
            this.tbSifraArtikla.TextChanged += new System.EventHandler(this.tbSIfraArtika_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 535);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Količina za narudžbu:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(463, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "Dodaj u narudžbenicu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(909, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ukloni odabranu stavku";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1075, 500);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 59);
            this.button3.TabIndex = 12;
            this.button3.Text = "Generiraj narudžbenicu";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(659, 106);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(573, 369);
            this.dataGridView2.TabIndex = 13;
            // 
            // artiklBindingSource
            // 
            this.artiklBindingSource.DataSource = typeof(MiniStore.Artikl);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // kategorijaDataGridViewTextBoxColumn
            // 
            this.kategorijaDataGridViewTextBoxColumn.DataPropertyName = "kategorija";
            this.kategorijaDataGridViewTextBoxColumn.HeaderText = "kategorija";
            this.kategorijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kategorijaDataGridViewTextBoxColumn.Name = "kategorijaDataGridViewTextBoxColumn";
            this.kategorijaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobavljacIdDataGridViewTextBoxColumn
            // 
            this.dobavljacIdDataGridViewTextBoxColumn.DataPropertyName = "dobavljacId";
            this.dobavljacIdDataGridViewTextBoxColumn.HeaderText = "dobavljacId";
            this.dobavljacIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobavljacIdDataGridViewTextBoxColumn.Name = "dobavljacIdDataGridViewTextBoxColumn";
            this.dobavljacIdDataGridViewTextBoxColumn.Visible = false;
            this.dobavljacIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dobavljacDataGridViewTextBoxColumn
            // 
            this.dobavljacDataGridViewTextBoxColumn.DataPropertyName = "Dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.HeaderText = "Dobavljac";
            this.dobavljacDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobavljacDataGridViewTextBoxColumn.Name = "dobavljacDataGridViewTextBoxColumn";
            this.dobavljacDataGridViewTextBoxColumn.Visible = false;
            this.dobavljacDataGridViewTextBoxColumn.Width = 125;
            // 
            // artiklCijenasDataGridViewTextBoxColumn
            // 
            this.artiklCijenasDataGridViewTextBoxColumn.DataPropertyName = "ArtiklCijenas";
            this.artiklCijenasDataGridViewTextBoxColumn.HeaderText = "ArtiklCijenas";
            this.artiklCijenasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artiklCijenasDataGridViewTextBoxColumn.Name = "artiklCijenasDataGridViewTextBoxColumn";
            this.artiklCijenasDataGridViewTextBoxColumn.Visible = false;
            this.artiklCijenasDataGridViewTextBoxColumn.Width = 125;
            // 
            // artiklNarudzbenicasDataGridViewTextBoxColumn
            // 
            this.artiklNarudzbenicasDataGridViewTextBoxColumn.DataPropertyName = "ArtiklNarudzbenicas";
            this.artiklNarudzbenicasDataGridViewTextBoxColumn.HeaderText = "ArtiklNarudzbenicas";
            this.artiklNarudzbenicasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artiklNarudzbenicasDataGridViewTextBoxColumn.Name = "artiklNarudzbenicasDataGridViewTextBoxColumn";
            this.artiklNarudzbenicasDataGridViewTextBoxColumn.Visible = false;
            this.artiklNarudzbenicasDataGridViewTextBoxColumn.Width = 125;
            // 
            // artiklPovratnicasDataGridViewTextBoxColumn
            // 
            this.artiklPovratnicasDataGridViewTextBoxColumn.DataPropertyName = "ArtiklPovratnicas";
            this.artiklPovratnicasDataGridViewTextBoxColumn.HeaderText = "ArtiklPovratnicas";
            this.artiklPovratnicasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artiklPovratnicasDataGridViewTextBoxColumn.Name = "artiklPovratnicasDataGridViewTextBoxColumn";
            this.artiklPovratnicasDataGridViewTextBoxColumn.Visible = false;
            this.artiklPovratnicasDataGridViewTextBoxColumn.Width = 125;
            // 
            // artiklPrimkasDataGridViewTextBoxColumn
            // 
            this.artiklPrimkasDataGridViewTextBoxColumn.DataPropertyName = "ArtiklPrimkas";
            this.artiklPrimkasDataGridViewTextBoxColumn.HeaderText = "ArtiklPrimkas";
            this.artiklPrimkasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artiklPrimkasDataGridViewTextBoxColumn.Name = "artiklPrimkasDataGridViewTextBoxColumn";
            this.artiklPrimkasDataGridViewTextBoxColumn.Visible = false;
            this.artiklPrimkasDataGridViewTextBoxColumn.Width = 125;
            // 
            // artiklSkladistesDataGridViewTextBoxColumn
            // 
            this.artiklSkladistesDataGridViewTextBoxColumn.DataPropertyName = "ArtiklSkladistes";
            this.artiklSkladistesDataGridViewTextBoxColumn.HeaderText = "ArtiklSkladistes";
            this.artiklSkladistesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artiklSkladistesDataGridViewTextBoxColumn.Name = "artiklSkladistesDataGridViewTextBoxColumn";
            this.artiklSkladistesDataGridViewTextBoxColumn.Visible = false;
            this.artiklSkladistesDataGridViewTextBoxColumn.Width = 125;
            // 
            // racunArtiklsDataGridViewTextBoxColumn
            // 
            this.racunArtiklsDataGridViewTextBoxColumn.DataPropertyName = "RacunArtikls";
            this.racunArtiklsDataGridViewTextBoxColumn.HeaderText = "RacunArtikls";
            this.racunArtiklsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.racunArtiklsDataGridViewTextBoxColumn.Name = "racunArtiklsDataGridViewTextBoxColumn";
            this.racunArtiklsDataGridViewTextBoxColumn.Visible = false;
            this.racunArtiklsDataGridViewTextBoxColumn.Width = 125;
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(168, 533);
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(120, 22);
            this.nudKolicina.TabIndex = 14;
            // 
            // FormNarucivanjeArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 590);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSifraArtikla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPopisArtikala);
            this.Controls.Add(this.cbDobavljac);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNarucivanjeArtikala";
            this.Text = "Naručivanje artikala";
            this.Load += new System.EventHandler(this.FormNarucivanjeArtikala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisArtikala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDobavljac;
        private System.Windows.Forms.DataGridView dgvPopisArtikala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSifraArtikla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategorijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklCijenasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklNarudzbenicasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklPovratnicasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklPrimkasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artiklSkladistesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunArtiklsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource artiklBindingSource;
        private System.Windows.Forms.NumericUpDown nudKolicina;
    }
}
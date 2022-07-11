namespace MiniStore
{
    partial class FormZaprimanjeArtikala
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
            this.cbPrimke = new System.Windows.Forms.ComboBox();
            this.dgvStavkePrimke = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnZaprimi = new System.Windows.Forms.Button();
            this.dgvZaprimljeneStavke = new System.Windows.Forms.DataGridView();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.chkboxPrimkaZaprimljena = new System.Windows.Forms.CheckBox();
            this.tooltipCheckbox = new System.Windows.Forms.ToolTip(this.components);
            this.hpPomoc = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi primku:";
            // 
            // cbPrimke
            // 
            this.cbPrimke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrimke.FormattingEnabled = true;
            this.cbPrimke.Location = new System.Drawing.Point(99, 12);
            this.cbPrimke.Name = "cbPrimke";
            this.cbPrimke.Size = new System.Drawing.Size(113, 21);
            this.cbPrimke.TabIndex = 1;
            this.cbPrimke.SelectedValueChanged += new System.EventHandler(this.cbPrimke_SelectedValueChanged);
            // 
            // dgvStavkePrimke
            // 
            this.dgvStavkePrimke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePrimke.Location = new System.Drawing.Point(16, 80);
            this.dgvStavkePrimke.Name = "dgvStavkePrimke";
            this.dgvStavkePrimke.Size = new System.Drawing.Size(430, 300);
            this.dgvStavkePrimke.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(142, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stavke primke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(656, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Zaprimljene stavke";
            // 
            // btnZaprimi
            // 
            this.btnZaprimi.Location = new System.Drawing.Point(451, 207);
            this.btnZaprimi.Name = "btnZaprimi";
            this.btnZaprimi.Size = new System.Drawing.Size(75, 44);
            this.btnZaprimi.TabIndex = 6;
            this.btnZaprimi.Text = ">>\r\nZaprimi\r\n";
            this.btnZaprimi.UseVisualStyleBackColor = true;
            this.btnZaprimi.Click += new System.EventHandler(this.btnZaprimi_Click);
            // 
            // dgvZaprimljeneStavke
            // 
            this.dgvZaprimljeneStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaprimljeneStavke.Location = new System.Drawing.Point(532, 80);
            this.dgvZaprimljeneStavke.Name = "dgvZaprimljeneStavke";
            this.dgvZaprimljeneStavke.Size = new System.Drawing.Size(430, 300);
            this.dgvZaprimljeneStavke.TabIndex = 7;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(806, 386);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 37);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(887, 386);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 37);
            this.btnZatvori.TabIndex = 9;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // chkboxPrimkaZaprimljena
            // 
            this.chkboxPrimkaZaprimljena.AutoSize = true;
            this.chkboxPrimkaZaprimljena.Location = new System.Drawing.Point(644, 397);
            this.chkboxPrimkaZaprimljena.Name = "chkboxPrimkaZaprimljena";
            this.chkboxPrimkaZaprimljena.Size = new System.Drawing.Size(156, 17);
            this.chkboxPrimkaZaprimljena.TabIndex = 10;
            this.chkboxPrimkaZaprimljena.Text = "Označi primku zaprimljenom";
            this.tooltipCheckbox.SetToolTip(this.chkboxPrimkaZaprimljena, "Označiti ako su sve željene stavke zaprimljene. Primka će biti označena kao zapri" +
        "mljena i neće se više prikazivati u popisu.");
            this.chkboxPrimkaZaprimljena.UseVisualStyleBackColor = true;
            this.chkboxPrimkaZaprimljena.CheckedChanged += new System.EventHandler(this.chkboxPrimkaZaprimljena_CheckedChanged);
            // 
            // tooltipCheckbox
            // 
            this.tooltipCheckbox.AutoPopDelay = 10000;
            this.tooltipCheckbox.InitialDelay = 500;
            this.tooltipCheckbox.IsBalloon = true;
            this.tooltipCheckbox.ReshowDelay = 100;
            // 
            // hpPomoc
            // 
            this.hpPomoc.HelpNamespace = "Help/help-zaprimanje-artikala.chm";
            // 
            // FormZaprimanjeArtikala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 435);
            this.Controls.Add(this.chkboxPrimkaZaprimljena);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.dgvZaprimljeneStavke);
            this.Controls.Add(this.btnZaprimi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvStavkePrimke);
            this.Controls.Add(this.cbPrimke);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormZaprimanjeArtikala";
            this.hpPomoc.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaprimanje artikala";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.FormZaprimanjeArtikala_HelpButtonClicked);
            this.Load += new System.EventHandler(this.FormZaprimanjeArtikala_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormZaprimanjeArtikala_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePrimke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaprimljeneStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPrimke;
        private System.Windows.Forms.DataGridView dgvStavkePrimke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnZaprimi;
        private System.Windows.Forms.DataGridView dgvZaprimljeneStavke;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.CheckBox chkboxPrimkaZaprimljena;
        private System.Windows.Forms.ToolTip tooltipCheckbox;
        private System.Windows.Forms.HelpProvider hpPomoc;
    }
}
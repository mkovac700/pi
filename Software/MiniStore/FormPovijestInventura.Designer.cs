namespace MiniStore
{
    partial class FormPovijestInventura
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
            this.dgvPovijestInventura = new System.Windows.Forms.DataGridView();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestInventura)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPovijestInventura
            // 
            this.dgvPovijestInventura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijestInventura.Location = new System.Drawing.Point(12, 12);
            this.dgvPovijestInventura.Name = "dgvPovijestInventura";
            this.dgvPovijestInventura.Size = new System.Drawing.Size(886, 253);
            this.dgvPovijestInventura.TabIndex = 0;
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(823, 271);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(75, 31);
            this.btnZatvori.TabIndex = 1;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // FormPovijestInventura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 307);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.dgvPovijestInventura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPovijestInventura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Povijest inventura";
            this.Load += new System.EventHandler(this.FormPovijestInventura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestInventura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPovijestInventura;
        private System.Windows.Forms.Button btnZatvori;
    }
}
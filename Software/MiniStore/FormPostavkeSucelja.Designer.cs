namespace MiniStore
{
    partial class FormPostavkeSucelja
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
            this.pbPregled = new System.Windows.Forms.PictureBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPregled
            // 
            this.pbPregled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPregled.Location = new System.Drawing.Point(21, 36);
            this.pbPregled.Name = "pbPregled";
            this.pbPregled.Size = new System.Drawing.Size(479, 314);
            this.pbPregled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPregled.TabIndex = 0;
            this.pbPregled.TabStop = false;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(344, 365);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretraži...";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(425, 365);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnSpremi.TabIndex = 2;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Logotip (pretpregled):";
            // 
            // FormPostavkeSucelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.pbPregled);
            this.Name = "FormPostavkeSucelja";
            this.Text = "Postavke sučelja";
            this.Load += new System.EventHandler(this.FormPostavkeSucelja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPregled;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Label label1;
    }
}
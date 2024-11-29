namespace Client.Forms.Evidencije
{
    partial class FrmEvidencije
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnKreirajEvidenciju = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvEvidencije = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencije)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(380, 295);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(89, 23);
            this.btnObrisi.TabIndex = 25;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnKreirajEvidenciju
            // 
            this.btnKreirajEvidenciju.Location = new System.Drawing.Point(15, 295);
            this.btnKreirajEvidenciju.Name = "btnKreirajEvidenciju";
            this.btnKreirajEvidenciju.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajEvidenciju.TabIndex = 22;
            this.btnKreirajEvidenciju.Text = "Kreiraj";
            this.btnKreirajEvidenciju.UseVisualStyleBackColor = true;
            this.btnKreirajEvidenciju.Click += new System.EventHandler(this.btnKreirajEvidenciju_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(304, 13);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Evidencije spremljenih obroka i recepata po kojima su spremani";
            // 
            // dgvEvidencije
            // 
            this.dgvEvidencije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvidencije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvidencije.Location = new System.Drawing.Point(15, 38);
            this.dgvEvidencije.Name = "dgvEvidencije";
            this.dgvEvidencije.RowHeadersWidth = 51;
            this.dgvEvidencije.Size = new System.Drawing.Size(454, 251);
            this.dgvEvidencije.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            // 
            // FrmEvidencije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 338);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnKreirajEvidenciju);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvEvidencije);
            this.Controls.Add(this.label1);
            this.Name = "FrmEvidencije";
            this.Text = "FrmEvidencije";
            this.Load += new System.EventHandler(this.FrmEvidencije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvidencije)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnKreirajEvidenciju;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvEvidencije;
        private System.Windows.Forms.Label label1;
    }
}
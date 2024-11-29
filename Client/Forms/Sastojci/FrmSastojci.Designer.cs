namespace Client.Forms
{
    partial class FrmSastojci
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
            this.dgvSastojci = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKreirajSastojak = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // dgvSastojci
            // 
            this.dgvSastojci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSastojci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSastojci.Location = new System.Drawing.Point(12, 56);
            this.dgvSastojci.Name = "dgvSastojci";
            this.dgvSastojci.Size = new System.Drawing.Size(454, 150);
            this.dgvSastojci.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sastojci";
            // 
            // btnKreirajSastojak
            // 
            this.btnKreirajSastojak.Location = new System.Drawing.Point(12, 212);
            this.btnKreirajSastojak.Name = "btnKreirajSastojak";
            this.btnKreirajSastojak.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajSastojak.TabIndex = 3;
            this.btnKreirajSastojak.Text = "Kreiraj";
            this.btnKreirajSastojak.UseVisualStyleBackColor = true;
            this.btnKreirajSastojak.Click += new System.EventHandler(this.btnKreirajSastojak_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(285, 20);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazi.TabIndex = 5;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(391, 20);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(377, 212);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(89, 23);
            this.btnObrisi.TabIndex = 7;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(104, 212);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 8;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(194, 212);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 9;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // FrmSastojci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 249);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnKreirajSastojak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSastojci);
            this.Controls.Add(this.label1);
            this.Name = "FrmSastojci";
            this.Text = "FrmSastojci";
            this.Load += new System.EventHandler(this.FrmSastojci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSastojci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSastojci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKreirajSastojak;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnDetalji;
    }
}
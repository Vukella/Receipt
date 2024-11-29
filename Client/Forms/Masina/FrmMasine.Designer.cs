namespace Client.Forms.Masina
{
    partial class FrmMasine
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
            this.btnKreirajSastojak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMasine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasine)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKreirajSastojak
            // 
            this.btnKreirajSastojak.Location = new System.Drawing.Point(12, 250);
            this.btnKreirajSastojak.Name = "btnKreirajSastojak";
            this.btnKreirajSastojak.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajSastojak.TabIndex = 13;
            this.btnKreirajSastojak.Text = "Kreiraj";
            this.btnKreirajSastojak.UseVisualStyleBackColor = true;
            this.btnKreirajSastojak.Click += new System.EventHandler(this.btnKreirajSastojak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Masine i alati za preradu hrane";
            // 
            // dgvMasine
            // 
            this.dgvMasine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasine.Location = new System.Drawing.Point(12, 94);
            this.dgvMasine.Name = "dgvMasine";
            this.dgvMasine.Size = new System.Drawing.Size(324, 150);
            this.dgvMasine.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // FrmMasine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 300);
            this.Controls.Add(this.btnKreirajSastojak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMasine);
            this.Controls.Add(this.label1);
            this.Name = "FrmMasine";
            this.Text = "FrmMasina";
            this.Load += new System.EventHandler(this.FrmMasine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKreirajSastojak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMasine;
        private System.Windows.Forms.Label label1;
    }
}
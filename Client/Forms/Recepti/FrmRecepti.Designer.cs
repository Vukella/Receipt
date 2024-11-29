namespace Client.Forms.Recepti
{
    partial class FrmRecepti
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
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnKreirajSastojak = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(197, 274);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(75, 23);
            this.btnDetalji.TabIndex = 18;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.Location = new System.Drawing.Point(107, 274);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(75, 23);
            this.btnAzuriraj.TabIndex = 17;
            this.btnAzuriraj.Text = "Azuriraj";
            this.btnAzuriraj.UseVisualStyleBackColor = true;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(391, 18);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 15;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.Location = new System.Drawing.Point(285, 18);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(100, 20);
            this.txtPretrazi.TabIndex = 14;
            // 
            // btnKreirajSastojak
            // 
            this.btnKreirajSastojak.Location = new System.Drawing.Point(15, 274);
            this.btnKreirajSastojak.Name = "btnKreirajSastojak";
            this.btnKreirajSastojak.Size = new System.Drawing.Size(75, 23);
            this.btnKreirajSastojak.TabIndex = 13;
            this.btnKreirajSastojak.Text = "Kreiraj";
            this.btnKreirajSastojak.UseVisualStyleBackColor = true;
            this.btnKreirajSastojak.Click += new System.EventHandler(this.btnKreirajSastojak_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Recepti";
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(15, 47);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.Size = new System.Drawing.Size(454, 212);
            this.dgvRecepti.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // FrmRecepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 315);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.btnKreirajSastojak);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvRecepti);
            this.Controls.Add(this.label1);
            this.Name = "FrmRecepti";
            this.Text = "FrmRecepti";
            this.Load += new System.EventHandler(this.FrmRecepti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnKreirajSastojak;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.Label label1;
    }
}
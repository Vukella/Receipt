namespace Client.Forms
{
    partial class FrmSastojakDetalji
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbVrstaSastojka = new System.Windows.Forms.ComboBox();
            this.numKalorijskaVrednost = new System.Windows.Forms.NumericUpDown();
            this.btnKreiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKalorijskaVrednost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vrsta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "kcal";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(132, 31);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(227, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // cmbVrstaSastojka
            // 
            this.cmbVrstaSastojka.FormattingEnabled = true;
            this.cmbVrstaSastojka.Location = new System.Drawing.Point(133, 73);
            this.cmbVrstaSastojka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbVrstaSastojka.Name = "cmbVrstaSastojka";
            this.cmbVrstaSastojka.Size = new System.Drawing.Size(227, 24);
            this.cmbVrstaSastojka.TabIndex = 4;
            // 
            // numKalorijskaVrednost
            // 
            this.numKalorijskaVrednost.Location = new System.Drawing.Point(133, 118);
            this.numKalorijskaVrednost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numKalorijskaVrednost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numKalorijskaVrednost.Name = "numKalorijskaVrednost";
            this.numKalorijskaVrednost.Size = new System.Drawing.Size(228, 22);
            this.numKalorijskaVrednost.TabIndex = 5;
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Location = new System.Drawing.Point(32, 161);
            this.btnKreiraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(329, 28);
            this.btnKreiraj.TabIndex = 6;
            this.btnKreiraj.Text = "Kreiraj";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // FrmSastojakDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 222);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.numKalorijskaVrednost);
            this.Controls.Add(this.cmbVrstaSastojka);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSastojakDetalji";
            this.Text = "FrmDodajSastojak";
            this.Load += new System.EventHandler(this.FrmDodajSastojak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKalorijskaVrednost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbVrstaSastojka;
        private System.Windows.Forms.NumericUpDown numKalorijskaVrednost;
        private System.Windows.Forms.Button btnKreiraj;
    }
}
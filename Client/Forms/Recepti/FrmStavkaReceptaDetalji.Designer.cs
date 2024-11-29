namespace Client.Forms.Recepti
{
    partial class FrmStavkaReceptaDetalji
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
            this.btnAction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbKorak = new System.Windows.Forms.RichTextBox();
            this.numTrajanjeKoraka = new System.Windows.Forms.NumericUpDown();
            this.lblMetric = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSastojak = new System.Windows.Forms.ComboBox();
            this.cmbMasina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanjeKoraka)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(35, 285);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(329, 42);
            this.btnAction.TabIndex = 20;
            this.btnAction.Text = "Kreiraj";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trajanje koraka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Korak";
            // 
            // rtbKorak
            // 
            this.rtbKorak.Location = new System.Drawing.Point(144, 152);
            this.rtbKorak.Margin = new System.Windows.Forms.Padding(4);
            this.rtbKorak.Name = "rtbKorak";
            this.rtbKorak.Size = new System.Drawing.Size(275, 109);
            this.rtbKorak.TabIndex = 21;
            this.rtbKorak.Text = "";
            // 
            // numTrajanjeKoraka
            // 
            this.numTrajanjeKoraka.Location = new System.Drawing.Point(144, 122);
            this.numTrajanjeKoraka.Margin = new System.Windows.Forms.Padding(4);
            this.numTrajanjeKoraka.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTrajanjeKoraka.Name = "numTrajanjeKoraka";
            this.numTrajanjeKoraka.Size = new System.Drawing.Size(128, 22);
            this.numTrajanjeKoraka.TabIndex = 22;
            // 
            // lblMetric
            // 
            this.lblMetric.AutoSize = true;
            this.lblMetric.Location = new System.Drawing.Point(300, 127);
            this.lblMetric.Name = "lblMetric";
            this.lblMetric.Size = new System.Drawing.Size(28, 16);
            this.lblMetric.TabIndex = 23;
            this.lblMetric.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Potrebni sastojak";
            // 
            // cmbSastojak
            // 
            this.cmbSastojak.FormattingEnabled = true;
            this.cmbSastojak.Location = new System.Drawing.Point(35, 60);
            this.cmbSastojak.Name = "cmbSastojak";
            this.cmbSastojak.Size = new System.Drawing.Size(121, 24);
            this.cmbSastojak.TabIndex = 25;
            // 
            // cmbMasina
            // 
            this.cmbMasina.FormattingEnabled = true;
            this.cmbMasina.Location = new System.Drawing.Point(249, 60);
            this.cmbMasina.Name = "cmbMasina";
            this.cmbMasina.Size = new System.Drawing.Size(121, 24);
            this.cmbMasina.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Potrebna masina ili alat";
            // 
            // FrmStavkaReceptaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 340);
            this.Controls.Add(this.cmbMasina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSastojak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMetric);
            this.Controls.Add(this.numTrajanjeKoraka);
            this.Controls.Add(this.rtbKorak);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmStavkaReceptaDetalji";
            this.Text = "FrmStavkaReceptaDetalji";
            this.Load += new System.EventHandler(this.FrmStavkaReceptaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTrajanjeKoraka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbKorak;
        private System.Windows.Forms.NumericUpDown numTrajanjeKoraka;
        private System.Windows.Forms.Label lblMetric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSastojak;
        private System.Windows.Forms.ComboBox cmbMasina;
        private System.Windows.Forms.Label label4;
    }
}
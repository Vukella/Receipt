namespace Client.Forms.Evidencije
{
    partial class FrmEvidencijaDetalji
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
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cmbKategorijaJela = new System.Windows.Forms.ComboBox();
            this.lblKategorijaJela = new System.Windows.Forms.Label();
            this.rtbKomentar = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRecept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(28, 32);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Datum";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(125, 29);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(224, 22);
            this.txtDate.TabIndex = 2;
            // 
            // cmbKategorijaJela
            // 
            this.cmbKategorijaJela.FormattingEnabled = true;
            this.cmbKategorijaJela.Location = new System.Drawing.Point(125, 69);
            this.cmbKategorijaJela.Name = "cmbKategorijaJela";
            this.cmbKategorijaJela.Size = new System.Drawing.Size(224, 24);
            this.cmbKategorijaJela.TabIndex = 3;
            // 
            // lblKategorijaJela
            // 
            this.lblKategorijaJela.AutoSize = true;
            this.lblKategorijaJela.Location = new System.Drawing.Point(28, 72);
            this.lblKategorijaJela.Name = "lblKategorijaJela";
            this.lblKategorijaJela.Size = new System.Drawing.Size(93, 16);
            this.lblKategorijaJela.TabIndex = 4;
            this.lblKategorijaJela.Text = "Kategorija jela";
            // 
            // rtbKomentar
            // 
            this.rtbKomentar.Location = new System.Drawing.Point(125, 110);
            this.rtbKomentar.Name = "rtbKomentar";
            this.rtbKomentar.Size = new System.Drawing.Size(224, 66);
            this.rtbKomentar.TabIndex = 5;
            this.rtbKomentar.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Komentar";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(250, 234);
            this.btnAction.Margin = new System.Windows.Forms.Padding(4);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(99, 39);
            this.btnAction.TabIndex = 36;
            this.btnAction.Text = "Kreiraj";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 34;
            // 
            // cmbRecept
            // 
            this.cmbRecept.FormattingEnabled = true;
            this.cmbRecept.Location = new System.Drawing.Point(125, 192);
            this.cmbRecept.Name = "cmbRecept";
            this.cmbRecept.Size = new System.Drawing.Size(224, 24);
            this.cmbRecept.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Recept";
            // 
            // FrmEvidencijaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbRecept);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbKomentar);
            this.Controls.Add(this.lblKategorijaJela);
            this.Controls.Add(this.cmbKategorijaJela);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEvidencijaDetalji";
            this.Text = "FrmEvidencijaDetalji";
            this.Load += new System.EventHandler(this.FrmEvidencijaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.ComboBox cmbKategorijaJela;
        private System.Windows.Forms.Label lblKategorijaJela;
        private System.Windows.Forms.RichTextBox rtbKomentar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRecept;
        private System.Windows.Forms.Label label2;
    }
}
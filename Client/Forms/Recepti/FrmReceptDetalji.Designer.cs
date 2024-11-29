namespace Client.Forms.Recepti
{
    partial class FrmReceptDetalji
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
            this.btnDodajStavkuRecepta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipObroka = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtPVP = new System.Windows.Forms.TextBox();
            this.txtKcal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajStavkuRecepta
            // 
            this.btnDodajStavkuRecepta.Location = new System.Drawing.Point(14, 356);
            this.btnDodajStavkuRecepta.Name = "btnDodajStavkuRecepta";
            this.btnDodajStavkuRecepta.Size = new System.Drawing.Size(84, 23);
            this.btnDodajStavkuRecepta.TabIndex = 17;
            this.btnDodajStavkuRecepta.Text = "Dodaj stavku";
            this.btnDodajStavkuRecepta.UseVisualStyleBackColor = true;
            this.btnDodajStavkuRecepta.Click += new System.EventHandler(this.btnDodajStavkuRecepta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Recept";
            // 
            // dgvStavke
            // 
            this.dgvStavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(14, 200);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.Size = new System.Drawing.Size(355, 150);
            this.dgvStavke.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 14;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(174, 48);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(193, 20);
            this.txtNaziv.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tip obroka";
            // 
            // cmbTipObroka
            // 
            this.cmbTipObroka.FormattingEnabled = true;
            this.cmbTipObroka.Location = new System.Drawing.Point(246, 74);
            this.cmbTipObroka.Name = "cmbTipObroka";
            this.cmbTipObroka.Size = new System.Drawing.Size(121, 21);
            this.cmbTipObroka.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ukupan broj kalorija:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Potrebno vreme pripreme:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Koraci recepta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "minuta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "kcal";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(14, 401);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(84, 38);
            this.btnAction.TabIndex = 34;
            this.btnAction.Text = "Kreiraj";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtPVP
            // 
            this.txtPVP.Location = new System.Drawing.Point(251, 107);
            this.txtPVP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPVP.Name = "txtPVP";
            this.txtPVP.Size = new System.Drawing.Size(76, 20);
            this.txtPVP.TabIndex = 35;
            // 
            // txtKcal
            // 
            this.txtKcal.Location = new System.Drawing.Point(251, 139);
            this.txtKcal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKcal.Name = "txtKcal";
            this.txtKcal.Size = new System.Drawing.Size(76, 20);
            this.txtKcal.TabIndex = 36;
            // 
            // FrmReceptDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.txtKcal);
            this.Controls.Add(this.txtPVP);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipObroka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnDodajStavkuRecepta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.label5);
            this.Name = "FrmReceptDetalji";
            this.Text = "FrmReceptDetalji";
            this.Load += new System.EventHandler(this.FrmReceptDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajStavkuRecepta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipObroka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtPVP;
        private System.Windows.Forms.TextBox txtKcal;
    }
}
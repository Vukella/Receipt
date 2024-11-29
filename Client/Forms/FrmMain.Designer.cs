namespace Client
{
    partial class FrmMain
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
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.itemSastojci = new System.Windows.Forms.ToolStripMenuItem();
            this.masineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.receptiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSastojci,
            this.masineToolStripMenuItem,
            this.receptiToolStripMenuItem,
            this.evidencijeToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mnMain.Size = new System.Drawing.Size(735, 28);
            this.mnMain.TabIndex = 0;
            this.mnMain.Text = "menuStrip1";
            // 
            // itemSastojci
            // 
            this.itemSastojci.Name = "itemSastojci";
            this.itemSastojci.Size = new System.Drawing.Size(74, 24);
            this.itemSastojci.Text = "Sastojci";
            this.itemSastojci.Click += new System.EventHandler(this.itemSastojci_Click);
            // 
            // masineToolStripMenuItem
            // 
            this.masineToolStripMenuItem.Name = "masineToolStripMenuItem";
            this.masineToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.masineToolStripMenuItem.Text = "Masine";
            this.masineToolStripMenuItem.Click += new System.EventHandler(this.masineToolStripMenuItem_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(35, 97);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 16);
            this.lblUser.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 28);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(735, 422);
            this.pnlMain.TabIndex = 2;
            // 
            // receptiToolStripMenuItem
            // 
            this.receptiToolStripMenuItem.Name = "receptiToolStripMenuItem";
            this.receptiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.receptiToolStripMenuItem.Text = "Recepti";
            this.receptiToolStripMenuItem.Click += new System.EventHandler(this.receptiToolStripMenuItem_Click);
            // 
            // evidencijeToolStripMenuItem
            // 
            this.evidencijeToolStripMenuItem.Name = "evidencijeToolStripMenuItem";
            this.evidencijeToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.evidencijeToolStripMenuItem.Text = "Evidencije";
            this.evidencijeToolStripMenuItem.Click += new System.EventHandler(this.evidencijeToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.mnMain);
            this.MainMenuStrip = this.mnMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem itemSastojci;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStripMenuItem masineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receptiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijeToolStripMenuItem;
    }
}
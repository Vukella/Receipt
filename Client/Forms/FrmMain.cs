using Client.Forms;
using Client.Forms.Evidencije;
using Client.Forms.Masina;
using Client.Forms.Recepti;
using Client.GuiController;
using Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent(); 
        }

        private void itemSastojci_Click(object sender, EventArgs e)
        {
            FrmSastojci frmSastojci = new FrmSastojci();
            frmSastojci.ShowDialog(); 
        }

        private void masineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMasine frmMasine = new FrmMasine();
            frmMasine.ShowDialog();
        }

        private void receptiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecepti frmRecepti = new FrmRecepti();
            frmRecepti.ShowDialog();
        }

        private void evidencijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEvidencije frmEvidencije = new FrmEvidencije();
            frmEvidencije.ShowDialog();
        }
    }
}

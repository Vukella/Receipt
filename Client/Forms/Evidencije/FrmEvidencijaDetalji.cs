using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Client.Forms.Evidencije
{
    public partial class FrmEvidencijaDetalji : Form
    {
        public FormMode Mode { get; set; }
        public Evidencija TrenutnaEvidencija { get; set; }
        public FrmEvidencijaDetalji(FormMode mode, Evidencija evidencija = null)
        {
            InitializeComponent();
            Mode = mode;
            TrenutnaEvidencija = evidencija;       
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {                
                case FormMode.Create:
                    Evidencija evidencija = new Evidencija()
                    {
                        Datum = DateTime.Now.ToString(),
                        KategorijaJela = (KategorijaJela)cmbKategorijaJela.SelectedItem,
                        Komentar = rtbKomentar.Text,
                        ReceptEvidencije = (Recept)cmbRecept.SelectedItem,
                    };
                    Communication.Instance.KreirajEvidenciju(evidencija);
                    Close();
                    break;                                                        
                default:
                    break;
            }
        }

        private void FrmEvidencijaDetalji_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString();
            txtDate.ReadOnly = true;

            switch (Mode)
            {
                case FormMode.Update:
                    break;
                case FormMode.Create:
                    btnAction.Text = "Kreiraj";

                    cmbKategorijaJela.DataSource = Enum.GetValues(typeof(KategorijaJela));
                    var recepti = (List<Recept>)Communication.Instance.UcitajRecepte().Result;
                    cmbRecept.DataSource = recepti.Distinct().ToList(); 
                    break;
                case FormMode.Details:
                    btnAction.Visible = false;

                    txtDate.Text = TrenutnaEvidencija.Datum.ToString();
                    rtbKomentar.Text = TrenutnaEvidencija.Komentar;
                    cmbKategorijaJela.SelectedItem = TrenutnaEvidencija.KategorijaJela;
                    cmbRecept.SelectedItem = TrenutnaEvidencija.ReceptEvidencije;

                    cmbKategorijaJela.Enabled = false;
                    cmbRecept.Enabled = false;
                    txtDate.ReadOnly = true;
                    rtbKomentar.ReadOnly = true;
                    break;
                default:
                    break;
            }
        }
    }
}

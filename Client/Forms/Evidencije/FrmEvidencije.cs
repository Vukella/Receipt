using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Client.Forms.Evidencije
{
    public partial class FrmEvidencije : Form
    {
        class EvidencijaDgv
        {
            [Browsable(false)]
            public int IDEvidencija { get; set; }
            public string Datum { get; set; }
            public KategorijaJela KategorijaJela { get; set; }
            public string Komentar { get; set; }
            public Recept ReceptEvidencije { get; set; }

            public EvidencijaDgv(int id, string datum, KategorijaJela kategorija, string komentar, Recept recept)
            {
                IDEvidencija = id; 
                Datum = datum;
                KategorijaJela = kategorija;
                Komentar = komentar;
                ReceptEvidencije = recept; 
            }
        }
        public FrmEvidencije()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                EvidencijaDgv evidencijaDgv = (EvidencijaDgv)dgvEvidencije.SelectedRows[0].DataBoundItem;
                Evidencija evidencija = MapirajEvidenciju(evidencijaDgv);
                Communication.Instance.ObrisiEvidenciju(evidencija);
                RefreshDgV(); 
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void RefreshDgV()
        {
            var evidencije = (List<Evidencija>)Communication.Instance.UcitajEvidencije().Result;
            dgvEvidencije.DataSource = MapirajEvidencije(evidencije);
            dgvEvidencije.Refresh();
        }

        private void btnKreirajEvidenciju_Click(object sender, EventArgs e)
        {
            FrmEvidencijaDetalji frmEvidencija = new FrmEvidencijaDetalji(FormMode.Create);
            frmEvidencija.ShowDialog();
            RefreshDgV();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            EvidencijaDgv evidencijaDgv = (EvidencijaDgv)dgvEvidencije.SelectedRows[0].DataBoundItem;
            Evidencija evidencija = MapirajEvidenciju(evidencijaDgv);
            FrmEvidencijaDetalji frmEvidencija = new FrmEvidencijaDetalji(FormMode.Details,evidencija);
        }

        private Evidencija MapirajEvidenciju(EvidencijaDgv evidencijaDgv)
        {
            return new Evidencija()
            {
                IDEvidencija = evidencijaDgv.IDEvidencija,
                Datum = evidencijaDgv.Datum,
                KategorijaJela = evidencijaDgv.KategorijaJela,
                Komentar = evidencijaDgv.Komentar,
                ReceptEvidencije = evidencijaDgv.ReceptEvidencije
            };
        }

        private List<EvidencijaDgv> MapirajEvidencije(List<Evidencija> evidencije)
        {
            return evidencije.Select(e => new EvidencijaDgv(e.IDEvidencija, e.Datum, e.KategorijaJela, e.Komentar, e.ReceptEvidencije)).ToList();
        }

        private void FrmEvidencije_Load(object sender, EventArgs e)
        {
            var evidencije = (List<Evidencija>)Communication.Instance.UcitajEvidencije().Result;
            dgvEvidencije.DataSource = MapirajEvidencije(evidencije); 
        }
    }
}

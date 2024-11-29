using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmSastojci : Form
    {
         internal class SastojakDgv
         {
            [Browsable(false)]
            public int IDSastojak { get; set; }
            public string SasNaziv { get; set; }
            public SasVrsta SasVrsta { get; set; }
            public int KalorijskaVrednost { get; set; }

            public SastojakDgv(int id, string naziv, SasVrsta vrsta, int kalorijskaVrednost)
            {
                IDSastojak = id;
                SasNaziv = naziv;
                SasVrsta = vrsta;
                KalorijskaVrednost = kalorijskaVrednost;
            }
        }

        public FrmSastojci()
        {
            InitializeComponent();
        }

        private void FrmSastojci_Load(object sender, EventArgs e)
        {
            try
            {
                List<Sastojak> sastojci = (List<Sastojak>)Communication.Instance.UcitajSastojke().Result;
                dgvSastojci.DataSource = MapirajSastojke(sastojci);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server je ugasen!");
                throw;
            }
        }

        private List<SastojakDgv> MapirajSastojke(List<Sastojak> sastojci)
        {
            return sastojci.Select(s => new SastojakDgv (s.IDSastojak, s.SasNaziv, s.SasVrsta, s.KalorijskaVrednost)).ToList(); 
        }

        private void btnKreirajSastojak_Click(object sender, EventArgs e)
        {
            FrmSastojakDetalji frmDodajSastojak = new FrmSastojakDetalji(FormMode.Create); 
            frmDodajSastojak.ShowDialog();
            RefreshDgv(); 
        }

        private void RefreshDgv()
        {
            List<Sastojak> sastojci = (List<Sastojak>)Communication.Instance.UcitajSastojke().Result;
            dgvSastojci.DataSource = MapirajSastojke(sastojci);
            dgvSastojci.Refresh(); 
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string filter = txtPretrazi.Text; 
            List<Sastojak> sastojci = (List<Sastojak>)Communication.Instance.PretraziSastojke(filter).Result;
            dgvSastojci.DataSource = MapirajSastojke(sastojci);
            dgvSastojci.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                SastojakDgv sastojakDgv = (SastojakDgv)dgvSastojci.SelectedRows[0].DataBoundItem;
                Sastojak sastojak = MapirajSastojak(sastojakDgv);

                Communication.Instance.ObrisiSastojak(sastojak);
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite jedan sastojak.");
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                SastojakDgv sastojakDgv = (SastojakDgv)dgvSastojci.SelectedRows[0].DataBoundItem;
                Sastojak sastojak = MapirajSastojak(sastojakDgv);

                FrmSastojakDetalji frmAzuriraj = new FrmSastojakDetalji(FormMode.Update, sastojak);
                frmAzuriraj.ShowDialog();
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite jedan sastojak.");
            }
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                SastojakDgv sastojakDgv = (SastojakDgv)dgvSastojci.SelectedRows[0].DataBoundItem;
                Sastojak sastojak = MapirajSastojak(sastojakDgv);

                FrmSastojakDetalji frmDetalji = new FrmSastojakDetalji(FormMode.Details, sastojak);
                frmDetalji.ShowDialog();
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite jedan sastojak.");
            }
        }

        private Sastojak MapirajSastojak(SastojakDgv sastojakDgv)
        {
            return new Sastojak()
            {
                IDSastojak = sastojakDgv.IDSastojak,
                SasNaziv = sastojakDgv.SasNaziv,
                SasVrsta = sastojakDgv.SasVrsta,
                KalorijskaVrednost = sastojakDgv.KalorijskaVrednost
            };
        }
    }
}

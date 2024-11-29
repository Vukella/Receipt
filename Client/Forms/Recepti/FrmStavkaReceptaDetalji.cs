using Common.Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Forms.Recepti
{
    public partial class FrmStavkaReceptaDetalji : Form
    {
        public FormMode Mode { get; set; }
        public StavkaRecepta TrenutnaStavka { get; set; }
        public List<StavkaRecepta> ListaStavki { get; set; }
        public FrmStavkaReceptaDetalji(FormMode mode, StavkaRecepta stavka = null, List<StavkaRecepta> listaStavki = null)
        {
            InitializeComponent();
            Mode = mode;
            TrenutnaStavka = stavka;
            ListaStavki = listaStavki; 
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (Mode==FormMode.Update)
            {
                if ((int)numTrajanjeKoraka.Value == 0 || string.IsNullOrEmpty(rtbKorak.Text))
                {
                    MessageBox.Show("Popunite sva polja pre kreiranja stavke");
                    return;
                }
                if (cmbSastojak.SelectedIndex == -1 && cmbMasina.SelectedIndex == -1)
                {
                    MessageBox.Show("Pre kreiranja koraka je potrebno odabrati sastojak i alat");
                    return;
                }
                StavkaRecepta stavka = new StavkaRecepta()
                {
                    TekstKoraka = rtbKorak.Text,
                    TrajanjeStavkeUMin = (int)numTrajanjeKoraka.Value,
                    MasinaNaziv = ((Common.Domain.Masina)cmbMasina.SelectedItem).MasNaziv,
                    Masina = (Common.Domain.Masina)cmbMasina.SelectedItem,
                    PotrebniSastojak = (Sastojak)cmbSastojak.SelectedItem
                };
                Communication.Instance.AzurirajStavku(stavka);
                Close();
            } else if (Mode==FormMode.Create) 
            {
                if ((int)numTrajanjeKoraka.Value == 0 || string.IsNullOrEmpty(rtbKorak.Text))
                {
                    MessageBox.Show("Popunite sva polja pre kreiranja stavke");
                    return;
                }
                if (cmbSastojak.SelectedIndex == -1 && cmbMasina.SelectedIndex == -1)
                {
                    MessageBox.Show("Pre kreiranja koraka je potrebno odabrati sastojak i alat");
                    return;
                }
                StavkaRecepta stavka = new StavkaRecepta()
                {
                    TekstKoraka = rtbKorak.Text,
                    TrajanjeStavkeUMin = (int)numTrajanjeKoraka.Value,
                    MasinaNaziv = ((Common.Domain.Masina)cmbMasina.SelectedItem).MasNaziv,
                    Masina = (Common.Domain.Masina)cmbMasina.SelectedItem, 
                    PotrebniSastojak = (Sastojak)cmbSastojak.SelectedItem,
                };
                ListaStavki.Add(stavka);
                Close();
            }
            
        }

        private void FrmStavkaReceptaDetalji_Load(object sender, EventArgs e)
        {
            cmbMasina.DataSource = (List<Common.Domain.Masina>)Communication.Instance.UcitajMasine().Result;
            cmbSastojak.DataSource = (List<Sastojak>)Communication.Instance.UcitajSastojke().Result;

            cmbMasina.SelectedIndex = -1;
            cmbSastojak.SelectedIndex = -1;
            switch (Mode)
            {
                case FormMode.Update:
                    btnAction.Text = "Azuriraj stavku";
                    cmbMasina.SelectedItem = TrenutnaStavka.Masina;
                    cmbSastojak.SelectedItem = TrenutnaStavka.PotrebniSastojak;
                    rtbKorak.Text = TrenutnaStavka.TekstKoraka;
                    numTrajanjeKoraka.Value = TrenutnaStavka.TrajanjeStavkeUMin;
                    break;
                case FormMode.Create:
                    btnAction.Text = "Kreiraj stavku";
                    break;
                case FormMode.Details:
                    btnAction.Visible = false;

                    cmbMasina.SelectedItem = TrenutnaStavka.Masina;
                    cmbSastojak.SelectedItem = TrenutnaStavka.PotrebniSastojak;
                    rtbKorak.Text = TrenutnaStavka.TekstKoraka;
                    numTrajanjeKoraka.Value = TrenutnaStavka.TrajanjeStavkeUMin;

                    cmbMasina.Enabled = false;
                    cmbSastojak.Enabled = false;
                    rtbKorak.ReadOnly = true;
                    numTrajanjeKoraka.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}

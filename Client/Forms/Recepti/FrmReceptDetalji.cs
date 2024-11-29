using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client.Forms.Recepti
{
    public partial class FrmReceptDetalji : Form
    {
        internal class StavkaReceptaDgv
        {
            [Browsable(false)]
            public int IDRecepta { get; set; }
            [Browsable(false)]
            public int RedniBrojStavke { get; set; }
            public int TrajanjeStavkeUMin { get; set; }
            public string TekstKoraka { get; set; }
            public Sastojak PotrebniSastojak { get; set; }
            [Browsable(false)]
            public Common.Domain.Masina Masina { get; set; }
            public string MasinaNaziv { get; set; }

            public StavkaReceptaDgv(int iDRecepta, int redniBrojStavke, int trajanjeStavkeUMin, string tekstKoraka, Sastojak potrebniSastojak, string masinaNaziv, Common.Domain.Masina masina )
            {
                IDRecepta = iDRecepta;
                RedniBrojStavke = redniBrojStavke;
                TrajanjeStavkeUMin = trajanjeStavkeUMin;
                TekstKoraka = tekstKoraka;
                PotrebniSastojak = potrebniSastojak;
                MasinaNaziv = masinaNaziv;
                Masina = masina;
            }
        }
        public FormMode Mode { get; set; }
        public Recept TrenutniRecept { get; set; }
        public List<StavkaRecepta> StavkeRecepta { get; set; }
        public FrmReceptDetalji(FormMode mode, Recept recept = null)
        {
            InitializeComponent();
            Mode = mode;
            if (recept != null)
            {
                TrenutniRecept = recept;
                StavkeRecepta = recept.StavkeRecepta;
            }
            else
            {
                StavkeRecepta = new List<StavkaRecepta>();
            }
        }

        private void FrmReceptDetalji_Load(object sender, EventArgs e)
        {
            cmbTipObroka.DataSource = Enum.GetValues(typeof(TipObroka));
            switch (Mode)
            {
                case FormMode.Update:
                    txtNaziv.Text = TrenutniRecept.RecNaziv;                    
                    txtKcal.Text = TrenutniRecept.UkupanBrojKalorija.ToString();
                    txtPVP.Text = TrenutniRecept.PotrebnoVremePripreme.ToString();
                    txtKcal.ReadOnly = true;
                    txtPVP.ReadOnly = true;
                    cmbTipObroka.SelectedItem = TrenutniRecept.TipObroka;

                    List < StavkaRecepta > stavke = (List<StavkaRecepta>)Communication.Instance.UcitajStavke().Result;
                    List<StavkaRecepta> stavkeRecepta = stavke.Where(s => s.IDRecepta == TrenutniRecept?.IDRecept).ToList();
                    TrenutniRecept.StavkeRecepta = stavkeRecepta; 
                    dgvStavke.DataSource = MapirajStavke(stavkeRecepta);
                    dgvStavke.ReadOnly = true;
                    dgvStavke.ReadOnly = true;
                    dgvStavke.AllowUserToAddRows = false;
                    dgvStavke.AllowUserToDeleteRows = false;
                    dgvStavke.AllowUserToOrderColumns = false;


                    btnDodajStavkuRecepta.Visible = false;
                    btnAction.Text = "Azuriraj"; 
                    break;
                case FormMode.Create:
                    txtKcal.ReadOnly = true;
                    txtPVP.ReadOnly = true;
                    txtKcal.Text = "0";
                    txtPVP.Text = "0";
                    break;
                case FormMode.Details:
                    btnAction.Visible = false;
                    btnDodajStavkuRecepta.Visible = false;

                    txtKcal.Text = TrenutniRecept.UkupanBrojKalorija.ToString();
                    txtPVP.Text = TrenutniRecept.PotrebnoVremePripreme.ToString();
                    txtNaziv.Text = TrenutniRecept.RecNaziv;
                    txtKcal.ReadOnly = true;
                    txtPVP.ReadOnly = true;
                    txtNaziv.ReadOnly = true;

                    cmbTipObroka.SelectedItem = TrenutniRecept.TipObroka;
                    cmbTipObroka.Enabled = false;

                    List<StavkaRecepta> stavkice = (List<StavkaRecepta>)Communication.Instance.UcitajStavke().Result;
                    List<StavkaRecepta> stavkeRecept = stavkice.Where(s => s.IDRecepta == TrenutniRecept?.IDRecept).ToList();
                    TrenutniRecept.StavkeRecepta = stavkeRecept;
                    dgvStavke.DataSource = MapirajStavke(stavkeRecept);
                    dgvStavke.ReadOnly = true;
                    dgvStavke.ReadOnly = true;
                    dgvStavke.AllowUserToAddRows = false;
                    dgvStavke.AllowUserToDeleteRows = false;
                    dgvStavke.AllowUserToOrderColumns = false;
                    break;
                default:
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case FormMode.Update:

                    TrenutniRecept.RecNaziv = txtNaziv.Text;
                    TrenutniRecept.TipObroka = (TipObroka)cmbTipObroka.SelectedItem; 

                    Communication.Instance.AzurirajRecept(TrenutniRecept);
                    Close(); 
                    break;
                case FormMode.Create:
                    if (StavkeRecepta.Count == 0)
                    {
                        MessageBox.Show("Recept mora sadrzati barem jedan korak recepta");
                        return;
                    }
                    Recept recept = new Recept()
                    {
                        RecNaziv = txtNaziv.Text,
                        TipObroka = (TipObroka)cmbTipObroka.SelectedItem,
                        UkupanBrojKalorija = int.Parse(txtKcal.Text),
                        PotrebnoVremePripreme = int.Parse(txtPVP.Text),
                        StavkeRecepta = StavkeRecepta
                    };
                    Communication.Instance.KreirajRecept(recept);
                    Close();
                    break;
                case FormMode.Details:
                    break;
                default:
                    break;
            }
            
        }

        private void btnDodajStavkuRecepta_Click(object sender, EventArgs e)
        {
            FrmStavkaReceptaDetalji frmStavka = new FrmStavkaReceptaDetalji(FormMode.Create, listaStavki: StavkeRecepta);
            frmStavka.ShowDialog();
            RefreshDgv();
            if (StavkeRecepta.Count > 0)
            {
                txtKcal.Text = (int.Parse(txtKcal.Text) + StavkeRecepta.Last().PotrebniSastojak.KalorijskaVrednost).ToString();
                txtPVP.Text = (int.Parse(txtPVP.Text) + StavkeRecepta.Last().TrajanjeStavkeUMin).ToString();
            }
        }

        private void RefreshDgv()
        {
            switch (Mode)
            {
                case FormMode.Update:
                    List<StavkaRecepta> stavke = (List<StavkaRecepta>)Communication.Instance.UcitajStavke().Result;
                    List<StavkaRecepta> stavkeRecepta = stavke.Where(s => s.IDRecepta == TrenutniRecept?.IDRecept).ToList(); 
                    dgvStavke.DataSource = MapirajStavke(stavkeRecepta);
                    dgvStavke.Refresh();
                    break;
                case FormMode.Create:
                    dgvStavke.DataSource = MapirajStavke(StavkeRecepta);
                    dgvStavke.Refresh();
                    break;

                case FormMode.Details:
                    break;
                default:
                    break;
            }
        }

        private List<StavkaReceptaDgv> MapirajStavke(List<StavkaRecepta> stavke)
        {
            return stavke.Select(s => new StavkaReceptaDgv(s.IDRecepta,s.RedniBrojStavke, s.TrajanjeStavkeUMin ,s.TekstKoraka, s.PotrebniSastojak, s.MasinaNaziv, s.Masina)).ToList();
        }
        private StavkaRecepta MapirajStavku(StavkaReceptaDgv stavkaDgv)
        {
            return new StavkaRecepta()
            {
                IDRecepta = stavkaDgv.IDRecepta,
                RedniBrojStavke = stavkaDgv.RedniBrojStavke,
                TrajanjeStavkeUMin = stavkaDgv.TrajanjeStavkeUMin,
                TekstKoraka = stavkaDgv.TekstKoraka,
                PotrebniSastojak = stavkaDgv.PotrebniSastojak,
                Masina = stavkaDgv.Masina,
                MasinaNaziv = stavkaDgv.MasinaNaziv,
            };
        }

        private void btnAzurirajStavku_Click(object sender, EventArgs e)
        {
            try
            {
                StavkaReceptaDgv stavkaDgv = (StavkaReceptaDgv)dgvStavke.SelectedRows[0].DataBoundItem;
                StavkaRecepta stavka = MapirajStavku(stavkaDgv);
                FrmStavkaReceptaDetalji frmAzuriraj = new FrmStavkaReceptaDetalji(FormMode.Update, stavka: stavka);
                frmAzuriraj.ShowDialog();
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite jednu stavku.");
            }
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {
            try
            {
                StavkaReceptaDgv stavkaDgv = (StavkaReceptaDgv)dgvStavke.SelectedRows[0].DataBoundItem;
                StavkaRecepta stavka = MapirajStavku(stavkaDgv);

                Communication.Instance.ObrisiStavku(stavka);
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite jedan sastojak.");
            }
        }
    }
}

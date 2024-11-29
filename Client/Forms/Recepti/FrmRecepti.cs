using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Client.Forms.Recepti
{
    public partial class FrmRecepti : Form
    {
        internal class ReceptDgv
        {
            [Browsable(false)]
            public int IDRecept { get; set; }
            public string RecNaziv { get; set; }
            public TipObroka TipObroka { get; set; }
            public int PotrebnoVremePirpreme { get; set; } 
            public int UkupanBrojKalorija { get; set; } 

            [Browsable(false)]
            public List<StavkaRecepta> StavkeRecepta { get; set; }

            public ReceptDgv(int id, string naziv, TipObroka tipObroka, List<StavkaRecepta> stavkeRecepta, int trajanje, int kalorije)
            {
                IDRecept = id;
                RecNaziv = naziv;
                TipObroka = tipObroka;
                StavkeRecepta = stavkeRecepta;
                UkupanBrojKalorija = kalorije;
                PotrebnoVremePirpreme = trajanje; 
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                return IDRecept == ((ReceptDgv)obj).IDRecept;
            }

            public override int GetHashCode()
            {
                return IDRecept.GetHashCode();
            }
        }
        public FrmRecepti()
        {
            InitializeComponent();
        }

        private void btnKreirajSastojak_Click(object sender, EventArgs e)
        {
            FrmReceptDetalji frmDodajRecept = new FrmReceptDetalji(FormMode.Create);
            frmDodajRecept.ShowDialog();
            RefreshDgv();
        }

        private void RefreshDgv()
        {
            List<Recept> recepti = (List<Recept>)Communication.Instance.UcitajRecepte().Result;
            dgvRecepti.DataSource = MapirajRecepte(recepti);
            dgvRecepti.Refresh();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            try
            {
                ReceptDgv receptDgv = (ReceptDgv)dgvRecepti.SelectedRows[0].DataBoundItem;
                Recept recept = MapirajRecept(receptDgv);

                FrmReceptDetalji frmAzuriraj = new FrmReceptDetalji(FormMode.Update, recept);
                frmAzuriraj.ShowDialog();
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite jedan recept.");
            }
        }

        private Recept MapirajRecept(ReceptDgv receptDgv)
        {
            return new Recept()
            {
                IDRecept = receptDgv.IDRecept,
                RecNaziv = receptDgv.RecNaziv,
                TipObroka = receptDgv.TipObroka,
                PotrebnoVremePripreme = receptDgv.PotrebnoVremePirpreme, 
                UkupanBrojKalorija = receptDgv.UkupanBrojKalorija ,
                StavkeRecepta = receptDgv.StavkeRecepta
            };
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            string filter = txtPretrazi.Text;
            List<Recept> recepti = (List<Recept>)Communication.Instance.PretraziRecepte(filter).Result;
            dgvRecepti.DataSource = MapirajRecepte(recepti); 
            dgvRecepti.Refresh();
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                ReceptDgv receptDgv = (ReceptDgv)dgvRecepti.SelectedRows[0].DataBoundItem;
                Recept recept = MapirajRecept(receptDgv);

                FrmReceptDetalji frmDetalji = new FrmReceptDetalji(FormMode.Details, recept);
                frmDetalji.ShowDialog();
                RefreshDgv();
            }
            catch (Exception)
            {
                MessageBox.Show("Izaberite jedan recept.");
            }
        }

        private void FrmRecepti_Load(object sender, EventArgs e)
        {
            try
            {
                List<Recept> recepti = (List<Recept>)Communication.Instance.UcitajRecepte().Result;
                dgvRecepti.DataSource = MapirajRecepte(recepti);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server je ugasen");
                throw;
            }
        }

        private List<ReceptDgv> MapirajRecepte(List<Recept> recepti)
        {
            return recepti.Select(s => new ReceptDgv(s.IDRecept, s.RecNaziv, s.TipObroka, s.StavkeRecepta, s.PotrebnoVremePripreme, s.UkupanBrojKalorija)).Distinct().ToList();
        }


    }
}

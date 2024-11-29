using Common.Domain;
using System;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class FrmSastojakDetalji : Form
    {
        public FormMode Mode { get; set; }
        public Sastojak TrenutniSastojak { get; set; }

        public FrmSastojakDetalji(FormMode mode, Sastojak sastojak = null)
        {
            InitializeComponent();
            Mode = mode;
            TrenutniSastojak = sastojak;
        }

        private void FrmDodajSastojak_Load(object sender, EventArgs e)
        {
            cmbVrstaSastojka.DataSource = Enum.GetValues(typeof(SasVrsta));

            switch (Mode)
            {
                case FormMode.Update:
                    btnKreiraj.Text = "Azuriraj";
                    txtNaziv.Text = TrenutniSastojak.SasNaziv;
                    cmbVrstaSastojka.SelectedItem = TrenutniSastojak.SasVrsta;
                    numKalorijskaVrednost.Value = TrenutniSastojak.KalorijskaVrednost; 
                    break;
                case FormMode.Create:
                    btnKreiraj.Text = "Kreiraj"; 
                    break;
                case FormMode.Details:
                    btnKreiraj.Visible = false;

                    txtNaziv.Text = TrenutniSastojak.SasNaziv;
                    cmbVrstaSastojka.SelectedItem = TrenutniSastojak.SasVrsta;
                    numKalorijskaVrednost.Value = TrenutniSastojak.KalorijskaVrednost;

                    txtNaziv.ReadOnly = true;
                    cmbVrstaSastojka.Enabled = false;
                    numKalorijskaVrednost.Enabled = false; 
                    break;
                default:
                    break;
            }
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            if (Mode == FormMode.Create)
            {
                string naziv = txtNaziv.Text;
                SasVrsta sasVrsta = (SasVrsta)cmbVrstaSastojka.SelectedItem;
                int kalorijskaVrednost = (int)numKalorijskaVrednost.Value;

                Sastojak sastojak = new Sastojak()
                {
                    SasVrsta = sasVrsta,
                    SasNaziv = naziv,
                    KalorijskaVrednost = kalorijskaVrednost
                };

                Communication.Instance.KreirajSastojak(sastojak);
                Close();
            }
            else if (Mode == FormMode.Update)
            {
                string naziv = txtNaziv.Text;
                SasVrsta sasVrsta = (SasVrsta)cmbVrstaSastojka.SelectedItem;
                int kalorijskaVrednost = (int)numKalorijskaVrednost.Value;

                Sastojak sastojak = new Sastojak()
                {
                    IDSastojak = TrenutniSastojak.IDSastojak,
                    SasVrsta = sasVrsta,
                    SasNaziv = naziv,
                    KalorijskaVrednost = kalorijskaVrednost
                };

                Communication.Instance.AzurirajSastojak(sastojak);
                Close();
            }
        }
    }
}

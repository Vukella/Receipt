using System;
using System.Windows.Forms;

namespace Client.Forms.Masina
{
    public partial class FrmMasinaDetalji : Form
    {
        public FormMode Mode { get; set; }
        public Common.Domain.Masina TrenutnaMasina { get; set; }
        public FrmMasinaDetalji(FormMode mode, Common.Domain.Masina trenutnaMasina = null)
        {
            InitializeComponent();
            Mode = mode;
            TrenutnaMasina = trenutnaMasina;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            string naziv = txtNaziv.Text;
            Common.Domain.Masina masina = new Common.Domain.Masina() 
            {
                MasNaziv = naziv,
            };
            Communication.Instance.KreirajMasinu(masina);
            Close();
        }

        private void FrmMasinaDetalji_Load(object sender, EventArgs e)
        {
            switch (Mode)
            {
                case FormMode.Create:
                    btnCreate.Text = "Kreiraj";
                    break;
                case FormMode.Details:
                    btnCreate.Visible = false;
                    txtNaziv.Text = TrenutnaMasina.MasNaziv;
                    txtNaziv.ReadOnly = true;
                    break;
                default:
                    break;
            }
        }
    }
}

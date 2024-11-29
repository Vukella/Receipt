using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Client.Forms.Masina
{
    public partial class FrmMasine : Form
    {
        internal class MasinaDgv
        {
            [Browsable(false)]
            public int IdMasina { get; set; }
            public string MasNaziv { get; set; }

            public MasinaDgv(int idMasina, string masNaziv)
            {
                IdMasina = idMasina;
                MasNaziv = masNaziv;
            }
        }
        public FrmMasine()
        {
            InitializeComponent();
        }

        private void FrmMasine_Load(object sender, EventArgs e)
        {
            try
            {
                List<Common.Domain.Masina> masine = (List<Common.Domain.Masina>)Communication.Instance.UcitajMasine().Result;
                dgvMasine.DataSource = MapirajMasine(masine);
            }
            catch (Exception)
            {
                MessageBox.Show("Server je ugasen");
                throw;
            }
        }
        private void RefreshDgv()
        {
            List<Common.Domain.Masina> masine = (List<Common.Domain.Masina>)Communication.Instance.UcitajMasine().Result;
            try
            {
                dgvMasine.DataSource = MapirajMasine(masine);
                dgvMasine.Refresh();
            }
            catch (Exception)
            {
            }
        }

        private List<MasinaDgv> MapirajMasine(List<Common.Domain.Masina> masine)
        {
            return masine.Select(s => new MasinaDgv (s.IDMasina,s.MasNaziv)).ToList();
        }

        private void btnKreirajSastojak_Click(object sender, EventArgs e)
        {
            FrmMasinaDetalji frmDodajMasinu = new FrmMasinaDetalji(FormMode.Create);
            frmDodajMasinu.ShowDialog();
            RefreshDgv();
        }
    }
}

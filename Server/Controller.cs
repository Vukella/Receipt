using Common.Domain;
using Server.SystemOperation;
using Server.SystemOperation.SOEvidencija;
using Server.SystemOperation.SOMasina;
using Server.SystemOperation.SORecept;
using Server.SystemOperation.SOSastojak;
using Server.SystemOperation.SOStavkaRecepta;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    public class Controller
    {

        private static Controller instance;
        private string filter;

        public static Controller Instance
        {
            get
            {
                if(instance == null) instance = new Controller();
                return instance;
            }
        }
        private Controller() { }
        //Login
        internal User Login(User user)
        {
            LoginSO so = new LoginSO(user);
            so.ExecuteTemplate();
            return (User)so.result;
        }
        //Sastojak
        internal void AddIngredient(Sastojak argument)
        {
            KreirajSastojakSO so = new KreirajSastojakSO(argument);
            so.ExecuteTemplate();
        }

        internal List<Sastojak> SearchAllIngredients(bool allAttributes = false, string filter = "")
        {
            UcitajListuSastojakaSO so = new UcitajListuSastojakaSO(allAttributes, filter);
            so.ExecuteTemplate();
            return so.result.Cast<Sastojak>().ToList();
        }

        internal void UpdateIngredient(Sastojak argument)
        {
            IzmeniSastojakSO so = new IzmeniSastojakSO(argument);
            so.ExecuteTemplate();
        }

        internal List<Sastojak> GetAllIngredientsFilter(string argument)
        {
            NadjiSastjokeSO so = new NadjiSastjokeSO(argument);
            so.ExecuteTemplate() ;
            return so.result.Cast<Sastojak>().ToList() ;
        }

        internal Sastojak GetIngredientById(Sastojak argument)
        {
            UcitajSastojakSO so = new UcitajSastojakSO(argument);
            so.ExecuteTemplate();
            return (Sastojak)so.result;
        }
        //Masina
        internal void AddMachine(Masina argument)
        {
            KreirajMasinuSO so = new KreirajMasinuSO(argument);
            so.ExecuteTemplate();
        }

        internal List<Masina> SearchAllMachines(bool v = false)
        {
            UcitajListuMasinaSO so = new UcitajListuMasinaSO();
            so.ExecuteTemplate();
            return so.result.Cast<Masina>().ToList(); 
        }

        internal List<Masina> GetAllMachinesFilter(string argument)
        {
            NadjiMasineSO so = new NadjiMasineSO(argument);
            so.ExecuteTemplate();
            return so.result.Cast<Masina>().ToList();
        }

        internal Masina GetMachineById(Masina argument)
        {
            UcitajMasinuSO so = new UcitajMasinuSO(argument);
            so.ExecuteTemplate();
            return (Masina)so.result;
        }

        internal void DeleteIngredient(Sastojak argument)
        {
            ObrisiSastojakSO so = new ObrisiSastojakSO(argument);
            so.ExecuteTemplate();
        }
        //Recept
        internal void AddReceipt(Recept argument)
        {
            KreirajReceptSO so = new KreirajReceptSO(argument);
            so.ExecuteTemplate();
        }

        internal Recept GetReceiptById(Recept argument)
        {
            UcitajReceptSO so = new UcitajReceptSO(argument);
            so.ExecuteTemplate();
            return (Recept)so.result;
        }

        internal List<Recept> GetAllReceiptsFilter(string argument)
        {
            NadjiRecepteSO so = new NadjiRecepteSO(argument);
            so.ExecuteTemplate();
            return so.result.Cast<Recept>().ToList();
        }

        internal List<Recept> SearchAllReceipts(bool v = false)
        {
            UcitajListuRecepataSO so = new UcitajListuRecepataSO(v);
            so.ExecuteTemplate();
            return so.result.Cast<Recept>().ToList();
        }

        internal void UpdateReceipt(Recept argument)
        {
            IzmeniReceptSO so = new IzmeniReceptSO(argument);
            so.ExecuteTemplate();
        }

        internal void DeleteReceipt(Recept argument)
        {
            ObrisiReceptSO so = new ObrisiReceptSO(argument);
            so.ExecuteTemplate();
        }
        //Evidencija
        internal void AddEvidence(Evidencija argument)
        {
            KreirajEvidencijuSO so = new KreirajEvidencijuSO(argument);
            so.ExecuteTemplate();
        }

        internal List<Evidencija> SearchAllEvidences(bool v = false)
        {
            UcitajListuEvidencijaSO so = new UcitajListuEvidencijaSO(v);
            so.ExecuteTemplate();
            return so.result.Cast<Evidencija>().ToList();
        }

        internal List<Evidencija> GetAllEvidencesFilter(string argument)
        {
            NadjiEvidencijeSO so = new NadjiEvidencijeSO(argument);
            so.ExecuteTemplate();
            return so.result.Cast<Evidencija>().ToList();
        }

        internal Evidencija GetEvidenceById(Evidencija argument)
        {
            UcitajEvidencijuSO so = new UcitajEvidencijuSO(argument);
            so.ExecuteTemplate();
            return (Evidencija)so.result;
        }

        internal void DeleteEvidence(Evidencija argument)
        {
            ObrisiEvidencijuSO so = new ObrisiEvidencijuSO(argument);
            so.ExecuteTemplate();
        }

        internal void AddReceiptStep(StavkaRecepta argument)
        {
            KreirajStavkuReceptaSO so = new KreirajStavkuReceptaSO(argument);
            so.ExecuteTemplate();
        }

        internal void DeleteReceiptStep(StavkaRecepta argument)
        {
            ObrisiStavkuReceptaSO so = new ObrisiStavkuReceptaSO(argument);
            so.ExecuteTemplate();
        }

        internal void UpdateReceiptStep(StavkaRecepta argument)
        {
            IzmeniStavkuReceptaSO so = new IzmeniStavkuReceptaSO(argument);
            so.ExecuteTemplate();
        }

        internal List<StavkaRecepta> GetAllSteps()
        {
            UcitajListuStavkiReceptaSO so = new UcitajListuStavkiReceptaSO();
            so.ExecuteTemplate();
            return so.result.Cast<StavkaRecepta>().ToList();
        }
    }
}

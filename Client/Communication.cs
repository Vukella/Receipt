using Common.Communication;
using Common.Domain;
using System;
using System.Net.Sockets;
using System.Configuration;
using System.Collections.Generic;
using System.Collections;


namespace Client
{
    public class Communication
    {

        private static Communication _instance;
        public static Communication Instance { 
            get 
            {
                if( _instance == null ) _instance = new Communication();
                return _instance;
            } 
        }
        private Communication()
        {  
        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        public void Connect()
        {
            if ( socket == null || !socket.Connected) 
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
                sender = new Sender(socket);
                receiver = new Receiver(socket);
            }
        }

        internal void Close()
        {
            socket?.Close();
        }

        internal User Login(string username, string password)
        {
            User user = new User
            {
                Username = username,
                Password = password
            };
            Request req = new Request(Operation.Login, user);
            sender.Send(req);
            
            return (User)((Response)receiver.Receive()).Result;
        }


        public Response UcitajSastojke()
        {
            Request request = new Request(Operation.GetAllIngredientsSearch, null);
            sender.Send(request); 
            return (Response)receiver.Receive();
        }

        public Response KreirajSastojak(Sastojak sastojak)
        {
            Request request = new Request(Operation.CreateIngredient, sastojak);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        public Response PretraziSastojke(string filter)
        {
            Request request = new Request(Operation.SearchIngredients, filter);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        public void ObrisiSastojak(Sastojak sastojak)
        {
            Request request = new Request(Operation.DeleteIngredient, sastojak); 
            sender.Send(request);
            receiver.Receive();
        }

        public Response AzurirajSastojak(Sastojak sastojak)
        {
            Request request = new Request(Operation.UpdateIngredient, sastojak);
            sender.Send(request);
            return (Response)receiver.Receive();

        }

        internal Response UcitajMasine()
        {
            Request request = new Request(Operation.GetAllMachinesSearch, null);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal void KreirajMasinu(Masina masina)
        {
            Request request = new Request(Operation.CreateMachine, masina);
            sender.Send(request);
            receiver.Receive();
        }

        internal Response UcitajRecepte()
        {
            Request request = new Request(Operation.GetAllReceiptsSearch, null);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal Response PretraziRecepte(string filter)
        {
            Request request = new Request(Operation.GetAllReceiptsByName, filter);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal Response UcitajStavke()
        {
            Request request = new Request(Operation.GetAllSteps, null);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal void KreirajEvidenciju(Evidencija evidencija)
        {
            Request request = new Request(Operation.CreateEvidence, evidencija);
            sender.Send(request);
            receiver.Receive();
        }

        internal void ObrisiEvidenciju(Evidencija evidencija)
        {
            Request request = new Request(Operation.DeleteEvidence, evidencija);
            sender.Send(request);
            receiver.Receive();
        }

        internal Response UcitajEvidencije()
        {
            Request request = new Request(Operation.GetAllEvidenceSearch, null);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal void KreirajStavku(StavkaRecepta stavka)
        {
            Request request = new Request(Operation.CreateReceiptStep, stavka);
            sender.Send(request);
            receiver.Receive();
        }
        internal Response PretraziStavkeRecepta(Recept recept)
        {
            Request request = new Request(Operation.GetAllReceiptStepsSearch, recept);
            sender.Send(request);
            return (Response)receiver.Receive();
        }

        internal void AzurirajRecept(Recept recept)
        {
            Request request = new Request(Operation.UpdateReceipt, recept);
            sender.Send(request);
            receiver.Receive();
        }

        internal void ObrisiStavku(StavkaRecepta stavka)
        {
            Request request = new Request(Operation.DeleteReceiptStep, stavka);
            sender.Send(request);
            receiver.Receive();
        }

        internal void AzurirajStavku(StavkaRecepta stavka)
        {
            Request request = new Request(Operation.UpdateReceiptStep, stavka);
            sender.Send(request);
            receiver.Receive();
        }

        internal void KreirajRecept(Recept recept)
        {
            Request request = new Request(Operation.CreateReceipt, recept);
            sender.Send(request);
            receiver.Receive();
        }
    }
}

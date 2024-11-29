using Common.Communication;
using Common.Domain;
using System;
using System.Diagnostics;
using System.Net.Sockets;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;
        private Socket socket;

        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = (Request)receiver.Receive();
                    Response response = ProcessRequest(req);
                    sender.Send(response);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>>" + ex.Message);
                Server.clients.Remove(this);
                socket.Close();
            }
        }

        private Response ProcessRequest(Request req)
        {
            Response response = new Response();
            try
            {
                switch (req.Operation)
                {
                    case Operation.Login:
                        {
                            response.Result = Controller.Instance.Login((User)req.Argument);
                        }
                        break;
                    case Operation.CreateIngredient:
                        {
                            Controller.Instance.AddIngredient((Sastojak)req.Argument);
                            response.Message = "Sistem je uspesno kreirao sastojak";
                        }
                        break;
                    case Operation.GetAllIngredientsSearch:
                        {
                            if (req.Argument != null && (bool)req.Argument) response.Result = Controller.Instance.SearchAllIngredients();
                            else response.Result = Controller.Instance.SearchAllIngredients(true);
                        }
                        break;
                    case Operation.SearchIngredients:
                        {
                            if (!string.IsNullOrEmpty((string)req.Argument)) response.Result = Controller.Instance.SearchAllIngredients(filter: (string)req.Argument);
                            else response.Result = Controller.Instance.SearchAllIngredients(true);
                        }
                        break;
                    case Operation.DeleteIngredient:
                        {
                            Controller.Instance.DeleteIngredient((Sastojak)req.Argument);
                            response.Message = "Sitem je uspesno izbrisao sastojak";
                        }
                        break;
                    case Operation.UpdateIngredient:
                        {
                            Controller.Instance.UpdateIngredient((Sastojak)req.Argument);
                            response.Message = "Sistem je uspesno obrisao recept";
                        }
                        break;
                    case Operation.GetAllIngredientsByName:
                        {
                            response.Result = Controller.Instance.GetAllIngredientsFilter((string)req.Argument);
                        }
                        break;
                    case Operation.GetAllIngredientsById:
                        {
                            response.Result = Controller.Instance.GetIngredientById((Sastojak)req.Argument);
                        }
                        break;
                    case Operation.CreateMachine:
                        {
                            Controller.Instance.AddMachine((Masina)req.Argument);
                            response.Message = "Sistem je uspesno kreirao masinu";
                        }
                        break;
                    case Operation.GetAllMachinesSearch:
                        {
                            if (req.Argument != null && (bool)req.Argument) response.Result = Controller.Instance.SearchAllMachines(true);
                            else response.Result = Controller.Instance.SearchAllMachines();
                        }
                        break;
                    case Operation.GetAllMachinesByName:
                        {
                            response.Result = Controller.Instance.GetAllMachinesFilter((string)req.Argument);
                        }
                        break;
                    case Operation.GetAllMachinesById:
                        {
                            response.Result = Controller.Instance.GetMachineById((Masina)req.Argument);
                        }
                        break;
                    case Operation.CreateReceipt:
                        {
                            Controller.Instance.AddReceipt((Recept)req.Argument);
                            response.Message = "Sitem je uspesno kreirao recept";
                        }
                        break;
                    case Operation.GetAllReceiptsSearch:
                        {
                            if (req.Argument != null && (bool)req.Argument) response.Result = Controller.Instance.SearchAllReceipts(true);
                            else response.Result = Controller.Instance.SearchAllReceipts();
                        }
                        break;
                    case Operation.GetAllReceiptsByName:
                        {
                            response.Result = Controller.Instance.GetAllReceiptsFilter((string)req.Argument);
                        }
                        break;
                    case Operation.GetAllReceiptsById:
                        {
                            response.Result = Controller.Instance.GetReceiptById((Recept)req.Argument);
                        }
                        break;
                    case Operation.UpdateReceipt:
                        {
                            Controller.Instance.UpdateReceipt((Recept)req.Argument);
                            response.Message = "Sistem je uspesno izmenio recept";
                        }
                        break;
                    case Operation.CreateEvidence:
                        {
                            Controller.Instance.AddEvidence((Evidencija)req.Argument);
                            response.Message = "Sitem je uspesno kreirao recept";
                        }
                        break;
                    case Operation.DeleteEvidence:
                        Controller.Instance.DeleteEvidence((Evidencija)req.Argument);
                        response.Message = "Sitem je uspesno izbrisao evidenciju";
                        break;
                    case Operation.GetAllEvidenceSearch:
                        {
                            if (req.Argument != null && (bool)req.Argument) response.Result = Controller.Instance.SearchAllEvidences(true);
                            else response.Result = Controller.Instance.SearchAllEvidences();
                        }
                        break;
                    case Operation.GetAllEvidenceByName:
                        {
                            response.Result = Controller.Instance.GetAllEvidencesFilter((string)req.Argument);
                        }
                        break;
                    case Operation.GetAllEvidenceById:
                        {
                            response.Result = Controller.Instance.GetEvidenceById((Evidencija)req.Argument);
                        }
                        break;
                    case Operation.CreateReceiptStep:
                        {
                            Controller.Instance.AddReceiptStep((StavkaRecepta)req.Argument);
                            response.Message = "Sistem je uspesno kreirao stavku recepta";
                        }
                        break;
                    case Operation.DeleteReceiptStep: 
                        {
                            Controller.Instance.DeleteReceiptStep((StavkaRecepta)req.Argument);
                            response.Message = "Sitem je uspesno izbrisao stavku recepta";
                        }
                        break;
                    case Operation.UpdateReceiptStep: 
                        {
                            Controller.Instance.UpdateReceiptStep((StavkaRecepta)req.Argument);
                            response.Message = "Sitem je uspesno azurirao stavku recepta";
                        }
                        break;
                    case Operation.GetAllSteps: 
                        {
                            response.Result = Controller.Instance.GetAllSteps();
                            response.Message = "Sitem je uspesno uctitao stavke recepta";
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>>>>>> " + ex.Message);
                response.Message = ex.Message;
            }
            return response;
        }
        internal void Close()
        {
            socket?.Close();
        }
    }
}

using Common.Domain;


namespace Server.SystemOperation.SORecept
{
    internal class KreirajReceptSO : SystemOperationBase
    {
        private readonly Recept argument;

        public KreirajReceptSO(Recept argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            int recId = broker.ReturnIdAdd(argument);
            int brojac = 1; 

            foreach (StavkaRecepta stavka in argument.StavkeRecepta)
            {
                stavka.IDRecepta = recId;
                stavka.RedniBrojStavke = brojac++;
                broker.Add(stavka);
            }
        }
    }
}

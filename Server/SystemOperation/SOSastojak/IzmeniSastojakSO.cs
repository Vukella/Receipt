using Common.Domain;


namespace Server.SystemOperation.SOSastojak
{
    internal class IzmeniSastojakSO : SystemOperationBase
    {
        private Sastojak argument;

        public IzmeniSastojakSO(Sastojak sastojak)
        {
            this.argument = sastojak;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(argument);
        }
    }
}

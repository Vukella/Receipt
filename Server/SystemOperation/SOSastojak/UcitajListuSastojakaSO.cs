using Common.Domain;
using System.Collections.Generic;

namespace Server.SystemOperation.SOSastojak
{
    internal class UcitajListuSastojakaSO : SystemOperationBase
    {
        public List<IEntity> result {  get; set; }
        public bool ReadAll { get; set; }

        public string Filter { get; set; }
        public UcitajListuSastojakaSO(bool allAttributes = false, string filter = "")
        {
            ReadAll = allAttributes;
            Filter = filter;
        }
        protected override void ExecuteConcreteOperation()
        {
            if (ReadAll) 
            {
                result = broker.ReadAll(new Sastojak());
            }
            else result = broker.GetAllByFilter(new Sastojak(), Filter);
        }
    }
}

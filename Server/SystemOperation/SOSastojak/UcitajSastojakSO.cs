using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOSastojak
{
    internal class UcitajSastojakSO : SystemOperationBase
    {
        private readonly Sastojak argument;
        public IEntity result {  get; set; }

        public UcitajSastojakSO(Sastojak argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(argument);
        }
    }
}

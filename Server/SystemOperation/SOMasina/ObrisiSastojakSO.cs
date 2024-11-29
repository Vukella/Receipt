using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMasina
{
    internal class ObrisiSastojakSO : SystemOperationBase
    {
        private readonly Sastojak argument;

        public ObrisiSastojakSO(Sastojak argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(argument);
        }
    }
}

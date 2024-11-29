using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOStavkaRecepta
{
    internal class ObrisiStavkuReceptaSO : SystemOperationBase
    {
        private readonly StavkaRecepta argument;

        public ObrisiStavkuReceptaSO(StavkaRecepta argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(argument);
        }
    }
}

using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOStavkaRecepta
{
    internal class KreirajStavkuReceptaSO : SystemOperationBase
    {
        private readonly StavkaRecepta argument;

        public KreirajStavkuReceptaSO(StavkaRecepta argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(argument);
        }
    }
}

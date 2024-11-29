using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOStavkaRecepta
{
    internal class IzmeniStavkuReceptaSO : SystemOperationBase
    {
        private StavkaRecepta argument;

        public IzmeniStavkuReceptaSO(StavkaRecepta argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(argument);
        }
    }
}

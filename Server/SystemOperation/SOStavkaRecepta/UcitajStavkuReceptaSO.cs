using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOStavkaRecepta
{
    internal class UcitajStavkuReceptaSO : SystemOperationBase
    {
        private readonly StavkaRecepta argument;
        public IEntity result {  get; set; }

        public UcitajStavkuReceptaSO(StavkaRecepta argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(argument);
        }
    }
}

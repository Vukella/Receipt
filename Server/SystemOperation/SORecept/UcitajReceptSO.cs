using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SORecept
{
    internal class UcitajReceptSO : SystemOperationBase
    {
        private readonly Recept argument;
        public IEntity result {  get; set; }

        public UcitajReceptSO(Recept argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(argument);
        }
    }
}

using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SORecept
{
    internal class IzmeniReceptSO : SystemOperationBase
    {
        private Recept argument;

        public IzmeniReceptSO(Recept argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Update(argument);
        }
    }
}

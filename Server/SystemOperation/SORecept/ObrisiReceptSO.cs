using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SORecept
{
    internal class ObrisiReceptSO : SystemOperationBase
    {
        private readonly Recept argument;

        public ObrisiReceptSO(Recept argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(argument);
        }
    }
}

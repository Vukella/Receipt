using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOEvidencija
{
    internal class ObrisiEvidencijuSO : SystemOperationBase
    {
        private readonly Evidencija argument;

        public ObrisiEvidencijuSO(Evidencija argument)
        {
            this.argument = argument;
        }
        protected override void ExecuteConcreteOperation()
        {
            broker.Delete(argument);
        }
    }
}

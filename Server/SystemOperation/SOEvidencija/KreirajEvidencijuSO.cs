using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOEvidencija
{
    internal class KreirajEvidencijuSO : SystemOperationBase
    {
        private Evidencija argument;

        public KreirajEvidencijuSO(Evidencija argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(argument);
        }
    }
}

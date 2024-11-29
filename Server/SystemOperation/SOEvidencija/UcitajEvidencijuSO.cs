using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOEvidencija
{
    internal class UcitajEvidencijuSO : SystemOperationBase
    {
        private Evidencija argument;
        public IEntity result {  get; set; }
        public UcitajEvidencijuSO(Evidencija argument)
        {
            this.argument = argument;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(argument);    
        }
    }
}

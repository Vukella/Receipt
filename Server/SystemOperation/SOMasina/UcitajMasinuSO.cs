using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMasina
{
    internal class UcitajMasinuSO : SystemOperationBase
    {
        private readonly Masina argument;
        public IEntity result {  get; set; }
        public UcitajMasinuSO(Masina argument)
        {
            this.argument = argument;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(argument);
        }
    }
}

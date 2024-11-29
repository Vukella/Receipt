using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMasina
{
    internal class NadjiMasineSO : SystemOperationBase
    {
        private readonly string argument;
        public List<IEntity> result {  get; set; }

        public NadjiMasineSO(string argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAllByFilter(new Masina(), argument);
        }
    }
}

using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SORecept
{
    internal class NadjiRecepteSO : SystemOperationBase
    {
        private readonly string argument;
        public List<IEntity> result {  get; set; }

        public NadjiRecepteSO(string argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAllByFilter(new Recept(), argument);
        }
    }
}

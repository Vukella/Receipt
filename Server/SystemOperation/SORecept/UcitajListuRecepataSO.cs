using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SORecept
{
    internal class UcitajListuRecepataSO : SystemOperationBase
    {
        private bool ReadAll { get; set; }
        public List<IEntity> result { get; set; }

        public UcitajListuRecepataSO(bool allAttributes = false)
        {
            this.ReadAll = allAttributes;
        }

        protected override void ExecuteConcreteOperation()
        {
            if (ReadAll)
            {
                result = broker.ReadAll(new Recept());
            }
            else result = broker.ReadAllSearch(new Recept());
        }
    }
}

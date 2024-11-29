using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOStavkaRecepta
{
    internal class UcitajListuStavkiReceptaSO : SystemOperationBase
    {
        private bool ReadAll { get; set; }
        public List<IEntity> result { get; set; }

        public UcitajListuStavkiReceptaSO(bool allAttributes = false)
        {
            this.ReadAll = allAttributes;
        }

        protected override void ExecuteConcreteOperation()
        {
            if (ReadAll)
            {
                result = broker.ReadAll(new StavkaRecepta());
            }
            else result = broker.ReadAllSearch(new StavkaRecepta());
        }
    }
}

using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMasina
{
    internal class UcitajListuMasinaSO : SystemOperationBase
    {
        public List<IEntity> result;
        public bool ReadAll { get; set; }

        public UcitajListuMasinaSO(bool allAttributes = false)
        {
            ReadAll = allAttributes;
        }

        protected override void ExecuteConcreteOperation()
        {
            if (ReadAll)
            {
                result = broker.ReadAll(new Masina());
            }
            else result = broker.ReadAllSearch(new Masina());
        }
    }
}

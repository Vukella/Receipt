using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOEvidencija
{
    internal class UcitajListuEvidencijaSO : SystemOperationBase
    {
        private bool ReadAll;
        public List<IEntity> result { get; set; }
        public UcitajListuEvidencijaSO(bool v)
        {
            this.ReadAll = v;
        }

        protected override void ExecuteConcreteOperation()
        {
            if (ReadAll)
            {
                result = broker.ReadAll(new Evidencija());
            }
            else result = broker.ReadAllSearch(new Evidencija());
        }
    }
}

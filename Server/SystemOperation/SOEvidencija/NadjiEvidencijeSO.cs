using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOEvidencija
{
    internal class NadjiEvidencijeSO : SystemOperationBase
    {
        private readonly string filter;
        public List<IEntity> result { get; set; }

        public NadjiEvidencijeSO(string filter)
        {
            this.filter = filter;
        }

        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAllByFilter(new Evidencija(), filter);
        }
    }
}

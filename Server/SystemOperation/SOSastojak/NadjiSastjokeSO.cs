using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOSastojak
{
    internal class NadjiSastjokeSO : SystemOperationBase
    {
        public List<IEntity> result { get; set; }
        public readonly string Filter;
        public NadjiSastjokeSO(string filter) 
        {
            Filter = filter;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetAllByFilter(new Sastojak(), Filter);
        }
    }
}

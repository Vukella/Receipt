using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOSastojak
{
    internal class KreirajSastojakSO : SystemOperationBase
    {
        private readonly Sastojak sastojak;

        public KreirajSastojakSO(Sastojak sastojak)
        {
            this.sastojak = sastojak;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(sastojak);
        }
    }
}

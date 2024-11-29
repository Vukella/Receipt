using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SOMasina
{
    internal class KreirajMasinuSO : SystemOperationBase
    {
        private Masina argument;

        public KreirajMasinuSO(Masina argument)
        {
            this.argument = argument;
        }

        protected override void ExecuteConcreteOperation()
        {
            broker.Add(argument);
        }
    }
}

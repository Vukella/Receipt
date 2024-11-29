using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation
{
    public class LoginSO : SystemOperationBase
    {
        public IEntity result { get; set; }
        private readonly User user;
        public LoginSO(User user)
        {
            this.user = user;
        }
        protected override void ExecuteConcreteOperation()
        {
            result = broker.GetEntityById(user);
        }
    }
}

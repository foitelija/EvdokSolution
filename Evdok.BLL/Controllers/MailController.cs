using Evdok.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Controllers
{
    public class MailController : IMailController
    {
        public void sendCriticalErrorMessage(string message)
        {
            throw new NotImplementedException();
        }

        public void sendNoMailsClients(List<string> noNumbers, string mailTo)
        {
            throw new NotImplementedException();
        }

        public void sendNoNumberClients(List<string> noNumbers, string mailTo)
        {
            throw new NotImplementedException();
        }

        public void sendReceiveMoneyMessage(string messageBody, string mailTo)
        {
            throw new NotImplementedException();
        }

        public void sendXokTask(string mailTo)
        {
            throw new NotImplementedException();
        }
    }
}

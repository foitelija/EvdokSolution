using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Interfaces
{
    public interface IMailController
    {
        void sendXokTask(string mailTo);
        void sendNoNumberClients(List<string> noNumbers, string mailTo);
        void sendNoMailsClients(List<string> noNumbers, string mailTo);
        void sendReceiveMoneyMessage(string messageBody, string mailTo);
        void sendCriticalErrorMessage(string message);
    }
}

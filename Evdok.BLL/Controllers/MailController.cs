using Evdok.BLL.Interfaces;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
            MailAddress from = new MailAddress("RPA_Evdolim@alfa-bank.by");
            MailAddress to = new MailAddress("Mikalai.Prakopchyk@alfa-bank.by");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Клиенты без почты";

            string clients = "";

            foreach (var item in noNumbers)
            {
                clients += " " + item;
            }
            message.Body = clients;
            SmtpClient smtp = new SmtpClient("server", 25);
            smtp.Credentials = new NetworkCredential("RPA_Evdolim@alfa-bank.by", "");
            smtp.Send(message);
        }

        public void sendNoNumberClients(List<string> noNumbers, string mailTo)
        {
            MailAddress from = new MailAddress("RPA_Evdolim@alfa-bank.by");
            MailAddress to = new MailAddress("Mikalai.Prakopchyk@alfa-bank.by");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Клиенты без номеров";

            string clients = "";

            foreach(var item in noNumbers)
            {
                clients += " " + item;
            }
            message.Body = clients;
            SmtpClient smtp = new SmtpClient("server", 25);
            smtp.Credentials = new NetworkCredential("RPA_Evdolim@alfa-bank.by", "");
            smtp.Send(message);
        }

        public void sendReceiveMoneyMessage(string messageBody, string mailTo)
        {
            throw new NotImplementedException();
        }

        public void sendXokTask(string mailTo)
        {
            MailAddress from = new MailAddress("RPA_Evdolim@alfa-bank.by");
            MailAddress to = new MailAddress("Mikalai.Prakopchyk@alfa-bank.by");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "DC20DAF2-6EAE-4B6E-9956-B3B5CDA65B1F";
            message.Attachments.Add(new Attachment("fileUrl"));
            SmtpClient smtp = new SmtpClient(" ", 25);
            smtp.Credentials = new NetworkCredential("RPA_Evdolim@alfa-bank.by", "");
            smtp.Send(message);
        }
    }
}

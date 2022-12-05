using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Interfaces
{
    public interface IDialogFileController
    {
        string ReportFilePath { get; set; }
        bool OpenReportFileDialog();
        void SetReportPath(string filePath);


        string PhoneFilePath { get; set; }
        bool OpenPhoneFileDialog();
        void SetPhonePath(string filePath);



        string CsvFilePath { get; set; }
        bool OpenCsvFileDialog();
        void SetCsvPath(string filePath);


        void SetMail(string content);
        string MailAddress { get; set; }


        string CorpoInfoCsv { get; set; }
        bool OpenCorpoInfoCsv();
        void SetCorpoInfoCsv(string filePath);

        string CorpoInfoMidCsv { get; set; }
        bool OpenCorpoInfoMidCsv();
        void SetCorpoInfoMidCsv(string filePath);

    }
}

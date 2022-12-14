using Evdok.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Evdok.DLL.Models;
using Microsoft.Win32;
using System.IO;

namespace Evdok.BLL.Controllers
{
    public class DialogFileController : IDialogFileController, INotifyPropertyChanged
    {
        private string corpoInfoCsv = GetInfoCorpoPath();
        public string CorpoInfoCsv
        {
            get { return corpoInfoCsv; }
            set
            {
                corpoInfoCsv = value;
                OnPropertyChanged("CorpoInfoCsv");
            }
        }

        public bool OpenCorpoInfoCsv()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == true)
            {
                CorpoInfoCsv = openFileDialog.FileName;
                return true;
            }
            return false;
        }


        #region REPORT FILE
        private string reportFilePath = GetReportPath();
        public string ReportFilePath
        {
            get
            {
                return reportFilePath;
            }
            set
            {
                reportFilePath = value;
                OnPropertyChanged("ReportFilePath");
            }
        }
        public bool OpenReportFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ReportFilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }
        #endregion

        #region PHONE FILE
        private string phoneFilePath = GetPhonePath();
        public string PhoneFilePath
        {
            get
            {
                return phoneFilePath;
            }
            set 
            {
                phoneFilePath = value;
                OnPropertyChanged("PhoneFilePath");
            }
        }
        #endregion

        #region CSV FILE
        private string csvFilePath = GetCsvPath();
        public string CsvFilePath
        {
            get
            {
                return csvFilePath;
            }
            set
            {
                csvFilePath = value;
                OnPropertyChanged("CsvFilePath");
            }
        }
        #endregion

        public bool OpenCsvFileDialog()
        {
            System.Windows.Forms.FolderBrowserDialog openFileDlg = new System.Windows.Forms.FolderBrowserDialog();
            var result = openFileDlg.ShowDialog();
            if (result.ToString() != string.Empty)
            {
                CsvFilePath = openFileDlg.SelectedPath;
                return true;
            }
            return false;
        }

        public bool OpenPhoneFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                PhoneFilePath = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public void SetCsvPath(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(Config.csvFilePath, false, Encoding.Default))
            {
                writer.WriteLine(filePath);
            }
        }

        public void SetCorpoInfoCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(Config.corpoInfoPath, false, Encoding.Default))
            {
                writer.WriteLine(filePath);
            }
        }

        public void SetReportPath(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(Config.reportFilePath, false, Encoding.Default))
            {
                writer.WriteLine(filePath);
            }
        }

        public void SetPhonePath(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(Config.phoneFilePath, false, Encoding.Default))
            {
                writer.WriteLine(filePath);
            }
        }


        public void SetMail(string content)
        {
            using(StreamWriter writer = new StreamWriter(Config.mailFilePath, false, Encoding.Default))
            {
                writer.WriteLine(content);
            }
        }

        private string mailAddress = GetEmail();
        public string MailAddress
        {
            get
            {
                return mailAddress;
            }
            set
            {
                mailAddress = value;
                OnPropertyChanged("MailAddress");
            }
        }

        private string corpoInfoMidCsv = GetInfoCorpoMidPath();
        public string CorpoInfoMidCsv
        {
            get
            {
                return corpoInfoMidCsv;
            }
            set
            {
                corpoInfoMidCsv = value;
                OnPropertyChanged("CorpoInfoMidCsv");
            }
        }

        public static string GetInfoCorpoPath()
        {
            string filePath = Config.corpoInfoPath;
            string line;
            string path = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        path = line;
                    }
                }
            }
            return path;
        }

        #region ON PROPERTY CHANGED
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public static string GetEmail()
        {
            string filePath = Config.mailFilePath;
            string line;
            string content = string.Empty;

            if (File.Exists(filePath))
            {
                using(StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    while((line = sr.ReadLine())!= null)
                    {
                        content = line;
                    }
                }
            }
            return content;
        }        

        public static string GetReportPath()
        {
            string filePath = Config.reportFilePath;
            string line;
            string path = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        path = line;
                    }
                }
            }
            return path;
        }


        public static string GetPhonePath()
        {
            string filePath = Config.phoneFilePath;
            string line;
            string path = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        path = line;
                    }
                }
            }
            return path;
        }

        public static string GetCsvPath()
        {
            string filePath = Config.csvFilePath;
            string line;
            string path = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        path = line;
                    }
                }
            }
            return path;
        }

        public static string GetInfoCorpoMidPath()
        {
            string filePath = Config.corpoMidPath;
            string line;
            string path = string.Empty;

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        path = line;
                    }
                }
            }
            return path;
        }

        public bool OpenCorpoInfoMidCsv()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                CorpoInfoMidCsv = openFileDialog.FileName;
                return true;
            }
            return false;
        }

        public void SetCorpoInfoMidCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(Config.corpoMidPath, false, Encoding.Default))
            {
                writer.WriteLine(filePath);
            }
        }

        #endregion
    }
}

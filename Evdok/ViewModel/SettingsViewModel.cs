using Evdok.BLL.Interfaces;
using Evdok.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.ViewModel
{
    public class SettingsViewModel : ObservableObject
    {
        private IDialogFileController _dialogFile;
        public SettingsViewModel(IDialogFileController dialogFile)
        {
            _dialogFile = dialogFile;
        }
        public IDialogFileController DialogFileService
        {
            get { return _dialogFile; }
            set
            {
                _dialogFile = value;
            }
        }
        public RelayCommand OpenReportCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (_dialogFile.OpenReportFileDialog() == true)
                    {
                        _dialogFile.SetReportPath(_dialogFile.ReportFilePath);
                    }
                });
            }
        }

        public RelayCommand OpenCsvCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (_dialogFile.OpenCsvFileDialog() == true)
                    {
                        _dialogFile.SetCsvPath(_dialogFile.CsvFilePath);
                    }
                });
            }
        }
        public RelayCommand OpenPhoneCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (_dialogFile.OpenPhoneFileDialog() == true)
                    {
                        _dialogFile.SetPhonePath(_dialogFile.PhoneFilePath);
                    }
                });
            }
        }

        private string mailsForMessage;
        public string MailsForMessage
        {
            get { return mailsForMessage = _dialogFile.MailAddress; }
            set
            {
                mailsForMessage = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand MailCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _dialogFile.SetMail(mailsForMessage);
                });
            }
        }
    }
}

using Evdok.BLL.Interfaces;
using Evdok.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Evdok.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private string CorpoSegment = string.Empty;
        private string MiddleSegment = string.Empty;
        private string MassSegment = string.Empty;
        private string FinancialSegment = string.Empty;
        private string UnknownSegment = string.Empty;

        private readonly IWorkerController _workerService;
        IDialogFileController _dialogFile;

        public MainViewModel(IDialogFileController dialogFile, IWorkerController workerService)
        {
            _workerService = workerService;
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

        private RelayCommand openCsvCommand;
        public RelayCommand OpenCsvCommand
        {
            get
            {
                return openCsvCommand ?? new RelayCommand(obj =>
                {
                    if(_dialogFile.OpenCsvFileDialog() == true)
                    {
                        _dialogFile.SetCsvPath(_dialogFile.CsvFilePath);
                    }
                });
            }
        }

        private RelayCommand openPhoneCommand;
        public RelayCommand OpenPhoneCommand
        {
            get
            {
                return openPhoneCommand ?? new RelayCommand(obj =>
                {
                    if(_dialogFile.OpenPhoneFileDialog()== true)
                    {
                        _dialogFile.SetPhonePath(_dialogFile.PhoneFilePath);
                    }
                });
            }
        }

        private RelayCommand openReportCommand;
        public RelayCommand OpenReportCommand
        {
            get
            {
                return openReportCommand ?? new RelayCommand(obj =>
                {
                    if(_dialogFile.OpenReportFileDialog() == true)
                    {
                        _dialogFile.SetReportPath(_dialogFile.ReportFilePath);
                    }
                });
            }
        }


        private RelayCommand startCommand;
        public RelayCommand StartCommand
        {
            get
            {
                return startCommand ?? new RelayCommand(obj =>
                {
                    _workerService.EvdokimStartWork(MiddleSegment, CorpoSegment, MassSegment, FinancialSegment, UnknownSegment);
                });
            }
        }

        public RelayCommand ShutdownWindowCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Application.Current.Shutdown();
                });
            }
        }

        #region RelayCommands for segments
        private RelayCommand checkMediumCommand;
        public RelayCommand CheckMediumCommand
        {
            get
            {
                return checkMediumCommand ?? new RelayCommand(obj =>
                {
                    checkedMediumBusiness(obj);
                });
            }
        }

        private RelayCommand checkCorpoCommand;
        public RelayCommand CheckCorpoCommand
        {
            get
            {
                return checkCorpoCommand ?? new RelayCommand(obj =>
                {
                    checkCorporateBusiness(obj);
                });
            }
        }

        private RelayCommand checkMassCommand;
        public RelayCommand CheckMassCommand
        {
            get
            {
                return checkMassCommand ?? new RelayCommand(obj =>
                {
                    checkMassBusiness(obj);
                });
            }
        }

        private RelayCommand checkFinancialCommand;
        public RelayCommand CheckFinancialCommand
        {
            get
            {
                return checkFinancialCommand ?? new RelayCommand(obj =>
                {
                    checkFinancialBusiness(obj);
                });
            }
        }

        private RelayCommand checkUnknownCommand;
        public RelayCommand CheckUnknownCommand
        {
            get
            {
                return checkUnknownCommand ?? new RelayCommand(obj =>
                {
                    checkUnknowsBusiness(obj);
                });
            }
        }

        #endregion



        #region Private void for segments

        //средний сегмент бизнеса
        private void checkedMediumBusiness(object obj)
        {
            var checkbox = obj as CheckBox;
            if (checkbox.IsChecked.Value)
            {
                MiddleSegment = "Средний";
            }
            else
            {
                MiddleSegment = "False";
            }
        }

        //корпоративный сегмент
        private void checkCorporateBusiness(object obj)
        {
            var checkboxCorpo = obj as CheckBox;
            if (checkboxCorpo.IsChecked.Value)
            {
                CorpoSegment = "Корпоративный";
            }
            else
            {
                CorpoSegment = "False";
            }
        }

        private void checkMassBusiness(object obj)
        {
            var checkboxMass = obj as CheckBox;
            if (checkboxMass.IsChecked.Value)
            {
                MassSegment = "Массовый";
            }
            else
            {
                MassSegment = "False";
            }
        }

        private void checkFinancialBusiness(object obj)
        {
            var checkboxFinancial = obj as CheckBox;
            if (checkboxFinancial.IsChecked.Value)
            {
                FinancialSegment = "Финансовый";
            }
            else
            {
                FinancialSegment = "False";
            }
        }

        private void checkUnknowsBusiness(object obj)
        {
            var checkboxUnk = obj as CheckBox;
            if (checkboxUnk.IsChecked.Value)
            {
                UnknownSegment = "Неопределен";
            }
            else
            {
                UnknownSegment = "False";
            }
        }

        #endregion
    }
}

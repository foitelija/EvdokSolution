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

        public MainViewModel(IWorkerController workerService)
        {
            _workerService = workerService;
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
                MiddleSegment = "middle";
                MessageBox.Show(MiddleSegment + $"\n{nameof(checkedMediumBusiness)}");
            }
            else
            {
                MiddleSegment = "False";
                MessageBox.Show(MiddleSegment + $"\n{nameof(checkedMediumBusiness)}");
            }
        }

        //корпоративный сегмент
        private void checkCorporateBusiness(object obj)
        {
            var checkboxCorpo = obj as CheckBox;
            if (checkboxCorpo.IsChecked.Value)
            {
                CorpoSegment = "Corporate";
                MessageBox.Show(CorpoSegment + $"\n{nameof(checkCorporateBusiness)}");
            }
            else
            {
                CorpoSegment = "False";
                MessageBox.Show(CorpoSegment + $"\n{nameof(checkCorporateBusiness)}");
            }
        }

        private void checkMassBusiness(object obj)
        {
            var checkboxMass = obj as CheckBox;
            if (checkboxMass.IsChecked.Value)
            {
                MassSegment = "Mass";
                MessageBox.Show(MassSegment + $"\n{nameof(checkMassBusiness)}");
            }
            else
            {
                MassSegment = "False";
                MessageBox.Show(MassSegment + $"\n{nameof(checkMassBusiness)}");
            }
        }

        private void checkFinancialBusiness(object obj)
        {
            var checkboxFinancial = obj as CheckBox;
            if (checkboxFinancial.IsChecked.Value)
            {
                FinancialSegment = "Finance";
                MessageBox.Show(FinancialSegment + $"\n{nameof(checkFinancialBusiness)}");
            }
            else
            {
                FinancialSegment = "False";
                MessageBox.Show(FinancialSegment + $"\n{nameof(checkFinancialBusiness)}");
            }
        }

        private void checkUnknowsBusiness(object obj)
        {
            var checkboxUnk = obj as CheckBox;
            if (checkboxUnk.IsChecked.Value)
            {
                UnknownSegment = "Unknown";
                MessageBox.Show(UnknownSegment + $"\n{nameof(checkUnknowsBusiness)}");
            }
            else
            {
                UnknownSegment = "False";
                MessageBox.Show(UnknownSegment + $"\n{nameof(checkUnknowsBusiness)}");
            }
        }

        #endregion
    }
}

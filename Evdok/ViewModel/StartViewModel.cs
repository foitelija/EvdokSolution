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
    public class StartViewModel : ObservableObject
    {
        private readonly IWorkerController _workerController;
        private string CorpoSegment = string.Empty;
        private string MiddleSegment = string.Empty;
        private string MassSegment = string.Empty;
        private string FinancialSegment = string.Empty;
        private string UnknownSegment = string.Empty;
        
        public StartViewModel(IWorkerController workerController)
        {
            _workerController = workerController;
        }

        public RelayCommand StartCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    _workerController.EvdokimStartWork(MiddleSegment,CorpoSegment,MassSegment,FinancialSegment,UnknownSegment);
                });
            }
        }

        #region СЕГМЕНТЫ
        #region СРЕДНИЙ БИЗНЕС
        public RelayCommand CheckMediumCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    checkedMediumBusiness(obj);
                });
            }
        }
        private void checkedMediumBusiness(object obj)
        {
            var checkbox = obj as CheckBox;
            if (checkbox.IsChecked.Value)
            {
                MiddleSegment = "средний";
                MessageBox.Show($"{MiddleSegment}");
            }
            else
            {
                MiddleSegment = "empty";
                MessageBox.Show($"{MiddleSegment}");

            }
        }
        #endregion

        #region КОРПОРАТИВНЫЙ БИЗНЕС
        public RelayCommand CheckCorpoCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    checkCorporateBusiness(obj);
                });
            }
        }
        private void checkCorporateBusiness(object obj)
        {
            var checkboxCorpo = obj as CheckBox;
            if (checkboxCorpo.IsChecked.Value)
            {
                CorpoSegment = "корпоративный";
                MessageBox.Show($"{CorpoSegment}");
            }
            else
            {
                CorpoSegment = "empty";
                MessageBox.Show($"{CorpoSegment}");

            }
        }
        #endregion

        #region МАССОВЫЙ БИЗНЕС
        public RelayCommand CheckMassCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    checkMassBusiness(obj);
                });
            }
        }
        private void checkMassBusiness(object obj)
        {
            var checkboxMass = obj as CheckBox;
            if (checkboxMass.IsChecked.Value)
            {
                MassSegment = "массовый";
                MessageBox.Show($"{MassSegment}");

            }
            else
            {
                MassSegment = "empty";
                MessageBox.Show($"{MassSegment}");

            }
        }
        #endregion

        #region ФИНАНСОВЫЙ
        public RelayCommand CheckFinancialCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    checkFinancialBusiness(obj);
                });
            }
        }
        private void checkFinancialBusiness(object obj)
        {
            var checkboxFinancial = obj as CheckBox;
            if (checkboxFinancial.IsChecked.Value)
            {
                FinancialSegment = "финансовый";
                MessageBox.Show($"{FinancialSegment}");

            }
            else
            {
                FinancialSegment = "empty";
                MessageBox.Show($"{FinancialSegment}");

            }
        }
        #endregion

        #region НЕОПРЕДЕЛЁН
        public RelayCommand CheckUnknownCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    checkUnknowsBusiness(obj);
                });
            }
        }

        private void checkUnknowsBusiness(object obj)
        {
            var checkboxUnk = obj as CheckBox;
            if (checkboxUnk.IsChecked.Value)
            {
                UnknownSegment = "неопределен";
                MessageBox.Show($"{UnknownSegment}");

            }
            else
            {
                UnknownSegment = "empty";
                MessageBox.Show($"{UnknownSegment}");

            }
        }
        #endregion

        #endregion
    }
}

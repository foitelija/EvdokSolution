using Evdok.BLL.Interfaces;
using Evdok.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Evdok.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private string CorpoSegment = string.Empty;
        private string MiddleSegment = string.Empty;
        private string ClientSegment = string.Empty;

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
                    _workerService.EvdokimStartWork(MiddleSegment);
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

        private RelayCommand checkMediumCommand;
        public RelayCommand CheckMediumCommand
        {
            get
            {
                return checkMediumCommand ?? new RelayCommand(obj =>
                {
                    checkedMediumBissunes(obj);
                });
            }
        }

        private void checkedMediumBissunes(object obj)
        {
            var checkbox = obj as System.Windows.Controls.CheckBox;
            if (checkbox.IsChecked.Value)
            {
                MiddleSegment = "middle";
                MessageBox.Show(MiddleSegment);
            }
            else
            {
                MiddleSegment = "False";
                MessageBox.Show(MiddleSegment);
            }
        }
    }
}

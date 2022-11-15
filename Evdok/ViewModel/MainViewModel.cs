using Evdok.BLL.Interfaces;
using Evdok.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.ViewModel
{
    public class MainViewModel : ObservableObject
    {
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
                    _workerService.EvdokimStartWork();
                });
            }
        }
    }
}

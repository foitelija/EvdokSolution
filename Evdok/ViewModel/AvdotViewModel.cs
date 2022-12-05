using Evdok.BLL.Interfaces;
using Evdok.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.ViewModel
{
    public class AvdotViewModel
    {
        IDialogFileController _dialogFileController;

        public AvdotViewModel(IDialogFileController dialogFileController)
        {
            _dialogFileController = dialogFileController;
        }

        public IDialogFileController DialogFileService
        {
            get { return _dialogFileController; }
            set
            {
                _dialogFileController = value;
            }
        }

        public RelayCommand OpenCoproInfoCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (_dialogFileController.OpenCorpoInfoCsv() == true)
                    {
                        _dialogFileController.SetCorpoInfoCsv(_dialogFileController.CorpoInfoCsv);
                    }
                });
            }
        }

        public RelayCommand OpenCoproMidCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (_dialogFileController.OpenCorpoInfoMidCsv() == true)
                    {
                        _dialogFileController.SetCorpoInfoMidCsv(_dialogFileController.CorpoInfoMidCsv);
                    }
                });
            }
        }
    }
}

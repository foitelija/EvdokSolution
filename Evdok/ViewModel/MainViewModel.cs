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
        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand ShowSettingView { get; set; }
        public RelayCommand ShowStartView { get; set; }
        public RelayCommand ShowAvdotView { get; set; }
        private readonly IWorkerController _workerService;
        IDialogFileController _dialogFile;


        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public StartViewModel StartViewModel { get; set; }
        public SettingsViewModel SettingVM { get; set; }

        public AvdotViewModel AvdotVM { get; set; }

        public MainViewModel(IDialogFileController dialogFile, IWorkerController workerService)
        {
            _workerService = workerService;
            _dialogFile = dialogFile;
            
            StartViewModel = new StartViewModel(workerService);
            SettingVM = new SettingsViewModel(dialogFile);
            AvdotVM = new AvdotViewModel(dialogFile);
            CurrentView = SettingVM;

            MoveWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
            ShowSettingView = new RelayCommand(o => { CurrentView = SettingVM; });
            ShowStartView = new RelayCommand(o => { CurrentView = StartViewModel; });
            ShowAvdotView = new RelayCommand(o => { CurrentView = AvdotVM; });
        }

        public RelayCommand ShutdownWindowCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    if (MessageBox.Show("Выход из Евдокима приведёт к протере всех данных. \nВы дейсвительно хотите выйти?", "Подтвердите действие", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        Application.Current.Shutdown();
                    }
                });
            }
        }

        public RelayCommand MinimizeWindowCommand
        {
            get
            {
                return new RelayCommand(obj =>
                {
                    Application.Current.MainWindow.WindowState = WindowState.Minimized;
                });
            }
        }

    }
}

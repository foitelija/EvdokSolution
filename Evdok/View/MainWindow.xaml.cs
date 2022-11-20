using Evdok.BLL.Controllers;
using Evdok.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autofac;
using Autofac.Core;
using Evdok.BLL.Interfaces;

namespace Evdok
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IContainer _container;
        public MainWindow()
        {
            _container = Core.Container.config();
            InitializeComponent();
            var _excelController = _container.Resolve<IExcelController>();
            var _xokController = _container.Resolve<IXokController>();
            var _rkoController = _container.Resolve<IRkoController>();

            DataContext = new MainViewModel(new WorkerController(_excelController, _xokController, _rkoController));
        }
    }
}

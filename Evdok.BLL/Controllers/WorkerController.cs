using Evdok.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Evdok.BLL.Controllers
{
    public class WorkerController : IWorkerController
    {
        public Task EvdokimStartWork()
        {
            MessageBox.Show("Дошли до " + typeof(WorkerController));
            return null;
        }
    }
}

using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
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
        ExcelController _excelController = new ExcelController();

        List<ReportModel> _reportModels = new List<ReportModel>();

        public async Task EvdokimStartWork()
        {
            var reportResponse =  _excelController.readReportsFromExcelToModel();
            _reportModels = reportResponse;


        }
    }
}

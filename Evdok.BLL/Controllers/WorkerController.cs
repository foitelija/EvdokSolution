using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Evdok.BLL.Controllers
{
    public class WorkerController : IWorkerController
    {

        private readonly IExcelController _excelController;
        private readonly IXokController _xokController;
        private readonly IRkoController _rkoController;

        public WorkerController(IExcelController excelController, IXokController xokController, IRkoController rkoController)
        {
            _excelController = excelController;
            _xokController = xokController;
            _rkoController = rkoController;
        }

        string middleSegment = string.Empty;
        string corporateSegment = string.Empty;
        string massSegment = string.Empty;
        string financialSegment = string.Empty;
        string unknownSegment = string.Empty;

        public List<ReportModel> _reportModels;

        public async Task EvdokimStartWork(string Medium, string Corporate, string Mass, string Financial, string Unknown)
        {
            middleSegment = Medium;
            corporateSegment = Corporate;
            massSegment = Mass;
            financialSegment = Financial;
            unknownSegment = Unknown;

            var reportResponse = _excelController.readReportsFromExcelToModel();

            //var xokResponse = _xokController.XokModels(reportResponse);




            _reportModels = reportResponse;
        }
    }
}

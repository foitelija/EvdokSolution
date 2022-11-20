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
        SqlController _sqlController = new SqlController();

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
            var sqlQueryList = _sqlController.getValuesFromXokSqlDatabase("234006");


            _reportModels = reportResponse;
        }
    }
}

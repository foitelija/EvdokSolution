using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Ganss.Excel;
using NPOI.SS.Formula.Functions;

namespace Evdok.BLL.Controllers
{
    public class ExcelController : IExcelController
    {
        public List<ReportModel> reportModels;

        public ExcelController()
        {

        }

        public List<ReportModel> createReportModelEditedWithoutSameClients(List<ReportModel> reportModels, List<RkoModel> rkoModels)
        {
            throw new NotImplementedException();
        }

        public List<ReportModel> readReportsFromExcelToModel()
        {
            var reports = new ExcelMapper("D:\\Evdokimi\\Report.xlsx") { HeaderRow = false}.Fetch<ReportModel>().ToList();
            return reports;
        }
    }
}

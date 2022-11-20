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


        public List<ReportModel> createReportModelEditedWithoutSameClients(List<ReportModel> reportModels, List<RkoModel> rkoModels)
        {
            throw new NotImplementedException();
        }

        public List<NumbersModel> readNumbersFromExcelToModel()
        {
            var response = new ExcelMapper(DialogFileController.GetPhonePath()) { HeaderRow = true }.Fetch<NumbersModel>().ToList();
            return response;
        }

        public List<ReportModel> readReportsFromExcelToModel()
        {
            var reports = new ExcelMapper(DialogFileController.GetReportPath()) { HeaderRow = false}.Fetch<ReportModel>().ToList();
            return reports;
        }
    }
}

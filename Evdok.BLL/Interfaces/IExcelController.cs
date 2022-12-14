using Evdok.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Interfaces
{
    public interface IExcelController
    {
        List<ReportModel> readReportsFromExcelToModel();
        List<NumbersModel> readNumbersFromExcelToModel();
        List<ReportModel> createReportModelEditedWithoutSameClients(List<ReportModel> reportModels, List<RkoModel> rkoModels);
    }
}

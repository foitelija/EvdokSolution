using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Controllers
{
    public class ExcelController : IExcelController
    {
        public ExcelController()
        {

        }
        public Task<List<ReportModel>> readReportsFromExcelToModel()
        {
            throw new NotImplementedException();
        }
    }
}

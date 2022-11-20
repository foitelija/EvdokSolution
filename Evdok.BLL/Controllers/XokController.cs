using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Controllers
{
    public class XokController : IXokController
    {
        private readonly ISqlController _sqlController;

        public XokController(ISqlController sqlController)
        {
            _sqlController = sqlController;
        }

        public List<XokModel> XokModels(List<ReportModel> reportModelEditeds) // change to ReportModelEdited
        {
            //var sqlResponse = _sqlController.getValuesFromXokSqlDatabase("11111");

            throw new NotImplementedException();
        }
    }
}

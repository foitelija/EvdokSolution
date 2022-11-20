using Evdok.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Interfaces
{
    public interface IXokController
    {
        List<XokModel> XokModels(List<ReportModel> reportModelEditeds, string[] segments);
    }
}

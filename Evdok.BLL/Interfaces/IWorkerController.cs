using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Interfaces
{
    public interface IWorkerController
    {
        Task EvdokimStartWork(string Medium, string Corporate, string Mass, string Financial, string Unknown);
    }
}

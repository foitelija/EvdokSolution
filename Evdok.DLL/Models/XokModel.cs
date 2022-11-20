using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.DLL.Models
{
    public class XokModel
    {
        public string Dosk { get; set; }
        public string Id_client { get; set; }
        public string App_Number { get; set; } = "empty";
        public string Summa { get; set; } = "empty";
        public string Annotation { get; set; }
        public string Email { get; set; }
        public string Executor { get; set; }
    }
}

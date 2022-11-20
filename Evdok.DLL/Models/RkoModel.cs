using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.DLL.Models
{
    public class RkoModel
    {
        public string Curr { get; set; }
        public string Date { get; set; }
        public double Sum { get; set; }
        public string Base { get; set; }
        public string State { get; set; }

        public RkoModel(string curr = null, string date = null, double sum = 0, string @base = null, string state = null )
        {
            Curr = curr;
            Date = date;
            Sum = sum;
            Base = @base.Substring(12,6);
            State = state;
        }
    }
}

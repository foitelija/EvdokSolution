using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.DLL.Models
{
    public class ReportModel
    {
        [Column(4)]
        public string EqId { get; set; } = string.Empty;
        [Column(5)]
        public string ReceiptDate { get; set; } = string.Empty;
        [Column(6)]
        public string Currency { get; set; } = string.Empty;
        [Column(7)]
        public double ReceiptMoneyCount { get; set; }
        [Column(9)]
        public int DaysHavePassed { get; set; }
        [Column(13)]
        public string SpecialUnicode { get; set; } = string.Empty;
    }
}

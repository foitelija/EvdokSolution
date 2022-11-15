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
        [Column(Letter = "D")]
        private string EqId { get; set; } = string.Empty;
        [Column(Letter = "E")]
        private string ReceiptDate { get; set; } = string.Empty;
        [Column(Letter = "F")]
        private string Currency { get; set; } = string.Empty;
        [Column(Letter = "G")]
        private double ReceiptMoneyCount { get; set; }
        [Column(Letter = "I")]
        private int DaysHavePassed { get; set; }
        [Column(Letter = "M")]
        private string SpecialUnicode { get; set; } = string.Empty;
    }
}

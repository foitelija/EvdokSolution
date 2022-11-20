using Ganss.Excel;

namespace Evdok.DLL.Models
{
    public class ReportModelEdited
    {
        [Column(1)]
        public int Code1 { get; set; }
        [Column(2)]
        public int Code2 { get; set; }
        [Column(3)]
        public int Code3 { get; set; }
        [Column(4)]
        public string EqId { get; set; }
        [Column(5)]
        public string ReceiptDate { get; set; }
        [Column(6)]
        public string Currency { get; set; }
        [Column(7)]
        public double receiptMoneyCount { get; set; }
        [Column(8)]
        public string Note { get; set; }
        [Column(9)]
        public int DaysHadPassed { get; set; }
        [Column(10)]
        public string Department { get; set; }
        [Column(11)]
        public string ClientCompany { get; set; }
        [Column(12)]
        public string Responsible { get; set; }
        [Column(13)]
        public string SpecialUnicode { get; set; }
    }
}

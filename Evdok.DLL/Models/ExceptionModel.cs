using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganss.Excel;
namespace Evdok.DLL.Models
{
    public class ExceptionModel
    {
        [Column(Letter ="A")]
        public string EqID { get; set; }
        [Column(Letter ="B")]
        public string Remove { get; set; }
        [Column(Letter ="C")]
        public string Reason { get; set; }
        [Column(Letter ="D")]
        public string userXok { get; set; }
        [Column(Letter ="E")]
        public string fioXok { get; set; }
        [Column(Letter ="F")]
        public string segmentXok { get; set; }
        [Column(Letter = "J")]
        public string email { get; set; }
    }
}

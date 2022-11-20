using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ganss.Excel;

namespace Evdok.DLL.Models
{
    public class NumbersModel
    {
        [Column(Letter ="A")]
        public string EqID { get; set; }
        [Column(Letter ="B")]
        public string PhoneNumber { get; set; }
        [Column(Letter ="C")]
        public string Exception { get; set; }
        [Column(Letter ="D")]
        public string ExceptionReason { get; set; }
        [Column(Letter ="E")]
        public string EmailAddress { get; set; }
        [Column(Letter ="F")]
        public string Annotation { get; set; }
    }
}

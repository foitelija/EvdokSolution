using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
using Ganss.Excel;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
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

        public List<XokModel> XokModels(List<ReportModel> reportModelEditeds, string[] segments) // change to ReportModelEdited
        {
            List<ReportModel> model = reportModelEditeds;
            List<ReportModel> modelDTO = reportModelEditeds;
            List<XokModel> xokModel = new List<XokModel>();

            for (int i = 0; i < model.Count; i++)
            {
                string Doks = string.Empty;
                string Email = string.Empty;
                string Executor = string.Empty;
                string AnnotationString = string.Empty;

                string eqid = model[0].EqId;

                modelDTO = model.Where(x => x.EqId == eqid).ToList();
                var similarEntries = model.Where(e => modelDTO.FirstOrDefault(r => e.EqId == r.EqId && e.ReceiptDate == r.ReceiptDate) != null).ToList();

                if (similarEntries.Count != 1)
                {
                    foreach (var item in similarEntries)
                    {
                        AnnotationString += $"Сведения: \nПрошло: {item.DaysHadPassed} дней {item.ReceiptDate} {item.receiptMoneyCount} {item.Currency}.\n"; 
                    }
                }
                else
                {
                    foreach (var item in similarEntries)
                    {
                        AnnotationString = $"Сведения: \nПрошло: {item.DaysHadPassed} дней {item.ReceiptDate} {item.receiptMoneyCount} {item.Currency}.\n";

                    }
                }

                var sqlResponse = _sqlController.getValuesFromXokSqlDatabase(eqid);

                if (segments.Contains(sqlResponse[4]))
                {
                    Doks = "GomelBot";
                    Email = "GomelBot@tehprofile.by";
                    Executor = "abd5dd7e-a24c-0fed-5583-0f66a6679121";


                    xokModel.Add(new XokModel
                    {
                        Dosk = Doks,
                        Id_client = sqlResponse[0],
                        App_Number = "empty",
                        Summa = "empty",
                        Annotation = AnnotationString,
                        Email = Email,
                        Executor = Executor
                    });
                }
                else
                {
                    Doks = sqlResponse[1];
                    Email = sqlResponse[2];
                    Executor = "f38c7064-083d-206c-07af-af2be525db3d";

                    xokModel.Add(new XokModel
                    {
                        Dosk = Doks,
                        Id_client = sqlResponse[0],
                        App_Number = "empty",
                        Summa = "empty",
                        Annotation = AnnotationString,
                        Email = Email,
                        Executor = Executor
                    });
                }
                model.RemoveAll(x => x.EqId == eqid);
                i = 0;
            }

            //string xokListName = $"xokTask_{DateTime.Now.ToString("yyyy.MM.dd")}_{DateTime.Now.ToString("HH.mm.ss")}.xlsx";
            //new ExcelMapper().Save($"D:\\dotnetprojects\\EvdokSolution\\Evdok\\bin\\Debug\\Done\\{xokListName}", xokModel, "list1");


            return xokModel;
        }
    }
}

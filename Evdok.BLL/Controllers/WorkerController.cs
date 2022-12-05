using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Evdok.BLL.Controllers
{
    public class WorkerController : IWorkerController
    {

        private readonly IExcelController _excelController;
        private readonly IXokController _xokController;
        private readonly IRkoController _rkoController;
        private readonly IExceptionController _exceptionController;

        public WorkerController(IExcelController excelController, IXokController xokController, IRkoController rkoController, IExceptionController exceptionController)
        {
            _excelController = excelController;
            _xokController = xokController;
            _rkoController = rkoController;
            _exceptionController = exceptionController;
        }

        public List<ReportModel> _reportModels;

        public async Task EvdokimStartWork(string Medium, string Corporate, string Mass, string Financial, string Unknown)
        {
            try
            {
                string csvPath = File.ReadAllText(Config.csvFilePath).Replace("\r\n","");

                string text = "dawdawdawdaw";
                File.WriteAllText(Path.Combine(csvPath + "\\", "file.csv"), text);

                string[] xokSegmentMass = new string[] { Medium, Corporate, Mass, Financial, Unknown };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //var numbersResponse = _excelController.readNumbersFromExcelToModel(); // читаем файл Номера2.0

            //var reportResponse = _excelController.readReportsFromExcelToModel(); //Читай файл отчёта

            //var xokResponse = _xokController.XokModels(reportResponse, xokSegmentMass); // создаём список задач на постановку в Xok, но не отправляем их на почту.

            //var excResponse = _exceptionController.CreateLettersWithExceptions(xokResponse, numbersResponse);




            //_reportModels = reportResponse;
        }
    }
}

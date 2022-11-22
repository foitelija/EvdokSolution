using Evdok.BLL.Interfaces;
using Evdok.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Controllers
{
    public class ExceptionController : IExceptionController
    {
        List<ExceptionModel> IExceptionController.CreateLettersWithExceptions(List<XokModel> xoks, List<NumbersModel> numbers)
        {
            var gomelbotXok = xoks.Where(d =>
            {
                return d.Email.ToLower().Contains("gomelbot") || d.Dosk.ToLower().Contains("gomelbot");
            }).ToList();



            for (int i = 0; i < xoks.Count; i++)
            {
                string firstEqId = xoks[0].Id_client;


                //if (xok[0].Dosk.ToLower().Contains("gomelbot") || xok[0].Email.ToLower().Contains("gomelbot"))
                //{

                //}
                //else
                //{
                //    xok.RemoveAll(x => x.Id_client == firstEqId);
                //    i = 0;
                //    continue;
                //}
            }


            return null;
        }
    }
}

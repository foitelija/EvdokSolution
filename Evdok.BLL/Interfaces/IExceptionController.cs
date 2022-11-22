using Evdok.DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evdok.BLL.Interfaces
{
    public interface IExceptionController
    {
        List<ExceptionModel> CreateLettersWithExceptions(List<XokModel> xoks, List<NumbersModel> numbers);
    }
}

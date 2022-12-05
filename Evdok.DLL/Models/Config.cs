using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Evdok.DLL.Models
{
    public class Config
    {
        public static string reportFilePath = Path.Combine(Environment.CurrentDirectory, @"file\path.txt");
        public static string phoneFilePath = Path.Combine(Environment.CurrentDirectory, @"file\path2.txt");
        public static string csvFilePath = Path.Combine(Environment.CurrentDirectory, @"file\path3.txt");
        public static string mailFilePath = Path.Combine(Environment.CurrentDirectory, @"file\pathMail.txt");
        public static string corpoInfoPath = Path.Combine(Environment.CurrentDirectory, @"file\pathInfo.txt");
        public static string corpoMidPath = Path.Combine(Environment.CurrentDirectory, @"file\pathMid.txt");
    }
}

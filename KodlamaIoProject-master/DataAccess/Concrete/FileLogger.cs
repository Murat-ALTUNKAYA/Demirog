using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class FileLogger : ILogger
    {
        public void Log(string fileLogger)
        {
            Console.WriteLine("File Loglandi : " + fileLogger);
        }
    }
}

using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class SmsLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message+" gondeildi...");
        }
    }
}

using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class DataBaseLogger : ILogger
    {
        public void Log(string dataBaseLogger)
        {
            Console.WriteLine("DataBase-e Logglandi: "+dataBaseLogger);
        }
    }
}

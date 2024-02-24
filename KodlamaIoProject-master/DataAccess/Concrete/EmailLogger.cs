﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EmailLogger : ILogger
    {
        public void Log(string emailLogger)
        {
            Console.WriteLine("Email Loglandi: "+emailLogger);
        }
    }
}

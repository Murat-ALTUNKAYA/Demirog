using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("helloo baby");
            
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            short number3 = -32768;
            byte number4 = 255;
            bool condition = false;
            char character = 'a';
            string city = "Ankara";
            double number5 = 10.4;
            decimal number6 = 10.4m;
            Console.WriteLine("Number1 is {0}",number1);
            Console.ReadLine();
        }
        enum Days
        {
            Monday, Tuesday, Wednesday, Friday, Sunday, Saturday, Thursday
        }
    }
}

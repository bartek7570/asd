using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.WebService1 myMathService = new localhost.WebService1();
            Console.Write("2 + 4 =", myMathService.Add(2, 4));
        }
    }
}

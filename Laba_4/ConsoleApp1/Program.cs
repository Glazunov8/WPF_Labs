using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.Colculate("2 + 2 - 2 * 2 / 2"));
            Console.Read();
        }
    }
}

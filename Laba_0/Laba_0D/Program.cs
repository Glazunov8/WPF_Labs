using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_0D
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            try
            {
                a = checked(a + 1);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Было переполнение {0}", e.Message) ;
            }
            Console.Read();
        }
    }
}

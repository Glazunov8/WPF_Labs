using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_0
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj0 = new Angle(1, 2, 'N');
            Console.WriteLine("obj0");
            obj0.View();

            var obj1 = new Angle();
            Console.WriteLine("obj1");
            obj1.View();
            obj1.Edit();
            obj1.View();
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_0
{
    class Angle
    {
        public int degree;
        public float numberMinutes;
        public char direction;

        public Angle()
        {
            degree = 0;
            numberMinutes = 0;
            direction = 'S';
        }

        public Angle(int degree, float numberMinutes, char direction)
        {
            this.degree = degree;
            this.numberMinutes = numberMinutes;
            this.direction = direction;
        }

        public void Edit()
        {
            Console.WriteLine("Enter new degree: ");
            degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new numberMinutes: ");
            numberMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter new direction: ");
            direction = char.Parse(Console.ReadLine());
        }

        public void View()
        {
            Console.WriteLine("Degree: {0}\nNumber Minutes: {1}\nDirection: {2}\n", degree, numberMinutes, direction);
        }
    }
}

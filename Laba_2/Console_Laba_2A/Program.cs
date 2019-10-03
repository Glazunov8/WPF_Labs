using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Laba_2A
{
    class Program
    {
        static void Main(string[] args)
        {
            int e = 0;
            Console.WriteLine("1 - Круг\n2 - Прямоугольник\n3 - Квадрат\n0 - Выход");
            do
            {
                switch (e = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Радиус:");
                        var circle = new Circle(double.Parse(Console.ReadLine()));
                        circle.Show();
                        break;
                    case 2:
                        Console.WriteLine("Сторона А и B:");
                        var rect = new Rect(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                        rect.Show();
                        break;
                    case 3:
                        Console.WriteLine("Сторона:");
                        var square = new Square(double.Parse(Console.ReadLine()));
                        square.Show();
                        break;
                }
            }
            while (e != 0);
        }
    }
}

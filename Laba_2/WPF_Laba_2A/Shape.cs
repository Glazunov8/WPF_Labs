using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Laba_2A
{
    public class Shape
    {
            protected double P;
            protected double S;
            protected string Name;

            public Shape()
            {
                P = 0;
                S = 0;
                Name = "";
            }

            public string Show()
            {
                return $"Название:\t{Name}\nПериметр:\t{P}\nПлощадь:\t{S}\n";
            }
        }

        class Circle : Shape
        {
            public double R { get; }

            public Circle()
            {
                R = 0;
                Name = "Круг";
            }

            public Circle(double R)
            {
                this.R = R;
                Name = "Круг";
                Area();
                Perimeter();
            }

            public void Area()
            {
                S = Math.PI * R * R;
            }

            public void Perimeter()
            {
                P = Math.PI * R * 2;
            }
        }

        class Rect : Shape
        {
            public double A { get; }
            public double B { get; }

            public Rect()
            {
                A = 0;
                B = 0;
                Name = "Прямоугольник";
            }

            public Rect(double A, double B)
            {
                this.A = A;
                this.B = B;
                Name = "Прямоугольник";
                Area();
                Perimeter();
            }

            public void Area()
            {
                S = A * B;
            }

            public void Perimeter()
            {
                P = 2 * (A + B);
            }
        }

        class Square : Rect
        {
            public new double A { get; }

            public Square()
            {
                A = 0;
            }

            public Square(double A)
            {
                this.A = A;
            Name = "Квадрат";
                Area();
                Perimeter();
            }

            public new void Area()
            {
                S = A * A;
            }

            public new void Perimeter()
            {
                P = 4 * A;
            }

}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_0B
{
    class CupOfTea : HotDrink, ICup
    {
        protected string leafType = "черный";
        public string LeafType { get {return leafType; }
            set{
                if (value is string)
                    if (value.Equals("зеленый"))
                        leafType = value;
            }
        }
        protected string type = "пластик";
        public string Type
        {
            get { return type; }
            set
            {
                if (value is string)
                    if (value == "стекло")
                        type = value;
            }
        }
        protected double copacity = 0.2;
        public double Copacity { get { return copacity; }
            set {
                if (value <= 0.2) copacity = 0.2;
                if (value > 0.2) copacity = 0.3;
            }
        }

        public void Refill()
        {
            Console.WriteLine("Повторить чай {4} объемом {0}\n" +
                "Молоко: {1}\n" +
                "Сахар: {2}\n" +
                "Тип стакана: {3}\n", Copacity, Milk, Sugar, Type, leafType);
        }

        public void Wash()
        {
            Console.WriteLine("Вымыть {0} чашку с чаем\n", Type);
        }
    }
}

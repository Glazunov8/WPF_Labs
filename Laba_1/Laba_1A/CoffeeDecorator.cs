using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1A
{
    abstract class CoffeeDecorator : Coffee
    {
        protected Coffee coffee;

        public CoffeeDecorator(string name, Coffee coffee) : base(name)
        {
            this.coffee = coffee;
        }
    }

    class CoffeeWithMilk : CoffeeDecorator
    {
        public CoffeeWithMilk(Coffee coffee) : base(coffee.Name + ", c молоком", coffee) { }

        public override int GetCost()
        {
            return coffee.GetCost() + 5;
        }
    }

    class CoffeeWithSugar : CoffeeDecorator
    {
        public CoffeeWithSugar(Coffee coffee) : base(coffee.Name + ", c сахором", coffee) { }

        public override int GetCost()
        {
            return coffee.GetCost() + 10;
        }
    }
}

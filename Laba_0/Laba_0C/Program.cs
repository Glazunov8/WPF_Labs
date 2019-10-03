using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_0C
{
    struct Orders
    {
        public string itemName;
        public int unitCount;
        public double unitCost;

        public Orders(string itemName, int unitCount, double unitCost)
        {
            this.itemName = itemName;
            this.unitCount = unitCount;
            this.unitCost = unitCost;
        }

        public double Sum()
        {
            return unitCost * unitCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Orders();
            Console.WriteLine("Заказ: ");
            obj.itemName = Console.ReadLine();
            Console.WriteLine("Количество: ");
            obj.unitCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Стоимость: ");
            obj.unitCost = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------\n" +
                "Заказа: {0}\n" +
                "Количество: {1}\n" +
                "Цена за единицу: {2}\n" +
                "Общая стоимость: {3}\n", obj.itemName, obj.unitCount, obj.unitCost, obj.Sum());
            Console.ReadLine();
        }
    }
}

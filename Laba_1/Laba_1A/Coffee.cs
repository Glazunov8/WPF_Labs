using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba_1A
{
    abstract class Coffee
    {
        public string Name { get; protected set; }
        public abstract int GetCost();

        public Coffee(string Name)
        {
            this.Name = Name;
        }

        public Grid ChangeImage(Grid grid)
        {
            Image image = new Image
            {
                //Source = new BitmapImage(new Uri(@"C:\Users\glaz8\Desktop\C#\Laba_1\Laba_1A\Resource\" + Name + ".jpg"))
            };
            grid.Children.Clear();
            grid.Children.Add(image);
            return grid;
        }
    }

    /// <summary>
    /// ////////////////////////////////////////////////////////////////////////////
    /// </summary>

    class Cappuccino : Coffee
    {
        public Cappuccino() : base("Cappuccino") { }
        public override int GetCost()
        {
            return 50;
        }
    }

    class Americano : Coffee
    {
        public Americano() : base("Americano") { }
        public override int GetCost()
        {
            return 45;
        }
    }

    class Espresso : Coffee
    {
        public Espresso() : base("Espresso") { }
        public override int GetCost()
        {
            return 30;
        }
    }

    class Cacao : Coffee
    {
        public Cacao() : base("Cacao") { }
        public override int GetCost()
        {
            return 35;
        }
    }
}

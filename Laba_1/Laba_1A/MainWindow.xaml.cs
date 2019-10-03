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
    public partial class MainWindow : Window
    {
        Coffee drink = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void GiveMoney(object sender, RoutedEventArgs e)
        {
            if (Sum.Text == "")
                Sum.Text = Money.Text;
            else
                Sum.Text =( Convert.ToInt32(Sum.Text) + Convert.ToInt32(Money.Text)).ToString();
        }

        public void CoffeeImage(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            ChoiceObject();
            drink.ChangeImage(ImageCoffee);
            SumCost.Text = drink.GetCost().ToString();
        }

        public void ImageChecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Name == "Milk")
            {
                drink = new CoffeeWithMilk(drink);
                ImageMilk.Visibility = Visibility.Visible;
            }
            else
            {
                drink = new CoffeeWithSugar(drink);
                ImageSugar.Visibility = Visibility.Visible;
            }    
            SumCost.Text = drink.GetCost().ToString();
        }

        public void ImageUnChecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            ChoiceObject();
            if (checkBox.Name == "Milk")
            {
                if (Sugar.IsChecked == true)
                    drink = new CoffeeWithSugar(drink);
                ImageMilk.Visibility = Visibility.Hidden;
            }
            else
            {
                if (Milk.IsChecked == true)
                    drink = new CoffeeWithMilk(drink);
                ImageSugar.Visibility = Visibility.Hidden;
            }

            SumCost.Text = drink.GetCost().ToString();
        }

        public void ChoiceObject()
        {
            if (Americano.IsChecked == true)
                drink = new Americano();
            if (Cacao.IsChecked == true)
                drink = new Cacao();
            if (Cappuccino.IsChecked == true)
                drink = new Cappuccino();
            if (Espresso.IsChecked == true)
                drink = new Espresso();
        }

        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (int.Parse(Sum.Text) >= int.Parse(SumCost.Text))
                {
                    Change.Text = (int.Parse(Sum.Text) - int.Parse(SumCost.Text)).ToString();
                    MessageBox.Show("Операция успешно выполнена.");
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!!\n Вы внесли не достаточно средств!");
                }
            }
            catch(Exception)
            {
                Change.Text = "0";
            }
        }
    }
}

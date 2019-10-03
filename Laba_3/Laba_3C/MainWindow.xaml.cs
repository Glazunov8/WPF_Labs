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

namespace Laba_3C
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int X1;
        int Y1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(X1 ==  default(int) && Y1 == default(int))
            {
                X1 = (int)e.GetPosition(canvas).X - 4;
                Y1 = (int)e.GetPosition(canvas).Y - 4;
                canvas.Children.Add(new Ellipse
                {
                    Height = 8,
                    Width = 8,
                    Fill = Brushes.Black,
                    Margin = new Thickness(X1, Y1, 0, 0)
                });
                
            }
            else
            {
                canvas.Children.Add(new Line
                {
                    X1 = X1 + 4,
                    Y1 = Y1 + 4,
                    X2 = e.GetPosition(canvas).X,
                    Y2 = e.GetPosition(canvas).Y,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1
                });
                X1 = (int)e.GetPosition(canvas).X - 4;
                Y1 = (int)e.GetPosition(canvas).Y - 4;
                canvas.Children.Add(new Ellipse
                {
                    Height = 8,
                    Width = 8,
                    Fill = Brushes.LightGreen,
                    Margin = new Thickness(X1, Y1, 0, 0)
                });
            }
        }
    }
}

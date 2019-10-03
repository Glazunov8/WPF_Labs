using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace Laba_3A
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Click> clicks;

        class Click
        {
            public string KeyCode { get; set; }
            public string KeyValue { get; set; }
            public string KeyState { get; set; }
            public string KeyChar { get; set; }
            public string SystemKey { get; set; }
            public string KeyDown { get; set; }
            public string KeyUp { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            clicks = new ObservableCollection<Click>();
            Table.ItemsSource = clicks;
        }

        private void Table_KeyEvent(object sender, KeyEventArgs e)
        {
            int c = (int)e.Key;
            clicks.Add(new Click{
                KeyCode = e.Key.ToString(),
                KeyValue = c.ToString(),
                KeyState = e.KeyStates.ToString(),
                KeyChar = Convert.ToChar(c).ToString(),
                SystemKey = e.SystemKey.ToString(),
                KeyDown = e.IsDown.ToString(),
                KeyUp = e.IsUp.ToString()
            });

        }
    }
}

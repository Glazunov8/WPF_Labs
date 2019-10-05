using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;
//using System.Windows.Forms;
using System.Drawing.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba_4A
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int b = 1;
        int i = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var aFontsCollection = Fonts.SystemFontFamilies.Select(family => family.ToString()).ToList();
            aFontsCollection.Sort();

            var style = new Style(typeof(ComboBoxItem));
            var setter = new Setter(FontFamilyProperty, new Binding { Converter = new FontFamilyConvecter() });
            style.Setters.Add(setter);
            comboBox.ItemContainerStyle = style;

            comboBox.ItemsSource = aFontsCollection;
        }

        private void Bolt_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBox != null && b == 1)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            if(b == 2)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
            b ^= 3;
        }

        private void Italics_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBox != null && i ==1)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            if(i==2)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
            i ^= 3;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if(richTextBox != null)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, slider.Value);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            if (richTextBox != null && comboBox.SelectedValue != null)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, comboBox.SelectedValue);    
        }
    }
}

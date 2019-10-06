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

namespace Laba_4B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int b = 1;
        int i = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bolt_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBox != null && b == 1)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            if (b == 2)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
            b ^= 3;
        }

        private void Italics_Click(object sender, RoutedEventArgs e)
        {
            if (richTextBox != null && i == 1)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
            if (i == 2)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
            i ^= 3;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (richTextBox != null)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, slider.Value);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (FontFamily fontFamily in Fonts.SystemFontFamilies)
            {
                listBox.Items.Add(fontFamily.Source);
            }

            listBox.SelectedIndex = 0;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (richTextBox != null && listBox.SelectedValue != null)
                richTextBox.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, listBox.SelectedValue);
        }
    }
}

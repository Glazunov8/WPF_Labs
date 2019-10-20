using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Security;
using System.Windows.Controls;

namespace Laba_6D
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetTreeView(new DirectoryInfo("C:\\Users\\glaz8\\source\\repos"));
        }

        private void SetTreeView(DirectoryInfo dir, ItemCollection col = null)
        {
            try
            {
                if (col == null) col = treeView.Items;
                foreach (DirectoryInfo folder in dir.GetDirectories())
                {
                    var tvi = new TreeViewItem()
                    {
                        Header = new TextBlock()
                        {
                            Text = folder.Name,
                            Tag = folder.FullName,
                            
                        }
                    };
                    col.Add(tvi);
                    SetTreeView(folder, tvi.Items);
                }
            }
            catch (SecurityException) { }
            catch (DirectoryNotFoundException) { }
            catch (UnauthorizedAccessException) { }
        }

        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            object h = e.NewValue;
            var dir = new DirectoryInfo(((TextBlock)((TreeViewItem)h).Header).Tag.ToString());

            info.Text = "Attributes: " + dir.Attributes +
                "\nCreation Time: " + dir.CreationTime +
                "\nLast Opened: " + dir.LastAccessTime +
                "\nLast Edited: " + dir.LastWriteTime +
                "\nFull Name: " + dir.FullName +
                "\nName: " + dir.Name;
        }
    }
}

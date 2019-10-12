using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba_6A
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

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            listOfFiles.Items.Clear();
            listOfFiles.Visibility = Visibility.Visible;
            textBlock.Visibility = Visibility.Hidden;
            toZip.IsEnabled = false;
            var dir = new DirectoryInfo(way.Text);
            string file = obj.Text;
            FindInDir(dir, file, findInFolders.IsChecked.Value);

            if (listOfFiles.Items.Count == 0)
            {
                System.Windows.MessageBox.Show("Файлы не найдены");
            }
                
            if (listOfFiles.Items.Count == 1)
            {
                listOfFiles.Visibility = Visibility.Hidden;
                textBlock.Visibility = Visibility.Visible;
                toZip.IsEnabled = true;
                ReadFile((string)listOfFiles.Items[0]);
            }
                
        }

        private void FindInDir(DirectoryInfo dir, string pattern, bool recursive)
        {
            try
            {
                foreach (FileInfo file in dir.GetFiles(pattern))
                {
                    listOfFiles.Items.Add(file.FullName);
                }
                if (recursive)
                {
                    foreach (DirectoryInfo subdir in dir.GetDirectories())
                    {
                        FindInDir(subdir, pattern, recursive);
                    }
                }

            }
            catch (SecurityException) { }
            catch (DirectoryNotFoundException) { }
            catch (UnauthorizedAccessException) { }
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            var folderBrowser = new FolderBrowserDialog();
            DialogResult result = folderBrowser.ShowDialog();
            way.Text = folderBrowser.SelectedPath;
        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            way.Text = "";
            obj.Text = "";
            textBlock.Text = "";
            listOfFiles.Items.Clear();
        }

        private void ReadFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
            {
                textBlock.Text = streamReader.ReadToEnd();
            }
        }

        private void ToZip_Click(object sender, RoutedEventArgs e)
        {
            string startPath = (string)listOfFiles.Items[0];
            string path = startPath.Substring(0, startPath.IndexOf('.'));
            string pathToZip = path + ".zip";

            var dir = new DirectoryInfo(path);

            if(Directory.Exists(path))
            {
                dir.Delete();
            }
            dir.Create();
            File.Copy((string)listOfFiles.Items[0], dir.FullName+'\\' + obj.Text);
            ZipFile.CreateFromDirectory(path, pathToZip);
            if (Directory.Exists(path))
            {
                dir.Delete();
            }
            System.Windows.MessageBox.Show($"Успешно создан архив {pathToZip}");
        }

        private bool IsExist(string path)
        {
            var dirParent = new DirectoryInfo(path.Substring(0, path.LastIndexOf('\\')));
            foreach (var s in dirParent.GetDirectories())
                if (s.Name.Equals(obj.Text.Substring(0, obj.Text.IndexOf('.'))))
                    return false;
            return true;
        }
    }
}

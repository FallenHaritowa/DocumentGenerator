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
using Microsoft.Win32;

namespace Document_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreatePatternButton_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void FileSelectButton_Click(object sender, RoutedEventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.DefaultExt = ".docx";
        //    dialog.Filter = "Word documents| *.docx;*.doc";
        //    if (dialog.ShowDialog() == true)
        //    {
        //        FileNameTextBox.Text = dialog.FileName;
        //    }
        //}
    }
}

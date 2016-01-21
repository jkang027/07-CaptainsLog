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
using CaptainsLog.Core;
using System.Collections.ObjectModel;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<LogEntry> logEntries = new ObservableCollection<LogEntry>();

        public MainWindow()
        {
            InitializeComponent();

            dataGrid.ItemsSource = logEntries;
        }
        
        //New Log Entry
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            NewEntryWindow entryWindow = new NewEntryWindow();
            entryWindow.Show();
        }

        //Delete Log Entry
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            DeleteEntryWindow deleteWindow = new DeleteEntryWindow();
            deleteWindow.Show();
        }

        //Menu Click Close
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            CaptainsLogMainWindow.Close();
        }

        //Menu Click New
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow newFile = new MainWindow();
            newFile.Show();
        }

        //Menu Click Open
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {

        }

        //Menu Click Save
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {

        }

        //Menu Click Save As
        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {

        }
    }
}

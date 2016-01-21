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
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using CaptainsLog.Core;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for NewEntryWindow.xaml
    /// </summary>
    public partial class NewEntryWindow : Window
    {
        public NewEntryWindow()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            LogEntry newLog = new LogEntry();
            newLog.EntryDate = DateTime.Now;
            newLog.Id = LogEntry.IdCounter;
            newLog.Title = textBoxTitle.Text;
            newLog.Text = textBoxText.Text;
            MainWindow.logEntries.Add(newLog);

            NewEntry.Close();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            NewEntry.Close();
        }
    }
}

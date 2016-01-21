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
using CaptainsLog.Core;

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for ConfirmDeletionWindow.xaml
    /// </summary>
    public partial class ConfirmDeletionWindow : Window
    {
        public ConfirmDeletionWindow()
        {
            InitializeComponent();

            textBlock.Text = "Are you sure you want to delete log ID #" + DeleteEntryWindow.idNumberParse + "?";
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int entryId = DeleteEntryWindow.idNumberParse;
            LogEntry entry;

            for (int i = 0; i < MainWindow.logEntries.Count; i++)
            {
                if (MainWindow.logEntries[i].Id == entryId)
                {
                    entry = MainWindow.logEntries[i];
                    MainWindow.logEntries.Remove(entry);
                }
                else
                {
                    if (i == MainWindow.logEntries.Count - 1)
                    {
                        MessageBox.Show("That entry does not exist");
                    }
                }
            }
            ConfirmDeletion.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ConfirmDeletion.Close();
        }
    }
}

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

namespace CaptainsLog
{
    /// <summary>
    /// Interaction logic for DeleteEntryWindow.xaml
    /// </summary>
    public partial class DeleteEntryWindow : Window
    {
        public DeleteEntryWindow()
        {
            InitializeComponent();
        }

        public static int idNumberParse;

        //Cancel button
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DeleteEntry.Close();
        }

        //Delete button
        private void button_Click(object sender, RoutedEventArgs e)
        {
            string deleteIdNumber = textBox.Text;
            try
            {
                idNumberParse = int.Parse(deleteIdNumber);
                ConfirmDeletionWindow confirm = new ConfirmDeletionWindow();
                confirm.Show();
                DeleteEntry.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show("That is an invalid number. Input the log ID number (Ex. \"123\").");
            }
        }
    }
}
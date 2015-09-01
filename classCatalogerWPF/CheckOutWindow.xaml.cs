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
using System.Text.RegularExpressions;

namespace classCatalogerWPF
{
    /// <summary>
    /// Interaction logic for CheckOutWindow.xaml
    /// </summary>
    public partial class CheckOutWindow : Window
    {
        Book currentBook;
        public CheckOutWindow(ref Book currentBook)
        {
            InitializeComponent();
            this.currentBook = currentBook;
            //may not need to have a check for null, this is just an example.
            if (currentBook != null)
            {
                selectedBookLabel.Content = currentBook.title; 
            } 
        }

        private void durationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String myStr = durationComboBox.SelectedItem.ToString();
            myStr = myStr.Replace("days", "");

            currentBook.checkOutDur = Convert.ToInt32(myStr);
            //cant figure this out yet
        }

        private void dueDateReminderCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            currentBook.reminder = true;
        }

        private void finalCheckOutButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(checkOutToTextBox.Text))
            {
                currentBook.studentName = checkOutToTextBox.Text;
                currentBook.checkedOut = true;
                currentBook.checkOutDate = DateTime.Now;
                this.Close();
            }
            else
            {
                //add a label underneath checkOutToTextBox and set its content to ""
                //then when checkouttotextbox is null or empty add 
                //youmessedupLabel.background = color.red
                //then change the text to You must enter a student name
            }
            
        }
    }
}

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

namespace classCatalogerWPF
{
    /// <summary>
    /// Interaction logic for CheckOutWindow.xaml
    /// </summary>
    public partial class CheckOutWindow : Window
    {
        public CheckOutWindow(ref Book currentBook)
        {
            InitializeComponent();
            selectedBookLabel.Content = currentBook.title; 
        }

        private void durationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void dueDateReminderCheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void finalCheckOutButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

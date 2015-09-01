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
using System.Collections.ObjectModel;

namespace classCatalogerWPF
{
    public static class Shared
    {
        public static ObservableCollection<Book> bookList = new ObservableCollection<Book>();
        
       
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Shared.bookList.CollectionChanged+=bookList_CollectionChanged; //check if the collection has changed
            checkOverDue();
         }

        private void checkOverDue()
        {
            // put date and time stuff here.
            foreach (Book b in Shared.bookList)
            {
                if(b.IsOverdue())
                {
                    //I’m overdue!
                }
            }
        }

        private void bookList_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            //event handler for if booklist changes
 	        //    throw new NotImplementedException();
            libraryListBox.Items.Clear(); //clear the booklist
            foreach(var libraryBook in Shared.bookList)
            {
                libraryListBox.Items.Add(libraryBook.title);//add each book that is in the collection back to the listbox
            }
            
        }
        private void addABookButton_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow secondForm = new AddBookWindow();// create a new window object
            secondForm.Show();//show new window object

        }

        private void libraryListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String theBookStr = libraryListBox.SelectedItem.ToString();
                 //make a string variable for the selected item in libraryListBox
            Book theBook = Shared.bookList.Where(x => x.title == theBookStr).First();
                 //make a variable of a book object  where the title == theBookStr
                 //this makes a list of all the books with that title. .First() is saying
                 //show the first object with the name == theBookStr
            statusLabel.Content = theBook.checkedOut == true ? "Checked out" : "available";
                 // stringvalue = condition == true ? then this value : otherwise this;
        }

        private void checkOutButton_Click(object sender, RoutedEventArgs e)
        {
            String theBookStr = libraryListBox.SelectedItem.ToString();
            Book theBook = Shared.bookList.Where(x => x.title == theBookStr).First();
            CheckOutWindow checkOutForm = new CheckOutWindow(ref theBook);
            checkOutForm.Show();
        }
        
    }
}

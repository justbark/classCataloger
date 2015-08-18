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
        
    }
}

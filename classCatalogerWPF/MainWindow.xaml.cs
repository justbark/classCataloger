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

namespace classCatalogerWPF
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

        AddBookWindow secondForm = new AddBookWindow();// create a new window object
                                             // a website showed me to put this here.
        private void addABookButton_Click(object sender, RoutedEventArgs e)
        {
            secondForm.Show();//show new window object
            Book newBook = new Book();// create a new book

            newBook.author = secondForm.authorTextBox.Text;
            newBook.title = secondForm.titleTextBox.Text;
            newBook.editor = secondForm.editorTextBox.Text;
            newBook.date = secondForm.dateTextBox.Text;

            bookList.Add(newBook);
            this.Close();

        }
    }
}

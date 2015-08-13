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
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
        }


        private void finalAddBookButton_Click(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book();// create a new book

            newBook.author = authorTextBox.Text;
            newBook.title = titleTextBox.Text;
            newBook.editor = editorTextBox.Text;
            newBook.date = dateTextBox.Text;

            Shared.bookList.Add(newBook);
            this.Close();
        }
    }
}

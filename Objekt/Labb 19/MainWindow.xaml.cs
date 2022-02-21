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

namespace Labb_19
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
    }
    public class Media
    {
        public string Title { get; set; }
        public Media(string title)
        {
            Title = title;
        }

    }

    public class Movie : Media
    {
        public string Director { get; set; }
        public string Lenght { get; set; }
        public Movie(string title, string director, string lenght) : base(title)
        {
            Director = director;
            Lenght = lenght;
        }
        public void TillText()
        {

        }
    }
    public class Book : Media
    {
        public string Author { get; set; }
        public string NrOfPages { get; set; }
        public Book(string title, string author, string nrofpages) : base(title)
        {
            Author = author;
            NrOfPages = nrofpages;
        }
        public void TillText()
        {

        }
    }
}

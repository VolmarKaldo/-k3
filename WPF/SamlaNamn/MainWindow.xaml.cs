using System.Reflection;
using System.IO;
using System.Runtime.CompilerServices;
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

namespace SamlaNamn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global lista
        List<string> namnLista = new List<string>();
        public MainWindow()
        {

            InitializeComponent();
        }

        private void ClickLäggTill(object sender, RoutedEventArgs e)
        {
            //Läs av rutaNamn
            string namn = rutaNamn.Text;
            //Om den inte är tom, lägg till i rutaLista

            //Och lagra i en lista
            if (namn != "")
            {
                rutaLista.Text += $"{namn}\n";
                namnLista.Add(namn);
            }
            else
            {
                rutaFel.Text = "Fältet är tomt.";
            }
        }
        private void ClickSpara(Object sender, RoutedEventArgs e)
        {
            File.WriteAllLines("namnlista.txt", namnLista);
            rutaFel.Text = "Namnen sparade i namnlista.txt";
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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

namespace SökaLand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string[] rader;

        public MainWindow()
        {
            InitializeComponent();
            // Läs in alla rader från textfilen countries.csv
            rader = File.ReadAllLines("./countries.csv");
        }

        ///<summary>
        ///Det som händer när användaren klivkar på Sök
        ///</summary>
        private void ClickSök(Object sender, RoutedEventArgs e)
        {
            string sökterm = rutaSökterm.Text;
            int antal = 1;

            // Loopa igenom alla rader
            foreach (var rad in rader)
            {
                // Dela upp raden
                string[] delar = rad.Split(',');

                // Plocka ut land
                string land = delar[1];

                // Plocka ut landskod
                string landskod = delar[2];

                // Hitta land som innehåller sökterm se https://www.geeksforgeeks.org/c-sharp-string-contains-method/
                if (land.ToLower().Contains(sökterm.ToLower()))
                {
                    // Skriv ut matchande land och dess landskod
                    rutaResultat.Text += ($"{antal} {land}: {landskod} \n");
                    antal++;
                }
            }
        }
    }
}

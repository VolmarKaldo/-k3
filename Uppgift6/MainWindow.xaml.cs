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

namespace Uppgift6
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
        public float summa = 0;
        public int antalTal = 0;
        private void knappAdderaClick(object sender, RoutedEventArgs e)
        {
            bool ärKorrektInmatat = true;
            float tal;
            if (!float.TryParse(talRuta.Text, out tal))
            {
                MessageBox.Show("Fel inmatning.");
                ärKorrektInmatat = false;
            }
            if (ärKorrektInmatat)
            {
                summaRuta.Text = $"{summa} + {tal} = {summa + tal}";
                summa = tal + summa;
                antalTal += 1;
                medelRuta.Text = $"{summa} / {antalTal} = {summa / antalTal}";
            }
        }
    }
}

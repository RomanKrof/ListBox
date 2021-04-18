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

namespace ListBox
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Lidi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Jmeno j = Jmeno.ListOfLidi[Lidi.SelectedIndex];
            DataContext = j;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Lidi.SelectedIndex = 0;
        }

        public MainWindow()
        {
            InitializeComponent();

            Jmeno.ListOfLidi.Add(new Jmeno { PJmeno = "Roman", Prijmeni = "Krof", Vek = new DateTime(2002, 12, 17), RodneCis = "999999/999" });

            Jmeno.ListOfLidi.Add(new Jmeno { PJmeno = "Carlos", Prijmeni = "Punto", Vek = new DateTime(1958, 1, 9), RodneCis = "888888/888" });

            Jmeno.ListOfLidi.Add(new Jmeno { PJmeno = "Jakub", Prijmeni = "Mihalovič", Vek = new DateTime(2002, 12, 17), RodneCis = "777777/777" });

            Jmeno.ListOfLidi.Add(new Jmeno { PJmeno = "Igor", Prijmeni = "Bogdan", Vek = new DateTime(1988, 5, 30), RodneCis = "666666/666" });

            Jmeno.ListOfLidi.Add(new Jmeno { PJmeno = "Miloš", Prijmeni = "Zeman", Vek = new DateTime(1944, 9, 28), RodneCis = "555555/555" });

            Lidi.DataContext = Jmeno.ListOfLidi;
        }      
    }
}

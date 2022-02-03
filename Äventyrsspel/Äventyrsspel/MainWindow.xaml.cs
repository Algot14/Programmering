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

namespace Äventyrsspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            nuvarande_rum = new Room("Du befinner dig i Hallen, framför dig har du en skattskista som är låst med två nycklar, hitta dom två nycklarna genom att navigera dig genom dom olika rummen men knapparna och öppna kistan!");
            Room rum1 = new Room("Du har kommit till en återvändsgräns, det finns ingan nycklar i dethär rummet!");
            Room rum2 = new Room("Du har kommit till köket, här finns inga nycklar men du kan fortsätta söder för att utforska nya rum!");
            Room rum3 = new Room("Du befinner dig nu i vardagsrummet!");
            Room rum4 = new Room("Du är nu i Källaren, Här finns en nyckel!, ta tillbaks nyckeln till Hallen och sätt in den i nyckelhålet!");
            Room rum5 = new Room("Du har kommit till Garaget, här finns inga nycklar!");
            Room rum6 = new Room("Du har kommit till Övervåningen, här finns inga nycklar!");
            Room rum7 = new Room("Nu befinner du dig på Vinden, här finns en nyckel!, ta tillbaks nyckeln till Hallen och sätt in den i nyckelhålet!");
            
        }

        private Room nuvarande_rum;

        private void Norr_Click(object sender, RoutedEventArgs e)
        {
            Norr.Visibility = Visibility.Hidden;
            Väster.Visibility = Visibility.Hidden;
            Öster.Visibility = Visibility.Hidden;
            Keyhole1.Visibility = Visibility.Hidden;
            Keyhole2.Visibility = Visibility.Hidden;
            Chest.Visibility = Visibility.Hidden;

        }

        private void Väster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Öster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Söder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Keyhole2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Keyhole1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Chest_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

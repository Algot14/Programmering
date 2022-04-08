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

            nuvarande_rum.Norr = rum1;
            nuvarande_rum.Öster = rum6;
            nuvarande_rum.Väster = rum2;
            nuvarande_rum.Söder = rum5;

            rum1.Söder = nuvarande_rum;

            rum2.Öster = nuvarande_rum;
            rum2.Söder = rum3;

            rum3.Öster = rum5;
            rum3.Söder = rum4;

            rum4.Norr = rum3;

            rum5.Norr = nuvarande_rum;
            rum5.Väster = rum3;

            rum6.Väster = nuvarande_rum;
            rum6.Öster = rum7;

            rum7.Väster = rum6;




        }

        private Room nuvarande_rum;
        private int key = 0;

     

        

        private void changeRoom()
        {
            Norr.Visibility = nuvarande_rum.Norr == null ? Visibility.Hidden : Visibility.Visible;
            Väster.Visibility = nuvarande_rum.Väster == null ? Visibility.Hidden : Visibility.Visible;
            Öster.Visibility = nuvarande_rum.Öster == null ? Visibility.Hidden : Visibility.Visible;
            Söder.Visibility = nuvarande_rum.Söder == null ? Visibility.Hidden : Visibility.Visible;
            
        }



        private void Norr_Click(object sender, RoutedEventArgs e)
        {
            nuvarande_rum = nuvarande_rum.Norr;
            Beskrivning.Text = nuvarande_rum.Beskrivning;
            changeRoom();
        }

        private void Väster_Click(object sender, RoutedEventArgs e)
        {
            
            nuvarande_rum = nuvarande_rum.Väster;
            Beskrivning.Text = nuvarande_rum.Beskrivning;
            changeRoom();
        }

        private void Öster_Click(object sender, RoutedEventArgs e)
        {
            nuvarande_rum = nuvarande_rum.Öster;
            Beskrivning.Text = nuvarande_rum.Beskrivning;
            changeRoom();
        }

        private void Söder_Click(object sender, RoutedEventArgs e)
        {
            nuvarande_rum = nuvarande_rum.Söder;
            Beskrivning.Text = nuvarande_rum.Beskrivning;
            changeRoom();
        }

        private void Keyhole2_Click(object sender, RoutedEventArgs e)
        {
            Keyhole2.Visibility = key == 1 ? Visibility.Hidden : Visibility.Visible;
        }

        private void Keyhole1_Click(object sender, RoutedEventArgs e)
        {
            Keyhole1.Visibility = key == 1 ? Visibility.Hidden : Visibility.Visible;
        }

        private void Chest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Key_Click(object sender, RoutedEventArgs e)
        {
            key = 1;
        }
    }
}

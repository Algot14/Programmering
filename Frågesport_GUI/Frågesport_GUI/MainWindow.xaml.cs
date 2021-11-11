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

namespace Frågesport_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kortlek frågor = new Kortlek();
        public MainWindow()
        {
            InitializeComponent();

            
        }


        private void startKnapp_Click(object sender, RoutedEventArgs e)
        {
            ModerKort mittKort = frågor.Drakort();
            fråga.Text = mittKort.Fråga;
            förstaSida.Children.Remove(startKnapp);
            förstaSida.Children.Remove(välkommen);
            förstaSida.Children.Remove(emptySpace);
            svar1.Content = mittKort.GetSvar();
            List<String> Flersvar = ((Flersvar)mittKort).Getflersvar();
            svar2.Content = Flersvar[0];
            svar3.Content = Flersvar[1];
            svar4.Content = Flersvar[2];
        }
    }
}

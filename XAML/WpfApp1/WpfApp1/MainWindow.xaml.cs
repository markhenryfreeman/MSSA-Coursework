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

namespace DisplaySettingsMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Loadout loadout1 = new Loadout();
        Loadout loadout2 = new Loadout();
        Loadout loadout3 = new Loadout();
        Loadout loadout4 = new Loadout();
        Loadout currentLoadout = new Loadout();

        public bool isLoadout1 = true;
        public bool isLoadout2 = false;
        public bool isLoadout3 = false;
        public bool isLoadout4 = false;

        public MainWindow()
        {
            InitializeComponent();
            currentLoadout = loadout1;
            DataContext = currentLoadout;
        }

        private void chooseLoadout1(object sender, RoutedEventArgs e)
        {
            if (isLoadout2)
            {
                loadout2 = currentLoadout;
                currentLoadout = loadout1;
                isLoadout1 = true;
            }
            else if (isLoadout3)
            {

            }

        }

        private void chooseLoadout2(object sender, RoutedEventArgs e)
        {

        }

        private void chooseLoadout3(object sender, RoutedEventArgs e)
        {

        }

        private void chooseLoadout4(object sender, RoutedEventArgs e)
        {

        }

        //private void HintsOn(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Easy(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Medium(object sender, RoutedEventArgs e)
        //{

        //}

        //private void Hard(object sender, RoutedEventArgs e)
        //{

        //}

    }

    public class Loadout : INotifyPropertyChanged
    {
        //Fields
        private double brightness;
        private bool easy;
        private bool medium;
        private bool hard;
        private string resolution;
        private bool hints;

        public event PropertyChangedEventHandler PropertyChanged;

        public void changeLoadout(string property = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        //Properties
        public double Brightness
        {
            get { return brightness; }
            set { brightness = value; changeLoadout("Brightness"); }
        }

        public bool Easy
        {
            get { return easy; }
            set { easy = value; changeLoadout("Easy"); }
        }
        public bool Medium
        {
            get { return medium; }
            set { medium = value; changeLoadout("Medium"); }
        }
        public bool Hard
        {
            get { return hard; }
            set { hard = value; changeLoadout("Easy"); }
        }

        public string Resolution
        {
            get { return resolution; }
            set { resolution = value; }
        }

        public bool Hints
        {
            get { return hints; }
            set { hints = value; changeLoadout("Hints"); }
        }


        //Constructor
        public Loadout(double brightness = 100, bool easy = false, bool medium = true, bool hard = false, string resolution = "1920x1080p", bool hints = false)
        {
            this.brightness = brightness;
            this.easy = easy;
            this.medium = medium;
            this.hard = hard;
            this.resolution = resolution;
            this.hints = hints;
        }
    }
}

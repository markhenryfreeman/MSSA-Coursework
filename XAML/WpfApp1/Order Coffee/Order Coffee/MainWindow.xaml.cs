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
using System.ComponentModel;

namespace Order_Coffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        coffee coffee = new coffee();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = coffee;
        }

        public string size = "small";
        public string sugar;
        public string cream;
        public string type = "frappe";
        public string order;

        public string with;
        public string and;
        public bool _sugar;
        public bool _cream;


        public void sendOrder()
        {
            if(_cream && _sugar)
            {
                with = " with ";
                and = " and ";
            }
            else if (_cream || _sugar)
            {
                with = " with ";
                and = "";
            }
            else
            {
                with = "";
                and = "";
            }

            order = (size + " " + type + with + cream + and + sugar);
            coffee.Order = order;
        }

        public void typeChosen(object a, EventArgs e)
        {
            type = ($"{CoffeeSelection.SelectedValue.ToString()}");
            sendOrder();
        }

        public void addSmall(object a, EventArgs e)
        {
            size = "Small";
            sendOrder();
        }

        public void addLarge(object a, EventArgs e)
        {
            size = "Large";
            sendOrder();
        }

        public void addMedium(object a, EventArgs e)
        {
            size = "Medium";
            sendOrder();
        }

       public void addSugar(object a, EventArgs e)
        {
            if (Sugar.IsChecked == true)
            {
                sugar = "Sugar";
                _sugar = true;
                sendOrder();
            }

            else
            {
                sugar = " ";
                _sugar = false;
                sendOrder();
            }

        }

        public void addCream(object a, EventArgs e)
        {
            if (Cream.IsChecked == true)
            {
                cream = "Cream";
                _cream = true;
                sendOrder();
            }


            else
            {
                cream = " ";
                _cream = false;
                sendOrder();
            }


        }
    }

    public class coffee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //Properties
        private string order;
        public string Order
        {
            get { return order; }
            set { order = value; updateUI("Order"); }
        }

        //Constructor
        public coffee()
        {
            this.order = "Small Frappe";
        }

        //Method
        public void updateUI(string value = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(value));
        }

    }

}

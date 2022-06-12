using HCI.Controller;
using HCI.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HCI.Pages.Dialog
{
    /// <summary>
    /// Interaction logic for AddDrug.xaml
    /// </summary>
    public partial class AddDrug : Page
    {
        private DrugController _drugController;

        private string _name;
        private uint _weight;
        private string _category;
        private uint _quantity;

        public DispatcherTimer DemoTimer { get; set; } = new DispatcherTimer();

        public int Phase = 0;
        public AddDrug()
        {
            InitializeComponent();
            //this.DataContext = vm;
            var app = Application.Current as App;
            _drugController = app.DrugController;
            DataContext = this;
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public string Category
        {
            get => _category;
            set
            {
                _category = value;
            }
        }

        public uint Weight
        {
            get => _weight;
            set
            {
                _weight = value;
            }
        }

        public uint Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
            }
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if (ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string name = name_tb.Text;
            if (name == "")
            {
                MessageBoxResult result = MessageBox.Show("Name can't be empty");
                return;
            }
            uint weight = 1;
            try
            {
                weight = uint.Parse(weight_tb.Text);
            }
            catch
            {
                MessageBoxResult result = MessageBox.Show("Invalid input");
                return;
            }

            string category = category_tb.Text;
            if(category == "")
            {
                MessageBoxResult result = MessageBox.Show("Category can't be empty");
                return;
            }

            uint quantity = 1;
            try
            {
                quantity = uint.Parse(quantity_tb.Text);
            }
            catch
            {
                MessageBoxResult result = MessageBox.Show("Invalid input");
                return;
            }

            Drug drug = new Drug(name, weight, category, quantity);

            Drug new_drug = _drugController.CreateNewDrug(drug);

            var page = new Drugs();
            NavigationService.Navigate(page);
        }

        private void DemoButton_Click(object sender, RoutedEventArgs e)
        {

            DemoTimer.Interval = new TimeSpan(0, 0, 1);
            DemoTimer.Tick += new EventHandler(demoTimer_Tick);
            DemoTimer.IsEnabled = true;
            Phase = 0;
        }

        private void demoTimer_Tick(object sender, EventArgs e)
        {
            switch (Phase)
            {
                case 0:
                    name_tb.Focus();
                    Phase++;
                    break;
                case 1:
                    name_tb.Text = "xyzal";
                    Phase++;
                    break;
                case 2:
                    weight_tb.Focus();
                    Phase++;
                    break;
                case 3:
                    weight_tb.Text = 10.ToString();
                    Phase++;
                    break;
                case 4:
                    category_tb.Focus();
                    Phase++;
                    break;
                case 5:
                    category_tb.Text = "alergy";
                    Phase++;
                    break;
                case 6:
                    quantity_tb.Focus();
                    Phase++;
                    break;
                case 7:
                    quantity_tb.Text = 20.ToString();
                    Phase++;
                    break;
                case 8:
                    AddButton.Focus();
                    Phase++;
                    break;
                case 9:
                    Phase = -1;
                    var page = new Drugs();
                    NavigationService.Navigate(page);
                    break;
                default:
                    DemoTimer.IsEnabled = false;
                    Phase = 0;
                    break;
            }
        }



    }
}

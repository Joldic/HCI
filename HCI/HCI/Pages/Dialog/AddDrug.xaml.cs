using HCI.Controller;
using Model;
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

namespace HCI.Pages.Dialog
{
    /// <summary>
    /// Interaction logic for AddDrug.xaml
    /// </summary>
    public partial class AddDrug : Page
    {
        private DrugController _drugController;
        public AddDrug()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _drugController = app.DrugController;
            DataContext = this;
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
    }
}

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
    /// Interaction logic for UpdateDrug.xaml
    /// </summary>
    public partial class UpdateDrug : Page
    {
        private string _drugName;
        private string _category;
        private uint _weight;
        private uint _quantity;
        private Drug drugToUpdate;
        private DrugController _drugController;
        public UpdateDrug(Model.Drug drug)
        {
            InitializeComponent();
            var app = Application.Current as App;
            _drugController = app.DrugController;
            this.DataContext = this;
            drugToUpdate = drug;
            this._drugName = drug.Name;
            this._weight = drug.Weight;
            this._quantity = drug.Quantity;
            this._category = drug.Category;
            
        }

        public string DrugName
        {
            get => _drugName;
            set
            {
                _drugName = value;
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

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            string name = name_tb.Text;
            if(name == "")
            {
                MessageBoxResult r = MessageBox.Show("Name can not be empty");
                return;
            }
            uint weight = 1;
            try
            {
                weight = uint.Parse(weight_tb.Text);
            }
            catch
            {
                MessageBoxResult w = MessageBox.Show("Invalid input");
                return;
            }

            string category = category_tb.Text;
            if(category == "")
            {
                MessageBoxResult r = MessageBox.Show("Category can not be empty");
                return;
            }
            uint quantity = 1;
            try
            {
                weight = uint.Parse(quantity_tb.Text);
            }
            catch
            {
                MessageBoxResult w = MessageBox.Show("Invalid input");
                return;
            }

            drugToUpdate.Name = name;
            drugToUpdate.Weight = weight;
            drugToUpdate.Category = category;
            drugToUpdate.Quantity = quantity;

            _drugController.ChangeDrug(drugToUpdate);

        }
    }
}

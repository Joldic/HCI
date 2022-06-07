using HCI.Controller;
using HCI.Pages.Dialog;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace HCI.Pages
{
    /// <summary>
    /// Interaction logic for Ingredients.xaml
    /// </summary>
    public partial class Ingredients : Page
    {
        private Drug drug;
        private DrugController _drugController;
        private IngredientController _ingredientController;

        public ObservableCollection<DrugIngredientDTO> DrugIngredients { get; set; }
        public Ingredients(Drug temp)
        {
            InitializeComponent();
            var app = Application.Current as App;
            _drugController = app.DrugController;
            _ingredientController = app.IngredientController;

            DrugIngredients = new ObservableCollection<DrugIngredientDTO>(_drugController.GetDrugIngredients().ToList());


            drug = temp;

            for (int i = 0; i < DrugIngredients.Count(); i++)
            {
                if (drug.Id == DrugIngredients[i].DrugId)
                {
                    GRD.Items.Add(DrugIngredients[i]);
                }
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
            var page = new AddIngredient(drug);
            NavigationService.Navigate(page);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DrugIngredientDTO selectedItem = GRD.SelectedItem as DrugIngredientDTO;

            for (int i = 0; i < DrugIngredients.Count; i++)
            {
                if (selectedItem.Id == DrugIngredients[i].Id)
                {
                    GRD.Items.Remove(DrugIngredients[i]);
                }
            }

            //_drugController.DeleteDrugIngredient(selectedItem.Id);
        }


    }
}

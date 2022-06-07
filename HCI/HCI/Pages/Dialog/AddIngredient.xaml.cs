using HCI.Controller;
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

namespace HCI.Pages.Dialog
{
    /// <summary>
    /// Interaction logic for AddIngredient.xaml
    /// </summary>
    public partial class AddIngredient : Page
    {
        private uint id;
        Drug temp;
        public ObservableCollection<Ingredient> NameOfIngredients { get; set; }

        private DrugController _drugController;
        private IngredientController _ingredientController;
        public AddIngredient(Drug drug)
        {
            InitializeComponent();
            DataContext = this;
            id = drug.Id;

            temp = drug;

            var app = Application.Current as App;
            _drugController = app.DrugController;
            _ingredientController = app.IngredientController;

            NameOfIngredients = new ObservableCollection<Ingredient>(_ingredientController.GetAll().ToList());
            Names.ItemsSource = NameOfIngredients;
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if (ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Ingredient ingredientItem = Names.SelectedItem as Ingredient;
            if(ingredientItem == null)
            {
                MessageBoxResult result = MessageBox.Show("Please select alergen");
                return;
            }

            string ingredientName = ingredientItem.Name;
            uint ingredientId = ingredientItem.Id;

            DrugIngredientDTO newDto = new DrugIngredientDTO(id, ingredientId, ingredientName);
            DrugIngredientDTO createdDto = _drugController.AddDrugIngredient(newDto);

            var page = new Ingredients(temp);
            NavigationService.Navigate(page);
        }
    }
}

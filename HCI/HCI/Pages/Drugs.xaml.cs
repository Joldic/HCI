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
    /// Interaction logic for Drugs.xaml
    /// </summary>
    public partial class Drugs : Page
    {
        public ObservableCollection<Drug> DrugsList;
        private DrugController _drugController;
        public Drugs()
        {
            //DateTime dateTime = DateTime.Now;
            InitializeComponent();
            DataContext = this;
            var app = Application.Current as App;
            _drugController = app.DrugController;

            DrugsList = new ObservableCollection<Drug>(_drugController.GetAll().ToList());
            //GRD.Items.Add(r1);
            //GRD.Items.Add(r2);
            for (int i = 0; i < DrugsList.Count; i++)
            {
                GRD.Items.Add(DrugsList[i]);
            }
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if(ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Drug drug = GRD.SelectedItem as Drug;
            _drugController.DeleteDrug(drug.Id);

            for(int i= 0; i < DrugsList.Count; i++)
            {
                if(DrugsList[i].Id == drug.Id)
                {
                    GRD.Items.Remove(DrugsList[i]);
                }
            }
        }
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var page = new AddDrug();
            NavigationService.Navigate(page);
        }
    }
}

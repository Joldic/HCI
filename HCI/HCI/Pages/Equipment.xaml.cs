using HCI.Controller;
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
    /// Interaction logic for Equipment.xaml
    /// </summary>
    public partial class Equipment : Page
    {
        public ObservableCollection<Model.Equipment> EquipmentList { get; set; }
        private EquipmentController _equipmentController;

        public Equipment()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _equipmentController = app.EquipmentController;

            EquipmentList = new ObservableCollection<Model.Equipment>(_equipmentController.GetAll().ToList());
            for (int i = 0; i < EquipmentList.Count; i++)
            {
                GRD.Items.Add(EquipmentList[i]);
            }
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if (ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Model.Equipment equipment = GRD.SelectedItem as Model.Equipment;
            //_equipmentController.DeleteEquipment(equipment.Id);

            for (int i = 0; i < EquipmentList.Count; i++)
            {
                if (EquipmentList[i].Id == equipment.Id)
                {
                    GRD.Items.Remove(EquipmentList[i]);
                }
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

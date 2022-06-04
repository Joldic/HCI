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
        public ObservableCollection<Model.Equipment> RoomsList { get; set; }
        private EquipmentController _equipmentController;

        public Equipment()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _equipmentController = app.EquipmentController;

            RoomsList = new ObservableCollection<Model.Equipment>(_equipmentController.GetAll().ToList());
            for (int i = 0; i < RoomsList.Count; i++)
            {
                GRD.Items.Add(RoomsList[i]);
            }
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            NavigationService.Navigate(ClickedButton.NavUri);
        }
    }
}

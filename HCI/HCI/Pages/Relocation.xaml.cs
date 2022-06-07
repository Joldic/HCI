using Controller;
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

namespace HCI.Pages
{
    /// <summary>
    /// Interaction logic for Relocation.xaml
    /// </summary>
    public partial class Relocation : Page
    {
        private string name;
        private uint quantity;
        private string _name;
        private RoomControler _roomController;
        private EquipmentController _equipmentController;
        public ObservableCollection<Model.Equipment> equipment_names { get; set; }
        public ObservableCollection<Room> room_names { get; set; }
        public Relocation()
        {
            InitializeComponent();
            DataContext = this;

            var app = Application.Current as App;
            _roomController = app.RoomControler;
            _equipmentController = app.EquipmentController;

            equipment_names = new ObservableCollection<Model.Equipment>(_equipmentController.GetAll());
            room_names = new ObservableCollection<Room>(_roomController.GetAll());

            Equipment_name_combo.ItemsSource = equipment_names;
            Room_from.ItemsSource = room_names;
            Room_to.ItemsSource = room_names;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if(ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            GRD.Items.Clear();
            var eq = Equipment_name_combo.SelectedItem as Model.Equipment;
            name = eq.Name;
            quantity = uint.Parse(quantity_tb.Text);
            IList<RoomEquipmentDTO> temp = new List<RoomEquipmentDTO>();

            IEnumerable<RoomEquipmentDTO> room_equipment_list = _equipmentController.GetAllRoomAndEquipment();
            var Data = new ObservableCollection<RoomEquipmentDTO>();

            foreach (RoomEquipmentDTO room_equipment in room_equipment_list)
            {
                int result = (int)room_equipment.Quantity - (int)quantity;
                if (room_equipment.EquipmentName == name & result >= 0)
                {
                    Data.Add(room_equipment);
                    // room_equipment.Quantity -= quantity;
                }
                temp.Add(room_equipment);
            }

            for (int i = 0; i < Data.Count(); i++)
            {
                GRD.Items.Add(Data[i]);
            }
        }

    }
}

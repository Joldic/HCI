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
using System.Windows.Threading;

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

        public DispatcherTimer DemoTimer { get; set; } = new DispatcherTimer();

        public int Phase = 0;
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

        public uint Quantity
        {
            get => quantity;
            set
            {
                quantity = value;
            }
        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            Room room_from = Room_from.SelectedItem as Room;
            Room room_to = Room_to.SelectedItem as Room;

            //treba da napravim metodu koja ce da vrati iz RoomEquipment.txt RoomEquipmentDTO po id-u sobe i id ili imena equipmenta
            RoomEquipmentDTO from = _equipmentController.GetByRoomIdAndEquipmentName(room_from.Id, name);
            RoomEquipmentDTO to = _equipmentController.GetByRoomIdAndEquipmentName(room_to.Id, name);

            if (from.Quantity - quantity >= 0)
            {
                from.Quantity -= quantity;
                to.Quantity += quantity;
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Lower quantity");
                return;
            }

            // sada treba da upisem u fajl RoomEquipment.txt promene

            if (_equipmentController.SaveChangesToFile(from) & _equipmentController.SaveChangesToFile(to))
            {
                MessageBoxResult result = MessageBox.Show("Uspesno prebacivanje");
            }
            else
            {
                MessageBoxResult result = MessageBox.Show("Neuspesno prebacivanje");
            }
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if(ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }

    

        private void quantity_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            GRD.Items.Clear();
            var eq = Equipment_name_combo.SelectedItem as Model.Equipment;
            if(eq != null)
                name = eq.Name;
            try
            {
                quantity = uint.Parse(quantity_tb.Text);
            }
            catch
            {
                GRD.Items.Clear();
            }
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
            GRD.Items.Add(new RoomEquipmentDTO());
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
                    Equipment_name_combo.IsDropDownOpen = true;
                    //Equipment_name_combo.Focus();
                    Phase++;
                    break;
                case 1:
                    Equipment_name_combo.SelectedIndex = 0;
                    Phase++;
                    break;
                case 2:
                    quantity_tb.Focus();
                    Phase++;
                    break;
                case 3:
                    quantity_tb.Text = 1.ToString();
                    Phase++;
                    break;
                case 4:
                    Room_from.IsDropDownOpen = true;
                    Phase++;
                    break;
                case 5:
                    Room_from.SelectedIndex = 0;
                    Phase++;
                    break;
                case 6:
                    Room_to.IsDropDownOpen = true;
                    Phase++;
                    break;
                case 7:
                    Room_to.SelectedIndex = 1;
                    Phase++;
                    break;
                case 8:
                    Date_picker.IsDropDownOpen = true;
                   // Date_picker.Focus();
                    Phase++;
                    break;
                case 9:
                    Phase++;
                    Date_picker.Text = "10/10/2022";
                    break;
                case 10:
                    Phase++;
                    Date_picker.IsDropDownOpen = false;
                    break;
                case 11:
                    Transfer.Focus();
                    Phase = -1;
                    break;
                default:
                    DemoTimer.IsEnabled = false;
                    Phase = 0;
                    break;
            }
        }
    }
}

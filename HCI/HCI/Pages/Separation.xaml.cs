using Controller;
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
    /// Interaction logic for Separation.xaml
    /// </summary>
    public partial class Separation : Page
    {
        private RoomControler _roomController;

        public string t;
        public string t2;
        public string d;
        public string d2;
        DateTime dt;
        DateTime dt_end;
        DateTime temp;

        public ObservableCollection<Room> Rooms { get; set; }
        public Separation()
        {
            InitializeComponent();
            DataContext = this;
            var app = Application.Current as App;
            _roomController = app.RoomControler;

            Rooms = new ObservableCollection<Room>(_roomController.GetAll().ToList());
            Room_names.ItemsSource = Rooms;
        }

        private void DP1_SelectedDateChanged(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cboitem = cboTP.SelectedItem as ComboBoxItem;
            if (cboitem == null)
            {
                //MessageBoxResult result = MessageBox.Show("Select a time first");
                d = DP1.Text;
                dt = DateTime.Parse(d);
                return;
            }
            if (cboitem.Content != null)
            {
                t = cboitem.Content.ToString();
                //t2 = cboitem2.Content.ToString();
                d = DP1.Text;

                dt = DateTime.Parse(d + " " + t);
                // dt_end = DateTime.Parse(d + " " + t2);
            }

        }

        private void DP1_SelectedDateChanged_Copy(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cboitem = cboTP_Copy.SelectedItem as ComboBoxItem;
            if (cboitem == null)
            {
                //MessageBoxResult result = MessageBox.Show("Select a time first");
                d2 = DP1_Copy.Text;
                dt_end = DateTime.Parse(d2);
                return;

            }
            if (cboitem.Content != null)
            {
                t2 = cboitem.Content.ToString();
                //t2 = cboitem2.Content.ToString();
                d2 = DP1_Copy.Text;

                dt_end = DateTime.Parse(d2 + " " + t2);
                // dt_end = DateTime.Parse(d + " " + t2);
            }

        }

        private void SeparateButton_Click(object sender, RoutedEventArgs e)
        {
            if(dt == temp)
            {
                MessageBoxResult result = MessageBox.Show("Please input a date");
                return;
            }
            if (dt_end == temp)
            {
                MessageBoxResult result = MessageBox.Show("Please input a date");
                return;
            }
            if (Room_names.SelectedItem == null)
            {
                MessageBoxResult result = MessageBox.Show("Please select a room");
                return;
            }
            Room room = Room_names.SelectedItem as Room;

            if (!(DateTime.Compare(dt, dt_end) < 0))
            {
                MessageBoxResult r = MessageBox.Show("Start date must be before end date");
                return;
            }

            if (_roomController.AvailableForDeletion(room.Id))
            {
                CreateNewRooms(room);
            }
            else
            {
                ShowError();
            }
        }

        private void ShowError()
        {
            MessageBoxResult result = MessageBox.Show("Room can't be seperated because it's in use!!!");
        }

        private void CreateNewRooms(Room room)
        {

            _roomController.DeleteRoom(room.Id);

            string room1_name = room.Name + " A";
            uint room1_square_ft = room.SquareFootage / 2;
            RoomType room1_Type = room.Type;
            Room room1 = new Room(room1_name, room1_Type, room1_square_ft, true);

            string room2_name = room.Name + " B";
            uint room2_square_ft = room.SquareFootage / 2;
            RoomType room2_type = room.Type;
            Room room2 = new Room(room2_name, room2_type, room2_square_ft, true);

            _roomController.CreateNewRoom(room1);
            _roomController.CreateNewRoom(room2);

            Success();
        }

        private void Success()
        {
            MessageBoxResult result = MessageBox.Show("Seperation executed");
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if (ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }
    }
}

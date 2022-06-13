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

namespace HCI.Pages.Dialog
{
    /// <summary>
    /// Interaction logic for AddRoom.xaml
    /// </summary>
    public partial class AddRoom : Page
    {
        private RoomControler _roomController;
        public ObservableCollection<string> RoomTypes { get; set; }
        public AddRoom()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _roomController = app.RoomControler;
            this.DataContext = this;
            RoomTypes = new ObservableCollection<string>(FindRoom());
        }

        private IList<string> FindRoom()
        {
            List<string> ret_val = new List<string>();
            ret_val.Add(RoomType.operatingRoom.ToString());
            ret_val.Add(RoomType.relaxationRoom.ToString());
            ret_val.Add(RoomType.ordinaryRoom.ToString());

            return ret_val;
        }

        public RoomType FindRoom(string _room_type)
        {
            if (RoomType.operatingRoom.ToString() == _room_type)
            {
                return RoomType.operatingRoom;
            }
            else if (RoomType.relaxationRoom.ToString() == _room_type)
            {
                return RoomType.relaxationRoom;
            }
            else
            {
                return RoomType.ordinaryRoom;
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
            string room_name = name_tb.Text;
            if(room_name == "")
            {
                MessageBoxResult result1 = MessageBox.Show("Name can not be empty");
                return;
            }
            if (RoomEnum.SelectedItem == null)
            {
                MessageBoxResult result = MessageBox.Show("Select room type");
                return;
            }

            RoomType room_type = FindRoom(RoomEnum.SelectedItem.ToString());
            uint square_ft = 1;

            try
            {
                square_ft = uint.Parse(surface_tb.Text);
            }
            catch
            {
                MessageBoxResult result = MessageBox.Show("Invalid input");
                return;
            }

            Room newRoom = _roomController.CreateNewRoom(new Room(room_name, room_type, square_ft, true));
            var page = new Rooms();
            this.NavigationService.Navigate(page);
        }
    }
}

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
    /// Interaction logic for Renovation.xaml
    /// </summary>
    public partial class Renovation : Page
    {
        public ObservableCollection<Room> RoomsList { get; set; }
        public Renovation()
        {
            InitializeComponent();
            Room r1 = new Room("soba 200", RoomType.operatingRoom, 15, true);
            Room r2 = new Room("soba 300", RoomType.operatingRoom, 27, true);
            Room r3 = new Room("soba 400", RoomType.ordinaryRoom, 35, true);
            Room r4 = new Room("soba 500", RoomType.relaxationRoom, 47, true);
            RoomsList = new ObservableCollection<Room>();
            RoomsList.Add(r1);
            RoomsList.Add(r2);
            RoomsList.Add(r3);
            RoomsList.Add(r4);

            Room_names.ItemsSource = RoomsList;
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            NavigationService.Navigate(ClickedButton.NavUri);
        }
    }
}

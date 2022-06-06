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
    /// Interaction logic for Rooms.xaml
    /// </summary>
    public partial class Rooms : Page
    {
        //public List<Room> RoomsList { get; set; }
        public ObservableCollection<Room> RoomsList { get; set; }
        private RoomControler _roomController;
        public Rooms()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _roomController = app.RoomControler;

            RoomsList = new ObservableCollection<Room>(_roomController.GetAll().ToList());

            for(int i=0; i<RoomsList.Count; i++)
            {
                GRD.Items.Add(RoomsList[i]);
            }

        }


        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if (ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }
    }
}

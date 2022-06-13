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
    /// Interaction logic for Renovation.xaml
    /// </summary>
    public partial class Renovation : Page
    {
        private RoomControler _roomController;
        private RenovationController _renovationController;
        public string t;
        public string t2;
        public string d;
        public string d2;
        DateTime dt;
        DateTime dt_end;
        DateTime temp;

        public ObservableCollection<Room> Rooms { get; set; }
        public Renovation()
        {
            InitializeComponent();
            DataContext = this;
            var app = Application.Current as App;
            _roomController = app.RoomControler;
            _renovationController = app.RenovationController;

            Rooms = new ObservableCollection<Room>(_roomController.GetAll().ToList());
            Room_names.ItemsSource = Rooms;
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if(ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void DP1_SelectedDateChanged(object sender, RoutedEventArgs e)
        {
            ComboBoxItem cboitem = cboTP.SelectedItem as ComboBoxItem;
            if(cboitem ==  null)
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

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if(dt == temp)
            {
                MessageBoxResult d1 = MessageBox.Show("Please enter date");
                return;
            }
            if(dt_end == temp)
            {
                MessageBoxResult d2 = MessageBox.Show("Please enter date");
                return;
            }
            Room roomItem = Room_names.SelectedItem as Room;
            if(roomItem == null)
            {
                MessageBoxResult r = MessageBox.Show("Select room");
                return;
            }
            DateTime date_begin = dt;
            DateTime date_end = dt_end;

            RoomRenovationDTO dto = new RoomRenovationDTO(roomItem.Id, date_begin, date_end);

            if (_renovationController.AddRenovation(dto) == null)
            {
                MessageBoxResult re = MessageBox.Show("End date is before start date enter again");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Uspesno zakazano renoviranje");
        }
    }
}

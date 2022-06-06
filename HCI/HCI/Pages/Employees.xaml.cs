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
    /// Interaction logic for Employees.xaml
    /// </summary>
    public partial class Employees : Page
    {
        public ObservableCollection<User> UsersList;
        private UserController _userController;
        public Employees()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _userController = app.UserController;
            UsersList = new ObservableCollection<User>(_userController.GetAll().ToList());

            for (int i = 0; i < UsersList.Count; i++)
            {
                GRD.Items.Add(UsersList[i]);
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
            User user = GRD.SelectedItem as User;
            //_userController.DeleteUser(user.Id);

            for (int i = 0; i < UsersList.Count; i++)
            {
                if (UsersList[i].Id == user.Id)
                {
                    GRD.Items.Remove(UsersList[i]);
                }
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
          
        }

    }
}

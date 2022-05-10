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
        public Employees()
        {
            InitializeComponent();
            User u1 = new User("Nenad", "Joldic", UserType.Manager);
            User u2 = new User("Dunja", "Bogdanovic", UserType.Secretary);
            User u3 = new User("Luka", "Lucic", UserType.Doctor);
            User u4 = new User("Stevan", "Milicic", UserType.Doctor);
            User u5 = new User("Marko", "Djurdjevic", UserType.Secretary);

            UsersList = new ObservableCollection<User>();
            UsersList.Add(u1);
            UsersList.Add(u2);
            UsersList.Add(u3);
            UsersList.Add(u4);

            GRD.Items.Add(u1);
            GRD.Items.Add(u2);
            GRD.Items.Add(u3);
            GRD.Items.Add(u4);
            GRD.Items.Add(u5);
        }
    }
}

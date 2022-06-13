using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using HCI.Controller;
using HCI.Pages;
using MaterialDesignThemes.Wpf;

namespace HCI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserController _userController;
        private string _password;
        private string _username;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            var app = Application.Current as App;
            _userController = app.UserController;
        }

        public bool isDarkTheme { get; set; }
        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            ITheme theme = paletteHelper.GetTheme();

            if(isDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                isDarkTheme = false;
                theme.SetBaseTheme(Theme.Light);
            }
            else
            {
                isDarkTheme = true;
                theme.SetBaseTheme(Theme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }
        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Model.User user = _userController.FindUserByUsername(Username);
            
            if (user == null)
            {
                MessageBoxResult result = MessageBox.Show("Username " + Username + " doesn't exist");
                return;
            }
            if (!(String.Compare(user.Password, txtPassword.Password) == 0))
            {
                MessageBoxResult result = MessageBox.Show("Invalid password");
                return;
            }

            NavigationWindow window = new NavigationWindow();
            window.Source = new Uri("/Pages/Landing.xaml", UriKind.Relative);
            window.Height = 750;
            window.Width = 430;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();

            this.Close();

            //this.Visibility = Visibility.Hidden;


        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

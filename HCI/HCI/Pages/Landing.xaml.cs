using System;
using System.Collections.Generic;
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
    /// Interaction logic for Landing.xaml
    /// </summary>
    public partial class Landing : Page
    {
        public Landing()
        {
            InitializeComponent();
            DataContext = this;
            
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            //var ClickedButton = e.OriginalSource as NavButton;
            //NavigationService.Navigate(ClickedButton.NavUri);
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Show();
            this.Visibility = Visibility.Hidden;
        }
    }
}

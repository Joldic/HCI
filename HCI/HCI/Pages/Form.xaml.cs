using Model;
using projekat.Controller;
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
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : Page
    {
        private FormController _formController;

        public ObservableCollection<FormHospitalDTO> Data { get; set; }
        public Form()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _formController = app.FormController;

            Data = new ObservableCollection<FormHospitalDTO>(_formController.GetAllHospitalForms().ToList());
            //DataGridXAML.ItemsSource = Data;
            for (int i = 0; i < Data.Count; i++)
            {
                DataGridXAML.Items.Add(Data[i]);
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

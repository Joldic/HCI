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

namespace HCI.Pages.Dialog
{
    /// <summary>
    /// Interaction logic for UpdateEquipment.xaml
    /// </summary>
    public partial class UpdateEquipment : Page
    {
        private string _name;
        private uint _quantity;
        
        public ObservableCollection<string> EquipmentTypes { get; set; }
        private Model.Equipment equipmentToUpdate;
        private EquipmentController _equipmentController;
        public UpdateEquipment(Model.Equipment equipment)
        {
            InitializeComponent();
            var app = Application.Current as App;
            _equipmentController = app.EquipmentController;
            this.DataContext = this;
            equipmentToUpdate = equipment;
            this._name = equipment.Name;
            this._quantity = equipment.Quantity;
            TypeEnum.SelectedItem = equipment.Type.ToString();

            EquipmentTypes = new ObservableCollection<string>(FindEquipment());
        }
        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            var ClickedButton = e.OriginalSource as NavButton;
            if (ClickedButton != null)
                NavigationService.Navigate(ClickedButton.NavUri);
        }
        public string EqName
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public uint Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
            }
        }
        private IList<string> FindEquipment()
        {
            List<string> ret_val = new List<string>();
            ret_val.Add(EquipmentType.DYNAMIC.ToString());
            ret_val.Add(EquipmentType.STATIC.ToString());

            return ret_val;
        }
        public EquipmentType FindEquipment(string _room_type)
        {
            if (EquipmentType.DYNAMIC.ToString() == _room_type)
            {
                return EquipmentType.DYNAMIC;
            }
            else
            {
                return EquipmentType.STATIC;
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            string name = name_tb.Text;
            if(name == "")
            {
                MessageBoxResult r = MessageBox.Show("Name can not be empty");
                return;
            }
            if(TypeEnum.SelectedItem == null)
            {
                MessageBoxResult t = MessageBox.Show("Select equipment type");
                return;
            }
            EquipmentType type = FindEquipment(TypeEnum.SelectedItem.ToString());
            uint quantity = 0;
            try
            {
                quantity = uint.Parse(quantity_tb.Text);
            }
            catch
            {
                MessageBoxResult result = MessageBox.Show("Invalid input");
                return;
            }

            equipmentToUpdate.Name = name;
            equipmentToUpdate.Quantity = quantity;
            equipmentToUpdate.Type = type;

            _equipmentController.UpdateEquipment(equipmentToUpdate);
            var page = new Equipment();
            NavigationService.Navigate(page);
        }
    }
}

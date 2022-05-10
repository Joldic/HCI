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
    /// Interaction logic for Equipment.xaml
    /// </summary>
    public partial class Equipment : Page
    {
        public ObservableCollection<Model.Equipment> RoomsList { get; set; }

        public Equipment()
        {
            InitializeComponent();
            Model.Equipment r1 = new Model.Equipment(10, "skalpel", Model.EquipmentType.DYNAMIC);
            Model.Equipment r2 = new Model.Equipment(5, "bed", Model.EquipmentType.STATIC);
            Model.Equipment r3 = new Model.Equipment(8, "spric", Model.EquipmentType.DYNAMIC);
            Model.Equipment r4 = new Model.Equipment(2, "rendgen", Model.EquipmentType.STATIC);
            Model.Equipment r5 = new Model.Equipment(7, "gaza", Model.EquipmentType.DYNAMIC);
            RoomsList = new ObservableCollection<Model.Equipment>();
            RoomsList.Add(r1);
            RoomsList.Add(r2);
            RoomsList.Add(r3);
            RoomsList.Add(r4);
            RoomsList.Add(r5);

            //GRD.Items.Add(r1);
            //GRD.Items.Add(r2);
            for (int i = 0; i < RoomsList.Count; i++)
            {
                GRD.Items.Add(RoomsList[i]);
            }
        }
    }
}

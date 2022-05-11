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
    /// Interaction logic for Drugs.xaml
    /// </summary>
    public partial class Drugs : Page
    {
        public ObservableCollection<Drug> DrugsList;
        public Drugs()
        {
            DateTime dateTime = DateTime.Now;
            InitializeComponent();
            Drug r1 = new Drug("bromazepam", "nervs", 15, dateTime);
            Drug r2 = new Drug("klonazepam", "nervs", 10, dateTime);
            Drug r3 = new Drug("probiotik", "stomach", 5, dateTime);
            Drug r4 = new Drug("canesten", "bacteries", 88, dateTime);
            Drug r5 = new Drug("zync", "supplement", 99, dateTime);
            DrugsList = new ObservableCollection<Drug>();
            DrugsList.Add(r1);
            DrugsList.Add(r2);
            DrugsList.Add(r3);
            DrugsList.Add(r4);
            DrugsList.Add(r5);


            //GRD.Items.Add(r1);
            //GRD.Items.Add(r2);
            for (int i = 0; i < DrugsList.Count; i++)
            {
                GRD.Items.Add(DrugsList[i]);
            }
        }
    }
}

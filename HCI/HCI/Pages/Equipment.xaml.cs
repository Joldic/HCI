using HCI.Controller;
using HCI.Pages.Dialog;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
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
        public ObservableCollection<Model.Equipment> EquipmentList { get; set; }
        private EquipmentController _equipmentController;

        private static string _projectPath = System.Reflection.Assembly.GetExecutingAssembly().Location
          .Split(new string[] { "bin" }, StringSplitOptions.None)[0];
        private string REPORT_FILE = _projectPath + "\\Reports\\Report.pdf";

        public Equipment()
        {
            InitializeComponent();
            var app = Application.Current as App;
            _equipmentController = app.EquipmentController;

            EquipmentList = new ObservableCollection<Model.Equipment>(_equipmentController.GetAll().ToList());
 

            GRD.ItemsSource = EquipmentList;

            //FilterBy.ItemsSource = typeof(Model.Equipment).GetProperties().Select((o) => o.Name);

            GRD.Items.Filter = NameFilter;

        }

        public Predicate<object> GetFilter()
        {
            return NameFilter;
        }
   
        private bool NameFilter(object obj)
        {
            var FilterObj = obj as Model.Equipment;

            return FilterObj.Name.Contains(FilterTextbox.Text);
        }

        private void FilterTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(FilterTextbox.Text == null)
            {
                GRD.Items.Filter = null;
            }
            else
            {
                GRD.Items.Filter = GetFilter();
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
            Model.Equipment equipment = GRD.SelectedItem as Model.Equipment;
            //_equipmentController.DeleteEquipment(equipment.Id);

            for (int i = 0; i < EquipmentList.Count; i++)
            {
                if (EquipmentList[i].Id == equipment.Id)
                {
                    GRD.Items.Remove(EquipmentList[i]);
                }
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            Model.Equipment equipment = GRD.SelectedItem as Model.Equipment;
            var page = new UpdateEquipment(equipment);
            this.NavigationService.Navigate(page); ;
        }
        public void SendMessage()
        {
            MessageBox.Show("Report is successfully created!");
        }

        private void ReportButton_Click(object sender, RoutedEventArgs e)
        {
            GeneratePDF();
            SendMessage();
        }

        public void GeneratePDF()
        {
            using (PdfDocument doc = new PdfDocument())
            {
                PdfPage page = doc.Pages.Add();
                PdfGraphics graphics = page.Graphics;
                PdfFont font1 =  new PdfStandardFont(PdfFontFamily.Helvetica, 20);
                PdfFont font2 =  new PdfStandardFont(PdfFontFamily.Helvetica, 15);
                string header = "Hospital";
                graphics.DrawString(header, font1, PdfBrushes.Black,new PointF(200, 0 ));
                string textPDF = "Info about equipment";
                graphics.DrawString(textPDF, font2, PdfBrushes.Black, new PointF(200, 75));
                PdfLightTable pdfTable = new PdfLightTable();
                DataTable table = new DataTable();
                table.Columns.Add("Naziv opreme");
                table.Columns.Add("Kolicina");
                table.Columns.Add("Tip");
                foreach(Model.Equipment equipment in EquipmentList)
                {
                    table.Rows.Add(new string[] { equipment.Name, equipment.Quantity.ToString(), equipment.Type.ToString() });
                }
                pdfTable.DataSource = table;
                pdfTable.Style.ShowHeader = true;


                pdfTable.Draw(page, new PointF(0, 100));

                doc.Save(@"C:\\Users\\joldi\\Desktop\\HCI\\HCI\\HCI\\HCI\\Reports\\Report.pdf");

                string filename = @"C:\\Users\\joldi\\Desktop\\HCI\\HCI\\HCI\\HCI\\Reports\\Report.pdf";
                System.Diagnostics.Process.Start(filename);
                doc.Close(true);



            }
        }

    
    }
}

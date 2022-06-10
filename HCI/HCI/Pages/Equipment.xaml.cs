using HCI.Controller;
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
            for (int i = 0; i < EquipmentList.Count; i++)
            {
                GRD.Items.Add(EquipmentList[i]);
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
                //PdfImage image = PdfImage.FromFile(@"..\..\..\heart.jpg");
                //graphics.DrawImage(image, 165, 0);
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

                //doc.Save(_projectPath + REPORT_FILE);
                pdfTable.Draw(page, new PointF(0, 100));
                //doc.Save("ViewerPreference.pdf");
                doc.Save(@"C:\\Users\\joldi\\Desktop\\HCI\\HCI\\HCI\\HCI\\Reports\\Report.pdf");
                doc.Close(true);

                //Launching the Pdf file.
                //("ViewerPreference.pdf");
                //doc.Close(true);
                //PdfLightTable pdfLightTable = new PdfLightTable;
                //DataTable table = new DataTable();
                //table.Columns.Add("Date");
                //table.Columns.Add("Room Name");
                //table.Columns.Add("Doctor");
                //List<Occupation> occupations = FindAllOccupationsByDate(dateTime);
                //foreach (Occupation o in occupations)
                //{
                //    table.Rows.Add(new string[] { o.}
                //}
                //PdfLightTable.DataSource = table;
                //PdfLightTable.Style.ShowHeader = true;


            }
        }
    }
}

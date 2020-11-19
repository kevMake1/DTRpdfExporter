using DTR.Model;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DTR.View
{
    /// <summary>
    /// Interaction logic for DisplayShipperAndCosigneeView.xaml
    /// </summary>
    /// 
    
    public partial class DisplayShipperAndCosigneeView : Window
    {
        
        public DisplayShipperAndCosigneeView()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;


            ReadShipperDatabase();
            //ReadCosigneeDatabase();
        }

        void ReadShipperDatabase()
        {
            //string databaseName = "Shipper.db";
            //string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            //string databasePath = System.IO.Path.Combine(folderPath, databaseName);

            //List<Shipper> shippers;

            //using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(databasePath))
            //{
            //  conn.CreateTable<Shipper>();
            //shippers = conn.Table<Shipper>().ToList();
            //}

            //if(shippers != null)
            //{
            //  ShipperView.ItemsSource = shippers;
            //}

            Companies companies = new Companies();
            List<Shipper> shippers = companies.shippers1;
        }

        void ReadCosigneeDatabase()
        {
            //string databaseName = "Cosignee.db";
            //string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            //string databasePath = System.IO.Path.Combine(folderPath, databaseName);

            //List<Cosignee> cosignees;

            //using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(databasePath))
            //{
              //  conn.CreateTable<Cosignee>();
              //  cosignees = conn.Table<Cosignee>().ToList();
            //}

            //if (cosignees != null)
            //{
              //  CosigneeView.ItemsSource = cosignees;
            //}
        }

        private void Shipper_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Shipper selectedShipper = (Shipper)ShipperView.SelectedItem;

            if(selectedShipper != null)
            {
                DetailView shipperDetailView = new DetailView(selectedShipper);
                shipperDetailView.ShowDialog();
                
                DisplayShipperAndCosigneeView newWindow = new DisplayShipperAndCosigneeView();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
                Close();
            }
        }

        private void CosigneeView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cosignee selectedCosignee = (Cosignee)CosigneeView.SelectedItem;

            if (selectedCosignee != null)
            {
                DetailView2 cosigneeDetailView = new DetailView2(selectedCosignee);
                cosigneeDetailView.ShowDialog();

                DisplayShipperAndCosigneeView newWindow = new DisplayShipperAndCosigneeView();
                Application.Current.MainWindow = newWindow;
                newWindow.Show();
                Close();
            }
        }
    }
}

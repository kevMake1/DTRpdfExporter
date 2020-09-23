using DTR.Model;
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
using System.Windows.Shapes;

namespace DTR.View
{
    /// <summary>
    /// Interaction logic for DetailView.xaml
    /// </summary>
    public partial class DetailView : Window
    {
        Shipper selectedShipper;
        public DetailView(Shipper shipper)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            this.selectedShipper = shipper;
            infoBox.Text = shipper.ShipperInfo;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            string databaseName = "Shipper.db";
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = System.IO.Path.Combine(folderPath, databaseName);


            Close();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            string databaseName = "Shipper.db";
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = System.IO.Path.Combine(folderPath, databaseName);


            Close();
        }
    }
}

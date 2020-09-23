using DTR.Model;
using DTR.ViewModel;
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
    /// Interaction logic for DTRInternationalView.xaml
    /// </summary>
    public partial class DTRInternationalView : Window
    {
        List<Shipper> shippers;
        List<Cosignee> cosignees;

        public DTRInternationalView()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            shippers = new List<Shipper>();
            cosignees = new List<Cosignee>();
            

        }

        private void ShipperTextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            
            
        }

        void ReadShipperDatabase()
        {
            string databaseName = "Shipper.db";
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = System.IO.Path.Combine(folderPath, databaseName);


        }
        void ReadCosigneeDatabase()
        {
            string databaseName = "Cosignee.db";
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = System.IO.Path.Combine(folderPath, databaseName);

            

        }

        private void ShipperView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void ShipperTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

        private void CosigneeView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void CosigneeTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void popup_Closed(object sender, EventArgs e)
        {
            ShipperView.ItemsSource = null;
        }

        private void popup2_Closed(object sender, EventArgs e)
        {
            CosigneeView.ItemsSource = null;
        }


        private void AddShipperButton_Click(object sender, RoutedEventArgs e)
        {
            AddShipeprView addShipperView = new AddShipeprView();
            addShipperView.ShowDialog();

            Reset();
        }

        private void AddCosigneeButton_Click(object sender, RoutedEventArgs e)
        {
            AddCosigneeView addCosigneeView = new AddCosigneeView();
            addCosigneeView.ShowDialog();
            Reset();
        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayShipperAndCosigneeView SCView = new DisplayShipperAndCosigneeView();
            SCView.ShowDialog();
            Reset();
        }

        private void Reset()
        {
            DTRInternationalView newWindow = new DTRInternationalView();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            Close();
        }
    }
}

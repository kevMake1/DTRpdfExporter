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
    /// Interaction logic for DetailView2.xaml
    /// </summary>
    public partial class DetailView2 : Window
    {
        Cosignee selectedCosignee;
        public DetailView2(Cosignee cosignee)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            this.selectedCosignee = cosignee;
            infoBox.Text = cosignee.CosigneeInfo;
        }


        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            string databaseName = "Cosignee.db";
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = System.IO.Path.Combine(folderPath, databaseName);


            Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            string databaseName = "Cosignee.db";
            string folderPath = AppDomain.CurrentDomain.BaseDirectory;
            string databasePath = System.IO.Path.Combine(folderPath, databaseName);

            Close();
        }
    }
}

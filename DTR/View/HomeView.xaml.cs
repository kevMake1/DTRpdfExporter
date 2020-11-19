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
    /// Interaction logic for HomeView.xaml
    /// </summary>
    public partial class HomeView : Window
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void DTRButton_Click(object sender, RoutedEventArgs e)
        {
            DTRInternationalView DTRView = new DTRInternationalView();
            DTRView.Show();
        }

        private void BillOfLandingButton_Click(object sender, RoutedEventArgs e)
        {
            BillOfLandingView BillOfLanding = new BillOfLandingView();
            BillOfLanding.Show();
        }
    }
}

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
    /// Interaction logic for DisplayShipperAndCosigneeView.xaml
    /// </summary>
    public partial class DisplayShipperAndCosigneeView : Window
    {
        public DisplayShipperAndCosigneeView()
        {
            InitializeComponent();

            List<Shipper> test = new List<Shipper>();
            test.Add(new Shipper() { Id = 2, ShipperInfo = "blah blah" });
            test.Add(new Shipper() { Id = 2, ShipperInfo = "blah blahljfadjf akl\nfjdlskfjlkfja\ndjaflkfjkdsfjl" });
            test.Add(new Shipper() { Id = 2, ShipperInfo = "blah blah" });
            test.Add(new Shipper() { Id = 2, ShipperInfo = "blah blah" });

            Test.ItemsSource = test;
        }
    }
}

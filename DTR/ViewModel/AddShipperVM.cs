using DTR.Model;
using DTR.ViewModel.Commands;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace DTR.ViewModel
{
    public class AddShipperVM : INotifyPropertyChanged
    {
        //Property changed boiler -------------------------------------------------------------------------
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Constructor
        public AddCommand addCommand { get; set; }

        public AddShipperVM()
        {
            addCommand = new AddCommand(this);

        }

        private string shipperContent;

        public string ShipperContent
        {
            get { return shipperContent; }
            set { shipperContent = value; OnPropertyChanged("ShipperContent"); }
        }

        public void AddShipper()
        {
            
            if(ShipperContent != null)
            {
                Shipper shipper = new Shipper()
                {
                    ShipperInfo = ShipperContent
                };

                //Save to dataBase
                string databaseName = "Shipper.db";
                string folderPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                string databasePath = System.IO.Path.Combine(folderPath, databaseName);

                using (SQLiteConnection connection = new SQLiteConnection(databasePath))
                {
                    connection.CreateTable<Shipper>();
                    connection.Insert(shipper);
                }

                
                
            }
            
        }


    }

    
}

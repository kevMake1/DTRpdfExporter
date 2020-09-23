using DTR.Model;
using DTR.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTR.ViewModel
{
    public class AddCosigneeVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public AddCosigneeCommand addCosigneeCommand { get; set; }

        public AddCosigneeVM()
        {
            addCosigneeCommand = new AddCosigneeCommand(this);

        }

        private string cosigneeContent;

        public string CosigneeContent
        {
            get { return cosigneeContent; }
            set { cosigneeContent = value; OnPropertyChanged("CosigneeContent"); }
        }

        public void AddCosignee()
        {

            if (CosigneeContent != null)
            {
                Cosignee cosignee = new Cosignee()
                {
                    CosigneeInfo = CosigneeContent
                };

                //Save to dataBase
                string databaseName = "Cosignee.db";
                string folderPath = AppDomain.CurrentDomain.BaseDirectory;
                string databasePath = System.IO.Path.Combine(folderPath, databaseName);



            }

        }
    }
}

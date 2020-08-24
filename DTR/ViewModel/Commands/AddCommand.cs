using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DTR.ViewModel.Commands
{
    public class AddCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public AddShipperVM addShipperVM {get; set;}

        public AddCommand(AddShipperVM vm)
        {
            addShipperVM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            addShipperVM.AddShipper();
        }
    }
}

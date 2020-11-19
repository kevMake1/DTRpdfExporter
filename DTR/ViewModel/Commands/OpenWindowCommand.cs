using DTR.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DTR.ViewModel.Commands
{
    public class OpenWindowCommand : ICommand
    {
        private BillOfLandingVM billOfLandingVM;

        public event EventHandler CanExecuteChanged;

        public DTRInternationalVM DTRvm{ get; set; }
        public AddShipeprView addShipperView { get; set; }

        public OpenWindowCommand(DTRInternationalVM vm)
        {
            DTRvm = vm;
        }

        public OpenWindowCommand(BillOfLandingVM billOfLandingVM)
        {
            this.billOfLandingVM = billOfLandingVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            addShipperView = new AddShipeprView();
            DTRvm.OpenWindow(addShipperView);
        }
    }
}

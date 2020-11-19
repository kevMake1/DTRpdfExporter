using DTR.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DTR.ViewModel.Commands
{
    public class ShowAllCommand : ICommand
    {
        private BillOfLandingVM billOfLandingVM;

        public event EventHandler CanExecuteChanged;

        DTRInternationalVM DTRvm { get; set; }
        DisplayShipperAndCosigneeView view { set; get; }

        public ShowAllCommand(DTRInternationalVM vm)
        {
            DTRvm = vm;
        }

        public ShowAllCommand(BillOfLandingVM billOfLandingVM)
        {
            this.billOfLandingVM = billOfLandingVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            view = new DisplayShipperAndCosigneeView();
            DTRvm.OpenWindow(view);
        }
    }
}

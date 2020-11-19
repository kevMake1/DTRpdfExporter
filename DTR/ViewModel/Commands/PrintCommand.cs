using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DTR.ViewModel.Commands
{
    public class PrintCommand : ICommand
    {
        private BillOfLandingVM billOfLandingVM;

        public event EventHandler CanExecuteChanged;
        public DTRInternationalVM VM { get; set; }

        public PrintCommand(DTRInternationalVM vm)
        {
            VM = vm;
        }

        public PrintCommand(BillOfLandingVM billOfLandingVM)
        {
            this.billOfLandingVM = billOfLandingVM;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.PrintToConsole();
        }
    }
}

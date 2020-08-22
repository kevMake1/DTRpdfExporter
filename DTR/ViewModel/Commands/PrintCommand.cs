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
        public event EventHandler CanExecuteChanged;
        public DTRInternationalVM VM { get; set; }

        public PrintCommand(DTRInternationalVM vm)
        {
            VM = vm;
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

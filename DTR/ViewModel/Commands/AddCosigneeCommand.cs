using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DTR.ViewModel.Commands
{
    public class AddCosigneeCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public AddCosigneeVM addCosigneeVM { get; set; }

        public AddCosigneeCommand(AddCosigneeVM vm)
        {
            addCosigneeVM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            addCosigneeVM.AddCosignee();
        }
    }
}

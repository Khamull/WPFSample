using System.Windows.Input;

namespace WPFUI.Core
{
    internal class RelayCommandBase
    {

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
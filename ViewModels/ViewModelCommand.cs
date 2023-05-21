using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PasswordManager.ViewModels
{
    public class ViewModelCommand : ICommand
    {
        private readonly Action<Object> _executeAction;
        private readonly Predicate<Object>? _canExecuteAction;

        public ViewModelCommand (Action<object> executeAction)
        {
            _canExecuteAction = null;
            _executeAction = executeAction;
        }

        public ViewModelCommand(Action<object> executeAction, Predicate<object> canExecuteAction)
        {
            _canExecuteAction = canExecuteAction;
            _executeAction = executeAction;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteAction == null ? true : _canExecuteAction(parameter);
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }
    }
}

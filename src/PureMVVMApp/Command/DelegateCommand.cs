using System;
using System.Windows.Input;

namespace WpfApp1.Command
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Func<object, bool> _canExecuteAction;

        public DelegateCommand(Action<object> executeAction, Func<object, bool> canExecuteAction)
        {
            _executeAction = executeAction;
            _canExecuteAction = canExecuteAction;
        }

        public void Execute(object parameter) => _executeAction(parameter);

        public bool CanExecute(object parameter) => _canExecuteAction?.Invoke(parameter) ?? true;

        //public void InvokeCanExecuteChanged()
        //{
        //    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        //}

        //https://stackoverflow.com/questions/4531360/what-is-canexecutechanged-for
        public event EventHandler CanExecuteChanged;
        /*{
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }*/
    }
}

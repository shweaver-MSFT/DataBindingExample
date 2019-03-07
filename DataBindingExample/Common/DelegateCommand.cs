using System;
using System.Windows.Input;

namespace DataBindingExample.Common
{
    public class DelegateCommand<T> : ICommand
    {
        private readonly Action<T> _action;
        private readonly Func<T, bool> _canExecute;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<T> action, Func<T, bool> canExecute = null)
        {
            _action = action;
            _canExecute = canExecute ?? ((x) => { return true; });
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool CanExecute(T parameter)
        {
            return _canExecute(parameter);
        }

        public void Execute(T parameter)
        {
            _action(parameter);
        }

        public bool CanExecute(object parameter) => CanExecute((T)parameter);
        public void Execute(object parameter) => Execute((T)parameter);
    }
}

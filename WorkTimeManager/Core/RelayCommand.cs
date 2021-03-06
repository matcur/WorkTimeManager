using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WorkTimeManager.Core
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        
        private readonly Action<object> execute;
        
        private readonly Predicate<object> canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
        {
            if (execute == null)
                throw new ArgumentNullException("Execute can not be null");

            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            execute.Invoke(parameter);
        }
    }
}

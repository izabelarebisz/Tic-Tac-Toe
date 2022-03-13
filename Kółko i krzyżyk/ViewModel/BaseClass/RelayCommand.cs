﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kółko_i_krzyżyk.ViewModel.BaseClass
{
    class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged 
        {
            add {
                if (canExecute != null) CommandManager.RequerySuggested += value; 
            }
            remove {
                if (canExecute != null) CommandManager.RequerySuggested -= value;
            }
        }

        private Action<object> execute;
        private Predicate<object> canExecute;

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }


        public bool CanExecute(object parameter)
        {

            return canExecute==null ? true: canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public static implicit operator char(RelayCommand v)
        {
            throw new NotImplementedException();
        }
    }
}

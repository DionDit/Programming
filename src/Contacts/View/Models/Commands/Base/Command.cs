using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace View.Models.Commands.Base
{
    /// <summary>
    /// Базовый класс для команд.
    /// </summary>
    public abstract class Command : ICommand
    {
        /// <summary>
        /// Событие уведомления об изменении возможности выполнения команды.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        /// Выполнение команды с условием.
        /// </summary>
        public abstract bool CanExecute(object parameter);

        /// <summary>
        /// Выполняет команду.
        /// </summary>
        public abstract void Execute(object parameter);
    }
}
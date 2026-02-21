using System;
using System.Collections.Generic;
using System.Text;
using View.Models.Commands.Base;

namespace View.Models.Commands
{
    public class DelegateCommand : Command
    {
        /// <summary>
        /// Делегат, содержащий логику выполнения команды.
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// Делегат, определяющий возможность выполнения команды.
        /// </summary>
        private readonly Func<object, bool> _canExecute;

        /// <summary>
        /// Конструктор класса <see cref="DelegateCommand"./>
        /// </summary>
        public DelegateCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _execute = Execute;
            _canExecute = CanExecute;
        }

        /// <summary>
        /// Выполнение команды.
        /// </summary>
        public override void Execute(object parameter) => _execute?.Invoke(parameter);

        /// <summary>
        /// Выполнение команды с условием.
        /// </summary>
        public override bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;
    }
}
using Microsoft.Win32;
using System.Windows;
using ViewModel.Interfaces;

namespace View.Services
{
    /// <summary>
    /// Реализация сервиса диалогов для WPF.
    /// Предоставляет методы для показа сообщений и диалогов выбора файлов.
    /// </summary>
    public class DialogService : IDialogService
    {
        /// <summary>
        /// Показывает информационное сообщение.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="title">Заголовок окна сообщения.</param>
        public void ShowMessage(string message, string title = "Информация")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Показывает сообщение об ошибке.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="title">Заголовок окна сообщения.</param>
        public void ShowError(string message, string title = "Ошибка")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Показывает предупреждение.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        /// <param name="title">Заголовок окна сообщения.</param>
        public void ShowWarning(string message, string title = "Предупреждение")
        {
            MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        /// <summary>
        /// Открывает диалог выбора файла.
        /// </summary>
        /// <param name="filter">Фильтр типов файлов.</param>
        /// <param name="title">Заголовок диалогового окна.</param>
        /// <returns>Путь к выбранному файлу или null, если выбор отменён.</returns>
        public string? OpenFileDialog(string filter, string title)
        {
            var dialog = new OpenFileDialog
            {
                Filter = filter,
                Title = title
            };

            return dialog.ShowDialog() == true ? dialog.FileName : null;
        }
    }
}